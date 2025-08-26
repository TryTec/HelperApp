using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Windows.Forms;
using Zen.Barcode;

namespace HelperApp
{
    public partial class FrmGenerateQRCode : Form
    {
        private DataTable dt;
        private readonly int qrCodeHeight = 35;
        private readonly int qrCodeWidth = 35;

        public FrmGenerateQRCode()
        {
            InitializeComponent();
            ConfigDataGridView();
        }

        private void BtnUploadFileExcel_Click(object sender, EventArgs e)
        {
            UploadFileExcel();
        }

        private void UploadFileExcel()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "ជ្រើសរើសឯកសារ Excel";
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dt = new DataTable();
                dt.Columns.Add("Name");
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(openFileDialog.FileName, false))
                {
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                    foreach (Row r in sheetData.Elements<Row>())
                    {
                        DataRow dr = dt.NewRow();
                        foreach (Cell c in r.Elements<Cell>())
                        {
                            if (c.DataType != null && c.DataType == CellValues.SharedString)
                            {
                                int ssid = int.Parse(c.CellValue.Text);
                                string str = workbookPart.SharedStringTablePart.SharedStringTable.Elements<SharedStringItem>().ElementAt(ssid).InnerText;
                                dr["Name"] = str;
                            }
                            else
                            {
                                dr[c.CellReference] = c.CellValue.Text;
                            }
                        }
                        dt.Rows.Add(dr);
                    }
                }
                DgvExcel.DataSource = dt;
            }
        }

        private void ConfigDataGridView()
        {
            if (DgvExcel.Columns.Count == 0)
            {
                DgvExcel.AutoGenerateColumns = false;
                DataGridViewColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = "ទិន្នន័យ";
                column.Name = "colName";
                column.DataPropertyName = "Name";
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                DgvExcel.Columns.Add(column);
            }
        }

        private void RbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (RbManual.Checked)
            {
                TxtText.Enabled = true;
                BtnUploadFileExcel.Enabled = false;
                PicLogo.Visible = true;
                BtnSaveQRCode.Enabled = false;
                PicQRCode.BorderStyle = BorderStyle.FixedSingle;
                DgvExcel.DataSource = null;
                ConfigDataGridView();
                DgvExcel.Enabled = false;
                TxtText.Focus();
            }
        }

        private void RbMultiple_CheckedChanged(object sender, EventArgs e)
        {
            if (RbMultiple.Checked)
            {
                TxtText.Enabled = false;
                BtnUploadFileExcel.Enabled = true;
                BtnSaveQRCode.Enabled = false;
                PicQRCode.BorderStyle = BorderStyle.FixedSingle;
                PicLogo.Visible = true;
                TxtText.Text = string.Empty;
                PicQRCode.Image = null;
                DgvExcel.Enabled = true;
            }
        }

        private void TsmiChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "ជ្រើសរើសរូបភាព";
            openFileDialog.Filter = "ប្រភេទរូបភាព|*.jpg;*.jpeg;*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                PicLogo.ImageLocation = openFileDialog.FileName;
                PicLogo.BorderStyle = BorderStyle.None;
            }
        }

        private void TsmiRemoveImage_Click(object sender, EventArgs e)
        {
            PicLogo.ImageLocation = null;
            PicLogo.BorderStyle = BorderStyle.FixedSingle;
        }

        private bool ValidateText()
        {
            if (string.IsNullOrEmpty(TxtText.Text))
            {
                MessageBox.Show("ឯកសារមិនអាចទទេបានទេ!", "ទិន្នន័យមិនគ្រប់គ្រាន់", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool ValidateFileExcel()
        {
            if (DgvExcel.Rows.Count < 1)
            {
                MessageBox.Show("ទិន្នន័យមិនអាចទទេបានទេ!", "ទិន្នន័យមិនគ្រប់គ្រាន់", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void BtnGenerateQRCode_Click(object sender, EventArgs e)
        {
            if (RbManual.Checked)
            {
                if (!ValidateText())
                {
                    TxtText.Focus();
                    return;
                }

                GenerateQRCode2(TxtText.Text);
            }
            else
            {
                if (!ValidateFileExcel())
                {
                    BtnUploadFileExcel.Focus();
                    return;
                }

                TxtText.Text = string.Empty;
                PicQRCode.Image = null;
                PicQRCode.BorderStyle = BorderStyle.FixedSingle;
                PicLogo.Visible = true;

                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                folderBrowserDialog.Description = "ជ្រើសរើសទីតាំងរក្សា QR Code";
                DialogResult result = folderBrowserDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog.SelectedPath;
                    try
                    {
                        Enabled = false;
                        Cursor = Cursors.WaitCursor;
                        foreach (DataRow row in dt.Rows)
                        {
                            string text = row.Field<string>("Name");

                            GenerateQRCode2(text);
                            text = text.Replace("/", "");

                            PicQRCode.Image.Save(string.Format("{0}\\{1}.png", selectedPath, text.Trim()), ImageFormat.Png);
                        }
                        RbMultiple_CheckedChanged(null, null);
                    }
                    finally
                    {
                        MessageBox.Show("រក្សា QR Code ជោគជ័យ");
                        Enabled = true;
                        Cursor = Cursors.Default;
                    }
                }
            }
        }

        private void GenerateQRCode(string text)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            PicQRCode.Image = qrcode.Draw(text, qrCodeHeight);
            PicQRCode.BorderStyle = BorderStyle.None;
            PicLogo.Visible = false;
            BtnSaveQRCode.Enabled = true;

            if (PicLogo.Image != null)
            {
                MergeLogoWithQrCode();
            }
        }

        private void GenerateQRCode2(string text)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            var generatedQRCode = qrcode.Draw(text, 500, 10);
            //Merge QR Code with Frame
            var qrCode = new Bitmap(generatedQRCode);
            var frame = new Bitmap(Properties.Resources.qrcode_white_frame);
            var gr = Graphics.FromImage(frame);
            gr.DrawImage(qrCode, (frame.Width - qrCode.Width) / 2, (frame.Height - qrCode.Height) / 2);

            //Merge Log with QR Code
            /*Bitmap logo = new Bitmap(PicLogo.Image, 100, 100);
            logo.MakeTransparent();
            gr.DrawImage(logo, (frame.Width - logo.Width) / 2, (frame.Height - logo.Height) / 2);
            PicLogo.Visible = false;*/

            PicQRCode.Image = frame;
            BtnSaveQRCode.Enabled = true;
        }

        private void BtnSaveQRCode_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.Description = "ជ្រើសរើសទីតាំងរក្សា QR Code";
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    /*string text = TxtText.Text;
                    text = text.Replace("/", "");*/
                    string text = "primecineplex-onelink-app";
                    PicQRCode.Image.Save(string.Format("{0}\\{1}.png", folderBrowserDialog.SelectedPath, text.Trim()), ImageFormat.Png);
                    Enabled = false;
                    Cursor = Cursors.WaitCursor;
                }
                finally
                {
                    MessageBox.Show("រក្សា QR Code ជោគជ័យ");
                    Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void MergeLogoWithQrCode()
        {
            Bitmap logo = new Bitmap(PicLogo.Image);
            logo.MakeTransparent();
            Bitmap template = new Bitmap(PicQRCode.Image);
            Graphics gr = Graphics.FromImage(template);
            gr.DrawImage(logo, template.Width - 108, template.Height -108, qrCodeWidth, qrCodeHeight);
            PicQRCode.Image = template;
        }

        private void TxtText_Enter(object sender, EventArgs e)
        {
            Helpers.ChangeKeyboardToEnglish();
        }

        private void TsmiClearQRCode_Click(object sender, EventArgs e)
        {
            PicQRCode.Image = null;
            PicQRCode.BorderStyle = BorderStyle.FixedSingle;
            PicLogo.Visible = true;
            RbManual_CheckedChanged(null, null);
        }

        private void DgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = DgvExcel.CurrentRow;
            TxtText.Text = currentRow.Cells[0].Value.ToString();
            GenerateQRCode(TxtText.Text);
        }

        private void TsmiUploadFileExcel_Click(object sender, EventArgs e)
        {
            BtnUploadFileExcel.PerformClick();
        }

        private void TsmiClearFileExcel_Click(object sender, EventArgs e)
        {
            TxtText.Text = string.Empty;
            PicQRCode.Image = null;
            PicQRCode.BorderStyle = BorderStyle.FixedSingle;
            PicLogo.Visible = true;
            BtnSaveQRCode.Enabled = false;
            DgvExcel.DataSource = null;
            ConfigDataGridView();
        }

        private void LblCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtText.Text))
            {
                Clipboard.SetText(TxtText.Text);
                MessageBox.Show("អត្ថបទចម្លងរួចហើយ");
            }
        }

        private void TsmiSaveOnlyQRCode_Click(object sender, EventArgs e)
        {
            if (RbManual.Checked)
            {
                BtnSaveQRCode.PerformClick();
            }
            else
            {
                BtnGenerateQRCode.PerformClick();
            }
        }

        private void TsmiSaveQRCodeWithTemplate_Click(object sender, EventArgs e)
        {
            if(RbManual.Checked)
            {
                if (PicQRCode.Image != null)
                {
                    FrmPreviewQRCodeTemplate objfrmPreviewPromoteCode = new FrmPreviewQRCodeTemplate();
                    objfrmPreviewPromoteCode.PromoteCode = TxtText.Text;
                    objfrmPreviewPromoteCode.QRCodeImage = PicQRCode.Image;
                    objfrmPreviewPromoteCode.ShowDialog();
                }
            }
            else
            {
                if (dt.Rows.Count > 1)
                {
                    FrmPreviewQRCodeTemplate objfrmPreviewPromoteCode = new FrmPreviewQRCodeTemplate();
                    objfrmPreviewPromoteCode.DtQRCode = dt;
                    objfrmPreviewPromoteCode.ShowDialog();
                }
            }
        }
    }
}

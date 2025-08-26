using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Zen.Barcode;

namespace HelperApp
{
    public partial class FrmPreviewQRCodeTemplate : Form
    {        
        public Image QRCodeImage;
        public string PromoteCode;
        public DataTable DtQRCode;
        private long imageSize = 500;
        private int templateWidth = 1080;
        private int templateHeight = 1720;
        private string oldImagePath;
        private string newImagePath;
        private Image selectedTemplate;
        private int qrNumber;

        public FrmPreviewQRCodeTemplate()
        {
            InitializeComponent();
            DtQRCode = new DataTable();
        }

        private void frmPreviewQRCodeTemplate_Load(object sender, EventArgs e)
        {
            if (QRCodeImage == null)
            {
                GenerateQRCodeWithFrame("TEST");
            }

            TsmiDefault.PerformClick();
        }

        private void TsmiDefault_Click(object sender, EventArgs e)
        {
            qrNumber = 0;
            selectedTemplate = Properties.Resources.qrcode_template;
            CreateQRCodeWithTemplate(selectedTemplate);
        }

        private void TsmiFromComputer_Click(object sender, EventArgs e)
        {
            if (LoadImageToPictureBox(ImageFormat.Jpeg, imageSize, templateWidth, templateHeight, oldImagePath, out newImagePath, out string imageFileName, out bool resizeImageStatus))
            {
                if (!string.IsNullOrEmpty(newImagePath))
                {
                    qrNumber = 0;
                    GenerateQRCodeWithFrame2("TEST");
                    selectedTemplate = Image.FromFile(newImagePath);
                    CreateQRCodeWithTemplate(selectedTemplate);
                }
            }
            else
            {
                if (picQRCodeWithTemplate.Image == null)
                {
                    Close();
                }
            }
        }

        private void CreateQRCodeWithTemplate(Image template)
        {
            var resizedTemplate = ResizeImage2(template, templateWidth, templateHeight);
            var gr = Graphics.FromImage(resizedTemplate);
            //gr.DrawImage(QRCodeImage, (resizedTemplate.Width - QRCodeImage.Width) / 2, (resizedTemplate.Height - QRCodeImage.Height) / 2);
            gr.DrawImage(QRCodeImage, (resizedTemplate.Width - QRCodeImage.Width) / 2, ((resizedTemplate.Height - QRCodeImage.Height) / 2) - 60);

            AddTextToTemplate(gr);

            picQRCodeWithTemplate.Image = resizedTemplate;
        }

        private void AddTextToTemplate(Graphics gr)
        {
            qrNumber++;
            string strNum = qrNumber.ToString();
            int x = 145;
            int y = 370;//415;//365;
            x = strNum.Length == 1 ? 145 : strNum.Length == 2 ? 120 : 105;
            Font arialFont = new Font("Verdana", 46);
            gr.DrawString(strNum, arialFont, Brushes.Black, x, y);
        }

        private void SaveMultiQRCodeWithTemplate()
        {
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

                    //var resizedTemplate = ResizeImage2(selectedTemplate, templateWidth, templateHeight);
                    //var gr = Graphics.FromImage(resizedTemplate);

                    foreach (DataRow row in DtQRCode.Rows)
                    {
                        var resizedTemplate = ResizeImage2(selectedTemplate, templateWidth, templateHeight);

                        string text = row.Field<string>("Name");

                        //GenerateQRCodeWithFrame2(text);
                        CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
                        var generatedQRCode = qrcode.Draw(text, 500, 13);
                        text = text.Replace("/", "");

                        var gr = Graphics.FromImage(resizedTemplate);
                        //gr.DrawImage(QRCodeImage, (resizedTemplate.Width - QRCodeImage.Width) / 2, (resizedTemplate.Height - QRCodeImage.Height) / 2);
                        gr.DrawImage(generatedQRCode, (resizedTemplate.Width - generatedQRCode.Width) / 2, ((resizedTemplate.Height - generatedQRCode.Height) / 2) - 60);

                        //CreateQRCodeWithTemplate(selectedTemplate);

                        AddTextToTemplate(gr);

                        /*var resizedTemplate = ResizeImage2(selectedTemplate, templateWidth, templateHeight);
                        var gr = Graphics.FromImage(resizedTemplate);
                        gr.DrawImage(QRCodeImage, (resizedTemplate.Width - QRCodeImage.Width) / 2, (resizedTemplate.Height - QRCodeImage.Height) / 2);*/

                        picQRCodeWithTemplate.Image = resizedTemplate;

                        picQRCodeWithTemplate.Image.Save(string.Format("{0}\\{1}.png", selectedPath, qrNumber /*text.Trim()*/), ImageFormat.Png);
                    }
                }
                finally
                {
                    MessageBox.Show("រក្សា QR Code ជោគជ័យ");
                    Enabled = true;
                    Cursor = Cursors.Default;
                }
            }
        }

        private void GenerateQRCodeWithFrame(string text)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            var generatedQRCode = qrcode.Draw(text, 500, 10);
            //Merge QR Code with Frame
            var qrCode = new Bitmap(generatedQRCode);
            var frame = new Bitmap(Properties.Resources.qrcode_white_frame);
            var gr = Graphics.FromImage(frame);
            gr.DrawImage(qrCode, (frame.Width - qrCode.Width) / 2, (frame.Height - qrCode.Height) / 2);
            QRCodeImage = frame;
        }

        private void GenerateQRCodeWithFrame2(string text)
        {
            CodeQrBarcodeDraw qrcode = BarcodeDrawFactory.CodeQr;
            var generatedQRCode = qrcode.Draw(text, 500, 13);
            QRCodeImage = generatedQRCode;
        }

        private void TsmiSave_Click(object sender, EventArgs e)
        {
            qrNumber = 0;
            if (DtQRCode.Rows.Count > 1)
            {
                SaveMultiQRCodeWithTemplate();
            }
            else
            {
                SaveImage(picQRCodeWithTemplate.Image, string.Format(@"qrcode_{0}.png", PromoteCode));
            }
        }

        private void TmsiCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool LoadImageToPictureBox(ImageFormat imageFormat, long imageSizeInByte, int imageWidthInPixel, int imageHeightInPixel, string oldImagePath, out string newImageLocation, out string imageFileName, out bool isResizeImage)
        {
            isResizeImage = false;
            newImageLocation = "";
            imageFileName = "";
            //Get Image with path
            try
            {
                //Getting The Image From The System
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = imageFormat == ImageFormat.Png ? "Image Files(*.png)|*.png" : "Image Files(*.jpg; *.jpeg)|*.jpg; *.jpeg";

                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap img = new Bitmap(open.FileName);
                    FileInfo file = new FileInfo(open.FileName);
                    long sizeInBytes = file.Length / 1024; //Convert Byte to KB
                    int imageWidth = img.Width;
                    int imageHeight = img.Height;

                    //Check Event Poster size
                    if (sizeInBytes > imageSizeInByte || imageWidth != imageWidthInPixel || imageHeight != imageHeightInPixel)
                    {
                        DialogResult result = MessageBox.Show("Image Size: " + sizeInBytes + "KB\n" + "Image Width: " + imageWidth + "PX\n" +
                                          "Image Height: " + imageHeight + "PX\n\n" +
                                          "It not the same recommended image dimension!\n\n" +
                                          "Do you want to resize your image? Yes 'Resize', No 'Select Other' or Cancel",
                                          "Your Image Dimension is :",
                                          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            newImageLocation = open.FileName;
                            isResizeImage = true;
                        }
                        else if (result == DialogResult.No)
                        {
                            return false;
                        }
                        else
                        {
                            newImageLocation = oldImagePath;
                        }
                    }
                    else
                    {
                        newImageLocation = open.FileName;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(oldImagePath))
                    {
                        newImageLocation = oldImagePath;
                    }
                }
                if (!string.IsNullOrEmpty(newImageLocation))
                {
                    imageFileName = newImageLocation.Substring(newImageLocation.LastIndexOf("\\"));
                    imageFileName = imageFileName.Remove(0, 1);
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            return true;
        }

        public void SetQualityAndSave(ImageFormat imageFormat, Image image, int width, int height, string path, string fileName)
        {
            ImageCodecInfo jpgEncoder = GetImageEncoder(imageFormat);
            Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
            EncoderParameters myEncoderParameters = new EncoderParameters(1);
            EncoderParameter myEncoderParameter = new EncoderParameter(myEncoder, 80L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            ResizeImage(image, width, height).Save(path + fileName, jpgEncoder, myEncoderParameters);
        }

        private Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new Rectangle(0, 0, width, height);
            Bitmap destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.Default;
                graphics.InterpolationMode = InterpolationMode.Low;
                graphics.SmoothingMode = SmoothingMode.Default;
                graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;

                using (ImageAttributes wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public Image ResizeImage2(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(resizedImage);
            graphics.DrawImage(image, 0, 0, width, height);
            return resizedImage;
        }

        private ImageCodecInfo GetImageEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        public void SaveImage(Image image, string fileName)
        {
            if (image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Images|*.jpg;*.jpeg;*.png",
                    Title = "Save as",
                    FileName = fileName,
                    RestoreDirectory = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string destinationPath = saveFileDialog.FileName;
                    if (!string.IsNullOrEmpty(destinationPath) && (destinationPath.Contains(".jpg") || destinationPath.Contains(".jpeg") || destinationPath.Contains(".png")))
                    {
                        try
                        {
                            image.Save(destinationPath);
                        }
                        finally
                        {
                           MessageBox.Show("Image saved to : " + destinationPath, "Save success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please specific image extension (.jpg, .jpeg or .png).\nE.g. image_name.jpg", "Invalid image format!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

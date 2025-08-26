namespace HelperApp
{
    partial class FrmGenerateQRCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblCopy = new System.Windows.Forms.Label();
            this.RbMultiple = new System.Windows.Forms.RadioButton();
            this.RbManual = new System.Windows.Forms.RadioButton();
            this.TxtText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnUploadFileExcel = new System.Windows.Forms.Button();
            this.BtnSaveQRCode = new System.Windows.Forms.Button();
            this.BtnGenerateQRCode = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.CmsLogo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiChooseImage = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiRemoveImage = new System.Windows.Forms.ToolStripMenuItem();
            this.PicQRCode = new System.Windows.Forms.PictureBox();
            this.CmsQRCode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiSaveQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClearQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.DgvExcel = new System.Windows.Forms.DataGridView();
            this.CmsGridView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiUploadFileExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiClearFileExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSaveOnlyQRCode = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSaveQRCodeWithTemplate = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.CmsLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicQRCode)).BeginInit();
            this.CmsQRCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvExcel)).BeginInit();
            this.CmsGridView.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblCopy);
            this.groupBox1.Controls.Add(this.RbMultiple);
            this.groupBox1.Controls.Add(this.RbManual);
            this.groupBox1.Controls.Add(this.TxtText);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnUploadFileExcel);
            this.groupBox1.Controls.Add(this.BtnSaveQRCode);
            this.groupBox1.Controls.Add(this.BtnGenerateQRCode);
            this.groupBox1.Controls.Add(this.PicLogo);
            this.groupBox1.Controls.Add(this.PicQRCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "បង្កើត និងរក្សា QR Code";
            // 
            // LblCopy
            // 
            this.LblCopy.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCopy.BackColor = System.Drawing.SystemColors.Window;
            this.LblCopy.Location = new System.Drawing.Point(518, 84);
            this.LblCopy.Name = "LblCopy";
            this.LblCopy.Size = new System.Drawing.Size(42, 29);
            this.LblCopy.TabIndex = 5;
            this.LblCopy.Text = "ចម្លង";
            this.LblCopy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblCopy.Click += new System.EventHandler(this.LblCopy_Click);
            // 
            // RbMultiple
            // 
            this.RbMultiple.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RbMultiple.AutoSize = true;
            this.RbMultiple.Location = new System.Drawing.Point(268, 24);
            this.RbMultiple.Name = "RbMultiple";
            this.RbMultiple.Size = new System.Drawing.Size(93, 25);
            this.RbMultiple.TabIndex = 4;
            this.RbMultiple.Text = "បង្កើតច្រើន";
            this.RbMultiple.UseVisualStyleBackColor = true;
            this.RbMultiple.CheckedChanged += new System.EventHandler(this.RbMultiple_CheckedChanged);
            // 
            // RbManual
            // 
            this.RbManual.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RbManual.AutoSize = true;
            this.RbManual.Checked = true;
            this.RbManual.Location = new System.Drawing.Point(165, 24);
            this.RbManual.Name = "RbManual";
            this.RbManual.Size = new System.Drawing.Size(97, 25);
            this.RbManual.TabIndex = 4;
            this.RbManual.TabStop = true;
            this.RbManual.Text = "បង្កើតមួយៗ";
            this.RbManual.UseVisualStyleBackColor = true;
            this.RbManual.CheckedChanged += new System.EventHandler(this.RbManual_CheckedChanged);
            // 
            // TxtText
            // 
            this.TxtText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtText.Location = new System.Drawing.Point(165, 84);
            this.TxtText.Name = "TxtText";
            this.TxtText.Size = new System.Drawing.Size(355, 29);
            this.TxtText.TabIndex = 0;
            this.TxtText.Enter += new System.EventHandler(this.TxtText_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "បញ្ចូលអត្ថបទដើម្បីបង្កើត QR Code";
            // 
            // BtnUploadFileExcel
            // 
            this.BtnUploadFileExcel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnUploadFileExcel.Enabled = false;
            this.BtnUploadFileExcel.Location = new System.Drawing.Point(417, 129);
            this.BtnUploadFileExcel.Name = "BtnUploadFileExcel";
            this.BtnUploadFileExcel.Size = new System.Drawing.Size(150, 45);
            this.BtnUploadFileExcel.TabIndex = 3;
            this.BtnUploadFileExcel.Text = "បញ្ចូលឯកសារ Excel";
            this.BtnUploadFileExcel.UseVisualStyleBackColor = true;
            this.BtnUploadFileExcel.Click += new System.EventHandler(this.BtnUploadFileExcel_Click);
            // 
            // BtnSaveQRCode
            // 
            this.BtnSaveQRCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnSaveQRCode.Enabled = false;
            this.BtnSaveQRCode.Location = new System.Drawing.Point(298, 129);
            this.BtnSaveQRCode.Name = "BtnSaveQRCode";
            this.BtnSaveQRCode.Size = new System.Drawing.Size(113, 45);
            this.BtnSaveQRCode.TabIndex = 2;
            this.BtnSaveQRCode.Text = "រក្សា QR Code";
            this.BtnSaveQRCode.UseVisualStyleBackColor = true;
            this.BtnSaveQRCode.Click += new System.EventHandler(this.BtnSaveQRCode_Click);
            // 
            // BtnGenerateQRCode
            // 
            this.BtnGenerateQRCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnGenerateQRCode.Location = new System.Drawing.Point(165, 129);
            this.BtnGenerateQRCode.Name = "BtnGenerateQRCode";
            this.BtnGenerateQRCode.Size = new System.Drawing.Size(127, 45);
            this.BtnGenerateQRCode.TabIndex = 1;
            this.BtnGenerateQRCode.Text = "បង្កើត QR Code";
            this.BtnGenerateQRCode.UseVisualStyleBackColor = true;
            this.BtnGenerateQRCode.Click += new System.EventHandler(this.BtnGenerateQRCode_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicLogo.ContextMenuStrip = this.CmsLogo;
            this.PicLogo.Location = new System.Drawing.Point(66, 84);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(30, 30);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 0;
            this.PicLogo.TabStop = false;
            // 
            // CmsLogo
            // 
            this.CmsLogo.Font = new System.Drawing.Font("Nokora", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsLogo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiChooseImage,
            this.TsmiRemoveImage});
            this.CmsLogo.Name = "CmsLogo";
            this.CmsLogo.Size = new System.Drawing.Size(141, 48);
            // 
            // TsmiChooseImage
            // 
            this.TsmiChooseImage.Font = new System.Drawing.Font("Nokora", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TsmiChooseImage.Name = "TsmiChooseImage";
            this.TsmiChooseImage.Size = new System.Drawing.Size(140, 22);
            this.TsmiChooseImage.Text = "បញ្ចូលរូបភាព";
            this.TsmiChooseImage.Click += new System.EventHandler(this.TsmiChooseImage_Click);
            // 
            // TsmiRemoveImage
            // 
            this.TsmiRemoveImage.Name = "TsmiRemoveImage";
            this.TsmiRemoveImage.Size = new System.Drawing.Size(140, 22);
            this.TsmiRemoveImage.Text = "ដករូបភាព";
            this.TsmiRemoveImage.Click += new System.EventHandler(this.TsmiRemoveImage_Click);
            // 
            // PicQRCode
            // 
            this.PicQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicQRCode.ContextMenuStrip = this.CmsQRCode;
            this.PicQRCode.Location = new System.Drawing.Point(6, 24);
            this.PicQRCode.Name = "PicQRCode";
            this.PicQRCode.Size = new System.Drawing.Size(150, 150);
            this.PicQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicQRCode.TabIndex = 0;
            this.PicQRCode.TabStop = false;
            // 
            // CmsQRCode
            // 
            this.CmsQRCode.Font = new System.Drawing.Font("Nokora", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsQRCode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSaveQRCode,
            this.TsmiClearQRCode});
            this.CmsQRCode.Name = "CmsQRCode";
            this.CmsQRCode.Size = new System.Drawing.Size(181, 70);
            // 
            // TsmiSaveQRCode
            // 
            this.TsmiSaveQRCode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiSaveOnlyQRCode,
            this.TsmiSaveQRCodeWithTemplate});
            this.TsmiSaveQRCode.Name = "TsmiSaveQRCode";
            this.TsmiSaveQRCode.Size = new System.Drawing.Size(180, 22);
            this.TsmiSaveQRCode.Text = "រក្សា QR Code";
            // 
            // TsmiClearQRCode
            // 
            this.TsmiClearQRCode.Name = "TsmiClearQRCode";
            this.TsmiClearQRCode.Size = new System.Drawing.Size(180, 22);
            this.TsmiClearQRCode.Text = "សម្អាត QR Code";
            this.TsmiClearQRCode.Click += new System.EventHandler(this.TsmiClearQRCode_Click);
            // 
            // DgvExcel
            // 
            this.DgvExcel.AllowUserToAddRows = false;
            this.DgvExcel.AllowUserToDeleteRows = false;
            this.DgvExcel.AllowUserToResizeColumns = false;
            this.DgvExcel.AllowUserToResizeRows = false;
            this.DgvExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvExcel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvExcel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvExcel.ContextMenuStrip = this.CmsGridView;
            this.DgvExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvExcel.Enabled = false;
            this.DgvExcel.Location = new System.Drawing.Point(0, 180);
            this.DgvExcel.Name = "DgvExcel";
            this.DgvExcel.ReadOnly = true;
            this.DgvExcel.RowHeadersVisible = false;
            this.DgvExcel.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgvExcel.Size = new System.Drawing.Size(572, 261);
            this.DgvExcel.TabIndex = 1;
            this.DgvExcel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvExcel_CellClick);
            // 
            // CmsGridView
            // 
            this.CmsGridView.Font = new System.Drawing.Font("Nokora", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiUploadFileExcel,
            this.TsmiClearFileExcel});
            this.CmsGridView.Name = "CmsGridView";
            this.CmsGridView.Size = new System.Drawing.Size(178, 48);
            // 
            // TsmiUploadFileExcel
            // 
            this.TsmiUploadFileExcel.Name = "TsmiUploadFileExcel";
            this.TsmiUploadFileExcel.Size = new System.Drawing.Size(177, 22);
            this.TsmiUploadFileExcel.Text = "បញ្ចូលឯកសារ Excel";
            this.TsmiUploadFileExcel.Click += new System.EventHandler(this.TsmiUploadFileExcel_Click);
            // 
            // TsmiClearFileExcel
            // 
            this.TsmiClearFileExcel.Name = "TsmiClearFileExcel";
            this.TsmiClearFileExcel.Size = new System.Drawing.Size(177, 22);
            this.TsmiClearFileExcel.Text = "សម្អាតទិន្នន័យ";
            this.TsmiClearFileExcel.Click += new System.EventHandler(this.TsmiClearFileExcel_Click);
            // 
            // TsmiSaveOnlyQRCode
            // 
            this.TsmiSaveOnlyQRCode.Name = "TsmiSaveOnlyQRCode";
            this.TsmiSaveOnlyQRCode.Size = new System.Drawing.Size(187, 22);
            this.TsmiSaveOnlyQRCode.Text = "រក្សាតែ QR Code";
            this.TsmiSaveOnlyQRCode.Click += new System.EventHandler(this.TsmiSaveOnlyQRCode_Click);
            // 
            // TsmiSaveQRCodeWithTemplate
            // 
            this.TsmiSaveQRCodeWithTemplate.Name = "TsmiSaveQRCodeWithTemplate";
            this.TsmiSaveQRCodeWithTemplate.Size = new System.Drawing.Size(187, 22);
            this.TsmiSaveQRCodeWithTemplate.Text = "រក្សាជាមួយ Template";
            this.TsmiSaveQRCodeWithTemplate.Click += new System.EventHandler(this.TsmiSaveQRCodeWithTemplate_Click);
            // 
            // FrmGenerateQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 441);
            this.Controls.Add(this.DgvExcel);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGenerateQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "បង្កើត និងរក្សា QR Code";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.CmsLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicQRCode)).EndInit();
            this.CmsQRCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvExcel)).EndInit();
            this.CmsGridView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox PicLogo;
        private System.Windows.Forms.PictureBox PicQRCode;
        private System.Windows.Forms.Button BtnGenerateQRCode;
        private System.Windows.Forms.Button BtnSaveQRCode;
        private System.Windows.Forms.Button BtnUploadFileExcel;
        private System.Windows.Forms.DataGridView DgvExcel;
        private System.Windows.Forms.TextBox TxtText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RbMultiple;
        private System.Windows.Forms.RadioButton RbManual;
        private System.Windows.Forms.ContextMenuStrip CmsLogo;
        private System.Windows.Forms.ToolStripMenuItem TsmiChooseImage;
        private System.Windows.Forms.ToolStripMenuItem TsmiRemoveImage;
        private System.Windows.Forms.ContextMenuStrip CmsQRCode;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveQRCode;
        private System.Windows.Forms.ToolStripMenuItem TsmiClearQRCode;
        private System.Windows.Forms.ContextMenuStrip CmsGridView;
        private System.Windows.Forms.ToolStripMenuItem TsmiUploadFileExcel;
        private System.Windows.Forms.ToolStripMenuItem TsmiClearFileExcel;
        private System.Windows.Forms.Label LblCopy;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveOnlyQRCode;
        private System.Windows.Forms.ToolStripMenuItem TsmiSaveQRCodeWithTemplate;
    }
}


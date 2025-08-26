namespace HelperApp
{
    partial class FrmPreviewQRCodeTemplate
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
            this.cmsOption = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiDefault = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiFromComputer = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.TmsiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.picQRCodeWithTemplate = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmsOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeWithTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOption
            // 
            this.cmsOption.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmsOption.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.TsmiSave,
            this.TmsiCancel});
            this.cmsOption.Name = "cmsOption";
            this.cmsOption.Size = new System.Drawing.Size(144, 82);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiDefault,
            this.TsmiFromComputer});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 26);
            this.toolStripMenuItem1.Text = "ជ្រើសរើសគម្រូ";
            // 
            // TsmiDefault
            // 
            this.TsmiDefault.Name = "TsmiDefault";
            this.TsmiDefault.Size = new System.Drawing.Size(138, 26);
            this.TsmiDefault.Text = "គម្រូដើម";
            this.TsmiDefault.Click += new System.EventHandler(this.TsmiDefault_Click);
            // 
            // TsmiFromComputer
            // 
            this.TsmiFromComputer.Name = "TsmiFromComputer";
            this.TsmiFromComputer.Size = new System.Drawing.Size(138, 26);
            this.TsmiFromComputer.Text = "យកពីកុំព្យូទ័រ";
            this.TsmiFromComputer.Click += new System.EventHandler(this.TsmiFromComputer_Click);
            // 
            // TsmiSave
            // 
            this.TsmiSave.Name = "TsmiSave";
            this.TsmiSave.Size = new System.Drawing.Size(143, 26);
            this.TsmiSave.Text = "រក្សា";
            this.TsmiSave.Click += new System.EventHandler(this.TsmiSave_Click);
            // 
            // TmsiCancel
            // 
            this.TmsiCancel.Name = "TmsiCancel";
            this.TmsiCancel.Size = new System.Drawing.Size(143, 26);
            this.TmsiCancel.Text = "បោះបង់";
            this.TmsiCancel.Click += new System.EventHandler(this.TmsiCancel_Click);
            // 
            // picQRCodeWithTemplate
            // 
            this.picQRCodeWithTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picQRCodeWithTemplate.Location = new System.Drawing.Point(0, 18);
            this.picQRCodeWithTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.picQRCodeWithTemplate.Name = "picQRCodeWithTemplate";
            this.picQRCodeWithTemplate.Size = new System.Drawing.Size(300, 432);
            this.picQRCodeWithTemplate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picQRCodeWithTemplate.TabIndex = 1;
            this.picQRCodeWithTemplate.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Template dimensions: 1080px X 1720px";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPreviewQRCodeTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.ContextMenuStrip = this.cmsOption;
            this.Controls.Add(this.picQRCodeWithTemplate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPreviewQRCodeTemplate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview Promote Code";
            this.Load += new System.EventHandler(this.frmPreviewQRCodeTemplate_Load);
            this.cmsOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picQRCodeWithTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip cmsOption;
        private System.Windows.Forms.ToolStripMenuItem TsmiSave;
        private System.Windows.Forms.ToolStripMenuItem TmsiCancel;
        private System.Windows.Forms.PictureBox picQRCodeWithTemplate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TsmiDefault;
        private System.Windows.Forms.ToolStripMenuItem TsmiFromComputer;
        private System.Windows.Forms.Label label1;
    }
}
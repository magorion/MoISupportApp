namespace MOISupport
{
    partial class AddressFixerForm
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.progressAnimatonBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressAnimatonBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip3.TabIndex = 2;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.existingProjectToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newProjectToolStripMenuItem.Text = "New Project";
            // 
            // existingProjectToolStripMenuItem
            // 
            this.existingProjectToolStripMenuItem.Name = "existingProjectToolStripMenuItem";
            this.existingProjectToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.existingProjectToolStripMenuItem.Text = "Existing Project";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(120, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 443);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1039, 20);
            this.textBox1.TabIndex = 3;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(13, 38);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(371, 31);
            this.loadFileButton.TabIndex = 4;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fileInfoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 292);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Info";
            // 
            // fileInfoTextBox
            // 
            this.fileInfoTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.fileInfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileInfoTextBox.Location = new System.Drawing.Point(7, 20);
            this.fileInfoTextBox.Name = "fileInfoTextBox";
            this.fileInfoTextBox.ReadOnly = true;
            this.fileInfoTextBox.Size = new System.Drawing.Size(395, 266);
            this.fileInfoTextBox.TabIndex = 0;
            this.fileInfoTextBox.Text = "No Files Loaded.";
            this.fileInfoTextBox.TextChanged += new System.EventHandler(this.fileInfoTextBox_TextChanged);
            // 
            // progressAnimatonBox
            // 
            this.progressAnimatonBox.Image = global::MOISupport.Properties.Resources.Progress;
            this.progressAnimatonBox.InitialImage = null;
            this.progressAnimatonBox.Location = new System.Drawing.Point(390, 38);
            this.progressAnimatonBox.Name = "progressAnimatonBox";
            this.progressAnimatonBox.Size = new System.Drawing.Size(31, 31);
            this.progressAnimatonBox.TabIndex = 1;
            this.progressAnimatonBox.TabStop = false;
            this.progressAnimatonBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(428, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 322);
            this.panel1.TabIndex = 6;
            // 
            // AddressFixerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressAnimatonBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip3);
            this.Name = "AddressFixerForm";
            this.Text = "AddressFixer";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressAnimatonBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.RichTextBox fileInfoTextBox;
        private System.Windows.Forms.PictureBox progressAnimatonBox;
        private System.Windows.Forms.Panel panel1;
    }
}


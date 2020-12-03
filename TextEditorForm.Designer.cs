namespace FileManagerLab
{
    partial class TextEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tbWhatChange = new System.Windows.Forms.TextBox();
            this.rtbTextEditor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWhatChange = new System.Windows.Forms.Label();
            this.lblToWhatChange = new System.Windows.Forms.Label();
            this.tbToWhatChange = new System.Windows.Forms.TextBox();
            this.btnChangeSequence = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.toolStripMenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1137, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemSaveFile});
            this.toolStripMenuItemFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFile.Image")));
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(79, 24);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // menuItemSaveFile
            // 
            this.menuItemSaveFile.CheckOnClick = true;
            this.menuItemSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("menuItemSaveFile.Image")));
            this.menuItemSaveFile.Name = "menuItemSaveFile";
            this.menuItemSaveFile.Size = new System.Drawing.Size(155, 26);
            this.menuItemSaveFile.Text = "Зберегти";
            this.menuItemSaveFile.Click += new System.EventHandler(this.menuItemSaveFile_Click);
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemHelp.Image")));
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(97, 24);
            this.toolStripMenuItemHelp.Text = "Довідка";
            this.toolStripMenuItemHelp.Click += new System.EventHandler(this.toolStripMenuItemHelp_Click);
            // 
            // tbWhatChange
            // 
            this.tbWhatChange.Location = new System.Drawing.Point(222, 618);
            this.tbWhatChange.Name = "tbWhatChange";
            this.tbWhatChange.Size = new System.Drawing.Size(125, 27);
            this.tbWhatChange.TabIndex = 2;
            // 
            // rtbTextEditor
            // 
            this.rtbTextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbTextEditor.Location = new System.Drawing.Point(12, 41);
            this.rtbTextEditor.Name = "rtbTextEditor";
            this.rtbTextEditor.Size = new System.Drawing.Size(1112, 557);
            this.rtbTextEditor.TabIndex = 0;
            this.rtbTextEditor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-336, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // lblWhatChange
            // 
            this.lblWhatChange.AutoSize = true;
            this.lblWhatChange.Location = new System.Drawing.Point(13, 618);
            this.lblWhatChange.Name = "lblWhatChange";
            this.lblWhatChange.Size = new System.Drawing.Size(203, 20);
            this.lblWhatChange.TabIndex = 4;
            this.lblWhatChange.Text = "Послідовність, яку замінити";
            // 
            // lblToWhatChange
            // 
            this.lblToWhatChange.AutoSize = true;
            this.lblToWhatChange.Location = new System.Drawing.Point(390, 618);
            this.lblToWhatChange.Name = "lblToWhatChange";
            this.lblToWhatChange.Size = new System.Drawing.Size(224, 20);
            this.lblToWhatChange.TabIndex = 5;
            this.lblToWhatChange.Text = "Послідовність, на яку замінити";
            // 
            // tbToWhatChange
            // 
            this.tbToWhatChange.Location = new System.Drawing.Point(620, 618);
            this.tbToWhatChange.Name = "tbToWhatChange";
            this.tbToWhatChange.Size = new System.Drawing.Size(125, 27);
            this.tbToWhatChange.TabIndex = 6;
            // 
            // btnChangeSequence
            // 
            this.btnChangeSequence.Location = new System.Drawing.Point(795, 615);
            this.btnChangeSequence.Name = "btnChangeSequence";
            this.btnChangeSequence.Size = new System.Drawing.Size(94, 29);
            this.btnChangeSequence.TabIndex = 7;
            this.btnChangeSequence.Text = "Замінити";
            this.btnChangeSequence.UseVisualStyleBackColor = true;
            this.btnChangeSequence.Click += new System.EventHandler(this.btnChangeSequence_Click);
            // 
            // TextEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 659);
            this.Controls.Add(this.btnChangeSequence);
            this.Controls.Add(this.tbToWhatChange);
            this.Controls.Add(this.lblToWhatChange);
            this.Controls.Add(this.lblWhatChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWhatChange);
            this.Controls.Add(this.rtbTextEditor);
            this.Controls.Add(this.menuStrip);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TextEditorForm";
            this.Text = "TextEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TextEditorForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextEditorForm_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveFile;
        private System.Windows.Forms.TextBox tbWhatChange;
        private System.Windows.Forms.RichTextBox rtbTextEditor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWhatChange;
        private System.Windows.Forms.Label lblToWhatChange;
        private System.Windows.Forms.TextBox tbToWhatChange;
        private System.Windows.Forms.Button btnChangeSequence;
    }
}
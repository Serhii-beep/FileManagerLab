namespace FileManagerLab
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewDirectories = new System.Windows.Forms.ListView();
            this.DirectoryNames = new System.Windows.Forms.ColumnHeader(0);
            this.icons = new System.Windows.Forms.ImageList(this.components);
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.FileNames = new System.Windows.Forms.ColumnHeader(1);
            this.buttonBack = new System.Windows.Forms.Button();
            this.nUDBytes = new System.Windows.Forms.NumericUpDown();
            this.menuStripFileManager = new System.Windows.Forms.MenuStrip();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nUDBytes)).BeginInit();
            this.menuStripFileManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDirectories
            // 
            this.listViewDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewDirectories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DirectoryNames});
            this.listViewDirectories.HideSelection = false;
            this.listViewDirectories.Location = new System.Drawing.Point(13, 38);
            this.listViewDirectories.MultiSelect = false;
            this.listViewDirectories.Name = "listViewDirectories";
            this.listViewDirectories.Size = new System.Drawing.Size(428, 524);
            this.listViewDirectories.SmallImageList = this.icons;
            this.listViewDirectories.TabIndex = 0;
            this.listViewDirectories.UseCompatibleStateImageBehavior = false;
            this.listViewDirectories.View = System.Windows.Forms.View.Details;
            this.listViewDirectories.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewDirectories_MouseDoubleClick);
            // 
            // DirectoryNames
            // 
            this.DirectoryNames.Text = "";
            this.DirectoryNames.Width = 327;
            // 
            // icons
            // 
            this.icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.TransparentColor = System.Drawing.Color.Transparent;
            this.icons.Images.SetKeyName(0, "folder");
            this.icons.Images.SetKeyName(1, "file");
            // 
            // listViewFiles
            // 
            this.listViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileNames});
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LabelEdit = true;
            this.listViewFiles.Location = new System.Drawing.Point(637, 38);
            this.listViewFiles.MultiSelect = false;
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(417, 524);
            this.listViewFiles.SmallImageList = this.icons;
            this.listViewFiles.TabIndex = 1;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            this.listViewFiles.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewFiles_AfterLabelEdit);
            this.listViewFiles.BeforeLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listViewFiles_BeforeLabelEdit);
            this.listViewFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewFiles_MouseDoubleClick);
            // 
            // FileNames
            // 
            this.FileNames.Text = "";
            this.FileNames.Width = 327;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.Location = new System.Drawing.Point(447, 63);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(184, 29);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // nUDBytes
            // 
            this.nUDBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nUDBytes.Location = new System.Drawing.Point(447, 143);
            this.nUDBytes.Name = "nUDBytes";
            this.nUDBytes.Size = new System.Drawing.Size(184, 27);
            this.nUDBytes.TabIndex = 3;
            // 
            // menuStripFileManager
            // 
            this.menuStripFileManager.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFileManager.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelp});
            this.menuStripFileManager.Location = new System.Drawing.Point(0, 0);
            this.menuStripFileManager.Name = "menuStripFileManager";
            this.menuStripFileManager.Size = new System.Drawing.Size(1066, 28);
            this.menuStripFileManager.TabIndex = 4;
            this.menuStripFileManager.Text = "menuStrip1";
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.Image = ((System.Drawing.Image)(resources.GetObject("menuItemHelp.Image")));
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(97, 24);
            this.menuItemHelp.Text = "Довідка";
            this.menuItemHelp.Click += new System.EventHandler(this.menuItemHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 574);
            this.Controls.Add(this.nUDBytes);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewFiles);
            this.Controls.Add(this.listViewDirectories);
            this.Controls.Add(this.menuStripFileManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStripFileManager;
            this.Name = "Form1";
            this.Text = "File manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nUDBytes)).EndInit();
            this.menuStripFileManager.ResumeLayout(false);
            this.menuStripFileManager.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewDirectories;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader DirectoryNames;
        private System.Windows.Forms.ColumnHeader FileNames;
        private System.Windows.Forms.ImageList icons;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.NumericUpDown nUDBytes;
        private System.Windows.Forms.MenuStrip menuStripFileManager;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
    }
}


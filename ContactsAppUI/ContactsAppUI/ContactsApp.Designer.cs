﻿
namespace ContactsAppUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxContact = new System.Windows.Forms.ListBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonCreateNewContact = new System.Windows.Forms.Button();
            this.buttonChangeContact = new System.Windows.Forms.Button();
            this.buttonDeleteContact = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditChange = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuEditDeleteContact = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.controlContactMain = new ContactsAppUI.ControlContact();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxContact
            // 
            this.listBoxContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxContact.FormattingEnabled = true;
            this.listBoxContact.ItemHeight = 20;
            this.listBoxContact.Location = new System.Drawing.Point(12, 98);
            this.listBoxContact.Name = "listBoxContact";
            this.listBoxContact.Size = new System.Drawing.Size(314, 184);
            this.listBoxContact.TabIndex = 0;
            this.listBoxContact.SelectedIndexChanged += new System.EventHandler(this.listBoxContact_SelectedIndexChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(12, 46);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(56, 20);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Search:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(76, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(250, 27);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonCreateNewContact
            // 
            this.buttonCreateNewContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateNewContact.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCreateNewContact.BackgroundImage = global::ContactsAppUI.Properties.Resources.Add_8x_16x;
            this.buttonCreateNewContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateNewContact.FlatAppearance.BorderSize = 0;
            this.buttonCreateNewContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNewContact.Location = new System.Drawing.Point(12, 290);
            this.buttonCreateNewContact.Name = "buttonCreateNewContact";
            this.buttonCreateNewContact.Size = new System.Drawing.Size(25, 25);
            this.buttonCreateNewContact.TabIndex = 15;
            this.buttonCreateNewContact.UseVisualStyleBackColor = false;
            this.buttonCreateNewContact.Click += new System.EventHandler(this.ButtonСreateNewContact_Click);
            // 
            // buttonChangeContact
            // 
            this.buttonChangeContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonChangeContact.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonChangeContact.BackgroundImage = global::ContactsAppUI.Properties.Resources.Edit_grey_16x;
            this.buttonChangeContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonChangeContact.FlatAppearance.BorderSize = 0;
            this.buttonChangeContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeContact.Location = new System.Drawing.Point(47, 290);
            this.buttonChangeContact.Name = "buttonChangeContact";
            this.buttonChangeContact.Size = new System.Drawing.Size(25, 25);
            this.buttonChangeContact.TabIndex = 16;
            this.buttonChangeContact.UseVisualStyleBackColor = false;
            this.buttonChangeContact.Click += new System.EventHandler(this.buttonChangeContact_Click);
            // 
            // buttonDeleteContact
            // 
            this.buttonDeleteContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteContact.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDeleteContact.BackgroundImage = global::ContactsAppUI.Properties.Resources.Remove_color_16x;
            this.buttonDeleteContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteContact.FlatAppearance.BorderSize = 0;
            this.buttonDeleteContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteContact.Location = new System.Drawing.Point(82, 290);
            this.buttonDeleteContact.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDeleteContact.Name = "buttonDeleteContact";
            this.buttonDeleteContact.Size = new System.Drawing.Size(25, 25);
            this.buttonDeleteContact.TabIndex = 17;
            this.buttonDeleteContact.UseVisualStyleBackColor = false;
            this.buttonDeleteContact.Click += new System.EventHandler(this.buttonDeleteContact_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFile,
            this.toolStripMenuEdit,
            this.toolStripMenuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(668, 28);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "Меню";
            // 
            // toolStripMenuFile
            // 
            this.toolStripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFileExit});
            this.toolStripMenuFile.Name = "toolStripMenuFile";
            this.toolStripMenuFile.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuFile.Text = "File";
            // 
            // toolStripMenuFileExit
            // 
            this.toolStripMenuFileExit.Name = "toolStripMenuFileExit";
            this.toolStripMenuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuFileExit.Size = new System.Drawing.Size(169, 26);
            this.toolStripMenuFileExit.Text = "Exit";
            this.toolStripMenuFileExit.Click += new System.EventHandler(this.toolStripMenuFileExit_Click);
            // 
            // toolStripMenuEdit
            // 
            this.toolStripMenuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuEditAddContact,
            this.toolStripMenuEditChange,
            this.toolStripMenuEditDeleteContact});
            this.toolStripMenuEdit.Name = "toolStripMenuEdit";
            this.toolStripMenuEdit.Size = new System.Drawing.Size(49, 24);
            this.toolStripMenuEdit.Text = "Edit";
            // 
            // toolStripMenuEditAddContact
            // 
            this.toolStripMenuEditAddContact.Name = "toolStripMenuEditAddContact";
            this.toolStripMenuEditAddContact.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuEditAddContact.Text = "Add Contact";
            this.toolStripMenuEditAddContact.Click += new System.EventHandler(this.toolStripMenuEditAddContact_Click);
            // 
            // toolStripMenuEditChange
            // 
            this.toolStripMenuEditChange.Name = "toolStripMenuEditChange";
            this.toolStripMenuEditChange.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuEditChange.Text = "Edit Contact";
            this.toolStripMenuEditChange.Click += new System.EventHandler(this.toolStripMenuEditChange_Click);
            // 
            // toolStripMenuEditDeleteContact
            // 
            this.toolStripMenuEditDeleteContact.Name = "toolStripMenuEditDeleteContact";
            this.toolStripMenuEditDeleteContact.Size = new System.Drawing.Size(191, 26);
            this.toolStripMenuEditDeleteContact.Text = "Delete Contact";
            this.toolStripMenuEditDeleteContact.Click += new System.EventHandler(this.toolStripMenuEditDeleteContact_Click);
            // 
            // toolStripMenuHelp
            // 
            this.toolStripMenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuHelpAbout});
            this.toolStripMenuHelp.Name = "toolStripMenuHelp";
            this.toolStripMenuHelp.Size = new System.Drawing.Size(55, 24);
            this.toolStripMenuHelp.Text = "Help";
            // 
            // toolStripMenuHelpAbout
            // 
            this.toolStripMenuHelpAbout.Name = "toolStripMenuHelpAbout";
            this.toolStripMenuHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.toolStripMenuHelpAbout.Size = new System.Drawing.Size(142, 26);
            this.toolStripMenuHelpAbout.Text = "Info";
            this.toolStripMenuHelpAbout.Click += new System.EventHandler(this.toolStripMenuHelpAbout_Click);
            // 
            // controlContactMain
            // 
            this.controlContactMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlContactMain.Contact = null;
            this.controlContactMain.Enabled = false;
            this.controlContactMain.Location = new System.Drawing.Point(332, 31);
            this.controlContactMain.Name = "controlContactMain";
            this.controlContactMain.Size = new System.Drawing.Size(330, 259);
            this.controlContactMain.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(668, 321);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.controlContactMain);
            this.Controls.Add(this.buttonDeleteContact);
            this.Controls.Add(this.buttonChangeContact);
            this.Controls.Add(this.buttonCreateNewContact);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxContact);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        public System.Windows.Forms.ListBox listBoxContact;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonCreateNewContact;
        private System.Windows.Forms.Button buttonChangeContact;
        private System.Windows.Forms.Button buttonDeleteContact;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFileExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditAddContact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditChange;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuEditDeleteContact;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHelpAbout;
        private ControlContact controlContactMain;
    }
}


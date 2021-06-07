
namespace ContactsAppUI
{
    partial class ContactForm
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
            this.controlContactAdd = new ContactsAppUI.ControlContact();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlContactAdd
            // 
            this.controlContactAdd.Contact = null;
            this.controlContactAdd.Location = new System.Drawing.Point(12, 12);
            this.controlContactAdd.Name = "controlContactAdd";
            this.controlContactAdd.Size = new System.Drawing.Size(314, 271);
            this.controlContactAdd.TabIndex = 0;
            this.controlContactAdd.Load += new System.EventHandler(this.controlContactAdd_Load);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(45, 289);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(100, 30);
            this.buttonConfirm.TabIndex = 1;
            this.buttonConfirm.Text = "OK";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(185, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 334);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.controlContactAdd);
            this.Name = "ContactForm";
            this.Text = "Add/Edit Contact";
            this.Load += new System.EventHandler(this.ContactForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ControlContact controlContactAdd;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button button1;
    }
}
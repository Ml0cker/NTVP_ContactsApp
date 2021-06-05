
namespace ContactsAppUI
{
    partial class ControlContact
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.dateTimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxVkId = new System.Windows.Forms.TextBox();
            this.labelVkId = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(20, 97);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(119, 20);
            this.labelBirthDate.TabIndex = 26;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimeBirthDate
            // 
            this.dateTimeBirthDate.Location = new System.Drawing.Point(145, 97);
            this.dateTimeBirthDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimeBirthDate.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirthDate.Name = "dateTimeBirthDate";
            this.dateTimeBirthDate.Size = new System.Drawing.Size(156, 27);
            this.dateTimeBirthDate.TabIndex = 25;
            this.dateTimeBirthDate.Value = new System.DateTime(1999, 1, 1, 6, 56, 0, 0);
            this.dateTimeBirthDate.ValueChanged += new System.EventHandler(this.dateTimeBirthDate_ValueChanged);
            // 
            // textBoxVkId
            // 
            this.textBoxVkId.Location = new System.Drawing.Point(145, 222);
            this.textBoxVkId.Name = "textBoxVkId";
            this.textBoxVkId.Size = new System.Drawing.Size(156, 27);
            this.textBoxVkId.TabIndex = 24;
            this.textBoxVkId.TextChanged += new System.EventHandler(this.textBoxVkId_TextChanged);
            // 
            // labelVkId
            // 
            this.labelVkId.AutoSize = true;
            this.labelVkId.Location = new System.Drawing.Point(20, 225);
            this.labelVkId.Name = "labelVkId";
            this.labelVkId.Size = new System.Drawing.Size(30, 20);
            this.labelVkId.TabIndex = 23;
            this.labelVkId.Text = "VK:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(145, 183);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(156, 27);
            this.textBoxEmail.TabIndex = 22;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 186);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(49, 20);
            this.labelEmail.TabIndex = 21;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(145, 140);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(156, 27);
            this.textBoxPhoneNumber.TabIndex = 20;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(20, 143);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(60, 20);
            this.labelPhoneNumber.TabIndex = 19;
            this.labelPhoneNumber.Text = "Номер:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(145, 57);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(156, 27);
            this.textBoxName.TabIndex = 18;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 60);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 17;
            this.labelName.Text = "Имя:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(145, 12);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(156, 27);
            this.textBoxSurname.TabIndex = 16;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(20, 15);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(76, 20);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Фамилия:";
            // 
            // ControlContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.dateTimeBirthDate);
            this.Controls.Add(this.textBoxVkId);
            this.Controls.Add(this.labelVkId);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Name = "ControlContact";
            this.Size = new System.Drawing.Size(324, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDate;
        private System.Windows.Forms.TextBox textBoxVkId;
        private System.Windows.Forms.Label labelVkId;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
    }
}


namespace FormLoginSederhana
{
    partial class Form2
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
            this.registrasi = new System.Windows.Forms.Button();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pasword = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.konfi = new System.Windows.Forms.Label();
            this.textBoxKonfirmasiPasword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registrasi
            // 
            this.registrasi.Location = new System.Drawing.Point(141, 145);
            this.registrasi.Name = "registrasi";
            this.registrasi.Size = new System.Drawing.Size(97, 21);
            this.registrasi.TabIndex = 13;
            this.registrasi.Text = "registrasi";
            this.registrasi.UseVisualStyleBackColor = true;
            this.registrasi.Click += new System.EventHandler(this.registrasi_Click);
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(185, 55);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.PasswordChar = '*';
            this.textBoxPasword.Size = new System.Drawing.Size(129, 20);
            this.textBoxPasword.TabIndex = 12;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(185, 28);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(129, 20);
            this.textBoxEmail.TabIndex = 11;
            this.textBoxEmail.Text = "@";
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // pasword
            // 
            this.pasword.AutoSize = true;
            this.pasword.Location = new System.Drawing.Point(66, 62);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(47, 13);
            this.pasword.TabIndex = 10;
            this.pasword.Text = "pasword";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(66, 35);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 9;
            this.email.Text = "email";
            // 
            // konfi
            // 
            this.konfi.AutoSize = true;
            this.konfi.Location = new System.Drawing.Point(66, 93);
            this.konfi.Name = "konfi";
            this.konfi.Size = new System.Drawing.Size(97, 13);
            this.konfi.TabIndex = 14;
            this.konfi.Text = "konfirmasi pasword";
            this.konfi.Click += new System.EventHandler(this.konfi_Click);
            // 
            // textBoxKonfirmasiPasword
            // 
            this.textBoxKonfirmasiPasword.Location = new System.Drawing.Point(185, 90);
            this.textBoxKonfirmasiPasword.Name = "textBoxKonfirmasiPasword";
            this.textBoxKonfirmasiPasword.PasswordChar = '*';
            this.textBoxKonfirmasiPasword.Size = new System.Drawing.Size(129, 20);
            this.textBoxKonfirmasiPasword.TabIndex = 15;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.textBoxKonfirmasiPasword);
            this.Controls.Add(this.konfi);
            this.Controls.Add(this.registrasi);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.email);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button registrasi;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label pasword;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label konfi;
        private System.Windows.Forms.TextBox textBoxKonfirmasiPasword;
    }
}

namespace FormLoginSederhana
{
    partial class Form1
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
            this.textBoxKonfirmasiPasword = new System.Windows.Forms.TextBox();
            this.konfi = new System.Windows.Forms.Label();
            this.registrasi = new System.Windows.Forms.Button();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.pasword = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxKonfirmasiPasword
            // 
            this.textBoxKonfirmasiPasword.Location = new System.Drawing.Point(179, 86);
            this.textBoxKonfirmasiPasword.Name = "textBoxKonfirmasiPasword";
            this.textBoxKonfirmasiPasword.PasswordChar = '*';
            this.textBoxKonfirmasiPasword.Size = new System.Drawing.Size(129, 20);
            this.textBoxKonfirmasiPasword.TabIndex = 22;
            // 
            // konfi
            // 
            this.konfi.AutoSize = true;
            this.konfi.Location = new System.Drawing.Point(60, 89);
            this.konfi.Name = "konfi";
            this.konfi.Size = new System.Drawing.Size(97, 13);
            this.konfi.TabIndex = 21;
            this.konfi.Text = "konfirmasi pasword";
            // 
            // registrasi
            // 
            this.registrasi.Location = new System.Drawing.Point(135, 150);
            this.registrasi.Name = "registrasi";
            this.registrasi.Size = new System.Drawing.Size(97, 21);
            this.registrasi.TabIndex = 20;
            this.registrasi.Text = "registrasi";
            this.registrasi.UseVisualStyleBackColor = true;
            this.registrasi.Click += new System.EventHandler(this.registrasi_Click);
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(179, 51);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.PasswordChar = '*';
            this.textBoxPasword.Size = new System.Drawing.Size(129, 20);
            this.textBoxPasword.TabIndex = 19;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(179, 24);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(129, 20);
            this.textBoxEmail.TabIndex = 18;
            this.textBoxEmail.Text = "@";
            // 
            // pasword
            // 
            this.pasword.AutoSize = true;
            this.pasword.Location = new System.Drawing.Point(60, 58);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(47, 13);
            this.pasword.TabIndex = 17;
            this.pasword.Text = "pasword";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(60, 31);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(31, 13);
            this.email.TabIndex = 16;
            this.email.Text = "email";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(135, 123);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(97, 21);
            this.login.TabIndex = 23;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 228);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBoxKonfirmasiPasword);
            this.Controls.Add(this.konfi);
            this.Controls.Add(this.registrasi);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.email);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKonfirmasiPasword;
        private System.Windows.Forms.Label konfi;
        private System.Windows.Forms.Button registrasi;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label pasword;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Button login;
    }
}
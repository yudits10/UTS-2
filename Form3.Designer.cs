
namespace FormLoginSederhana
{
    partial class Form3
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
            this.Berhasil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Berhasil
            // 
            this.Berhasil.AutoSize = true;
            this.Berhasil.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Berhasil.Location = new System.Drawing.Point(0, 0);
            this.Berhasil.Name = "Berhasil";
            this.Berhasil.Size = new System.Drawing.Size(557, 48);
            this.Berhasil.TabIndex = 0;
            this.Berhasil.Text = "Selamat Anda Berhasil Login";
            this.Berhasil.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 203);
            this.Controls.Add(this.Berhasil);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Berhasil;
    }
}
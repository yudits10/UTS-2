using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLoginSederhana
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void konfi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrasi_Click(object sender, EventArgs e)
        {
            if(textBoxEmail.Text == "admin" && textBoxPasword.Text == "12345" && textBoxKonfirmasiPasword.Text == "12345")
            {
                Form3 F3 = new Form3();
                F3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email/Pasword yang anda masukan salah");
            }
        }
    }
}

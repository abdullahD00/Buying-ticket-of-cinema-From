using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemasalonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.URL = "C:\\Users\\abdul\\Desktop\\work\\denemeler\\C#\\sinemasalonu\\foto ve müzik\\1.mp3";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="abdullah" && textBox2.Text == "0000")
            {
                Form2 ikinci = new Form2();
                ikinci.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız,Lütfen Tekrar Deneyiniz...");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }
    }
}

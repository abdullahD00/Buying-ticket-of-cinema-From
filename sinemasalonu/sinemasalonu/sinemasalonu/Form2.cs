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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 ücüncü= new Form3();
            ücüncü.Show();
            this.Hide();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 yeni = new Form4();
            yeni.Show();
            this.Hide();

        }
    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            

        }

        private void vURGUNCULARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            label4.Text = vURGUNCULARToolStripMenuItem.Text;
            richTextBox1.Text = "ABD’nin Miami eyaletinde yaşayan iki yakın arkadaş Efraim Diveroli ve David Packouz, henüz çok genç olmalarında rağmen, ABD Ordu ihalelerine girme fırsatını yakalayan iki kahramanımızdır. Girdikleri işlerde güzel paralar kazanan ve gününe gün demeyen iki arkadaş, bir gün Afganistan Ordusu’na silah temin etmek zorunda kalır.";
            label5.Text = "7,1";
          
        }

        private void dEADPOOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            label4.Text = dEADPOOLToolStripMenuItem.Text;
            richTextBox1.Text = "Marvel Filmlerinin en sevilen ve en yeni süper kahramanları arasında bulunan Deadpool, kanser teşhisi konulan Wilson’un başından geçenleri izleyiciye aktarmaktadır. Marvel Evreni’nin anti kahramanı Deadpool’u komedi, bilim kurgu ve aksiyon türünde izleyebilirsiniz.";
            label5.Text = "8,0";
            
        }

        private void öLÜMYARIŞIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            label4.Text = öLÜMYARIŞIToolStripMenuItem.Text;
            richTextBox1.Text = "Jason Statham’ın baş rolde oynadığı bir başka aksiyon filmi ile karşınızdayız. En iyi aksiyon filmlerinin yıldız oyuncusu Jason Statham, azılı suçlularla dolu bir hapishaneye düşer. Bu hapishanenin yöneticileri, ceza evindeki mahkumları birbirlerini öldürmeye zorlayacak bir yarış alanı düzenler. Aksiyon’un hiç eksik olmadığı Death Race filminde heyecanın doruklarına ulaşacaksınız.";
            label5.Text = "6,4";
            
        }

        private void mALEFİCENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            label4.Text = mACERAToolStripMenuItem.Text;
            richTextBox1.Text = "Fantastik film izlemek isteyenler için 2014 yılında vizyona giren Maficvent oldukça etkileyici bir yapım. Filmin yönetmen koltuğunda Robert Stromberg, oyuncu kadrosunda ise Angelina Jolie, Elle Fanning ve Sharlto Copley yer almaktadır.";
            label5.Text = "7,0";
            
        }

        private void bENEFSANEYİMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            richTextBox1.Visible = true;
            label4.Text = bENEFSANEYİMToolStripMenuItem.Text;
            richTextBox1.Text = "Bilim kurgu filmleri arasında zombi filmleri oldukça önemli bir yere sahiptir. Zombi konulu bazı bilim kurgu filmleri tarihin tozlu sayfalarına gömülürken bazıları ise yıllar geçse de her zaman vitrinde görülmektedir. Ben Efsaneyim filmi de en iyi bilim kurgu film önerileri listesinde her zaman başı çeken filmlerden bir tanesidir. Konusu; Başrolde oynayan Robert Neville dünya üzerinde yer alan virüse bağışıklık kazanmıştır ve diğer insanları bulmaya çalışmaktadır. Aksiyon bilim kurgu filmleri arasında yer alan I am Legend kesinlikle izlenmesi gereken bir yapımdır.";
            label5.Text = "7,2";

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            richTextBox1.Visible = false;
            
        }
    }
}

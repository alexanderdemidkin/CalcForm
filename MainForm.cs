using System;
using System.Windows.Forms;

namespace app2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SimplCalc newForm = new SimplCalc();
            newForm.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KvUrCalc newForm = new KvUrCalc();
            newForm.Show();
        }
     
    }
}

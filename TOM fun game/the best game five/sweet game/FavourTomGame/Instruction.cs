using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FavourTomGame
{
    public partial class INSTRUCTION : Form
    {
        public INSTRUCTION()
        {
            InitializeComponent();
        }

        private void INSTRUCTION_Load(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@".\inst.txt");
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                counter++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MainMenu().Show();
            this.Hide();
        }
    }
}

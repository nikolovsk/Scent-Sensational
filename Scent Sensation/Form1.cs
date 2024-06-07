using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scent_Sensation
{
    public partial class Form1 : Form
    {
        List<Perfume> perfumesW;
        List<Perfume> perfumesM;
        Perfume p;

        public Form1()
        {
            InitializeComponent();

            perfumesW = new List<Perfume>();
            perfumesM = new List<Perfume>();


        }

        private void btnWomanCategory_Click(object sender, EventArgs e)
        {
            Form woman = new Woman_Perfumes();
            woman.ShowDialog();
        }

        private void btnMaleCategory_Click(object sender, EventArgs e)
        {
            Form male = new Male_Perfumes();
            male.ShowDialog();
        }

        private void updateTotalAmount()
        {
            toolStripStatusLabel1.Text = $"Износот на вашата нарачка изнесува: {perfumesW[2].Price.ToString()}";
        }
    }
}

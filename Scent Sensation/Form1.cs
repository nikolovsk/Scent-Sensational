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
            AddFemalePerfumesToList();
            AddMalePerfumesToList();
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

        private void AddFemalePerfumesToList()
        {
            p = new Perfume("ARMAF Club De Nuit Milestone EDP", 105, "Fruity, Fresh", "Out of stock", 4030);
            perfumesW.Add(p);
            p = new Perfume("CALVIN KLEIN Euphoria EDP", 100, "Sweet, Floral", "In stock", 3830);
            perfumesW.Add(p);
            p = new Perfume("ARMANI My Way EDP", 90, "Sweet, Floral", "In stock", 6880);
            perfumesW.Add(p);
            p = new Perfume("LANCOME La Vie Est Belle EDP", 100, "Sweet, Floral", "In stock", 7370);
            perfumesW.Add(p);
            p = new Perfume("ARMAF Club de Nuit Impériale EDP", 105, "Fruity, Sweet", "In Stock", 3690);
            perfumesW.Add(p);
        }

        private void AddMalePerfumesToList()
        {
            p = new Perfume("VERSACE Eros Eau de Parfum EDP", 100, "Fresh, Sweet", "In of stock", 4690);
            perfumesW.Add(p);
            p = new Perfume("MONTALE Arabians Tonka EDP", 100, "Oriental, Sweet", "In stock", 6480);
            perfumesW.Add(p);
            p = new Perfume("DOLCE & GABBANA The One for Men EDP", 100, "Woody, Spicy", "In stock", 4970);
            perfumesW.Add(p);
            p = new Perfume("AFNAN Turathi Blue EDP", 90, "Fresh, citrusy", "Out of stock", 5740);
            perfumesW.Add(p);
            p = new Perfume("YVES SAINT LAURENT Y for Men EDP", 100, "Fresh, Sweet", "In Stock", 6590);
            perfumesW.Add(p);
        }
    }
}

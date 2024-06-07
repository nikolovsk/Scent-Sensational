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
    public partial class Male_Perfumes : Form
    {
        List<Perfume> perfumesM;
        Perfume p;

        public Male_Perfumes()
        {
            InitializeComponent();

            perfumesM = new List<Perfume>();
            AddMalePerfumesToList();
            ShowPerfumes();
        }

        private void Male_Perfumes_Load(object sender, EventArgs e)
        {

        }

        private void AddMalePerfumesToList()
        {
            p = new Perfume("VERSACE Eros Eau de Parfum EDP", 100, "Fresh, Sweet", "In of stock", 4690);
            perfumesM.Add(p);
            p = new Perfume("MONTALE Arabians Tonka EDP", 100, "Oriental, Sweet", "In stock", 6480);
            perfumesM.Add(p);
            p = new Perfume("DOLCE & GABBANA The One for Men EDP", 100, "Woody, Spicy", "In stock", 4970);
            perfumesM.Add(p);
            p = new Perfume("AFNAN Turathi Blue EDP", 90, "Fresh, citrusy", "Out of stock", 5740);
            perfumesM.Add(p);
            p = new Perfume("YVES SAINT LAURENT Y for Men EDP", 100, "Fresh, Sweet", "In Stock", 6590);
            perfumesM.Add(p);
        }

        private void ShowPerfumes()
        {
            foreach (Perfume p in perfumesM)
            {
                lbPerfumesList.Text += p.ToString();
            }
        }
    }
}

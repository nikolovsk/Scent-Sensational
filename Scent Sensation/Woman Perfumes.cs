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
    public partial class Woman_Perfumes : Form
    {
        List<Perfume> perfumesW;
        Perfume p;

        public Woman_Perfumes()
        {
            InitializeComponent();

            perfumesW = new List<Perfume>();
            AddFemalePerfumesToList();
            ShowPerfumes();
        }

        private void Woman_Perfumes_Load(object sender, EventArgs e)
        {

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

        private void ShowPerfumes ()
        {
            foreach (Perfume p in perfumesW)
            {
                lbPerfumesList.Text += p.ToString();
            }
        }
    }
}

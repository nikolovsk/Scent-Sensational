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
    public partial class Add_to_cart : Form
    {
        public Add_to_cart()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Дали сте сигурни дека сакате производот да го додадете во кошничка?");
            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("Ви благодариме на довербата!");
            }


        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class Tela_Inicial : Form
    {
        public Tela_Inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro product = new cadastro();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login product = new Login();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

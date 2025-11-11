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
            Tela_Cadastro product = new Tela_Cadastro();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login_Tela product = new Login_Tela();
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

        private void Tela_Inicial_Load(object sender, EventArgs e)
        {

        }
    }
}

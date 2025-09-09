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
    public partial class Login_Tela : Form
    {
        public Login_Tela()
        {
            InitializeComponent();
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            Tela_Inicial central = new Tela_Inicial();
            this.Hide();
            central.ShowDialog();
            this.Show();
        }
    }
}

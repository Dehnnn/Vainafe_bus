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
    public partial class Paineladmin : Form
    {
        private int idUsuario;
        private string nomeUsuario;

        // 🔹 Este é o construtor
        public Paineladmin(int idUsuario, string nomeUsuario)
        {
            InitializeComponent(); // monta os componentes visuais

            // Guarda os valores para uso dentro da tela
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;


        }

        private void Paineladmin_Load(object sender, EventArgs e)
        {

        }

        private void btnviagens_Click(object sender, EventArgs e)
        {

        }
    }
}
    
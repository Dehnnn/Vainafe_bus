using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vainafe_bus
//{
//    public partial class Paineladmin : Form
//    {
//        private int idUsuario;
//        private string nomeUsuario;

//        // 🔹 Este é o construtor
//        public Paineladmin(int idUsuario, string nomeUsuario)
//        {
//            InitializeComponent(); // monta os componentes visuais

//            // Guarda os valores para uso dentro da tela
//            this.idUsuario = idUsuario;
//            this.nomeUsuario = nomeUsuario;


//        }

//        private void Paineladmin_Load(object sender, EventArgs e)
//        {

//        }

//        private void btnviagens_Click(object sender, EventArgs e)
//        {

//        }
//    }
//}

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

        // 🔹 Construtor do Painel do Administrador
        public Paineladmin(int idUsuario, string nomeUsuario)
        {
            InitializeComponent(); // Monta os componentes visuais

            // Guarda os valores para uso dentro da tela
            this.idUsuario = idUsuario;
            this.nomeUsuario = nomeUsuario;
        }

        private void Paineladmin_Load(object sender, EventArgs e)
        {
            // Opcional: Exibe o nome do admin no topo, se tiver um label
            // Exemplo:
            // lblBoasVindas.Text = $"Bem-vindo, {nomeUsuario}!";
        }

        // 🔹 Botão: Gerenciar Viagens
        private void btnviagens_Click(object sender, EventArgs e)
        {
            // Abre a tela de gerenciamento de viagens
            GerenciarViagens telaViagens = new GerenciarViagens();
            telaViagens.ShowDialog(); // Abre como janela modal (bloqueia a tela anterior até fechar)
        }

        // 🔹 Botão: Gerenciar Passagens (se quiser já deixar pronto)
        private void btnPassagens_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função 'Gerenciar Passagens' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 🔹 Botão: Gerenciar Usuários
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função 'Gerenciar Usuários' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 🔹 Botão: Relatórios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função 'Relatórios' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

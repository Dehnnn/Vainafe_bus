//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Vainafe_bus
//{
//    public partial class Paineladmin : Form
//    {
//        private int idUsuario;
//        private string nomeUsuario;

//        // 🔹 Construtor do Painel do Administrador
//        public Paineladmin(int idUsuario, string nomeUsuario)
//        {
//            InitializeComponent(); // Monta os componentes visuais

//            // Guarda os valores para uso dentro da tela
//            this.idUsuario = idUsuario;
//            this.nomeUsuario = nomeUsuario;
//        }

//        private void Paineladmin_Load(object sender, EventArgs e)
//        {
//            // Se houver label de boas-vindas, pode usar:
//            // lblBoasVindas.Text = $"Bem-vindo, {nomeUsuario}!";
//        }

//        // 🔹 Botão: Gerenciar Viagens
//        private void btnviagens_Click(object sender, EventArgs e)
//        {
//            GerenciarViagens telaViagens = new GerenciarViagens();
//            telaViagens.ShowDialog();
//        }

//        // 🔹 Botão: Gerenciar Passagens (FUNCIONAL COMPLETO)
//        private void btnPassagens_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                GerenciarPassagens telaPassagens = new GerenciarPassagens();
//                telaPassagens.ShowDialog();
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Erro ao abrir a tela de Passagens:\n" + ex.Message,
//                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }

//        // 🔹 Botão: Gerenciar Usuários
//        private void btnUsuarios_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Função 'Gerenciar Usuários' em desenvolvimento!",
//                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        // 🔹 Botão: Relatórios
//        private void btnRelatorios_Click(object sender, EventArgs e)
//        {
//            MessageBox.Show("Função 'Relatórios' em desenvolvimento!",
//                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        }

//        private void panelContent_Paint(object sender, PaintEventArgs e)
//        {

//        }

//        // Caso tenha outro botão duplicado no designer, esse aqui também chama o form
//        private void btnpassagens_Click_1(object sender, EventArgs e)
//        {
//            btnPassagens_Click(sender, e); // Reaproveita a função principal
//        }

//        private void btnusuarios_Click_1(object sender, EventArgs e)
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
            // Se houver label de boas-vindas, pode usar:
            // lblBoasVindas.Text = $"Bem-vindo, {nomeUsuario}!";
        }

        // 🔹 Botão: Gerenciar Viagens
        private void btnviagens_Click(object sender, EventArgs e)
        {
            GerenciarViagens telaViagens = new GerenciarViagens();
            telaViagens.ShowDialog();
        }

        // 🔹 Botão: Gerenciar Passagens (FUNCIONAL COMPLETO)
        private void btnPassagens_Click(object sender, EventArgs e)
        {
            try
            {
                GerenciarPassagens telaPassagens = new GerenciarPassagens();
                telaPassagens.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao abrir a tela de Passagens:\n" + ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Botão: Gerenciar Usuários (VERSÃO FUNCIONAL)
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            // Chama a função principal de gerenciamento de usuários
            btnusuarios_Click_1(sender, e);
        }

        // 🔹 Botão: Relatórios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Função 'Relatórios' em desenvolvimento!",
                "Em breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
            // Código de pintura do painel (se necessário)
        }

        // Caso tenha outro botão duplicado no designer, esse aqui também chama o form
        private void btnpassagens_Click_1(object sender, EventArgs e)
        {
            btnPassagens_Click(sender, e); // Reaproveita a função principal
        }

        // 🔹 BOTÃO PRINCIPAL: Gerenciar Usuários (FUNCIONAL COMPLETO)
        private void btnusuarios_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Cria e mostra a tela de gerenciamento de usuários
                GerenciarUsuarios telaUsuarios = new GerenciarUsuarios();

                // Opção 1: Usando ShowDialog() (mais simples - bloqueia até fechar)
                this.Hide(); // Esconde o painel admin temporariamente
                telaUsuarios.ShowDialog(); // Mostra a tela de usuários
                this.Show(); // Mostra o painel admin novamente quando fechar

                // Opção 2: Se quiser usar Show() (ambas janelas abertas)
                // telaUsuarios.Show();
                // this.WindowState = FormWindowState.Minimized; // Minimiza o painel
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o Gerenciamento de Usuários:\n{ex.Message}",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 🔹 Botão: Sair do Sistema
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Tem certeza que deseja sair do sistema?",
                "Confirmar Saída",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Application.Exit(); // Fecha toda a aplicação
                // Ou this.Close() para fechar apenas esta janela
            }
        }
    }
}
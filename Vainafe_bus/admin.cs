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

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        // Caso tenha outro botão duplicado no designer, esse aqui também chama o form
        private void btnpassagens_Click_1(object sender, EventArgs e)
        {
            btnPassagens_Click(sender, e); // Reaproveita a função principal
        }

        private void btnusuarios_Click_1(object sender, EventArgs e)
        {

        }
    }
}

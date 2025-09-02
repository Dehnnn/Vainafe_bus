using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vainafe_bus
{
    public partial class cadastro : Form
    {
        public cadastro()
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

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            string Nome = txbNome.Text;
            string Cpf = txbCpf.Text;
            string Telefone = txbTel.Text;
            string Nascimento = txbDataN.Text;
            string Email = txbEmail.Text;
            string Senha = txbSenha.Text;

            string conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO usuarios (Nome, Cpf, Telefone, Nascimento, Email, Senha) " +
                         "VALUES (@Nome ,@Cpf ,@Telefone ,@Nascimento ,@Email, @Senha)";

            using (SqlConnection conn = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", Nome);
                cmd.Parameters.AddWithValue("@Cpf", Cpf);
                cmd.Parameters.AddWithValue("@Telefone", Telefone);

                // validação de data
                DateTime dataNascimento;
                if (!DateTime.TryParse(Nascimento, out dataNascimento))
                {
                    MessageBox.Show("Data de nascimento inválida. Use o formato dd/MM/yyyy.");
                    return;
                }
                cmd.Parameters.AddWithValue("@Nascimento", dataNascimento);

                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Senha", Senha);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar: " + ex.Message);
                }
            }
        }
    }
}
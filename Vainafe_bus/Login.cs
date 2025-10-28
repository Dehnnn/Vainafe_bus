using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            // SUBSTITUA O CÓDIGO ANTIGO POR ESTE:

            // Validação de campos vazios
            if (string.IsNullOrWhiteSpace(textemail.Text))
            {
                MessageBox.Show("Por favor, preencha o e-mail.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textemail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textsenha.Text))
            {
                MessageBox.Show("Por favor, preencha a senha.", "Campo obrigatório",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textsenha.Focus();
                return;
            }

            // Criptografa a senha digitada para comparar com o banco
            string senhaCriptografada = CriptografarSenha(textsenha.Text);
            string email = textemail.Text.Trim();

            // Conexão com o banco
            string conexao = "Server=sqlexpress;Database=cj3027759dpr2;User Id=aluno;Password=aluno";
            string sql = "SELECT ID_USUARIO, NOME, TIPO_USUARIO FROM USUARIOS WHERE EMAIL = @Email AND SENHA = @Senha";

            using (SqlConnection conn = new SqlConnection(conexao))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Senha", senhaCriptografada);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Login encontrado!
                        int idUsuario = reader.GetInt32(0);
                        string nomeUsuario = reader.GetString(1);
                        string tipoUsuario = reader.GetString(2);

                        reader.Close();

                        // VERIFICAÇÃO DO TIPO DE USUÁRIO
                        if (tipoUsuario.ToLower() == "admin" || tipoUsuario.ToLower() == "administrador")
                        {
                            // É ADMINISTRADOR - abre painel admin
                            MessageBox.Show($"Bem-vindo, Administrador {nomeUsuario}!",
                                "Login Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // ⚠️ CRIE ESTE FORMULÁRIO ou use sua tela de admin
                            Paineladmin painelAdmin = new Paineladmin(idUsuario, nomeUsuario);
                            this.Hide();
                            painelAdmin.ShowDialog();
                            this.Show();
                        }
                        else if (tipoUsuario.ToLower() == "funcionario")
                        {
                            // É FUNCIONÁRIO - abre tela de vendas
                            MessageBox.Show($"Bem-vindo, {nomeUsuario}!",
                                "Login Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Se você tiver uma tela específica para funcionário, use aqui
                            Tela_Inicial telaFunc = new Tela_Inicial();
                            this.Hide();
                            telaFunc.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            // É CLIENTE - abre tela principal/inicial
                            MessageBox.Show($"Bem-vindo, {nomeUsuario}!",
                                "Login Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Tela_Inicial central = new Tela_Inicial();
                            this.Hide();
                            central.ShowDialog();
                            this.Show();
                        }

                        // Limpa os campos após login
                        LimparCampos();
                    }
                    else
                    {
                        // Login incorreto
                        MessageBox.Show("E-mail ou senha incorretos!",
                            "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textsenha.Clear();
                        textsenha.Focus();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao conectar com o banco de dados: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message,
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // MÉTODO PARA CRIPTOGRAFAR A SENHA (igual ao do cadastro)
        private string CriptografarSenha(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder resultado = new StringBuilder();
                foreach (byte b in hash)
                {
                    resultado.Append(b.ToString("x2"));
                }

                return resultado.ToString();
            }
        }

        // MÉTODO PARA LIMPAR OS CAMPOS
        private void LimparCampos()
        {
            textemail.Clear();
            textsenha.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

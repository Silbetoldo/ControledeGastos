using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//usando o mySQL
using MySql.Data.MySqlClient;
namespace ControlaGastos
{
    public partial class frmLogin : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
            "Persist Security info = False;" + //evitar que o comando não fique pedindo a senha a cada conexão
            "server = localhost;" + //onde é o banco de dados
            "database = contas;" + // nome do banco de dados
            "uid = root;" + // nome do usuario
            "pwd ="  // senha do usuario
            );

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da Aplicação?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text != "" && txtPass.Text != "")
            {
                try
                {
                    mConn.Open();

                    if(mConn.State == ConnectionState.Open)
                    {
                        MySqlCommand comandoSQL = mConn.CreateCommand();
                        comandoSQL.CommandText = "SELECT * FROM login WHERE user=@usuario AND senha=@senha ";
                        comandoSQL.Parameters.AddWithValue("@usuario", txtUser.Text);
                        comandoSQL.Parameters.AddWithValue("@senha", txtPass.Text);

                        comandoSQL.Connection = mConn;

                        MySqlDataReader dadoslogin = comandoSQL.ExecuteReader();

                        if (dadoslogin.HasRows)
                        {
                            //esconde a tela de login
                            this.TopMost = false;
                            this.Hide();
                           
                            Form1 frmCad = new Form1();
                            frmCad.ShowDialog();

                            //mostra a tela de login = logout
                            this.Show();
                            txtUser.Clear();
                            txtPass.Clear();
                            txtUser.Focus();
                        }
                        else
                        {
                            MessageBox.Show(
                                                                    "Usuario e senha não confere!",
                                                                    "Informação",
                                                                    MessageBoxButtons.OK,
                                                                    MessageBoxIcon.Information);
                            txtUser.Clear();
                            txtPass.Clear();
                            txtUser.Focus();
                        }
                    }
                    mConn.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                                      "Erro ao conectar o banco de dados!\n\n\n" +erro,
                                       "Informação",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                }
          
            }
            else
            {
                MessageBox.Show(
                    "Prencha todos os campos!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {   //esconde a tela de login
            this.TopMost = false;
            this.Hide();
            //chama o formulario Cadastro de Usuarios
            FrmUsuario frmUser= new FrmUsuario();
            frmUser.ShowDialog();
            
            
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

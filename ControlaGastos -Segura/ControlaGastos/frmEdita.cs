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
using System.Globalization;

namespace ControlaGastos
{
    public partial class frmEdita : Form
    {
        private MySqlConnection mConn = new MySqlConnection(
           "Persist Security info = False;" + //evitar que o comando
           "server = localhost;" + //onde é o banco de dados
           "database = contas;" + // nome do banco de dados
           "uid = root ;" + // nome do usuario
           "pwd = "  // senha do usuario
           );
        string valorID;
        //metodo construtor
        public frmEdita(string ID)
        {
            InitializeComponent();
            valorID = ID;
            try
            {
                mConn.Open();
                if (mConn.State == ConnectionState.Open)
                {
                    MySqlCommand comandoSQL = mConn.CreateCommand();
                    comandoSQL.CommandText = "SELECT * FROM contas WHERE idContas=" + valorID;
                    comandoSQL.Connection = mConn;

                    MySqlDataReader dadosclientes = comandoSQL.ExecuteReader();
                    dadosclientes.Read();

                    txtConta.Text = dadosclientes["compra"].ToString();
                    cmbTipo.Text = dadosclientes["tipo"].ToString();
                    txtValor.Text = dadosclientes["valor"].ToString();
                    cmbPago.Text = dadosclientes["pago"].ToString();

                    mConn.Close();
                }

            }
            catch (Exception erro)
            {

                MessageBox.Show("Erro na conexão com o banco \n\n\n " + erro.ToString());

            }

        }
        private void frmEdita_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frmum = new Form1();
            frmum.ShowDialog();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja atualizar o registro atual?",
                "Informação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Atualiza o registro no Banco de dados
                try
                {
                    mConn.Open();

                    if (mConn.State == ConnectionState.Open)
                    {
                        MySqlCommand comandoSQL = mConn.CreateCommand();
                        // indicando a conexão

                        //tratamento de valor ponto para virgula
                        string valor = Convert.ToDecimal(txtValor.Text).ToString("0.00", CultureInfo.InvariantCulture).ToString();
                        comandoSQL.Connection = mConn;

                        // criando o comando UPDATE
                        comandoSQL.CommandText =
                            "UPDATE Contas SET " +
                            "compra=?compra, tipo=?tipo, valor=?valor, " +
                            "pago=?pago " +
                            "WHERE idContas=?idContas";

                        comandoSQL.Parameters.Add("?idContas", MySqlDbType.VarChar).Value = valorID;
                        comandoSQL.Parameters.Add("?compra", MySqlDbType.VarChar).Value = txtConta.Text;
                        comandoSQL.Parameters.Add("?tipo", MySqlDbType.VarChar).Value = cmbTipo.Text;
                        comandoSQL.Parameters.Add("?valor", MySqlDbType.VarChar).Value = valor;
                        comandoSQL.Parameters.Add("?pago", MySqlDbType.VarChar).Value = cmbPago.Text;
                        ;

                        //Executando o comando SQL
                        comandoSQL.ExecuteNonQuery();

                        //fechar a conexão
                        mConn.Close();

                        //mensagem que está tudo certo
                        MessageBox.Show(
                                    "O registro foi atualizado com sucesso.",
                                    "Informação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                        //fecha o formulário após a confirmação da leitura
                        this.Close();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                                    "Erro na atualização dos dados.\n\n\n" + erro.ToString(),
                                    "Informação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                "As alterações foram canceladas!",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }





    


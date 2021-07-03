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
    public partial class Frmexcluir : Form
    {

        //criando uma conexão
        private MySqlConnection mConn = new MySqlConnection(
            "Persist Security info = False;" + //evitar que o comando não fique pedindo a senha a cada conexão
            "server = localhost;" + //onde é o banco de dados
            "database = contas;" + // nome do banco de dados
            "uid = root;" + // nome do usuario
            "pwd ="  // senha do usuario
            );
        string valorID;

        public Frmexcluir(string ID)
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
                    MySqlDataReader dadosClientes = comandoSQL.ExecuteReader();
                    dadosClientes.Read();
                    txtConta.Text = dadosClientes["compra"].ToString();
                    cmbTipo.Text = dadosClientes["tipo"].ToString();
                    txtValor.Text = dadosClientes["valor"].ToString();
                    cmbPago.Text = dadosClientes["pago"].ToString();


                    mConn.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão com o banco!\n\n\n" + erro.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frmum = new Form1();
            frmum.ShowDialog();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(
                "Deseja realmente excluir esse registro?",
                "Informação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Error) == DialogResult.Yes)
            {
                try
                {
                    mConn.Open();

                    if (mConn.State == ConnectionState.Open)
                    {
                        MySqlCommand comandoSQL = mConn.CreateCommand();

                        comandoSQL.Connection = mConn;

                        comandoSQL.CommandText = "DELETE FROM contas WHERE idContas=?id";

                        comandoSQL.Parameters.Add("id", MySqlDbType.VarChar).Value = valorID;

                        comandoSQL.ExecuteNonQuery();

                        mConn.Close();

                        MessageBox.Show(
                            "O registro foi excluído com sucesso.",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        this.Close();
                    }

                }
                catch (Exception erro)
                {
                    MessageBox.Show(
                        "Erro ao tentar acessar o banco de dados!\n\n\n" + erro,
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                "A exclusão foi cancelada!",
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }

        }
    }
    }


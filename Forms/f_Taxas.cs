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

namespace SisRH_Desktop
{
    public partial class f_Taxas : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private string url = @"Data Source=DESKTOP-DNIRGUH\SQLEXPRESS;Initial Catalog=BD_Funcionario;"
        + "Integrated Security=true;";

        public f_Taxas()
        {
            InitializeComponent();
        }

        private void labelFuncionario_Click(object sender, EventArgs e)
        {

        }

        private void textFuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTaxa_Click(object sender, EventArgs e)
        {

        }

        private void textTaxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelValor_Click(object sender, EventArgs e)
        {

        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelTipo_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxDesconto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxAcrescimo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            string nomeUsuario = textFuncionario.Text;

            //Verificar se o usuário existe no banco de dados
            if (UsuarioExiste(nomeUsuario))
            {
                bool isTaxa = checkBoxDesconto.Checked;
                bool isAcrescimo = checkBoxAcrescimo.Checked;

                if (isTaxa || isAcrescimo)
                {
                    double valor = Convert.ToDouble(textValor.Text);
                    double salarioAtual = ObterSalarioAtual(nomeUsuario);
                    double novoSalario = 0;

                    if (isTaxa)
                    {
                        novoSalario = salarioAtual - (salarioAtual * (valor / 100.0));
                    }
                    else if (isAcrescimo)
                    {
                        novoSalario = salarioAtual + (salarioAtual * (valor / 100.0));
                    }

                    AtualizarSalarioNoBancoDeDados(nomeUsuario, novoSalario);

                    MessageBox.Show("Taxa ou acréscimo aplicado com sucesso!");
                }
                else
                {
                    MessageBox.Show("Selecione se é uma taxa ou um acréscimo.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado no banco de dados.");
            }
        }

        //verificar se o usuário existe no banco de dados
        private bool UsuarioExiste(string nomeUsuario)
        {
            bool usuarioExiste = false;

            try
            {
                con = new SqlConnection(url);
                string sql = "SELECT 1 FROM TB_funcionario WHERE nome LIKE @nome AND ativo = 1";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + nomeUsuario + "%");

                con.Open();

                object result = cmd.ExecuteScalar();

                // Se result não for nulo, significa que o usuário existe
                usuarioExiste = (result != null);
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return usuarioExiste;
        }

        // obter o salário atual do usuário no banco de dados
        private double ObterSalarioAtual(string nomeUsuario)
        {
            double salarioAtual = 0;

            try
            {
                con = new SqlConnection(url);
                string sql = "SELECT salario FROM TB_funcionario WHERE nome LIKE @nome AND ativo = 1";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + nomeUsuario + "%");

                con.Open();
                object result = cmd.ExecuteScalar();

                // Se result não for nulo, atribui o valor à variável salarioAtual
                if (result != null && result != DBNull.Value)
                {
                    salarioAtual = Convert.ToDouble(result);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }

            return salarioAtual;
        }

        //atualizar o salário no banco de dados
        private void AtualizarSalarioNoBancoDeDados(string nomeUsuario, double novoSalario)
        {
            try
            {
                con = new SqlConnection(url);
                string sql = "UPDATE TB_funcionario SET salario = @novoSalario WHERE nome LIKE @nome AND ativo = 1";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", "%" + nomeUsuario + "%");
                cmd.Parameters.AddWithValue("@novoSalario", novoSalario);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

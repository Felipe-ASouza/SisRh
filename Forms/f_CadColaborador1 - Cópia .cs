﻿using SisRH_Desktop.Enum;
using SisRH_Desktop.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisRH_Desktop.Controller;

namespace SisRH_Desktop
{
    public partial class f_CadColaborador1 : Form
    {
        public f_CadColaborador1()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            EnumAcessos Acesso = EnumAcessos.Colaborador; 
            EnumAtivo Ativo = EnumAtivo.Sim;
            int horasMensais = int.Parse(txtHoras.Text);
            double VR = double.Parse(txtVR.Text);
            double VT = double.Parse(txtVT.Text);
            double salarioBruto = double.Parse(txtSalarioBruto.Text);

            if (checkBoxAcesso.Checked)
            {
                Acesso = EnumAcessos.AdministradorRH;
            }                         
            

           FuncionarioModel funcionarioEnt = new FuncionarioModel(txtNome.Text,txtEndereco.Text,txtEmail.Text,
                                                                   txtTelefone.Text,dtNascimento.MaxDate, dtContratacao.MaxDate,
                                                                   horasMensais,VT,VR,salarioBruto,Acesso, txtSenha.Text, 
                                                                   Ativo, txtCargo.Text);

            try
            {
                ControllerFuncionario contFuncionario = new ControllerFuncionario();
                FuncionarioModel funcionarioSaida = contFuncionario.Inserir(funcionarioEnt);
                limparcampos();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                MessageBox.Show("INSERIDO");
               
            }




        }


        private void limparcampos()
        {
            txtNome.Text = string.Empty;
            txtCargo.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            dtNascimento.Text = string.Empty;
            dtContratacao.Text = string.Empty;
            txtHoras.Text = string.Empty;
            txtSalarioBruto.Text = string.Empty;
            txtSalarioBruto.Text = string.Empty;
            txtVR.Text = string.Empty;
            txtVT.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Redirect(this, new f_ListarColab());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void f_CadColaborador1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
      

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

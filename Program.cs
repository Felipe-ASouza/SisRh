﻿using SisRH_Desktop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tela_Login_Sis_RH;

namespace SisRH_Desktop
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }
        static public void Redirect(Form origem, Form destino)
        {
            origem.Hide();
            destino.Closed += (s, arg) => origem.Close();
            destino.Show();
        }
    }

}

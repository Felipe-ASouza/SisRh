using SisRH_Desktop.Enum;
using SisRH_Desktop.Model;
using SisRH_Desktop.Models.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Controller
{
    public class ControllerFuncionario
    {
        DaoFuncionario DaoFuncionario = null;
       public FuncionarioModel FuncionarioUpdate;


        public ControllerFuncionario()
        {

        }



        public FuncionarioModel Inserir (FuncionarioModel funEntrada)
        {
            DaoFuncionario = new DaoFuncionario();
            FuncionarioModel funSaida = DaoFuncionario.Inserir(funEntrada);
            return funSaida;
        }

        public List<FuncionarioModel> ListarTodos(FuncionarioModel funcEntrada)
        {
            DaoFuncionario = new DaoFuncionario();
            List<FuncionarioModel> listaSaida = DaoFuncionario.ListarTodos(funcEntrada);
            return listaSaida;
        }

        public List<FuncionarioModel> ListarPorNome(FuncionarioModel funcEntrada)
        {
            DaoFuncionario = new DaoFuncionario();
            List<FuncionarioModel> listaSaida = DaoFuncionario.ListarPorNome(funcEntrada);
            return listaSaida;
        }

        public FuncionarioModel CarregarTodosOsDados(int registro)
        {
            DaoFuncionario = new DaoFuncionario();
            FuncionarioModel funsaida = DaoFuncionario.CarregarTodosOsDadosFuncionarios(registro);
           
            //FuncionarioUpdate = new FuncionarioModel(funsaida.registro, funsaida.nome,
            //            funsaida.endereco, funsaida.email, funsaida.telefone,
            //            funsaida.data_nascimento, funsaida.data_contratacao, funsaida.horas_mensais,
            //            funsaida.valor_vt, funsaida.valor_vr, funsaida.salario_bruto,
            //            funsaida.nivel_acesso, funsaida.senha, funsaida.ativo,
            //            funsaida.cargo);


            return funsaida;


        }

        public FuncionarioModel Atualizar (FuncionarioModel funEntrada)
        {
            DaoFuncionario = new DaoFuncionario ();
            FuncionarioModel funSaida = DaoFuncionario.Atualizar(funEntrada);
            return funSaida;
        }
         
        public FuncionarioModel Desativar (FuncionarioModel funEntrada)
        {

            DaoFuncionario =new DaoFuncionario();
            FuncionarioModel funSaida = DaoFuncionario.Desativar(funEntrada);
            return funSaida;

        }

        public bool login(FuncionarioModel funEntrada)
        {
            //bool validar = false;

            DaoFuncionario = new DaoFuncionario();
            FuncionarioModel funSaida = DaoFuncionario.Login(funEntrada);
            
            if (funSaida != null )
            {
                int ativo = (int)funSaida.ativo;
                int acesso = (int)funSaida.nivel_acesso;
                if (funSaida.email == funEntrada.email && funSaida.senha == funEntrada.senha && ativo == 1 && acesso == 1 )
                {
                    return true;
                }
            }


            return false;

        }

        public FuncionarioModel CarregarDadosLogado(FuncionarioModel funcEntrada)
        {
            DaoFuncionario = new DaoFuncionario();
            FuncionarioModel funSaida = DaoFuncionario.CarregarDadosLogados(funcEntrada);
            return funSaida;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisRH_Desktop.Model
{
    public class TaxaModel
    {
        int id { get; set; }
        string nome { get; set; }
        double valor_base { get; set; }
        int desconto_acresimo { get; set; }
        int ativo { get; set; }
        HoleriteModel holerite { get; set; }
        FuncionarioModel funcionario { get; set; }
    }
}

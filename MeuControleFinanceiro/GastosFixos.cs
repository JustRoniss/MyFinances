using System.Net;

namespace MeuControleFinanceiro;

public class GastosFixos : Gastos
{
    // implementar excluir dados fisicos
    // criar os geters e setters
    public GastosFixos(string descricao, double valor, string data) : base(descricao, valor, data)
    {
    }


}
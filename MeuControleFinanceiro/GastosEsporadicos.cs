namespace MeuControleFinanceiro;

public class GastosEsporadicos : Gastos
{
    public GastosEsporadicos(string descricao, double valor, string data) : base(descricao, valor, data)
    {
        this.Descricao = descricao;
        this.Valor = valor;
        this.Data = data;

    }
    
}
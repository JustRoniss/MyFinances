namespace MeuControleFinanceiro;

public abstract class Gastos
{
    protected Gastos(string descricao, double valor, string data)
    {
        Descricao = descricao;
        Valor = valor;
        Data = data;
    }

    public string Descricao { get; set; }
    public double Valor { get; set; }
    public string Data { get; set; }
}
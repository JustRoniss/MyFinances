namespace Menus;

public static class Menus
{
    public static void MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Olá");
        Console.WriteLine("1) Ver minhas informações");
        Console.WriteLine("2) Registrar gasto");
        
        Console.Write("Opção desejada: ");
        int inputMenuPrincipal = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

        switch (inputMenuPrincipal)
        {
            case 1 :
                Console.WriteLine("Ainda não implementado");
                break;
            
            case 2 :
                MenuRegistrarGastos();
                break;
        }
        
    }
    
    public static void MenuCapturarDadosFinanceiros()
    {
        Console.WriteLine("Bem-Vindo");
        Console.WriteLine("Por favor, preencha o formulário a seguir: ");
        
        Console.Write("Qual seu salário liquido: ");
        float salario = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        //Financeiro.SetSalarioLiquido(salario);
        
        Console.Write("Qual valor do seu vale-refeição: ");
        float valeReifeicao = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        //Financeiro.SetValeRefeicao(valeReifeicao);
        
        Console.Write("Qual valor do seu auxilio home-office: ");
        float auxilioHomeOffice = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        //Financeiro.SetAuxilioHomeOffice(auxilioHomeOffice);
        
        
        Console.Write("Valor renda extra: ");
        float rendaExtra = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        //Financeiro.SetRendaExtra(rendaExtra);

        var dadosFinanceiros = new MeuControleFinanceiro.EntradaFinanceira();
        dadosFinanceiros.SetSalarioLiquido(salario);
        dadosFinanceiros.SetValeRefeicao(valeReifeicao);
        dadosFinanceiros.SetAuxilioHomeOffice(auxilioHomeOffice);
        dadosFinanceiros.SetRendaExtra(rendaExtra);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\nObrigado!!");
        System.Console.Clear();
        MeuControleFinanceiro.Program.Main();
        
        // try
        // {
        //     Financeiro.PersistirDadosArquivos();
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine(e);
        //     throw;
        // }
    }

    public static void MenuRegistrarGastos()
    {
        Console.Write("Valor: ");
        float valorGasto = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Console.Write("Descricao: ");
        string descricao = Console.ReadLine() ?? throw new InvalidOperationException();
        Console.Write("Data: ");
        string data = Console.ReadLine() ?? string.Empty;

        var registroGastosEsporadicos = new MeuControleFinanceiro.GastosEsporadicos(descricao, valorGasto, data);
        System.Threading.Thread.Sleep(3000);
        Console.WriteLine("\nObrigado!!");
        
        
        



    }
}
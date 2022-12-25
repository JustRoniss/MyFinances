// See https://aka.ms/new-console-template for more information

namespace MeuControleFinanceiro;

public class Program
{
    public const string filePath =
        @"/home/justronis/Developer/Projects/MeuControleFinanceiro/MeuControleFinanceiro/MeuControleFinanceiro/dados.txt";
    static void Main()
    {
        
        if (File.Exists(filePath))
        {
            MenuPrincipal();
        }
        else
        {
            
            File.Create(filePath).Close();
            MenuCapturarDados();
        }
        

    }

    static void MenuCapturarDados()
    {
        Console.WriteLine("Bem-Vindo");
        Console.WriteLine("Por favor, preencha o formulário a seguir: ");
        
        Console.Write("Qual seu salário liquido: ");
        float salario = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Financeiro.SetSalarioLiquido(salario);
        
        Console.Write("Qual valor do seu vale-refeição: ");
        float valeReifeicao = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Financeiro.SetValeRefeicao(valeReifeicao);
        
        Console.Write("Qual valor do seu auxilio home-office: ");
        float auxilioHomeOffice = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Financeiro.SetAuxilioHomeOffice(auxilioHomeOffice);
        
        
        Console.Write("Valor renda extra: ");
        float rendaExtra = float.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        Financeiro.SetRendaExtra(rendaExtra);
        Console.WriteLine("\nObrigado!!");
        
        System.Threading.Thread.Sleep(3000);

        try
        {
            Financeiro.PersistirDadosArquivos();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        
        System.Console.Clear();
        Program.Main();
        
    }

    static void MenuPrincipal()
    {
        Console.Clear();
        Console.WriteLine("Olá");
        Console.WriteLine("1) Ver minhas informações");
        Console.WriteLine("2) Registrar gasto");
        
    }
}
// See https://aka.ms/new-console-template for more information

namespace MeuControleFinanceiro;

public class Program
{
    public const string filePath =
        @"/home/justronis/Developer/Projects/MeuControleFinanceiro/MeuControleFinanceiro/MeuControleFinanceiro/dados.txt";
    public static void Main()
    {
        
        if (File.Exists(filePath))
        {
            Menus.Menus.MenuPrincipal();
        }
        else
        {
            Data.Data.ConnectionMySql();
            Console.WriteLine("Conexão realiza com sucesso");

        }
        

    }

    


}
using System.Diagnostics;

namespace MeuControleFinanceiro;

public static class Financeiro
{
    private static float SalarioLiquido { get; set; }
    private static float ValeRefeicao { get; set; }
    private static float AuxilioHomeOffice { get; set; }
    private static float RendaExtra { get; set; }

    public static float GetSalarioLiquido()
    {
        return SalarioLiquido;
    }

    public static void SetSalarioLiquido(float salarioLiquido)
    {
        SalarioLiquido = salarioLiquido;
    }
    
    public static float GetValeRefeicao()
    {
        return ValeRefeicao;
    }

    public static void SetValeRefeicao(float valeRefeicao)
    {
        ValeRefeicao = valeRefeicao;
    }
    
    public static float GetAuxilioHomeOffice()
    {
        return AuxilioHomeOffice;
    }

    public static void SetAuxilioHomeOffice(float auxilioHomeOffice)
    {
        AuxilioHomeOffice = auxilioHomeOffice;
    }
    
    public static float GetRendaExtra()
    {
        return RendaExtra;
    }

    public static void SetRendaExtra(float rendaExtra)
    {
        RendaExtra = rendaExtra;
    }

    public static void PersistirDadosArquivos()
    {
        
        using var file = File.AppendText(Program.filePath);
        file.WriteLine(GetSalarioLiquido());
        file.WriteLine(GetValeRefeicao());
        file.WriteLine(GetAuxilioHomeOffice());
        file.WriteLine(GetRendaExtra());
        
    }

}


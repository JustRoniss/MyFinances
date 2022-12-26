using System.Diagnostics;

namespace MeuControleFinanceiro;

public class EntradaFinanceira
{
    private float SalarioLiquido { get; set; }
    private float ValeRefeicao { get; set; }
    private float AuxilioHomeOffice { get; set; }
    private float RendaExtra { get; set; }

    public float GetSalarioLiquido()
    {
        return SalarioLiquido;
    }

    public void SetSalarioLiquido(float salarioLiquido)
    {
        SalarioLiquido = salarioLiquido;
    }
    
    public float GetValeRefeicao()
    {
        return ValeRefeicao;
    }

    public void SetValeRefeicao(float valeRefeicao)
    {
        ValeRefeicao = valeRefeicao;
    }
    
    public float GetAuxilioHomeOffice()
    {
        return AuxilioHomeOffice;
    }

    public void SetAuxilioHomeOffice(float auxilioHomeOffice)
    {
        AuxilioHomeOffice = auxilioHomeOffice;
    }
    
    public float GetRendaExtra()
    {
        return RendaExtra;
    }

    public void SetRendaExtra(float rendaExtra)
    {
        RendaExtra = rendaExtra;
    }

    // public void PersistirDadosArquivos()
    // {
    //     
    //     using var file = File.AppendText(Program.filePath);
    //     file.WriteLine(GetSalarioLiquido());
    //     file.WriteLine(GetValeRefeicao());
    //     file.WriteLine(GetAuxilioHomeOffice());
    //     file.WriteLine(GetRendaExtra());
    //     
    // }

}


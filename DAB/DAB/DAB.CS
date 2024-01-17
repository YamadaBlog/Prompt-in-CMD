using ProgramThree;

namespace ProgramFour;

public class Dab
{
    // Nombre de DAB en circulation
    public uint uid { get; }
    public static uint dabCount {  get; set; }

    // La banque associée au DAB
    public readonly Bank bank;

    public Dab(Bank bank)
    {
        this.bank = bank;
        dabCount ++;
    }
}
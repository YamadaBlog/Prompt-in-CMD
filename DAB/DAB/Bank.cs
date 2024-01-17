using ProgramFour;

namespace ProgramThree;
public class Bank
{
    public string Name { get; }
    // L'identifiant unique du DAB
    public uint Uid { get; }

    public Bank(string name)
    {
        Uid = 0;
        Name = name;
    }

}

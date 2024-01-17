using ProgramFour;
using ProgramThree;

namespace ProgramFive;

public class Method
{
    public static string GetString(string text)
    {

        while (text.Length == 0)
        {
            Console.WriteLine("texte :");
            text = Console.ReadLine();
        }
        return text;
    }

    public static uint GetUint(string text)
    {
        int result;
        while(!int.TryParse(text, out result)) { 

                Console.WriteLine("texte :");
                text = Console.ReadLine();
        }
        return (uint)result;
    }
    public static Dab GetDab() {
        Console.WriteLine("texte :");
        string text = Console.ReadLine();
        int result;
        while (!int.TryParse(text, out result))
        {
            Console.WriteLine("texte :");
            text = Console.ReadLine();
        }

        while (result != Dab.uid)
        {
            
        }
        return Dab.uid;
    }
}

using ProgramTwo;
using ProgramThree;
using ProgramFour;
using ProgramFive;

namespace Bases
{
    class ProgramOne
    {
        static void Main(string[] args)
        {
            // Appel de la fonction HelloName
            HelloName("Thomas");

            // Appel de la fonction PrintFibo
            PrintFibo(6);

            // Appel de la fonction ItoaBase
            string binary = ItoaBase(20, BASE.BINARY);
            Console.WriteLine(binary);

            // Création d'un objet User
            User user = new User("Junior");
            // Affichage du nom de l'utilisateur
            Console.WriteLine("user.Name is equal to: " + user.Name);
            // Pre création de la fonctionnalité object 2.2.3
            Console.WriteLine("DAB.dabCount is equal to: " + Dab.dabCount);
            // Création d'un objet Bank
            Bank bank = new Bank("AIO");
            // Affichage du nom de la banque
            Console.WriteLine("bank.Name is equal to: " + bank.Name);

            // Program4
            Dab dab = new Dab(bank);

            Console.WriteLine("dab.bank.Name is equal to: " + dab.bank.Name);
            Console.WriteLine("dab.bank.Uid is equal to: " + dab.bank.Uid);
            Console.WriteLine("DAB.dabCount is equal to: " + Dab.dabCount);

            //Program5
            string str = Method.GetString("hi");
            Console.WriteLine(str);

            uint prompt = Method.GetUint("yop");
            Console.WriteLine(prompt);

            //Program6
            
        }

        public static void HelloName(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        public static void PrintFibo(uint n)
        {
            int a = 0;
            int b = 1;
            Console.WriteLine(0);
            for (int i = 0; i < n; i++){
                Console.WriteLine($"// {a}");
                int temp = a;
                a = b;
                b = temp + b;
            }
        }

        public enum BASE
        {
            BINARY = 2,
            OCTAL = 8,
            DECIMAL = 10
        };

        public static string ItoaBase(uint n, BASE b)
        {
            int num = (int)b;
            string binary = Convert.ToString(n, num);
            return binary;
        }
    }

}
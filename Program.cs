static void miejscaZerowe()
{
    Console.WriteLine("Starting program that calculate the zero of the function ");
    double jsa;
    double jsb;
    double jsc;
    double jsx1, jsx2, jsdelta;
    char jsinput;
    do
    {
        Console.WriteLine("\nInsert a");
        jsa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insert b");
        jsb = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insert c");
        jsc = Convert.ToDouble(Console.ReadLine());
        if (jsa != 0)
        {
            jsdelta = Math.Pow(jsb, 2) - 4 * jsa * jsc;
            if (jsdelta < 0)
            {
                Console.WriteLine("No root in function");
            }
            else if (jsdelta == 0)
            {
                jsx1 = -jsb / (2 * jsa);
                Console.WriteLine("One root, that equals {0}", jsx1);
            }
            else
            {
                jsx1 = (-jsb + Math.Sqrt(jsdelta)) / (2 * jsa);
                jsx2 = (-jsb - Math.Sqrt(jsdelta)) / (2 * jsa);
                Console.WriteLine("Two roots, x1 {0} | x2 {1}", jsx1, jsx2);
            }
        }

        else if (jsb != 0)
        {
            jsx1 = -jsc / jsb;
            Console.WriteLine("Linear function - one root, that equals {0}", jsx1);

        }

        else if (jsc != 0)
        {
            Console.WriteLine("No roots in function");
        }

        else
        {
            Console.WriteLine("function y = 0, unlimited numbers of answers");
        }

        do
        {
            Console.WriteLine("\nIf you want to check other function type 'y', else type 'n'");
            jsinput = Console.ReadLine()[0];
            if (jsinput == 'N' || jsinput == 'n' || jsinput == 'Y' || jsinput == 'y') break;
        } while (true);
        if (jsinput == 'N' || jsinput == 'n') break;
        else continue;
    } while (true);
    Console.WriteLine("\nProjekt by Jakub \"xLoriki\" Soloducha");
}
miejscaZerowe();
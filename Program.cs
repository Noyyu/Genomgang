namespace Genomgång
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bob = 1;
            int linus = 2;
            int z = MathRoom(bob, linus);
            string name1 = "Roger";
            string name2 = "Bella";
            string name3 = "Pelle";
            string namn4 = "Mjölk";

            Welcome(name1);
            Welcome(name2);
            Welcome(name3);
            Welcome(namn4);


            z = bob + linus;
        }

        static void Welcome(string namn)
        {
            Console.WriteLine("----------");
            Console.WriteLine("----------");
            Console.WriteLine(namn);
            Console.WriteLine("----------");
            Console.WriteLine("----------");
        }
        static int MathRoom(int kuk, int röv)
        {
            return kuk + röv;
        }
    }
}

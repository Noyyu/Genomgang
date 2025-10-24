namespace Genomgång
{
    internal class Program
    {
        static void Main(string[] args) //det är på scenen ALLT "HÄNDER"
        {

            int x = 7;
            int y= 17;
            int z = Mathroom(x,y);


            int glassAmount = Glas()


            string name1 = "pelle";
            string name2 = "nikki";

            Welcome(name1);



        }

        // "VOID" är som ett soprum: du ger info= sopor till soprummet. Den tackar dig och du GET THE FUCK OUT. finished!
        static void Welcome(string name) // void visar bara den returnerar inget värde. 
        {
            Console.WriteLine($"Welcome {name} ");
        }


        //void är: vad kan hända på scen utan att visas på scen? Denna returnerar ingenting
        static int Mathroom(int p, int ö) //detta rummet (metoden) behöver eget papper/egna resurser för uträkning:pappper/penna/calculator
        {
            // regardless of using int/bool/string/etc variables--> its enough to declare them within the mehtod room ir "Mathroom" method.
            //the 'int' below is the 'order' 
            int z = p + ö;
            return z;
        }

        static int Glas()
        {
            int basket1 = 5;
            int basket2 = 5;
            int glasses = 0;


            //basket1 + basket2
            // vi skapade 'glasses' för att spara RESULTATET på beräkningen för 'basket1' och 'basket2'.
            // och som en SHORTCUT använder vi/ropar vi på 'Mathroom' och säger att addera basket1 och basket2
            // och RETURN = GLASSES -> ger tillbaka svaret (som en liten flyttbar calculator-ish)
            glasses = Mathroom(basket1 , basket2);
            return glasses;


        }




    }
}

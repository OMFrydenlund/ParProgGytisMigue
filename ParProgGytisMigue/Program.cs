namespace ParProgGytisMigue
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Deltaker gytis = new Deltaker();
            gytis.Navn = "Gytis";
            gytis.Age = 24;
            gytis.Hobby = "Bokser";

            Deltaker miguel = new Deltaker();
            miguel.Navn = "Miguel";
            miguel.Age = 105;
            miguel.Hobby = "Fisker";

            gytis.PresenterDeltaker();
            miguel.PresenterDeltaker();

            Console.ReadLine();
          
        }
    }
}

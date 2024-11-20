namespace ParProgGytisMigue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hvorMangeFolk = 0;

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

            List<Deltaker> participants = new List<Deltaker>();
            participants.Add(miguel);
            participants.Add(gytis);

            foreach (Deltaker d in participants)
            {
                hvorMangeFolk++;
            }
            Console.ReadLine();
          
        }
    }
}

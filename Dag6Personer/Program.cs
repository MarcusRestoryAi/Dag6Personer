namespace Dag6Personer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initiera en lista för Person Objekt
            List<Person> listPerson = new List<Person>();

            //Skapa ett obejkt av klassen Person
            //Spara obejktet i listan
            listPerson.Add(new Person("Marcus", "Henriksson", 34));
            listPerson.Add(new Person("Cihan", "Yasar", 49));
            listPerson.Add(new Person("Niklas", "Cullberg", 32));
            listPerson.Add(new Person("Bert", "Karlsson", 72));

            //Loop för att gå igenom Personer som skall presentera
            //sig själva
            foreach(Person person in listPerson)
            {
                Console.WriteLine(person.Greetings()); 
            }

            //Skapa en ForEach loop för Person
            foreach(Person p1 in listPerson)
            {
                //Skapa en inner loop för Person 2
                foreach(Person p2 in listPerson)
                {
                    //If sats för att kontrollera att p1 och p2 är olika personer
                    if (p1 != p2)
                    {
                        //p1 hälsar till p2
                        Console.WriteLine(p1.HelloToYou(p2));
                    }
                }
            }
        }
    }
}
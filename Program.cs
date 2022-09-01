namespace kodetimeM3_0109
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, M3!");


            //HVA ØNSKER DERE Å LÆRE MER OM?
            //pizzashop?
            //

            // PAUSE TIL 13:10

            var yuck = new AnchoviesAndBellpepper();
            var yum = new PepperoniAndMeatballs("Regular", "Red Sauce");

            Console.WriteLine(yum.Crust);
            Console.WriteLine(yuck.Cheese);


            //søke etter noe spesifikt og vise det
            //printe ut et spesfikt felt/property i objekt
            //lage en liste over personer - få ut alle under en viss alder

            var morten = new Person("Morten", 25);
            var viktor = new Person("Viktor", 31);
            var erik = new Person("Erik", 13);
            var dani = new Person("Dani", 69);
            var adrian = new Person("Adrian", 404);



            var peeps = new List<Person>
            {
                morten,
                viktor,
                erik,
                dani,
                adrian
            };

            //hvem er eldre enn 30 av disse?


            SearchOlderThan(peeps, 18);
        }

        public static void SearchOlderThan(List<Person> peeps, int age)
        {
            var matchCount = 0;
            foreach(var person in peeps)
            {
                if (person.Age > age)
                {
                    Console.WriteLine(person.Name + " " + person.Age);
                    matchCount++;
                }
            }
            
            Console.WriteLine("Found: " + matchCount);
        }
    }
}
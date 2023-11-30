namespace Labb_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Här begränsar användaren antalet personer som skrivs in i konsolen. Skriver använaren 4 så är begränsningen max 4. 
            Console.WriteLine("Ange antal personer i din familj");
            int Totalfamilymembers = int.Parse(Console.ReadLine());

            //En array som sammlar namn på familjemedlemmar
            string[] Name = new string[Totalfamilymembers];
            // En array som åldern på familjemedlammar
            double[] Age = new double[Totalfamilymembers];
            // Beräknar totalaåldern 
            double totalAge = 0;
            // Beräknar medelåldern 
            double medianAge = 0;
            // Denna variabel håller reda på användarens val.
            int menuSelector = 0;
            // Spårar antalet familjemedlemmar som användaren lägger till.
            int userMain = 0;


            while (menuSelector!=5)
            {
                // Meny med olika alternativ som användaren får välja
                Console.WriteLine(
                    "\n---------------------------------------------------------" +
                    "\nVälj ett av alternativen nedan:" +
                    "\n1.) Ange ett namn på en familjemedlem samt ålder" +
                    "\n2.) Visa familjemedlemmarna samt deras ålder" +
                    "\n3.) Skriv ut sammanlagda åldern på familjemedlemmarnas ålder" +
                    "\n4.) Skriv ut medelåldern på familjemedlemmarna" +
                    "\n5.) Avsluta" +
                    "\n----------------------------------------------------------"
                    );
                menuSelector = int.Parse(Console.ReadLine());
                //switch-case på olika senarier baserat på användarens val.
                switch (menuSelector)

                {
                    case 1: 
                        // Användaren anger namn och ålder på en familjemedlem
                        if (userMain < Totalfamilymembers)
                        {
                            Console.WriteLine("Skriv namnet på en familjemedlem");
                            Name[userMain] = Console.ReadLine();

                            Console.WriteLine("Skriv åldern på en familjemedlem");
                            Age[userMain] = double.Parse( Console.ReadLine());
                            userMain++;
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Tyvär kan du inte skriva flera familjemedlermar än vad du har angett.");
                        }
                        break;
                    case 2:
                        // Användaren kan visa namn och ålder för alla familjemedlemmar.
                        for (int i = 0; i < userMain; i++)
                        {
                            Console.WriteLine(Name[i] + " är " + Age[i]);
                        }
                        break;
                    case 3:
                        // Beränka och visa sammanlagda åldern familjemedlemmarna.
                        for (int i = 0; i < userMain; i++)
                        {
                            totalAge += Age[i];
                        }
                        Console.WriteLine("Sammanlagda åldern  är " +  totalAge.ToString("0.00"));
                        break;
                    case 4:
                        // Beräkna och visa medelåldern för all familjemedlemmar
                        for (int i = 0;i < userMain; i++)
                        {
                            medianAge += Age[i];
                        }
                        medianAge = medianAge/userMain;
                        Console.WriteLine("Medelåldern är " + medianAge.ToString("0.00"));
                        break;
                    case 5:
                        //avsluta 
                        Console.WriteLine("Avsluta");
                        break;
                }
            }
        }
    }
}

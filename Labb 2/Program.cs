namespace Labb_2
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //Här frågas användaren första frågan
            Console.WriteLine("Hur många är ni i familjen?");
            int familyMembers = Convert.ToInt32(Console.ReadLine());


            string[] names = new string[familyMembers];
            double[] age = new double[familyMembers];
            double totalage = 0;
            double averageage = 0;
            int menuSelector = 0;
            int userinput = 0;
            //här har ser vi menyn som vi gjort, plus använt en while-loop
            while (menuSelector != 5)
            {
                Console.WriteLine(
                "\n-------------------------------------------------" +
                "\nVälj ett av alternativen:" +
                "\n1.) Ge ett namn och ålder på familjemedlemmar" +
                "\n2.) Visa familjemedlemmar" +
                "\n3.) Totala åldern av familjemedlemmarnas ålder" +
                "\n4.) Medelåldern för familjemedlemmarna" +
                "\n5.) Avsluta" +
                "\n-----------------------------------------------------"
                );
                
                menuSelector = int.Parse(Console.ReadLine());
                //Här hanterar vi användarens val 
                switch (menuSelector)
                {
                    case 1:
                    if (userinput < familyMembers)
                        
                    {
                            Console.WriteLine("Namn på familjemedlemmar");
                            names[userinput] = Console.ReadLine();
                            
                            Console.WriteLine("Ålder på familjemedlemmar");
                            age[userinput] = double.Parse(Console.ReadLine());
                            userinput++;
                    }

                    else
                    {
                            Console.Clear();
                            Console.WriteLine("OppS! tyvärr har du inte några fler familjmedlemmar");
                    }

                         break;
                    
                    case 2:
                         {
                            if (userinput == 0) ;
                            Console.Clear() ;
                            Console.WriteLine("Du gav aldrig ett namn till dina familjmedlemar");
                         }
                         for (int i = 0; i < userinput; i++)
                         {
                            Console.WriteLine(names[i] + " är " + age[i] + " år gammal.");
                         }

                         break;
                    
                    case 3:
                         for (int i = 0; i < userinput; i++)

                         {
                            totalage += age[i];
                         }

                    Console.WriteLine(" Totala åldern är " + totalage.ToString("0.00"));
                         break;
                    
                    case 4:
                         for (int i = 0; i < userinput; i++)

                         {
                            averageage += age[i];
                         }
                         averageage = averageage / userinput;
                              Console.WriteLine(" Medelåldern är " + averageage.ToString("0.00"));

                         break;
                    
                    case 5:
                         Console.WriteLine("Tack för din tid, ha en bra dag!" +
                             "");
                         break;
                    
                    default: //här har vi default-case i switch-satsen, den körs ifall inget annat case körs.
                    Console.WriteLine("Felaktig indata, du behöver ange ett nummer mellan 1 - 5\n");
                        break;

                }
            }

        }

    }
}
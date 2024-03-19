namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 12; i < 50; i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.WriteLine(" Farbod_mirzaee_console_app ");
                Thread.Sleep(75);
            }
            for (int i = 50; i > 0; i--)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write(" Farbod_mirzaee_console_app ");
                Thread.Sleep(75);
            }
            for (int i = 0; i < 50; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Choose your Gender: ");

                string mustGoToMiliteryService;
                Console.WriteLine("are you female or male? if your male choose false or your female choose true ");
                mustGoToMiliteryService = Console.ReadLine();

                bool mustGoToMiliteryServiceBoolean = Convert.ToBoolean(mustGoToMiliteryService);
                Console.WriteLine("your choose was " + mustGoToMiliteryServiceBoolean);

                bool famale = true;
                bool male = false;

                //if statement name  
                Console.WriteLine("Please enter your name");
                String name = Console.ReadLine();

                const int V = 10;
                if (name.Length > V)
                {
                    Console.WriteLine("you can't enter character more than 10 do again ");
                    Console.ReadLine();
                }

                else if (name == "")
                {
                    Console.WriteLine("you did not enter your name do again ");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Hello {name}");
                }
                //last name
                Console.WriteLine("Please enter your last name");
                String lastname = Console.ReadLine();
                const int G = 20;
                if (lastname.Length > G)
                {
                    Console.WriteLine("you can't enter character more than 10");
                }
                else if (name == "")
                {
                    Console.WriteLine("you did not enter your last name!");
                }
                else
                {
                    Console.WriteLine($"ok your:{name} Ln:{lastname}");
                }
                Console.WriteLine("Please enter your father name");
                String fathername = Console.ReadLine();

                if (name == "")
                    Console.WriteLine("you did not enter your father name!");
                else
                    Console.WriteLine("ok");
                //cell phone
                string cellphone;
                Console.WriteLine("Please enter your cell phone ");
                cellphone = Console.ReadLine();
                cellphone.Substring(0, 3);
                string result = cellphone.Substring(0, 4);
                const int b = 11;
                if (CheckInt(cellphone))
                {
                    Console.WriteLine($"4 ragham aval:{result}");
                }
                else if (cellphone.Length > b)
                {
                    Console.WriteLine("you enter wrong format do it again");
                    Console.ReadLine();
                    Thanks();

                }
                else
                {
                    Thanks();
                    Console.WriteLine($"4 ragham aval:{result}");
                }

                //age
                byte age;
                Console.WriteLine("plaese enter your age:");
                age = byte.Parse(Console.ReadLine());

                if (age <= 0)
                {
                    Console.WriteLine("your not born yet!");
                }
                else if (age > 100)
                {
                    Console.WriteLine("You are too old");
                }
                else
                {
                    Console.WriteLine("sale tavolode shoma = ");
                    Console.WriteLine(1402 - age);
                }
                //Details & summry
                Console.WriteLine("Do you want detail or summury press 1 for detail and 2 for summury");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    Console.WriteLine($"here your detailes: youre name is:{name} Ln:{lastname} age:{age}  father name :{fathername} Gender{mustGoToMiliteryServiceBoolean}");
                }
                else if (select == 2)
                {

                    Console.WriteLine($"here your summrey: name is:{name} Ln is:{lastname} age is:{age}");
                }
                else
                {
                    Console.WriteLine("you didn't press key");
                }
                Console.ReadKey();
            }
        }
        public static bool CheckInt(string input)
        {
            int temp;
            return int.TryParse(input, out temp);
        }
        static void Thanks()
        {
            Console.WriteLine("Thanks");

        }
   
    }
}

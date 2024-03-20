using Microsoft.VisualBasic;
using System.Xml.Linq;
using UserInfo;
using Newtonsoft;
using Newtonsoft.Json;

namespace ConsoleApp5;

internal class Program
{
    static UserInfo.Information information = new UserInfo.Information();
    static void Main(string[] args)
    {
        App();
    }
    static void App() 
    {
        style();
        UserGender();
        UserName();
        UserLastName();
        UserFatherName();
        UserCellPhone();
        UserAge();
        UserSelect();
        Console.ReadKey();

    }
    static void style()
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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
        }
    }
    static bool UserGender() 
    
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Are you female or male? If you are male, write 'Yes'; if you are female, write 'No'.");
                information.Gender = Console.ReadLine();

                if (information.Gender.ToUpper() == "YES" || information.Gender.ToUpper() == "NO")
                {
                    Console.WriteLine("Your choice was " + information.Gender);
                    Console.Clear();
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Invalid input. The Error Is {ex.Message} Please try again.");
            }
        }

    }
    static bool UserName() 
    {
        while (true)
        {
            try 
            {
                Console.WriteLine("Please enter your name");
                information.Name = Console.ReadLine();
                if (information.Name is null)
                {
                    Console.WriteLine("You Name was null");
                  
                   
                }
                else if (information.Name.Length <= 2)
                {
                    Console.WriteLine("Your length of the name is shorter than 2 character");
                  
                }
                else if (information.Name.Length >= 50)
                {
                    Console.WriteLine("Your length of the name is shorter than 2 character");

                }
                else
                {
                    Console.WriteLine($"Your Name is {information.Name}");
                    Console.Clear();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");

            }
        }
     
    }
    static bool UserLastName() 
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Please enter your last name");
                information.LastName = Console.ReadLine();
                if (information.LastName is null)
                {
                    Console.WriteLine("You last name was null");


                }
                else if (information.LastName.Length <= 2)
                {
                    Console.WriteLine("Your length of the last name is shorter than 2 character");

                }
                else if (information.LastName.Length >= 50)
                {
                    Console.WriteLine("Your length of the last name is shorter than 2 character");

                }
                else
                {
                    Console.WriteLine($"Your Name is {information.LastName}");
                    Console.Clear();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");

            }
        }

    }
    static bool UserFatherName()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Please enter your father name");
                information.FatherName = Console.ReadLine();
                if (information.FatherName is null)
                {
                    Console.WriteLine("You father name was null");


                }
                else if (information.FatherName.Length <= 2)
                {
                    Console.WriteLine("Your length of the father name is shorter than 2 character");

                }
                else if (information.FatherName.Length >= 50)
                {
                    Console.WriteLine("Your length of the father name is shorter than 2 character");

                }
                else
                {
                    Console.WriteLine($"Your father name is {information.FatherName}");
                    Console.Clear();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");

            }

        }
    }
    static bool UserCellPhone() 
    {
        while (true)
        {
            try 
            {
                Console.WriteLine("Please enter your cell phone ");
                information.Cellphone = Console.ReadLine();

                if (information.Cellphone.Substring(0, 1) == "+")
                {
                    string res = information.Cellphone.Replace("+", "0");
                    Console.WriteLine(res);
                    res = res.Substring(0, 4); // Change to get the first four characters
                    Console.WriteLine($"The first four characters of your cell phone: {res}");
                    information.Cellphone = res; // Update the Cellphone value in the information object
                    Console.Clear();
                    return true;
                }
                else if (information.Cellphone.StartsWith(" "))
                {
                    string res = "0" + information.Cellphone.TrimStart(); // Add '0' at the beginning and remove leading spaces
                    res = res.Substring(0, 4); // Get the first four characters
                    Console.WriteLine($"The first four characters of your cell phone: {res}");
                    information.Cellphone = res; // Update the Cellphone value in the information object
                    Console.Clear();
                    return true;
                }
                else if (information.Cellphone.Length < 11)
                {
                    Console.WriteLine("you enter wrong format do it again");
                }
                else if (information.Cellphone.Length > 11)
                {
                    Console.WriteLine("you enter wrong format do it again");
                }
                else
                {
                    Console.WriteLine($"This is your cell phone {information.Cellphone}");
                    string res = information.Cellphone.Substring(0, 4);
                    Console.WriteLine($"The First four charachter you cell phone: {res}");
                    Console.Clear();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error Is {ex.Message}");
            }
        }
    }
    static bool UserAge() 
    {
        while (true)
        {
            try 
            {
                Console.WriteLine("plaese enter your age:");
                information.Age = byte.Parse(Console.ReadLine());

                if (information.Age <= 0)
                {
                    Console.WriteLine("you haven't borned yet!");
                }
                else if (information.Age > 130)
                {
                    Console.WriteLine("You are too old");
                }
                else
                {
                    Console.WriteLine($"Your Birthdate is : {1402 - information.Age} ");
                    Console.Clear();
                    return true;
                }
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
            }
            
        }
    }
    static bool UserSelect() 
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Do you want detail as a Text or as a json. for 'Text' press 1 for json press 2.");
                information.Select = byte.Parse(Console.ReadLine());
                if (information.Select == 1)
                {
                    string textDetails = $"Your Gender is {information.Gender}\n" +
                        $"Your Name is: {information.Name}\n" +
                        $"Last Name: {information.LastName}\n" +
                        $"Age: {information.Age}\n" +
                        $"Father's Name: {information.FatherName}\n" +
                        $"Cell Phone: {information.Cellphone}";

                    Console.WriteLine($"Here are your details as Text:\n{textDetails}");
                    return true;
                }
                else if (information.Select == 2)
                {
                    var _JsonDetails = new 
                    {
                   Gender = information.Gender,
                   Name = information.Name,
                   LastName = information.LastName,
                   FatherName = information.FatherName,
                   Cellphone =  information.Cellphone,
                   Age =  information.Age
                    };
                    var JsonDetail = JsonConvert.SerializeObject(_JsonDetails);
                    Console.WriteLine($"Here is your summary in JSON format:\n{JsonDetail}\n");
                    Console.Clear();
                    return true;
                }
                else
                {
                    Console.WriteLine("you didn't press key");
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
            }
            
        }
    }
}
     




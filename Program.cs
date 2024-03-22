using Newtonsoft;
using Newtonsoft.Json;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp5;

internal class Program
{
    static UserInfo.Information information = new UserInfo.Information();
    static void Main(string[] args)
    {
        App();
    }
    static bool App()
    {
        while (true)
        {
            try
            {
                style();
                Console.WriteLine("Do you want to start? if you want press 1 else press 2");
                int askToStart = Convert.ToInt32(Console.ReadLine());
                if (askToStart == 1)
                {
                    UserGender();
                    UserName();
                    UserLastName();
                    UserFatherName();
                    UserCellPhone();
                    UserAge();
                    UserSelect();
                }
                else if (askToStart == 2)
                {
                    Console.WriteLine("Ok Good bay");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
                Console.ReadKey();
                Console.Clear();
                return true;
            }
        }
    }
    static void style()
    {
        for (int i = 12; i < 50; i++)
        {
            Console.SetCursorPosition(i, 1);
            Console.WriteLine(" Farbod_Mirzaee ");
            Thread.Sleep(75);
        }
        for (int i = 50; i > 0; i--)
        {
            Console.SetCursorPosition(i, 1);
            Console.Write(" Farbod_Mirzaee ");
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
        var invalidAttempts = 0;
        while (invalidAttempts < 3)
        {
            try
            {
                Console.WriteLine("Are you female or male? If you are male, write 'Yes'; if you are female, write 'No'.");
                information.Gender = Console.ReadLine();

                if (information.Gender.ToUpper() == "YES" || information.Gender.ToUpper() == "NO")
                {
                    Console.WriteLine($"Your choice was {information.Gender}");
                    Console.WriteLine("press enter key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    return true;
                }
                else 
                {
                    invalidAttempts++;
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input. The Error Is {ex.Message} Please try again.");
            }
        }
          throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserName()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 7)
        {
            try
            {
                Console.WriteLine("Please enter your name");
                information.Name = Console.ReadLine();

                switch (information.Name)
                {
                    case "":
                        Console.WriteLine("You Name was null");
                        break;
                    case var name when name.Length <= 2:
                        Console.WriteLine("Your length of the name is shorter than 2 character");
                        break;
                    case var name when name.Length >= 50:
                        Console.WriteLine("Your length of the name is more than 50 character");
                        break;
                    default:
                        Console.WriteLine($"Your Name is {information.Name}");
                        Console.WriteLine("press enter key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        return true;
                }
                invalidAttempts++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserLastName()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 7)
        {
            try
            {
                Console.WriteLine("Please enter your last name");
                information.LastName = Console.ReadLine();
                switch (information.LastName)
                {
                    case "":
                        Console.WriteLine("your last name was null");
                        break;
                    case var lastName when lastName.Length <= 2:
                        Console.WriteLine("Your length of the last name is shorter than 2 character");
                        break;
                    case var lastName when lastName.Length >= 50:
                        Console.WriteLine("Your length of the last name is more than 50 character");
                        break;
                    default:
                        Console.WriteLine($"you last name is {information.LastName}");
                        Console.WriteLine("press enter key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        return true;
                }
                invalidAttempts++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserFatherName()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 7)
        {
            try
            {
                Console.WriteLine("Please enter your father name");
                information.FatherName = Console.ReadLine();
                switch (information.FatherName)
                {
                    case "":
                        Console.WriteLine("You father name was null");
                        break;

                    case var fatherName when fatherName.Length <= 2:
                        Console.WriteLine("Your length of the father name is shorter than 2 characters");
                        break;

                    case var fatherName when fatherName.Length >= 50:
                        Console.WriteLine("Your length of the father name is more than 50 characters");
                        break;

                    default:
                        Console.WriteLine($"Your father name is {information.FatherName}");
                        Console.WriteLine("press enter key to continue");
                        Console.ReadKey();
                        return true;
                }
                invalidAttempts ++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid input.The error Is{ex.Message}");
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserCellPhone()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 5)
        {
            try
            {
                Console.WriteLine("Please Enter Your Cellphone number");
                information.Cellphone = Console.ReadLine();
                switch (information.Cellphone.Substring(0, 1))
                {
                    case "":
                     Console.WriteLine("your cell phone was null");
                    break;
                    case "+":
                        var res = information.Cellphone.Replace("+", "0");
                        Console.WriteLine(res);
                        res = res.Substring(0, 4); // Change to get the first four characters
                        Console.WriteLine($"The first four characters of your cell phone: {res}");
                        information.Cellphone = res; // Update the Cellphone value in the information object
                        Console.WriteLine("press enter key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        return true;
                    case var phone when !phone.StartsWith("0"):
                        var resPhone = "0" + information.Cellphone; // Add '0' at the beginning
                        var resPhonesub = resPhone.Substring(0, 4); // Get the first four characters
                        Console.WriteLine($"The first four characters of your cell phone: {resPhonesub}");
                        information.Cellphone = resPhone; // Update the Cellphone value in the information object
                        Console.WriteLine("Press enter key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        return true;
                    default:
                        if (information.Cellphone.Length != 11)
                        {
                            Console.WriteLine("you enter wrong format do it again");
                        }
                        else if (string.IsNullOrEmpty(information.Cellphone)) 
                        {
                        Console.WriteLine("you cellphone was null");
                        Console.ReadKey();
                        invalidAttempts++;
                        return true;
                        }
                        else
                        {
                            Console.WriteLine($"This is your cell phone {information.Cellphone}");
                            string res2 = information.Cellphone.Substring(0, 4);
                            Console.WriteLine($"The First four characters of your cell phone: {res2}");
                            Console.Clear();
                            return true;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error Is {ex.Message}");
                invalidAttempts++;
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
               Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserAge()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 7)
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
                    Console.WriteLine($"Your Birthdate is : {1403 - information.Age} ");
                    Console.WriteLine("press enter key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    return true;
                }
                invalidAttempts++;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
    static bool UserSelect()
    {
        var invalidAttempts = 0;
        while (invalidAttempts < 3)
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
                    Console.WriteLine("press enter key to continue");
                    Console.ReadKey();
                    Console.Clear();
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
                        Cellphone = information.Cellphone,
                        Age = information.Age
                    };
                    var JsonDetail = JsonConvert.SerializeObject(_JsonDetails);
                    Console.WriteLine($"Here is your summary in JSON format:\n{JsonDetail}\n");
                    Console.WriteLine("press enter key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    return true;
                }
                else
                {
                    Console.WriteLine("you didn't press key");
                    invalidAttempts++;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"The Error is {ex.Message}");
                Console.WriteLine("press enter key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        throw new Exception("Exceeded maximum number of invalid attempts.");
    }
}
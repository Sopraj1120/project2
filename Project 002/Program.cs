using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintHello();
            //GreetUser();
            //sum();
            //PrintMessage();
            //DisplayInfo();
            //OredrCoffee();
            //BookFlight("America","2nd Of March 2025 " ,"Ecconomy"); 
            //Console.WriteLine(Multiply(3.5, 4.4));
            //Display("Hello C#");
            //Display(256);
            //Display(823.156);
            //Console.WriteLine(CalculateArea(25));
            //Console.WriteLine(CalculateArea(12,15));
            //Console.WriteLine(ConvertTemperature(32));
            //AddToCart("Biscut", 25);
            //AddToCart("Tofee", 150, 8.50);
            //Transfer(123456789, 5000);
            //Transfer(123456789, 5000, "for Monthly Rent Payment");
            //Console.WriteLine(Distance(6.3, 4.2, 5.5, 7));
            //Console.WriteLine(Distance(1.2, 4.2, 12, 7,3.4,7.5));
            //Console.WriteLine(FromDate(DateTime.Now));
            //Console.WriteLine(FromDate((DateTime.Now),"dddd , dd MMMM yyyy"));
            //Console.WriteLine(AuthenticateUser("user1","password1"));
            //Console.WriteLine(AuthenticateUser("user1", "password1","answer1"));
            SendEmail("example@gmail.com", "Hi and Welcome to C#");
            List<string> list = new List<string> { "CC1example12@gmail.com", "CC2example123@gmail.com" };
            
            SendEmail("example@gmail.com", "Greetng message", "Hi and Welcome to C#", list);










            Console.ReadLine();

        }
        //question1
        static void PrintHello()
        {
            Console.WriteLine("Hello, World!");
        }
        //Question2
        static void GreetUser()
        {
            Console.WriteLine("Enter The Name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello,{name}!");
        }
        //Question3
        static int sum()
        {
            Console.WriteLine("Enter Number1");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number2");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine($"{num1}+{num2} = {sum}");
            return sum;
        }
        //Question 4
        static void PrintMessage(string message = "Hello, World!")
        {
            Console.WriteLine(message);
        }
        //Question5
        static void DisplayInfo(string name = "raje", int age = 25)
        {
            Console.WriteLine($"Name:{name}\nAge:{age}");
        }
        // Question 6
        static void OredrCoffee()
        {
            Console.WriteLine("Enter Size Of Coffee..");
            string size = Console.ReadLine();
            Console.WriteLine("How many Spoon Of Sugar Added in Coffee..");
            int sugar = int.Parse(Console.ReadLine());
            Console.WriteLine("Can I Add Milk?..");
            bool milk = bool.Parse(Console.ReadLine());

            Console.WriteLine($"size:{size}\t{sugar} spoon Sugar\tMilk:{milk}");
        }
        //Question 7
        static void BookFlight(string destination, string date, string classType)
        {
            Console.WriteLine($"Destination:\t {destination}\t\nDate:\t {date}\t\nClass Type:\t {classType}\t");
        }
        // Question 8

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }
        // Question9
        static void Display(string value)
        {
            Console.WriteLine("String value: " + value);
        }


        static void Display(int value)
        {
            Console.WriteLine("Integer value: " + value);
        }


        static void Display(double value)
        {
            Console.WriteLine("Double value: " + value);
        }


        // Question10
        static double CalculateArea(double side)
        {
            return side * side;
        }


        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        // Question 11
        static double ConvertTemperature(double celcious)
        {
            return (celcious * 9 / 5) + 32;
        }
        //Question 12
        static void AddToCart(string productName, int quantity)
        {
            Console.WriteLine($"{quantity}\t of {productName} ");
        }

        static void AddToCart(string productName, int quantity, double price)
        {
            double totalCost = quantity * price;
            Console.WriteLine($"{quantity}\t of {productName}\tTotal cost: Rs.{totalCost}");
        }

        //Question 13
        static void Transfer(int accountNumber, int amount)
        {
            Console.WriteLine($"Transfer Amount: {amount} to Account: {accountNumber}");
        }
        static void Transfer(int accountNumber, int amount, string discription)
        {
            Console.WriteLine($"Transfer Amount: {amount} to Account: {accountNumber}\t Disccription:{discription}");
        }
        //Question 14
        static double Distance(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2));
        }
        static double Distance(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1 - y2),2)+ Math.Pow((z1-z2),2));
        }

        //Question 15
        static string FromDate(DateTime date)
        {
            return date.ToString("MM/dd/yyyy");
        }
        static string FromDate(DateTime date, string format) 
        {
            return date.ToString(format);
        }


        //Question 16
        static bool AuthenticateUser(string username, string password)
        {
            
            string[] usernames = { "user1", "user2", "user3" };
            string[] passwords = { "password1", "password2", "password3" };

            
            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password)
                {
                    return true; 
                }
            }

            return false;
        }

        
        static bool AuthenticateUser(string username, string password, string securityAnswer)
        {
          
            string[] usernames = { "user1", "user2", "user3" };
            string[] passwords = { "password1", "password2", "password3" };
            string[] securityAnswers = { "answer1", "answer2", "answer3" };

            for (int i = 0; i < usernames.Length; i++)
            {
                if (usernames[i] == username && passwords[i] == password && securityAnswers[i] == securityAnswer)
                {
                    return true; 
                }
            }

            return false; 
        }
        //Question 17
        static void SendEmail(String EmailAddress, string Message) 
        {
            Console.WriteLine($"Sending email to {EmailAddress}\nMessage: {Message}\n");
        }
        static void SendEmail(string EmailAddress,string Subject, string Message, List<string> CCRecipients ) 
        {
            Console.WriteLine($"Sending email to {EmailAddress}\nSubject: {Subject}\nMessage: {Message}");
            if (CCRecipients != null && CCRecipients.Count > 0)
            {
                Console.WriteLine("CC Receptionist:");
                foreach(var cc in CCRecipients)
                {

                Console.WriteLine(cc);
                }    
            }
            Console.WriteLine();
        }


    }
}





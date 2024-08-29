using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    internal class A1Q1
    {
        static void Main(string[] args)
        {
            Q1 q1 = new Q1();
            Q2 q2 = new Q2();
            Q4 q4 = new Q4();
            Q5 q5 = new Q5();
            Q6 q6 = new Q6();
            Q7 q7 = new Q7();  
            Q8 q8 = new Q8();  
            Q9 q9 = new Q9();  
            Q10 q10 = new Q10();   
        }
    }
    class Q1
    {
        public Q1()
        {
            int[] arr = new int[5];
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Price " + i + "=");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Total Price : " + sum);
            if (sum > 3000)
            {
                sum = (sum * 10) / 100;

            }
            Console.WriteLine("Price : " + sum);
        }

    }
    class Q2
    {
        public Q2()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a == 0)
            {
                Console.WriteLine("Freezing Temperature");
            }
            else
            {
                a = (a * 9 / 5) + 32;
                Console.WriteLine(a);
            }
        }
    }

    class Question3
    {
        /*3.Create a C# program that simulates a simple ATM. It should allow users to check their balance, 
            deposit money, and withdraw money. Ensure that the program checks for sufficient funds before allowing
            a withdrawal.*/
        decimal balance = 0.00m;

        public Question3()
        {
            bool isrunning = true;
            while (isrunning)
            {
                Console.WriteLine("Enter 1 for Check Balance");
                Console.WriteLine("Enter 2 for Deposit Money");
                Console.WriteLine("Enter 3 for Withdraw Money");
                Console.WriteLine("Enter 4 to Exit");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "1":
                        CheckBalance(balance);
                        break;
                    case "2":
                        Deposit(ref balance);
                        break;
                    case "3":
                        Withdrawal(ref balance);
                        break;
                    case "4":
                        isrunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        static void CheckBalance(decimal balance)
        {
            Console.WriteLine($"\nYour current balance is: ${balance:F2}\n");
        }

        static void Deposit(ref decimal balance)
        {
            Console.Write("Enter the amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal b) && b > 0)
            {
                balance += b;
                Console.WriteLine($"You have successfully deposited ${b:F2}. Your new balance is ${balance:F2}.");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        static void Withdrawal(ref decimal balance)
        {
            Console.Write("Enter the amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal a) && a > 0)
            {
                if (balance < a)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else
                {
                    balance -= a;
                    Console.WriteLine($"You have successfully withdrawn ${a:F2}. Your new balance is ${balance:F2}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }

    class Q4
    {
        public Q4()
        {
            int[] marks = new int[5];
            int sum = 0;
            for(int i = 0;i < 5;i++)
            {
                Console.Write("Marks "+i + "=");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }
            Console.WriteLine("Sum : "+sum);
            int avg = sum / 2;
            Console.WriteLine("Average : "+avg);
            if(avg > 90)
            {
                Console.WriteLine("A");
            }
            else if(avg > 80 &&  avg < 90)
            {
                Console.WriteLine("B");
            }
            else if (avg > 70 && avg < 80)
            {
                Console.WriteLine("C");
            }
            else if(avg > 60 && avg < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }

    class Q5
    {
        public Q5()
        {
            Console.WriteLine("Please enter your password:");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
            {
                Console.WriteLine("Password is valid.");
            }
            else
            {
                Console.WriteLine("Password is invalid. It must be at least 8 characters long, contain at least one uppercase letter, one lowercase letter, and one number.");
            }
        }

        static bool ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            bool hasUpperCase = false;
            bool hasLowerCase = false;
            bool hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpperCase = true;
                if (char.IsLower(c)) hasLowerCase = true;
                if (char.IsDigit(c)) hasDigit = true;
            }

            return hasUpperCase && hasLowerCase && hasDigit;
        }
    }
    class Q6
    {
        /*6.	Write a C# program to calculate the fare of a taxi ride. The fare is calculated based on the distance
        traveled. The first 2 kilometers are charged at a flat rate (Rs. 20), and any additional kilometers are charged
        at a per-kilometer rate. Include a night surcharge if the ride occurs after 10 PM.*/

        public Q6()
        {
            Console.WriteLine("Enter the distance that you have to tarvelled(in Kilometer): ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time (in 24 format): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int fare = 20;
            int night = 3;
            int km = 10;
            if (a > 2)
            {
                fare += (a - 2) * km;
            }
            if (n >= 22 && n <= 6)
            {
                fare += fare * night;
            }
            Console.WriteLine(fare);

        }
    }
    class Q7
    {
        /*7.	A school tracks the attendance of students over 5 days.The system should be able to record attendance,
        calculate the total number of days attended, and identify if a student has perfect attendance.*/

        public Q7()
        {
            bool[] arr = new bool[5];
            int attandance = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter your attandance in yes/no");
                String input = Console.ReadLine().Trim().ToLower();
                if (input == "yes")
                {
                    arr[i] = true;
                    attandance++;
                }
            }
            if (attandance == 5)
            {
                Console.WriteLine("Full Attandance");
            }
            else
            {
                Console.WriteLine($"Your attandance is {attandance}");
            }
        }
    }
    class Q8
    {
        /*8.	An individual tracks their expenses for each month in a year.They want to calculate the total expenses 
         * for the year and identify the month with the highest and lowest expenses.*/

        public Q8()
        {
            int[] arr = new int[12];
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter your montly Expences");
                int a = Convert.ToInt32(Console.ReadLine());
                sum = sum + a;
                arr[i] = a;
            }
            Console.WriteLine(sum);
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Max());
        }
    }

    class Q9
    {
        /*9.	Implement a shopping cart system where a user can add items, remove items, and view the total price.
         * Assume each item has a name and a price.*/
        Dictionary<String, int> cart = new Dictionary<String, int>();

        public Q9()
        {

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("Enter 1 to add item: ");
                Console.WriteLine("Enter 2 to remove item: ");
                Console.WriteLine("Enter 3 to rveiw cart: ");
                Console.WriteLine("Enter 4 to exit: ");
                String add = Console.ReadLine();
                switch (add)
                {
                    case "1":
                        addString(cart);
                        break;
                    case "2":
                        removeString(cart);
                        break;
                    case "3":
                        viewCart(cart);
                        break;
                    case "4":
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid No.:");
                        break;

                }
            }
        }
        static void addString(Dictionary<String, int> cart)
        {
            Console.WriteLine("Enter the item and price: ");
            cart.Add(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
        }
        static void removeString(Dictionary<String, int> cart)
        {
            Console.WriteLine("Enter the item anme that you want to remove: ");
            String ss = Console.ReadLine();
            cart.Remove(ss);
        }
        static void viewCart(Dictionary<String, int> cart)
        {
            int total = 0;
            foreach (var item in cart)
            {
                Console.WriteLine($"Your item is {item.Key}, and the pirce is ${item.Value}");
                total += item.Value;
            }
            Console.WriteLine(total);
        }
    }

    class Q10
    {
        /*10.	Create a program that calculates the monthly salary of an employee based on their hourly wage and the 
         * number of hours worked in a week.Consider that there are 4 weeks in a month.*/
        public Q10()
        {
            int wage = 100;
            Console.WriteLine("Enter the No. of hrs work in a week");
            int working = Convert.ToInt32(Console.ReadLine());
            int hrsOfMonth = working * 4;
            int TotalWages = wage * hrsOfMonth;
            Console.WriteLine($"Total Hours worked in a month is {hrsOfMonth} and your wages is {TotalWages}");

        }
    }
}
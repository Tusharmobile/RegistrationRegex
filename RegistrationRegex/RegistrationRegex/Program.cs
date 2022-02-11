using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Program number to get executed \n1. Validate first name \n2. Validate last name \n3. Validate EmailID \n4. Validate mobile no \n5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter First name :");
                        string fname = Console.ReadLine();
                        RegistrationValidation Checkpattern = new RegistrationValidation();
                        Checkpattern.Checkfirstname(fname);
                        break;
                    case 2:
                        Console.WriteLine("*First letter should be capital.");
                        Console.WriteLine("*length should be Minimum three characters.");
                        Console.WriteLine("Enter Last name :");
                        string lname = Console.ReadLine();
                        RegistrationValidation lnamepattern = new RegistrationValidation();
                        lnamepattern.Checklastname(lname);
                        break;
                    case 3:
                        Console.WriteLine("Enter Email id :");
                        string email = Console.ReadLine();
                        RegistrationValidation emailpattern = new RegistrationValidation();
                        emailpattern.Checkemail(email);
                        break;
                    case 4:
                        Console.WriteLine("Enter Mobile No. :");
                        string mobilenum = Console.ReadLine();
                        RegistrationValidation mobilenumpattern = new RegistrationValidation();
                        mobilenumpattern.Checkmobilenum(mobilenum);
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("invalid option");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
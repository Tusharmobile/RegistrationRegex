﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    internal class RegistrationValidation
    {
        public void Checkfirstname(string firstname)
        {
            string Firstnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(firstname, Firstnamepattern))
                Console.WriteLine("First Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
        public void Checklastname(string Lastname)
        {
            string lastnamepattern = "^[A-Z][a-z]{3,10}$";
            if (Regex.IsMatch(Lastname, lastnamepattern))
                Console.WriteLine("Last Name is valid");
            else
                Console.WriteLine("Invalid name!!");
        }
        public void Checkemail(string Emailid)
        {
            // string emailpattern = "^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";
            string emailpattern = "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            if (Regex.IsMatch(Emailid, emailpattern))
                Console.WriteLine("Email id is valid");
            else
                Console.WriteLine("Invalid Email id!!");
        }
        public void Checkmobilenum(string Mobilenum)
        {
            string mobilenumpattern = "^[1,9]{2}-[6-9]{1}[0-9]{9}";
            if (Regex.IsMatch(Mobilenum, mobilenumpattern))
                Console.WriteLine("Mobile number is valid");
            else
                Console.WriteLine("Invalid mobile number!!");
        }
        public void Checkpassward(string Passward)
        {
            // string passwardpattern = "^[A-Za-z0-9]{8,20}$";
            // string passwardpattern1 = "^(?=.*[A-Z])(?=.*[a-z]{8,}).*$";
            //string passwardpattern2 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            string passwardpattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            if (Regex.IsMatch(Passward, passwardpattern))
                Console.WriteLine("Passward is valid");
            else
                Console.WriteLine("Invalid passward!!");
        }

    }
}
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularjsRealworld.Utils
{
    public class ObjectRpository
    {
        //Sign up page navigation element

        public static string signuppageButton = "//a[text() = 'Sign up']";


        //Regustration elements
        public static string userName = "//input[@placeholder = 'Username']";
        public static string email = "//input[@placeholder = 'Email']";
        public static string password = "//input[@placeholder = 'Password']";
        public static string signupButton = "//button[text() = 'Sign up']";

        //Home Page Elements
        
        public static string accountName = "//a[contains(@href,'#/@Bindu']";

    }
}

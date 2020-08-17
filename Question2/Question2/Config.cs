using System;
using System.Collections.Generic;
using System.Text;

namespace Question2
{
    public class Config
    {
        public static class LoginDetails
        {
                public static string fullName= "Jai";
                public static string orgName = "Jai";
                public static string Email = EmailDetails.email+"@mailpoof.com";
        }

        public static List<string> ExpectedValues = new List<string>() { "English", "Dutch" };

        public static string WelcomeMsg = "A welcome email has been sent. Please check your email.";

        public static class EmailDetails
        {
            public static string email = "jaikudu";
        }
    }
}

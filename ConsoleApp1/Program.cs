using static System.Console;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] passcodeList = new string[2];
            passcodeList[0] = "mywsuId123";
            passcodeList[1] = "mywsuId890";
            passcodeList[2] = "mywsuId321";
            passcodeList[3] = "mywsuId192";
            passcodeList[4] = "mywsuId430";

            Write("Please enter passcode to access the system: ");

            string userPasscode = ReadLine();
            bool authenticated = false; //To check if authenticated

            foreach (string passcode in passcodeList)
            {
                if (userPasscode == passcode)
                {
                    //Set authentication to true
                    authenticated = true;
                }
            }


            if (authenticated) //if authenticated is true
            {
                string userName = string.Empty;
                Write("Enter user name:");
                userName = ReadLine();

                WriteLine($"UserName: {userName}. You are successfully authenticated by the system.");

            }
            else //if authenticated is false
            {
                WriteLine("You have entered incorrect passcode. Please try again.");
                ReadLine();
            }
        }
    }

}

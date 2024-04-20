using System.Security;
using UserModel;
using AccountData;
using UserBusinessLogic;

namespace UserLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Username: ");
                string user = Console.ReadLine();
            Console.WriteLine("Input Password: ");
            string password = Console.ReadLine();

            userBusiness accountinfo = new userBusiness();
            bool result = accountinfo.Verifyuser(user, password);

            if (result)
            {
                Console.WriteLine("User login is successful");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}

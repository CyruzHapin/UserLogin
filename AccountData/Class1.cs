using UserModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace AccountData
{
    public class userinfo
    {
        List<usernamepass> user = new List<usernamepass>();

        public userinfo()
        {
            createDummyData();
        }
        private void createDummyData()
        {
            usernamepass user1 = new usernamepass
            {
                username  = "Cyruz",
                    password = "192"
            };
            usernamepass user2 = new usernamepass
            {
                username = "Hapin",
                    password = "168"
            };
            usernamepass user3 = new usernamepass
            {
                username = "Dhionne",
                    password = "111"
            };
            user.Add(user1);
            user.Add(user2);
            user.Add(user3);
        }
        public usernamepass GetAccount(string username) {
            usernamepass foundAccount = new usernamepass();
            foreach (usernamepass user in user)
            {
                if (user.username == username)
                {
                    foundAccount = user;
                }
            }
            return foundAccount;
        }

    }
}
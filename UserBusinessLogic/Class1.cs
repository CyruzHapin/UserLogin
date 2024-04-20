using AccountData;
namespace UserBusinessLogic
{
    public class userBusiness
    {
        public bool Verifyuser ( string username, string password)
        {
            userinfo dataservice = new userinfo();
            var result = dataservice.GetAccount(username);

            return result.username != null ? true : false;
        }
    }
}

using My_Web_App.Models;

namespace My_Web_App.Services
{
    public class SecurityService
    {

        List<UserModel> knownUsers = new List<UserModel>();
        public SecurityService()
        {
            knownUsers.Add(new UserModel {Id = 0, UserName = "ChetanPagar", Password = "Ncs123" });
            knownUsers.Add(new UserModel { Id = 1, UserName = "YogeshSharma", Password = "Ncsi123" });
            knownUsers.Add(new UserModel { Id = 2, UserName = "AjayJakhade", Password = "Ncs@123" });
            knownUsers.Add(new UserModel { Id = 3, UserName = "RupeshPatil", Password = "Ncs123#" });
        }

        public bool IsValid(UserModel user)
        { 
        //print when found in the list
         return knownUsers.Any(x => x.UserName== user.UserName && x.Password == user.Password);
        }
    }
}

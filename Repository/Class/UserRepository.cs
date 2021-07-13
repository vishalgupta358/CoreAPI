using DataLayerClass;
using CoreAPI.Repository.Interface;
using System.Collections.Generic;
using Contract.Model;
using DataLayerClass.FacadeLayer;

namespace CoreAPI.Repository.Class
{
    
    public class UserRepository : IUserRepository
    {
        Facade facade = new Facade();
        public UserRepository()
        {
            //_context = context;
        }

        public int CreateUser(IUser userModel)
        {
           return facade.CreateUser((User)userModel);
        }

        public int DeleteUser(int UserId)
        {
            return facade.DeleteUser(UserId);
        }

        public IUser GetUser(int UserId)
        {
            return (IUser)(User)facade.GetUser(UserId);
            
        }

        public List<IUser> GetUsers()
        {
            return (List<IUser>)facade.GetUsers();
            
        }

        public int UpdateUser(IUser userModel)
        {
           return facade.UpdateUser((User)userModel);
            
            
        }
    }
}


using Contract.Model;
using CoreAPI.Factory;
using CoreAPI.Model;
using CoreAPI.Repository.Interface;
using System.Collections.Generic;

namespace CoreAPI.FacadeLayer
{
    public class Facade
    {
        private IUserRepository _user = null;
        public Facade(UserFactoryBuilder userFactoryBuilder)
        {
            _user = userFactoryBuilder.GetUserFactory();
        }        
         
        internal int CreateUser(IUser userdataModel)
        {
            return _user.CreateUser(userdataModel);
        }

        internal IUser GetUser(int Userid)
        {

            return _user.GetUser(Userid);
        }

        internal IEnumerable<IUser> GetUsers()
        {
            return _user.GetUsers();
        }

        internal int UpdateUser(IUser userdataModel) {
            return _user.UpdateUser(userdataModel);
        }

        internal int DeleteUser(int Userid)
        {
            return _user.DeleteUser(Userid);
        }


    }
}

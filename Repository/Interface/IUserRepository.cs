using Contract.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPI.Repository.Interface
{
    interface IUserRepository
    {
        int CreateUser(IUser userModel);
        int UpdateUser(IUser userModel);

        IUser GetUser(int UserId);
        List<IUser> GetUsers();

        int DeleteUser(int UserId);
    }
}


using CoreAPI.Repository.Class;

namespace CoreAPI.Factory
{
    public class UserFactoryBuilder
    {
        private UserRepository _user = null;
        public UserFactoryBuilder(UserRepository user)
        {
            _user = user;
        }
        public UserRepository GetUserFactory()
        {
            return _user;
        }

    }
}

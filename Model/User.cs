using Contract.Model;
using System;
using System.Collections.Generic;

#nullable disable

namespace CoreAPI.Model
{
    public partial class User:IUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Department { get; set; }
    }
}

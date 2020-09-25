using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository.Aggregate
{
    public class DetailUser
    {
        public string UserID { get; internal set; }
        public string UserName { get; internal set; }
        public string UserGender { get; internal set; }
        public string UserRole { get; internal set; }
        public string UserStatus { get; internal set; }
    }
}
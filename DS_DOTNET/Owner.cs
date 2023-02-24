using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_DOTNET
{
    public class Owner
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
        public bool isAdmin { get; set; }

        public Owner(string firstname, string lastname, string email, bool isAdmin)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.isAdmin = isAdmin;
        }
    }
}

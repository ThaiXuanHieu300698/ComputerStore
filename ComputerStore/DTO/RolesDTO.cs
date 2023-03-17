using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RolesDTO
    {
        private int roleID;
        private string roleName;

        public int RoleID { get => roleID; set => roleID = value; }
        public string RoleName { get => roleName; set => roleName = value; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UserRoleRelationshipDTO
    {
        private int roleID;
        private int userID;

        public int RoleID { get => roleID; set => roleID = value; }
        public int UserID { get => userID; set => userID = value; }
    }
}

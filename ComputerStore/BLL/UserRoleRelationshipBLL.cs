using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserRoleRelationshipBLL
    {
        private static UserRoleRelationshipBLL instance;

        public UserRoleRelationshipBLL()
        {

        }

        public static UserRoleRelationshipBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserRoleRelationshipBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return UserRoleRelationshipDAL.Instance.Select();
        }

        public DataTable GetByUserID(int _userID)
        {
            return UserRoleRelationshipDAL.Instance.SelectByUserID(_userID);
        }

        public void Update(int _userID, int _roleID)
        {
            UserRoleRelationshipDAL.Instance.Update(_userID, _roleID);
        }
    }
}

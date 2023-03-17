using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoriesDTO
    {
        private int categoryID;
        private string categoryName;
        private string description;

        public CategoriesDTO()
        {

        }

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }

        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}

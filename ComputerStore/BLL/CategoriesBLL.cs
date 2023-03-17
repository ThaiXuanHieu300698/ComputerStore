using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class CategoriesBLL
    {
        private static CategoriesBLL instance;

        public CategoriesBLL()
        {

        }

        public static CategoriesBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new CategoriesBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return CategoriesDAL.Instance.Select();
        }

        public DataTable GetCategoryBySearchString(string _searchString)
        {
            return CategoriesDAL.Instance.Select(_searchString);
        }

        public List<CategoriesDTO> GetCategories()
        {
            List<CategoriesDTO> categories = new List<CategoriesDTO>();
            DataTable dataTableCategories = CategoriesDAL.Instance.Select();
            foreach (DataRow dataRow in dataTableCategories.Rows)
            {
                CategoriesDTO category = new CategoriesDTO();
                category.CategoryID = Int32.Parse(dataRow["CategoryID"].ToString());
                category.CategoryName = category.CategoryID.ToString();
                category.Description = dataRow["Description"].ToString();

                categories.Add(category);
            }
            return categories;
        }

        public CategoriesDTO GetCategoryByID(int _categoryID)
        {
            CategoriesDTO category = new CategoriesDTO();
            DataTable dataTableCategory = CategoriesDAL.Instance.SelectByCategoryID(_categoryID);
            foreach (DataRow dataRow in dataTableCategory.Rows)
            {
                
                category.CategoryID = Int32.Parse(dataRow["CategoryID"].ToString());
                category.CategoryName = category.CategoryID.ToString();
                category.Description = dataRow["Description"].ToString();
            }
            return category;
        }

        public void Insert(string _categoryName, string _description)
        {
            CategoriesDAL.Instance.Insert(_categoryName, _description);
        }

        public void Update(int _categoryID, string _categoryName, string _description)
        {
            CategoriesDAL.Instance.Update(_categoryID, _categoryName, _description);
        }

        public void DeleteByCategoryID(int _categoryID)
        {
            CategoriesDAL.Instance.DeleteByCategoryID(_categoryID);
        }
    }
}

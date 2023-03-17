using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SuppliersBLL
    {
        private static SuppliersBLL instance;

        public SuppliersBLL()
        {

        }

        public static SuppliersBLL Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new SuppliersBLL();
                }
                return instance;
            }
        }

        public DataTable GetAll()
        {
            return SuppliersDAL.Instance.Select();
        }

        public List<SuppliersDTO> GetSuppliers()
        {
            List<SuppliersDTO> suppliers = new List<SuppliersDTO>();
            DataTable dataTableSuppliers = SuppliersDAL.Instance.Select();
            foreach (DataRow dataRow in dataTableSuppliers.Rows)
            {
                SuppliersDTO supplier = new SuppliersDTO();
                supplier.SupplierID = Int32.Parse(dataRow["SupplierID"].ToString());
                supplier.CompanyName = supplier.SupplierID.ToString();
                supplier.ContactName = dataRow["ContactName"].ToString();
                supplier.Address = dataRow["Address"].ToString();
                supplier.Phone = dataRow["Phone"].ToString();
                supplier.Email = dataRow["Email"].ToString();

                suppliers.Add(supplier);
            }
            return suppliers;
        }

        public SuppliersDTO GetBySupplierID(int _supplierID)
        {
            SuppliersDTO supplier = new SuppliersDTO();
            DataTable dataTableSupplier = SuppliersDAL.Instance.Select();
            foreach (DataRow dataRow in dataTableSupplier.Rows)
            {
                
                supplier.SupplierID = Int32.Parse(dataRow["SupplierID"].ToString());
                supplier.CompanyName = supplier.SupplierID.ToString();
                supplier.ContactName = dataRow["ContactName"].ToString();
                supplier.Address = dataRow["Address"].ToString();
                supplier.Phone = dataRow["Phone"].ToString();
                supplier.Email = dataRow["Email"].ToString();
            }
            return supplier;
        }

        public DataTable GetSupplierBySearchString(string _searchString)
        {
            return SuppliersDAL.Instance.SelectBySearchString(_searchString);
        }

        public void Insert(string _companyName, string _contactName, string _address, string _phone, string _email)
        {
            SuppliersDAL.Instance.Insert(_companyName, _contactName, _address, _phone, _email);
        }

        public void Update(int _supplierID, string _companyName, string _contactName, string _address, string _phone, string _email)
        {
            SuppliersDAL.Instance.Update(_supplierID, _companyName, _contactName, _address, _phone, _email);
        }

        public void DeleteBySupplierID(int _supplierID)
        {
            SuppliersDAL.Instance.DeleteBySupplierID(_supplierID);
        }
    }
}

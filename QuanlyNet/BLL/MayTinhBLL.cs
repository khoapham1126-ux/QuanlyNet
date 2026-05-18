using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyNet.DAL.DBContext;
using QuanLyNet.Entity;
using QuanLyNet.DAL;
using System.Data.Entity.Core.Metadata.Edm;


namespace QuanlyNet.BLL
{
    internal class MayTinhBLL
    {
        private readonly MayTinhDAL dal= new MayTinhDAL();
        public List<MayTinh> GetAll()
        {
            return dal.GetAll();
        }
        public MayTinh getByID(int id)
        {
            return dal.getByID(id);
        }
        public void Add(MayTinh maytinh)
        {
            dal.Add(maytinh);
        }
        public void Update(MayTinh maytinh)
        {
            dal.Update(maytinh);
        }
        public void Delete(int id)
        {
            dal.Delete(id);
        }
        public void CapNhatTrangThai(int maMay, string trangThai)
        {
            dal.CapNhatTrangThai(maMay, trangThai);
        }
    }
}
 
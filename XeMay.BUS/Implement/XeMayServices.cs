using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeMays.BUS.Interface;
using XeMays.BUS.ViewModel;
using XeMays.DAL.Repositories.Implement;
using XeMays.DAL.Repositories.Interface;
using XeMays.DAL;
using XeMays.BUS.Utils;
using System.Diagnostics;
using XeMays.DAL.Entities;

namespace XeMays.BUS.Implement
{
    public class XeMayService : IXeMayService
    {
        private readonly IXeMayRepo _repo;
        private readonly Thithu103Context _context;

        public XeMayService()
        {
            _repo = new XeMayRepo();
            _context = new Thithu103Context();
        }

        public string Create(XeMayCreateVM xeMayCreate)
        {
            try
            {
                var xeMay = XeMayMapping.MapCreateVMToEntity(xeMayCreate);
                _repo.Create(xeMay); // Phương thức Create trong repository
                return "Thêm thành công";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Lỗi khi lưu dữ liệu: {ex.Message}");
                return $"Thêm thất bại: {ex.Message}";
            }
        }

        public bool Delete(int code)
        {
            return _repo.Delete(code);
        }

        public XeMayVM GetByCode(int code)
        {
            var entity = _repo.GetByCode(code);
            return entity != null ? XeMayMapping.MapEntityToVM(entity) : null;
        }

        public List<XeMayVM> GetList()
        {
            return _repo.GetList().Select(XeMayMapping.MapEntityToVM).ToList();
        }

        public bool Update(XeMayUpdateVM updateVM)
        {
            var entity = XeMayMapping.MapUpdateVMToEntity(updateVM);
            return _repo.Update(entity);
        }
    }
}

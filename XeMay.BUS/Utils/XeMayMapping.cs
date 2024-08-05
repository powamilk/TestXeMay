using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeMays.BUS.ViewModel;
using XeMays.DAL.Entities;
using XeMays.DAL;

namespace XeMays.BUS.Utils
{
    public class XeMayMapping
    {
        public static XeMayVM MapEntityToVM(XeMay entity)
        {
            return new XeMayVM()
            {
                Id = entity.Id,
                TenXe = entity.TenXe,
                IdHang = entity.IdHang,
                Gia = entity.Gia,
            };
        }

        public static XeMay MapCreateVMToEntity(XeMayCreateVM createVM)
        {
            return new XeMay()
            {
                Id = createVM.Id,
                TenXe = createVM.TenXe,
                IdHang = createVM.IdHang,
                Gia = createVM.Gia
            };
        }

        public static XeMay MapUpdateVMToEntity(XeMayUpdateVM updateVM)
        {
            return new XeMay()
            {
                Id = updateVM.Id,
                TenXe = updateVM.TenXe,
                IdHang = updateVM.IdHang,
                Gia = updateVM.Gia
            };
        }
    }
}

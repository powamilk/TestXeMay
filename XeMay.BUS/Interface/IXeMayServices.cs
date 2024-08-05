using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XeMays.BUS.ViewModel;

namespace XeMays.BUS.Interface
{
    public interface IXeMayService
    {
        XeMayVM GetByCode(int code);
        List<XeMayVM> GetList();
        string Create(XeMayCreateVM createVM);
        bool Delete(int code);
        bool Update(XeMayUpdateVM updateVM);
    }
}

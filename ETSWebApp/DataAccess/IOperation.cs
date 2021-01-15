using ETSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETSWebApp.DataAccess
{
   interface IOperation
    {
        List<OdemeModel> GetList();
        void AddList(OdemeModel odemeModel);
    }
}

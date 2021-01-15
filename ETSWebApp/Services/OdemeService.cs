using ETSWebApp.DataAccess;
using ETSWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETSWebApp.Services
{
     class OdemeService
     {
        private readonly IOperation _operation;

        public OdemeService(IOperation operation)
        {
            _operation = operation;
        }
        public void AddList(OdemeModel odemeModel)
        {
            _operation.AddList(odemeModel);
        }

        public List<OdemeModel> GetList()
        {
            List<OdemeModel> odemeler = null;
            odemeler = _operation.GetList();
            return odemeler;
        }
    }
}


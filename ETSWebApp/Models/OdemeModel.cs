using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETSWebApp.Models
{
    public class OdemeModel
    {
        #region Form Properties
        /// <summary>
        /// Formdan gelen property
        /// </summary>
        public string GiderTuru { get; set; }

        /// <summary>
        /// Formdan gelen property
        /// </summary>
        public int Miktarı { get; set; }

        /// <summary>
        /// Formdan gelen property
        /// </summary>
        public int Fiyati { get; set; }

        /// <summary>
        /// Formdan gelen property
        /// </summary>
        public string Tarihi { get; set; }

        /// <summary>
        /// Formdan gelen property
        /// </summary>
        public string Aciklama { get; set; }

        #endregion

    }
}

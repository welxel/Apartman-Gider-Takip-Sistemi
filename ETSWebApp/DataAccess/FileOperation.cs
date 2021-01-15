
using ETSWebApp.Data;
using ETSWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ETSWebApp.DataAccess
{
    public class FileOperation : IOperation
    {
        FileData fileData = new FileData();
        public void AddList(OdemeModel odemeModel)
        {
            using (StreamWriter writer = new StreamWriter(fileData._dersDosyaPath,true))
            {
                writer.WriteLine(odemeModel.GiderTuru + ";" + odemeModel.Miktarı + ";" + odemeModel.Fiyati + ";" + odemeModel.Tarihi + ";" + odemeModel.Aciklama);
            }
            GetList();
        }

        public List<OdemeModel> GetList()
        {
            int toplam;
            int counter = 0;
            string line;
            List<OdemeModel> odemeModels = new List<OdemeModel>();
            System.IO.StreamReader file =
                new System.IO.StreamReader(fileData._dersDosyaPath);
            while ((line = file.ReadLine()) != null)
            {
               
                string[] odemeler = line.Split(';');
                OdemeModel odemeModel = new OdemeModel()
                {
                    GiderTuru = odemeler[0],
                    Miktarı = Convert.ToInt32(odemeler[1]),
                    Fiyati = Convert.ToInt32(odemeler[2]),
                    Tarihi = odemeler[3],
                    Aciklama = odemeler[4]

                };
                odemeModels.Add(odemeModel);
                counter++;
            }

            file.Close();
            //System.Console.WriteLine("There were {0} lines.", counter);
            //// Suspend the screen.  
            //System.Console.ReadLine();

            return odemeModels;
        }
    }
}

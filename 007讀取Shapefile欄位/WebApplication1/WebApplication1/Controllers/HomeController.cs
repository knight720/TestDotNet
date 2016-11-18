using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using Vishcious.ArcGIS.SLContrib;
//using ESRI.ArcGIS.Client;
using System.Diagnostics;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            #region read shapefile

            //string filePath = @"C:\Temp\161107\Export_Output";

            //FileInfo fiSHP = new FileInfo(string.Format("{0}.shp",filePath));
            //FileInfo fiDBF = new FileInfo(string.Format("{0}.dbf",filePath));

            //ShapeFile sf = new ShapeFile();
            //sf.Read(fiSHP, fiDBF);
            //Graphic g = sf.Records[0].ToGraphic();

            //foreach (string s in g.Attributes.Keys)
            //{
            //    Debug.WriteLine(s);
            //}

            DotNetDBF.DBFReader dbfr = new DotNetDBF.DBFReader(@"C:\Temp\161107\Export_Output.dbf");
            foreach (DotNetDBF.DBFField f in dbfr.Fields)
            {
                Debug.WriteLine(f.Name);
            }
            
            #endregion read shapefile

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
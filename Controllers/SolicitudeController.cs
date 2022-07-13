using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPruebaMontana.DAO;
using WebPruebaMontana.Models;

namespace WebPruebaMontana.Controllers
{
    public class SolicitudeController : Controller
    {
        // GET: Solicitude
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            SolicitudeModel solicitudeModel = new SolicitudeModel();
            SolicitudeDAO solicitudeDAO = new SolicitudeDAO();
            dt = solicitudeDAO.ObtenerSolicitud(1);
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i< dt.Rows.Count; i++)
                {
                    solicitudeModel.SolicitudeId =Convert.ToInt32(dt.Rows[i]["SolicitudeId"].ToString());
                    solicitudeModel.Code = dt.Rows[i]["Code"].ToString();
                    solicitudeModel.FromDate =Convert.ToDateTime(dt.Rows[i]["FromDate"].ToString());
                    solicitudeModel.ToDate  = Convert.ToDateTime(dt.Rows[i]["ToDate"].ToString());
                    solicitudeModel.Name = dt.Rows[i]["Name"].ToString();
                    solicitudeModel.IsActive = dt.Rows[i]["IsActive"].ToString();
                    solicitudeModel.RegisterUser = dt.Rows[i]["RegisterUser"].ToString();
                    solicitudeModel.RegisterDate = Convert.ToDateTime(dt.Rows[i]["RegisterData"].ToString());
                    solicitudeModel.UpdateUser = dt.Rows[i]["UpdateUser"].ToString();
                    solicitudeModel.UpdateData = Convert.ToDateTime(dt.Rows[i]["UpdateData"].ToString());
                }
            }
            //ViewBag.Solicitud = solicitudeModel;
            ViewBag.Code = solicitudeModel.Code;
            return View();
        }
    }
}
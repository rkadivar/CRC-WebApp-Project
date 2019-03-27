// ===============================
// AUTHOR     :     Rashid Kadivar
// CREATE DATE     :    March 26, 2019
// PURPOSE     :    Home controller for MVC application
// SPECIAL NOTES:
// ===============================
// Change History:
//
//==================================

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        database_Access_Layer.db dblayer = new database_Access_Layer.db();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult Add_record(request rs)
        {
            string res = string.Empty;
            try
            {
                dblayer.Add_record(rs);
                res = "Inserted";
            }
            catch (Exception)
            {
                res = "failed";
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }


        public JsonResult update_record(request rs)
        {
            string res = string.Empty;
            try
            {
                dblayer.update_record(rs);
                res = "Updated";
            }
            catch (Exception)
            {
                res = "failed";
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }


        public JsonResult delete_record(int id)
        {
            string res = string.Empty;
            try
            {
                dblayer.deletedata(id);
                res = "Data deleted";
            }
            catch (Exception)
            {
                res = "failed";
            }
            return Json(res, JsonRequestBehavior.AllowGet);
        }



        public JsonResult Get_data()
        {
            DataSet ds = dblayer.get_record();
            List<request> requests = new List<request>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                requests.Add(new request
                {
                    requestid = Convert.ToInt32(dr["requestid"]),
                    requestorid = Convert.ToInt32(dr["requestorid"]),
                    requestType = dr["requestType"].ToString(),
                    bandwidth = Convert.ToDecimal(dr["bandwidth"]),
                    requestDateTime = (dr["requestDateTime"]).ToString(),
                    startDateTime = Convert.ToDateTime(dr["startDateTime"]).ToString("MM/dd/yyyy"),
                    requestStatus = (dr["requestStatus"]).ToString(),
                    antennaHeight = Convert.ToInt32(dr["antennaHeight"]),
                    startFrequency = Convert.ToDecimal(dr["startFrequency"]),
                    endFrequency = Convert.ToDecimal(dr["endFrequency"]),
                    tpower = Convert.ToDecimal(dr["tpower"]),
                    latitude = Convert.ToDecimal(dr["latitude"]),
                    longitude = Convert.ToDecimal(dr["longitude"]),
                    radius = Convert.ToDecimal(dr["radius"]),
                    duration = Convert.ToInt32(dr["duration"]),
                    dutyCycle = Convert.ToInt32(dr["dutyCycle"]),
                    trafficModel = dr["trafficModel"].ToString(),
                });
            }
            return Json(requests, JsonRequestBehavior.AllowGet);
        }


        public JsonResult Get_databyid(int id)
        {
            DataSet ds = dblayer.get_recordbyid(id);
            List<request> requests = new List<request>();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                requests.Add(new request
                {
                    requestid = Convert.ToInt32(dr["requestid"]),
                    requestorid = Convert.ToInt32(dr["requestorid"]),
                    requestType = dr["requestType"].ToString(),
                    antennaHeight = Convert.ToInt32(dr["antennaHeight"]),
                    renewal = dr["renewal"].ToString(),
                    startFrequency = Convert.ToDecimal(dr["startFrequency"]),
                    endFrequency = Convert.ToDecimal(dr["endFrequency"]),
                    bandwidth = Convert.ToDecimal(dr["bandwidth"]),
                    aclLevel = Convert.ToDecimal(dr["aclLevel"]),
                    tpower = Convert.ToDecimal(dr["tpower"]),
                    receiverSens = Convert.ToDecimal(dr["receiverSens"]),
                    coChannelReceiver = Convert.ToDecimal(dr["coChannelReceiver"]),
                    adjacentChannel = Convert.ToDecimal(dr["adjacentChannel"]),
                    latitude = Convert.ToDecimal(dr["latitude"]),
                    longitude = Convert.ToDecimal(dr["longitude"]),
                    radius = Convert.ToDecimal(dr["radius"]),
                    requestDateTime = (dr["requestDateTime"]).ToString(),
                    startDateTime = (dr["startDateTime"]).ToString(),
                    duration= Convert.ToInt32(dr["duration"]),
                    dutyCycle = Convert.ToInt32(dr["dutyCycle"]),
                    repeatCount = Convert.ToInt32(dr["repeatCount"]),
                    repeatInterval = Convert.ToInt32(dr["repeatInterval"]),
                    trafficModel = dr["trafficModel"].ToString(),
                    qosLevelRequired = Convert.ToInt32(dr["qosLevelRequired"]),
                    radioFlags = Convert.ToInt32(dr["radioFlags"]),
                    requestStatus = dr["requestStatus"].ToString(),
                });
            }
            return Json(requests, JsonRequestBehavior.AllowGet);
        }

    }
}
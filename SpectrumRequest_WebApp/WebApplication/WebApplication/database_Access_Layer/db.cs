// ===============================
// AUTHOR     :     Rashid Kadivar
// CREATE DATE     :    March 26, 2019
// PURPOSE     :   Data base access with C# for MVC model
// SPECIAL NOTES:
// ===============================
// Change History:
//
//==================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using WebApplication.Models;

namespace WebApplication.database_Access_Layer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void Add_record(request rs)
        {
            //here we call the stored procedure from the database and add a new row to the table
            SqlCommand com = new SqlCommand("rkadivar.Sp_Request_Add", con);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@requestorid", rs.requestorid);
            com.Parameters.AddWithValue("@requestType", rs.requestType);
            com.Parameters.AddWithValue("@antennaHeight", rs.antennaHeight);
            com.Parameters.AddWithValue("@renewal", rs.renewal);
            com.Parameters.AddWithValue("@startFrequency", rs.startFrequency);
            com.Parameters.AddWithValue("@endFrequency", rs.endFrequency);
            com.Parameters.AddWithValue("@bandwidth", rs.bandwidth);
            com.Parameters.AddWithValue("@aclLevel", rs.aclLevel);
            com.Parameters.AddWithValue("@tpower", rs.tpower);
            com.Parameters.AddWithValue("@receiverSens", rs.receiverSens);
            com.Parameters.AddWithValue("@coChannelReceiver", rs.coChannelReceiver);
            com.Parameters.AddWithValue("@adjacentChannel", rs.adjacentChannel);
            com.Parameters.AddWithValue("@latitude", rs.latitude);
            com.Parameters.AddWithValue("@longitude", rs.longitude);
            com.Parameters.AddWithValue("@radius", rs.radius);
            com.Parameters.AddWithValue("@requestDateTime", rs.requestDateTime);
            com.Parameters.AddWithValue("@startDateTime", rs.startDateTime);
            com.Parameters.AddWithValue("@duration", rs.duration);
            com.Parameters.AddWithValue("@dutyCycle", rs.dutyCycle);
            com.Parameters.AddWithValue("@repeatCount", rs.repeatCount);
            com.Parameters.AddWithValue("@repeatInterval", rs.repeatInterval);
            com.Parameters.AddWithValue("@trafficModel", rs.trafficModel);
            com.Parameters.AddWithValue("@qosLevelRequired", rs.qosLevelRequired);
            com.Parameters.AddWithValue("@radioFlags", rs.radioFlags);
            com.Parameters.AddWithValue("@requestStatus", rs.requestStatus);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void update_record(request rs)
        {
            //here we call the stored procedure from the database and add a new row to the table
            SqlCommand com = new SqlCommand("rkadivar.Sp_Request_Update", con);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@requestid", rs.requestid);
            com.Parameters.AddWithValue("@requestorid", rs.requestorid);
            com.Parameters.AddWithValue("@requestType", rs.requestType);
            com.Parameters.AddWithValue("@antennaHeight", rs.antennaHeight);
            com.Parameters.AddWithValue("@renewal", rs.renewal);
            com.Parameters.AddWithValue("@startFrequency", rs.startFrequency);
            com.Parameters.AddWithValue("@endFrequency", rs.endFrequency);
            com.Parameters.AddWithValue("@bandwidth", rs.bandwidth);
            com.Parameters.AddWithValue("@aclLevel", rs.aclLevel);
            com.Parameters.AddWithValue("@tpower", rs.tpower);
            com.Parameters.AddWithValue("@receiverSens", rs.receiverSens);
            com.Parameters.AddWithValue("@coChannelReceiver", rs.coChannelReceiver);
            com.Parameters.AddWithValue("@adjacentChannel", rs.adjacentChannel);
            com.Parameters.AddWithValue("@latitude", rs.latitude);
            com.Parameters.AddWithValue("@longitude", rs.longitude);
            com.Parameters.AddWithValue("@radius", rs.radius);
            com.Parameters.AddWithValue("@requestDateTime", rs.requestDateTime);
            com.Parameters.AddWithValue("@startDateTime", rs.startDateTime);
            com.Parameters.AddWithValue("@duration", rs.duration);
            com.Parameters.AddWithValue("@dutyCycle", rs.dutyCycle);
            com.Parameters.AddWithValue("@repeatCount", rs.repeatCount);
            com.Parameters.AddWithValue("@repeatInterval", rs.repeatInterval);
            com.Parameters.AddWithValue("@trafficModel", rs.trafficModel);
            com.Parameters.AddWithValue("@qosLevelRequired", rs.qosLevelRequired);
            com.Parameters.AddWithValue("@radioFlags", rs.radioFlags);
            com.Parameters.AddWithValue("@requestStatus", rs.requestStatus);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataSet get_record()
        {
            //connection to the Store procedure to read the data from db
            SqlCommand com = new SqlCommand("spectrumrequest_get_sp", con);
            com.Connection = con;
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet get_recordbyid(int requestid)
        {
            SqlCommand com = new SqlCommand("spectrumrequest_get_byid", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@requestid", requestid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void deletedata(int requestid)
        {
            SqlCommand com = new SqlCommand("spectrumrequest_delete_sp", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@requestid", requestid);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
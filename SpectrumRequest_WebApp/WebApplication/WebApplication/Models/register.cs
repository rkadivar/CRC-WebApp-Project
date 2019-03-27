// ===============================
// AUTHOR     :     Rashid Kadivar
// CREATE DATE     :    March 26, 2019
// PURPOSE     :    Mapping an element from DB to MVC model
// SPECIAL NOTES:
// ===============================
// Change History:
//
//==================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class request
    {
        public int requestid { get; set; }
        public int requestorid { get; set; }
        public string requestType { get; set; }
        public int antennaHeight { get; set; }
        public string renewal { get; set; }
        public Decimal startFrequency { get; set; }
        public Decimal endFrequency { get; set; }
        public Decimal bandwidth { get; set; }
        public Decimal aclLevel { get; set; }
        public Decimal tpower { get; set; }
        public Decimal receiverSens { get; set; }
        public Decimal coChannelReceiver { get; set; }
        public Decimal adjacentChannel { get; set; }
        public Decimal latitude { get; set; }
        public Decimal longitude { get; set; }
        public Decimal radius { get; set; }
        public string requestDateTime { get; set; }
        public string startDateTime { get; set; }
        public int duration { get; set; }
        public int dutyCycle { get; set; }
        public int repeatCount { get; set; }
        public int repeatInterval { get; set; }
        public string trafficModel { get; set; }
        public int qosLevelRequired { get; set; }
        public int radioFlags { get; set; }
        public string requestStatus { get; set; }
    }
}
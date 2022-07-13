using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPruebaMontana.Models
{
    public class SolicitudeModel
    {
        public int SolicitudeId { get; set; }
        public string Code { get; set; } 
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Name { get; set; }
        public string IsActive { get; set; }
        public string RegisterUser { get; set; }
        public DateTime RegisterDate { get; set; }
        public string UpdateUser { get; set; }
        public DateTime UpdateData { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PwCRiskDatabase.Models
{
    public class RiskInfor
    {
        public int Id { get; set; }
        public string RiskName { get; set; }
        public string RiskPoint { get; set; }
        public RiskInfor(int Id, string RiskName, string RiskPoint)
        {
            this.Id = Id;
            this.RiskName = RiskName;
            this.RiskPoint = RiskPoint;
        }
    }
}
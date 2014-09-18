using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PwCRiskDatabase.Models;

namespace PwCRiskDatabase.IDAL
{
    public interface IRisk
    {
        RiskInfor GetRiskInfor();
    }
}
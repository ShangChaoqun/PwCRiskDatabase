using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PwCRiskDatabase.Models;

namespace PwCRiskDatabase.IDAL
{
    //All method should be achieved in Risk
    public interface IRisk
    {
        RiskInfor GetRiskInfor();
    }
}

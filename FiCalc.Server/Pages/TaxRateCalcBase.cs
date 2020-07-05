using System;
using System.ComponentModel;
using System.Linq;
using FiCalc.Server.Enums;
using FiCalc.Server.Helper;
using Microsoft.AspNetCore.Components;

namespace FiCalc.Server.Pages
{
    public class TaxRateCalcBase : ComponentBase
    {
        public static decimal GetTaxRate(decimal income, FileStatusEnum fileStatus)
        {
            if (fileStatus == FileStatusEnum.Single)
                return TaxBandHelper.SingleBands().First(b => income >= b.Lower && income <= b.Upper).Rate;

            if (fileStatus == FileStatusEnum.MarriedJointly)
                return TaxBandHelper.MarriedJointBands().First(b => income >= b.Lower && income <= b.Upper).Rate;

            throw new Exception($"FileStatus Unknown, unable to continue.");
        }
    }
}

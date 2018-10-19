using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IEXAPI
{
    public enum Range
    {
        [Description("5y")]
        FiveYears,

        [Description("2y")]
        TwoYears,

        [Description("1y")]
        OneYear,

        [Description("ytd")]
        YearToDate,

        [Description("6m")]
        SixMonths,

        [Description("3m")]
        ThreeMonths,

        [Description("1m")]
        OneMonth
    }
}

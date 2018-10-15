﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IEXAPI
{

    public class Company
    {
        public string symbol { get; set; }
        public string companyName { get; set; }
        public string exchange { get; set; }
        public string industry { get; set; }
        public string website { get; set; }
        public string description { get; set; }
        public string CEO { get; set; }
        public string issueType { get; set; }
        public string sector { get; set; }
        public string[] tags { get; set; }
    }
}

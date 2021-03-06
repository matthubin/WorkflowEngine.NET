﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WF.Sample.Business;
using WF.Sample.Business.Models;

namespace WF.Sample.Models
{
    public class DocumentListModel
    {
        public int Count { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public List<Document> Docs { get; set; }
    }
}
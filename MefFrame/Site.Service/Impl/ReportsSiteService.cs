﻿//------------------------------------------------------------------------------
// <copyright file="ReportsConfiguration.generated.cs">
//        生成时间：2014-09-02 13:50
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using Core.Service.Impl;
using Core.Models;

namespace Site.Service.Impl
{
    /// <summary>
    /// ——Reports
    /// </summary>  
    [Export(typeof(IReportsSiteContract))]
    internal class ReportsSiteService : ReportsService, IReportsSiteContract
    {
       
    }
}
﻿using System.Web;
using System.Web.Mvc;

namespace Homeappliences_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
﻿using System.Web;
using System.Web.Mvc;

namespace BE_U2_W1_D3_D4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace TicketBooking_WebAPI_Service
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}

﻿using System.Web;
using System.Web.Mvc;

namespace e_commerce_ASP
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}

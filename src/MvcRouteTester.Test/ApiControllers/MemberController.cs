﻿using System.Web.Http;

namespace MvcRouteTester.Test.ApiControllers
{
	public class MemberController: ApiController
	{
		[HttpGet]
		public bool ChangePassword(int memberId, string newPassword)
		{
			return memberId != 1;
		}
	}
}
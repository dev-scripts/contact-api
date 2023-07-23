﻿using System;
namespace Contacts.Api.Models
{
	public class ContactUpdateRequest
	{
		public string FullName { get; set; }

		public string Email { get; set; }

		public long Phone { get; set; }

		public string Address { get; set; }
	}
}


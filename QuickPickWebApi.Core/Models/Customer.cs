﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuickPickWebApi.Core.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public int City { get; set; }
        public int State { get; set; }
        public int Country { get; set; }
        public int PinCode { get; set; }
        public DateTime TimeCreated { get; set; }
        public bool IsActive { get; set; }

    }
}

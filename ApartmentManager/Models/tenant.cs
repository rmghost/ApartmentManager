﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApartmentManager.Models
{
    public class Tenant
    {
        [Key]
        public int TenantId { get; set; }

        [ForeignKey("HousingUnit")]
        [Display(Name = "Unit Number")]
        public int UnitId { get; set; }
        public HousingUnit HousingUnit { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
    }
}
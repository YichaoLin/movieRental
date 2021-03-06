﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codly.Models;
using System.ComponentModel.DataAnnotations;

namespace Codly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

       // [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

       // [Display(Name = "Membership Type")]
       // [Min18YearsIfAMember]
        public byte MembershipTypeId { get; set; }
    }
}
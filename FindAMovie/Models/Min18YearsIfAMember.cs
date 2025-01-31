﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindAMovie.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthdate == null)
            {
                return new ValidationResult("Birthdate is required.");
            }

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            if (age >= 18)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Customer should be at least 18 years old.");
            }
        }
    }
}
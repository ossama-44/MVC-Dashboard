﻿using MVC.DAL.Entites;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.AspNetCore.Http;

namespace MVC.PL.Models
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string Name { get; set; }

        public int? Age { get; set; }
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentViewModel Department { get; set; }
    }
}

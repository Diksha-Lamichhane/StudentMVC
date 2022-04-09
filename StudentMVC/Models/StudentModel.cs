using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentMVC.Models
{
    public class StudentModel
    {
        public int Student_ID { get; set; }

        [Required(ErrorMessage = "Name is required..!!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required..!!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Phone is required..!!")]
        public string Phone { get; set; }

    }
}
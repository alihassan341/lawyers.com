//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lawyers.com.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Appointment
    {   [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Please enter Email ID")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "PhoneNumber")]
        public int Phone { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Appointment Date")]
        public System.DateTime Date { get; set; }
        [Required(ErrorMessage = "Issue is required")]
        [DataType(DataType.Text)]
        [Display(Name = "Issue")]
        public string Issue { get; set; }
        public string Status { get; set; }
        public int Lid { get; set; }
        public int Cid { get; set; }
    
        public virtual client client { get; set; }
        public virtual lawyer lawyer { get; set; }
    }
}

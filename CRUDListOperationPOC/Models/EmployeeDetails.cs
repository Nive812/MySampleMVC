using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CRUDListOperationPOC.Models
{
    public class EmployeeDetails
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Employee Id shouldn't be Null")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Employee Id")]
        public int employeeid { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "First Name shouldn't be Null")]
        [DataType (DataType.Text)]
        [DisplayName("Employee First Name")]
        public string firstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Last Name shouldn't be Null")]
        [DataType(DataType.Text)]
        [DisplayName("Employee Last Name")]
        public string lastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Email Id shoudn't be Null")]
        [DataType(DataType.Text)]
        [DisplayName("Email Id")]
        public string email { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [DisplayName("Gender")]
        public string gender { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Address")]
        public string streetAddress { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("City")]
        public string city { get; set; }

        [DataType(DataType.Text)]
        [DisplayName("Country")]
        public string country { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayName("Zip Code")]
        public string zipCode { get; set; }

        [Required (AllowEmptyStrings =false,ErrorMessage ="Phone/Mobile Number shouldn't be Null")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Mobile/Phone Number:")]
        public string phone { get; set; }

    }
}
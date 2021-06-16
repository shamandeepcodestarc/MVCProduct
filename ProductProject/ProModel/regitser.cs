using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductProject.ProModel
{
    public class regitser
    {

        public Nullable<System.Guid> Id { get; set; }
        [DisplayName("Username")]
        [Required(ErrorMessage ="Username is required")]
        public string username { get; set; }
        [Required(ErrorMessage = "Fullname is required")]
        [DisplayName("Fullname")]
        public string fullname { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [DisplayName("Age")]
        public int age { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required(ErrorMessage = "ConformPassword is required")]
        [DisplayName("ConformPassword")]
        [DataType(DataType.Password)]
        [Compare("password",ErrorMessage ="Password is not match")]
        public string conformpassword { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [DisplayName("Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in a valid format. Example of correct format: joe.example@example.org")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required(ErrorMessage = "Username is required")]
        [DisplayName("UserPhonename")]
        public string phone { get; set; }
        public bool isdelete { get; set; }
        public bool isactive { get; set; }
    }
}
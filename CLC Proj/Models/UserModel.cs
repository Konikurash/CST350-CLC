using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CLC_Proj.Models
{
    public class UserModel
    {
        [Required]
        [DisplayName("First Name")]
        [StringLength(12, MinimumLength =2)]
        public string firstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        [StringLength(15, MinimumLength = 3)]
        public string lastName { get; set; }

        [DisplayName("Gender")]
        [StringLength(20, MinimumLength = 1)]
        public string sex { get; set; }

        [DisplayName("Age")]
        [Range(1, 115)]
        public int age { get; set; }

        [DisplayName("State")]
        [StringLength(2, MinimumLength = 2)]
        public string state { get; set; }

        [Required]
        [DisplayName("Email Address")]
        [StringLength(30, MinimumLength = 6)]
        public string email { get; set; }

        [Required]
        [DisplayName("Username")]
        [StringLength(18, MinimumLength = 1)]
        public string userName { get; set; }

        [Required]
        [DisplayName("Password")]
        [StringLength(22, MinimumLength = 8)]
        public string password { get; set; }

        public UserModel()
        {

        }

        public UserModel(string firstName, string lastName, string sex, int age, string state, string email, string userName, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.age = age;
            this.state = state;
            this.email = email;
            this.userName = userName;
            this.password = password;
        }
    }
}

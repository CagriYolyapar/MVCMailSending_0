using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCMailSending_0.Models.Entities
{
    public class AppUser:BaseEntity
    {
        public string UserName { get; set; }

        [EmailAddress(ErrorMessage ="Lütfen email formatında bir adres giriniz")]
        public string Email { get; set; }

    }
}
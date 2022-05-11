using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using AspNetCore.Authentication.SK.SmartID.Helpers;
using Microsoft.AspNetCore.Authorization;
using WebApplication4;
namespace WebApplication5.Pages
{
    public class IndexModel : PageModel
    {
       

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public string VerificationCode { get; set; }

        public class InputModel
        {
            [Required]
            [Display(Name = "Country Code")]
            public string CountryCode { get; set; }

            [Required]
            [Display(Name = "National Identity Number")]
            public string NationalIdentityNumber { get; set; }
        }

        
    }
}

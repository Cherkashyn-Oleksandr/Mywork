using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LoginPageAndSmartID
{
    [AllowAnonymous]
    public class SmartIdAuthenticationModel : PageModel
    {
        private readonly IAuthenticationPropertiesProvider _authenticationPropertiesProvider;

        public SmartIdAuthenticationModel(IAuthenticationPropertiesProvider authenticationPropertiesProvider)
        {
            _authenticationPropertiesProvider = authenticationPropertiesProvider;
        }

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

        public void OnGet(string returnUrl = null, string remoteError = null)
        {
            ReturnUrl = returnUrl ?? Url.Content("~/");

            if (remoteError != null)
                ModelState.AddModelError(String.Empty, remoteError);
        }

        public IActionResult OnPost(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            if (ModelState.IsValid)
            {
                var properties = _authenticationPropertiesProvider.ConfigureProperties(returnUrl, User);
                properties.SetString("CountryCode", Input.CountryCode);
                properties.SetString("NationalIdentityNumber", Input.NationalIdentityNumber);
                
                return new ChallengeResult(SmartIdDefaults.AuthenticationScheme, properties);
            }

            return Page();
        }

        public IActionResult OnGetShowVerificationCode(string sessionId, string verificationCode, string hash, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            VerificationCode = verificationCode;

            var redirectUrl = Url.Page("./SmartIdAuthentication", "CheckSession",
                new { sessionId, hash, returnUrl });
            Response.Headers.Add("REFRESH", $"3;URL={redirectUrl}");

            return Page();
        }

        public IActionResult OnGetCheckSession(string sessionId, string hash, string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");

            var properties = _authenticationPropertiesProvider.ConfigureProperties(returnUrl, User);
            properties.SetString("SessionId", sessionId);
            properties.SetString("Hash", hash);

            return new ChallengeResult(SmartIdDefaults.AuthenticationScheme, properties);
        }
    }
}

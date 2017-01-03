using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Net;
using System.Net.Mail;
using HelpingHands.Models;
using System.Threading.Tasks;

namespace HelpingHands.Controllers
{
    public class AccountController : Controller
    {
        HelpingHandsEntities HelpingHandsDb = new HelpingHandsEntities();        

        //
        // GET: /Account/LogOn

        public ActionResult LogOn()
        {
            return View();
        }

        //
        // POST: /Account/LogOn

        [HttpPost]
        public ActionResult LogOn(LogOnModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {                

                User user = HelpingHandsDb.GetUser(model.UserName);

                if (user != null) 
                {
                    if (user.Password.Equals(model.Password))
                    {

                        FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);

                        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
                            && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "The password provided is incorrect.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "The user name provided is incorrect.");
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }

        //
        // GET: /Account/Register

        public ActionResult Register()
        {
            return View();
        }

        //
        // POST: /Account/Register

        [HttpPost]
        public ActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                if (HelpingHandsDb.Users.Count(u => u.UserName == model.UserName) == 0)
                {
                    // Attempt to register the user, and creates a table in case it's not there
                    
                    HelpingHandsDb.Users.Add(model);
                    HelpingHandsDb.SaveChanges();
                    FormsAuthentication.SetAuthCookie(model.UserName, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                else
                {                    
                    ModelState.AddModelError(string.Empty, "User already exist");
                    return View();
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //GET: /Account/ForgotPassword

        // [Authorize]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        // [Authorize]
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {

                User user = HelpingHandsDb.GetUser(model.UserName);

                if (user != null)
                {
                    var password = model.UserName + user.Id;
                    user.Password = password;
                    user.ConfirmPassword = password;
                    HelpingHandsDb.SaveChanges();
                    ////
                    await SendEmail(model, user, password);
                    return RedirectToAction("Sent");
                    ////
                }
                else
                {
                    ModelState.AddModelError("", "The user name provided is incorrect.");
                }
            }
            // If we got this far, something failed, redisplay form
            return View(model);

        }

        private async Task SendEmail(ForgotPasswordModel model, User user, string password)
        {
            var bodyTemplate = "<p>User Name: {0} <p>{1}</p>";
            var message = new MailMessage();
            message.To.Add(new MailAddress(user.Email));  // replace with valid value 
            message.From = new MailAddress("TeamHelpingHands5@gmail.com");  // replace with valid value
            message.Subject = "Your new pasword";
            message.Body = string.Format(bodyTemplate, model.UserName, "Your new password is: " + password);
            message.IsBodyHtml = true;

            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "teamhelpinghands5@gmail.com",  // replace with valid value
                    Password = "helpinghands2016"  // replace with valid value
                };
                smtp.Credentials = credential;
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                await smtp.SendMailAsync(message);                
            }
        }

        public ActionResult Sent()
        {
            return View();
        }

        //
        // GET: /Account/ChangePassword

        // [Authorize]
        public ActionResult ChangePassword()
        {
            return View();
        }

        //
        // POST: /Account/ChangePassword

        [Authorize]
        [HttpPost]
        public ActionResult ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {                
                string CurrentUser = User.Identity.Name.ToString();                
                User user = HelpingHandsDb.GetUser(CurrentUser);
                  if (user != null)
                  {
                      if (user.Password == model.OldPassword)
                      {
                          user.Password = model.NewPassword;
                          user.ConfirmPassword = model.ConfirmPassword;
                          HelpingHandsDb.SaveChanges();
                          return RedirectToAction("ChangePasswordSuccess");
                    }
                      else
                      {
                          ModelState.AddModelError("", "The current password is incorrect.");
                      }
                  }
                  else
                  {
                      ModelState.AddModelError("", "For some straing reson, user is not in table. This is imposible in this point ");
                  }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        //
        // GET: /Account/ChangePasswordSuccess

        public ActionResult ChangePasswordSuccess()
        {
            return View();
        }
        

        #region Status Codes
        private static string ErrorCodeToString(MembershipCreateStatus createStatus)
        {
            // See http://go.microsoft.com/fwlink/?LinkID=177550 for
            // a full list of status codes.
            switch (createStatus)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "User name already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A user name for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
        #endregion
    }
}

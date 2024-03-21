using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using NuGet.Packaging;
using NuGet.Protocol.Plugins;
using SecurePassageProjects.DataContext;
using SecurePassageProjects.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace SecurePassageProjects.Controllers
{
    public class securepassController : Controller
    {
        private readonly SecureDbContext secureDbContext;
        private readonly IHttpContextAccessor _contxt;


        public securepassController(SecureDbContext secureDbContext, IHttpContextAccessor contxt)
        {
            this.secureDbContext = secureDbContext;
            this._contxt = contxt;
        }

        [HttpGet]
        public IActionResult signin()
        {


            return View();
        }
        [HttpPost]
        public IActionResult signin(signupModel signup)
        {
            var existingUser = secureDbContext.signupModels.FirstOrDefault(s=>s.PhoneNumber==signup.PhoneNumber);

            

            if (existingUser != null)
            {
                // Set flag to indicate phone number already exists
                ViewBag.PhoneNumberExists = true;

                // You can redirect back to the signup page or return the view directly
                return View(signup);
            }

            var signinValues = new signupModel()
            {
                UserName = signup.UserName,
                PhoneNumber= signup.PhoneNumber,
                PassWord= signup.PassWord,


            };


            secureDbContext.signupModels.Add(signinValues);
            secureDbContext.SaveChanges();


            return RedirectToAction("Logiin");
        }


        [HttpGet]
        public IActionResult Logiin()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Logiin(signupModel logiin)
        {
            

            var LogincheckbyNumber = secureDbContext.signupModels.FirstOrDefault(u=>u.PhoneNumber==logiin.PhoneNumber && u.PassWord ==logiin.PassWord);
            if (LogincheckbyNumber == null)
            {
                ViewBag.PhoneNumberExists = true;
                return View(logiin);
            }


                int getIdconvert = Convert.ToInt32(JsonConvert.SerializeObject(LogincheckbyNumber.signupId));
                _contxt.HttpContext.Session.SetInt32("getIdloginController", getIdconvert);
            
          

            if (LogincheckbyNumber != null)
            {
                return RedirectToAction("createaccount");
            }
          
            return View();
           
        }

        [HttpGet]
        public IActionResult createaccount()
        {


            return View();
        }

        [HttpPost]
        public IActionResult createaccount(GoogleModel google,string dropdownValue,InstgramModel instgram,FacebookModel facebook ,BankingModel banking)
        
        {
            int? idPlace = _contxt.HttpContext.Session.GetInt32("getIdloginController");

            if (dropdownValue == "GOOGLE")
            {
                var googleval = new GoogleModel()
                {
                    Accounttypego = dropdownValue,
                    GoogleuserName = google.GoogleuserName,
                    GooglePassword = google.GooglePassword,
                    signupModelsignupId = idPlace


                };

                secureDbContext.googleModels.Add(googleval);
                secureDbContext.SaveChanges();
            }

            else if (dropdownValue== "INSTAGRAM")
            {
                var instavalues = new InstgramModel()
                {
                    AccounttypeIN=dropdownValue,
                    INuserName=instgram.INuserName,
                    INPassword=instgram.INPassword,
                    signupModelsignupId = idPlace,

                };
                secureDbContext.instgramModels.Add(instavalues);
                secureDbContext.SaveChanges();

            }

            else if(dropdownValue== "FACEBOOK")
            {
                var fbvalues = new FacebookModel()
                {
                    AccounttypeFb=dropdownValue,
                    FBuserName=facebook.FBuserName,
                    FBPassword=facebook.FBPassword,
                    signupModelsignupId=idPlace,


                };
                secureDbContext.facebookModels.Add(fbvalues);
                secureDbContext.SaveChanges();
            }

            else if (dropdownValue == "BANKING")
            {
                var bankingvalues = new BankingModel()
                {
                    accounttype=dropdownValue,
                    Bankname=banking.Bankname,
                    BankPhonenumber=banking.BankPhonenumber,
                    UPIPin=banking.UPIPin,
                    signupModelsignupId = idPlace,

                };
                secureDbContext.bankingModels.Add(bankingvalues);
                secureDbContext.SaveChanges();

            }




            // return RedirectToAction("createaccount");
            return Json(new { success = true});
            return View();
        }


        [HttpGet]
        public IActionResult Forgotpass()
        {
          

            return View();
        }

        [HttpPost]
        public IActionResult Forgotpass( string phoneNumber)
        {
            var getPassword = secureDbContext.signupModels.FirstOrDefault(i => i.PhoneNumber == phoneNumber);
            if (getPassword == null)
            {
                return Json(  new { success = false } );
            }

            signupModel model = new signupModel
            {
                PassWord = getPassword.PassWord
            };

            return Json(new { password = getPassword.PassWord , success = true });
        }


       
        public IActionResult Dashboard()
        {
            int? idPlace = _contxt.HttpContext.Session.GetInt32("getIdloginController");


            var allrecords = new CompositeModel
            {

                GoogleModelss = secureDbContext.googleModels.Where(i => i.signupModelsignupId == idPlace).ToList(),
                FacebookModelss = secureDbContext.facebookModels.Where(i => i.signupModelsignupId == idPlace).ToList(),
                InstagramModelss = secureDbContext.instgramModels.Where(i => i.signupModelsignupId == idPlace).ToList(),
                BankingModelss = secureDbContext.bankingModels.Where(i => i.signupModelsignupId == idPlace).ToList(),

            };


            return View(allrecords);
        }

        [HttpGet]
        public IActionResult googleedit(string Accounttypego,int Id)
        {
            
                var googleEdits = secureDbContext.googleModels.Find(Id);
                return View(googleEdits);

        }

        [HttpGet]
        public IActionResult facebookedit(string Accounttypego, int Id) {

            var facebookEdits = secureDbContext.facebookModels.Find(Id);

            return View(facebookEdits);
        }

        [HttpGet]
        public IActionResult instaedit(string Accounttypego, int Id)
        {

            var instaEdits = secureDbContext.instgramModels.Find(Id);

            return View(instaEdits);
        }

        [HttpGet]
        public IActionResult bankingedit(string Accounttypego, int Id)
        {

            var bankingedits = secureDbContext.bankingModels.Find(Id);

            return View(bankingedits);
        }

        [HttpPost]
        public IActionResult googleedit(int Id , string Accounttypego,GoogleModel updatedGoogleModel)
        {

          

                var editsData = secureDbContext.googleModels.Find(Id);

            editsData.GoogleuserName=updatedGoogleModel.GoogleuserName;
            editsData.GooglePassword=updatedGoogleModel.GooglePassword;
            editsData.Accounttypego = updatedGoogleModel.Accounttypego;
             secureDbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        public IActionResult facebookedit(int Id, string Accounttypego, FacebookModel updatedFacebookModel)
        {



            var editsData = secureDbContext.facebookModels.Find(Id);

            editsData.FBuserName = updatedFacebookModel.FBuserName;
            editsData.FBPassword = updatedFacebookModel.FBPassword;
            editsData.AccounttypeFb = updatedFacebookModel.AccounttypeFb;
            secureDbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [HttpPost]
        public IActionResult instaedit(int Id, string Accounttypego, InstgramModel updatedInstgramModel)
        {



            var editsData = secureDbContext.instgramModels.Find(Id);

            editsData.INuserName = updatedInstgramModel.INuserName;
            editsData.INPassword = updatedInstgramModel.INPassword;
            editsData.AccounttypeIN = updatedInstgramModel.AccounttypeIN;
            secureDbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        [HttpPost]
        public IActionResult bankingedit(int Id, string Accounttypego, BankingModel updatedBankingModel)
        {



            var editsData = secureDbContext.bankingModels.Find(Id);

            editsData.Bankname = updatedBankingModel.Bankname;
            editsData.BankPhonenumber = updatedBankingModel.BankPhonenumber;
            editsData.UPIPin=updatedBankingModel.UPIPin;
            editsData.accounttype = updatedBankingModel.accounttype;
            secureDbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [HttpPost]
        public IActionResult delete(int GoogleId,int FacebookId,int InstaId,int bankId, GoogleModel google,FacebookModel facebook,InstgramModel instgram,BankingModel banking)
        {
            if (google.Accounttypego == "GOOGLE")
            {
                var googleEdits = secureDbContext.googleModels.Find(GoogleId);
                secureDbContext.googleModels.Remove(googleEdits);
                secureDbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }





            else if (facebook.AccounttypeFb == "FACEBOOK")
            {
                var facebookdelete = secureDbContext.facebookModels.Find(FacebookId);
                secureDbContext.facebookModels.Remove(facebookdelete);
                secureDbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }

            else if (instgram.AccounttypeIN == "INSTAGRAM")
            {
                var instadelete = secureDbContext.instgramModels.Find(InstaId);
                secureDbContext.instgramModels.Remove(instadelete);
                secureDbContext.SaveChanges();
                return RedirectToAction("Dashboard");

            }

            else if (banking.accounttype == "BANKING")
            {
                var bankingdelete = secureDbContext.bankingModels.Find(bankId);
                secureDbContext.bankingModels.Remove(bankingdelete);
                secureDbContext.SaveChanges();
                return RedirectToAction("Dashboard");

            }

            return View();
        }
    }
}


using System.Web.Mvc;

namespace MyResume.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void ResponseForm(Response responseModel)
        {
            using (Model db = new Model())
            {
                Response newResp = new Response { Response_id = 1, Name = responseModel.Name, Email = responseModel.Email,
                    Phone = responseModel.Phone, Subject = responseModel.Subject, Message = responseModel.Message };
                db.Response.Add(newResp);
                db.SaveChanges();
            }
        }

    }
}
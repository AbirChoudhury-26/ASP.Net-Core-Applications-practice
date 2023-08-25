//using FirstCoreMVCWebApplication.Models;
//using Microsoft.AspNetCore.Mvc;
//namespace FirstCoreMVCWebApplication.Controllers
//{
//    public class HomeController : Controller
//    {
//        public JsonResult GetStudentDetails(int Id)
//        {
//            StudentRepository repository = new StudentRepository();
//            Student studentDetails = repository.GetStudentById(Id);
//            return Json(studentDetails);
//        }

//    }
//}


// Here we wil be defining an Index methid ,which simply returns a view.
// This is done tyo ensure that  when view file be created with "index,cshtml" .
// It is so because whenever a user requests any of these web pages, the Home Controller action method determines which of the above views to use to build the webpage and return to the user.,if multiple views are there.


using Microsoft.AspNetCore.Mvc;
namespace FirstCoreMVCWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
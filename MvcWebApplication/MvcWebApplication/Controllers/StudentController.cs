using Microsoft.AspNetCore.Mvc;
namespace FirstCoreMVCWebApplication.Controllers
{
    public class StudentController : Controller
    {
        public string GetStudentsByName(string name)
        {
            //return "Return All Students";
            return $"Return All Students with Name : {name}";
        }
    }
}
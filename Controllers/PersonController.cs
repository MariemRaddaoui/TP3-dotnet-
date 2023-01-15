using Microsoft.AspNetCore.Mvc;
using TP3.Models;

namespace TP3.Controllers
{
    public class PersonController : Controller
    {
        [Route("Person/{id:int}")]
        public IActionResult Index(int id)
        {
            Personal_info personalInfo = new Personal_info();

            return View(personalInfo.GetPerson(id));
        }
        [Route("Person/")]
        public IActionResult Index()
        {
            Personal_info personalInfo = new Personal_info();

            return View(personalInfo.GetAllPerson());
        }
        [HttpGet]
        public IActionResult Search()
        {
            ViewBag.notFound = false;
            return View();
        }
        [HttpPost]
        public IActionResult Search(String FirstName, String Country)
        {
            Personal_info personalInfo = new Personal_info();
            List<Person> personal_Info = personalInfo.GetAllPerson();
            foreach (Person person in personal_Info)
            {
                if (person.FirstName == FirstName && person.Country == Country)
                {
                    return Redirect(person.Id.ToString());

                }
            }
            ViewBag.notFound = true;
            return View();
        }
    }
}
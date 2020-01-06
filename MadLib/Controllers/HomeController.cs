using Microsoft.AspNetCore.Mvc;
using MadLib.Models;

namespace MadLib.Controllers
{
    public class HomeController : Controller
    {

        // [Route("/")]
        // public ActionResult MadLib()
        // {
        //     Words myWords = new Words();
        //     myWords.Noun = "Lina";
        //     myWords.Verb = "Jasmine";
        //     myWords.Adjective = "Lina";
        //     myWords.Adverb = "Jasmine";
        //     return View(myWords);
        // }
        [Route("/")]
        public ActionResult Form() { return View(); }

        [Route("/madlib")]
        public ActionResult Madlib(string noun, string verb, string adjective, string adverb)
        {
            Words myWords = new Words();
            myWords.Noun = noun;
            myWords.Verb = verb;
            myWords.Adjective = adjective;
            myWords.Adverb = adverb;
            return View(myWords);
        }
    }
}
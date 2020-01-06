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
        public ActionResult Homepage() { return View(); }

        [Route("/woodsform")]
        public ActionResult woodsform() { return View(); }

        [Route("/foodform")]
        public ActionResult foodform() { return View(); }

        [Route("/epicodusform")]
        public ActionResult epicodusform() { return View(); }

        [Route("/woodsmadlib")]
        public ActionResult woodsmadlib(string noun, string verb, string adjective, string adverb)
        {
            Words myWords = new Words();
            myWords.Noun = noun;
            myWords.Verb = verb;
            myWords.Adjective = adjective;
            myWords.Adverb = adverb;
            return View(myWords);
        }

        [Route("/foodmadlib")]
        public ActionResult foodmadlib(string pronoun, string verb, string adjective, string adverb, string conjunction)
        {
            Words myWords = new Words();
            myWords.Pronoun = pronoun;
            myWords.Verb = verb;
            myWords.Adjective = adjective;
            myWords.Adverb = adverb;
            myWords.Conjunction = conjunction;
            return View(myWords);
        }

        [Route("/epicodusmadlib")]
        public ActionResult epicodusmadlib(string pronoun, string verb, string adjective, string adverb)
        {
            Words myWords = new Words();
            myWords.Pronoun = pronoun;
            myWords.Verb = verb;
            myWords.Adjective = adjective;
            myWords.Adverb = adverb;
            return View(myWords);
        }
    }
}
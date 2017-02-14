using Nancy;
using System.Collections.Generic;
using AllergyIdentifier.Objects;

namespace AllergyIdentifier
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };

            Post["/allergy"] = _ => {
                Allergies newAllergies = new Allergies(Request.Form["score"]);
                newAllergies.CalcAllergies();
                return View["Allergy.cshtml", newAllergies.GetAllergyList()];
            };
        }
    }
}

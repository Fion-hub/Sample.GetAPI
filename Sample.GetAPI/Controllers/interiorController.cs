using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sample.GetAPI.Models;
using System.Net.Http;
using System.Data.Entity.Validation;
using System.Data;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Sample.GetAPI.Controllers
{
    public class interiorController : Controller
    {
       
        //
        // GET: /Weather/
        public ActionResult Index()
        {
            string _apiUrl = "EA28418E-8956-4790-BAF4-C2D3988266CC?$format=json";
            List<InteriorModel> interiorlist;
            var serializer = new System .Web.Script .Serialization .JavaScriptSerializer();
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync(_apiUrl).Result;
            interiorlist = response.Content.ReadAsAsync<List<InteriorModel>>().Result;
            return Transcripts(interiorlist);
        }


        public ActionResult Transcripts(List<InteriorModel> interiorlist)
        {
            Interior It = new Interior();
            int i = 0;
            foreach (var item in interiorlist)
            {
                It.Id = i;
                It.unit = item.unit;
                It.telephon = item.telephon;
                It.fax = item.fax;
                It.address = item.address;
                It.website = item.website;

                using (var context = new InteriorEntitiee())
                {

                  Interior obj = context.Interiors.Single(x => x.unit == It.unit);
                  context.Entry(obj).State = EntityState.Deleted;
                  context.SaveChanges();

                  context.Interiors.Add(It);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        //丟出ex內容
                        var validationErrors = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);
                        var errMsgs = string.Join("; ", validationErrors);
                        var msg = errMsgs.ToString();
                    }
                }
                i++;
            }

            return View(interiorlist);
        }

    }
}
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Http;
using Newtonsoft.Json;
using WebApplication1.Models;

namespace WebApplication1.Controllers.Apis
{
    public class ValuesController : ApiController
    {
        // GET api/<controller>
        public string Get()
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en-US");

            string[] acceptLanguage = {"en-US", "ee"};

            var alEnum = acceptLanguage.Select(i => i);

            IList<string> list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(CultureInfo.CurrentUICulture.Name);
            }

            //var result = list.Select(i =>
            //    new LocaleEntity()
            //    {
            //        OuterLocale = i
            //    }
            //).ToList();

            var result = (from l in list
                join a in alEnum
                    on l equals a
                select new LocaleEntity()
                {
                    OuterLocale = CultureInfo.CurrentUICulture.Name
                }).ToList();

            return JsonConvert.SerializeObject(result);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
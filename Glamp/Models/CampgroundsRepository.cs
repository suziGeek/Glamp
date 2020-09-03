using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Glamp.Models
{
    public class CampgroundsRepository
    {
        private HttpClient _client;

        public CampgroundsRepository(HttpClient client)
        {
            _client = client;
        }

        public List<Campgrounds> GetCampgrounds(string selectState)
        {

            string campUrl = $"http://api.amp.active.com/camping/campgrounds/?pstate={selectState}&siteType=3001&api_key=hcgj5x79d9wren68k2pj5nv9";
            var campResponse = _client.GetStringAsync(campUrl).Result;

            XDocument xml = XDocument.Parse(campResponse);
            List<Campgrounds> nodeList = xml.Descendants("resultset")
                                  .Descendants("result")
                                  //.Where(x => x.Element("facilityID") != null && x.Element("facilityID") != null)
                                  .Select(x => new Campgrounds
                                  {
                                      facilityName = x.Attribute("facilityName").Value,
                                      facilityID = x.Attribute("facilityID").Value,
                                      state = x.Attribute("state").Value,
                                      latitude = decimal.Parse(x.Attribute("latitude").Value),
                                      longitude = decimal.Parse(x.Attribute("latitude").Value),
                                      contractID = x.Attribute("contractID").Value,
                                  }).ToList<Campgrounds>();

            return nodeList;

        }

    }
}

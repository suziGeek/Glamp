using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
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

        public List<Campgrounds> GetCampgrounds(string selectState, string selectActivity)
        {
            //http://api.amp.active.com/camping/campgrounds/?pstate={selectState}&siteType=3001&api_key=hcgj5x79d9wren68k2pj5nv9

            string campUrl = $"http://api.amp.active.com/camping/campgrounds/?pstate={selectState}&siteType={selectActivity}&api_key=hcgj5x79d9wren68k2pj5nv9";
            var campResponse = _client.GetStringAsync(campUrl).Result;

            //WebClient myWebClient = new WebClient();
            //byte[] data = myWebClient.DownloadData(uri);

            //string xmlContents = Encoding.UTF8.GetString(data);

            XDocument xml = XDocument.Parse(campResponse);
            //if theres only one result resultset is not a node - only result is - so throws an error...need to fix.
            try
            {
                List<Campgrounds> nodeList = xml.Descendants("resultset")
                                      .Descendants("result")
                                      //.Where(x => (string)x.Element("latitude") != "" || (string)x.Element("longitude")!= "" || (string)x.Element("facilityName") != "")
                                      .Select(x => new Campgrounds
                                      {
                                          facilityName = x.Attribute("facilityName").Value,
                                          facilityID = x.Attribute("facilityID").Value,
                                          state = x.Attribute("state").Value,
                                          //trying null conditional
                                          latitude = decimal.TryParse(x.Attribute("latitude").Value, out decimal tempVal) ? tempVal : (decimal?)null,
                                          longitude = decimal.TryParse(x.Attribute("longitude").Value, out decimal tempValSec) ? tempValSec : (decimal?)null,
                                          contractID = x.Attribute("contractID").Value,
                                      }).ToList<Campgrounds>();

                //pagination beginnings
                var page = 1;
                var pageSize = 50;
                nodeList = nodeList.Skip(page - 1 * pageSize).Take(pageSize).ToList<Campgrounds>();

                return nodeList;
            }
            catch (System.Xml.XmlException e)
            { throw (Exception)e.Data; }
            

        }

    }
}

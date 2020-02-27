using MVC_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MVC_WebAPI
{
    /// <summary>
    /// Summary description for WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WS : System.Web.Services.WebService
    {

        [WebMethod]
        public Book First(int id)
        {
            return Repo.Data.FirstOrDefault(f => f.Id == id);
        }
        [WebMethod]
        public List<Book> Second()
        {
            return Repo.Data;
        }
        [WebMethod]
        public List<Book> GetAll()
        {
            return Repo.Data;
        }
        [WebMethod]
        public List<Book> GetBookByRange(int startRange,int endRange)
        {
            return Repo.Data.Where(w=>w.Year>=startRange&&w.Year<=endRange).ToList();
        }
    }
}

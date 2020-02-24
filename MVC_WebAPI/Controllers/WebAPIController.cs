using MVC_WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC_WebAPI.Controllers
{
    [RoutePrefix("Books")]
    public class WebAPIController : ApiController
    {
        [HttpGet, Route("GetAll")]
        public IEnumerable<Book> GetAll()
        {
            return Repo.Data;
        }
        [HttpGet, Route("GetById/{Id}")]
        public Book GetById(int Id)
        {
            return Repo.Data.FirstOrDefault(f => f.Id == Id);
        }
        [HttpPost, Route("Add")]
        public int Add(Book book)
        {
            Repo.Data.Add(book);
            return Repo.Data.Count();
        }

        [HttpPost, Route("Edit/{Id}")]
        public string Edit([FromBody]Book book, [FromUri]int Id)
        {
            var book2 = Repo.Data.FirstOrDefault(f => f.Id == Id);
            if (book2 == null)
            {
                return null;
            }

            book2.Name = book.Name;
            book2.Author = book.Author;
            book2.Year = book.Year;

            Repo.Data.Add(book);
            return book2.Name;
        }
        [HttpPost, Route("Delete")]
        public bool Delete([FromUri]int Id)
        {
            return Repo.Data.Remove(Repo.Data.FirstOrDefault(f=>f.Id==Id));
        }
    }
}

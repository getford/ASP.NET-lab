using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using L14.Models;

namespace L14.Controllers
{
    public class ApiPhoneModelsController : ApiController
    {
        private PhoneContext db = new PhoneContext();

        // GET: /api/ApiPhoneModels/Get?id=111
        public IHttpActionResult Get(string id)
        {
            PhoneModel phoneModel = db.PhoneModels.Find(id);
            if (phoneModel == null)
                return NotFound();
            return Ok(phoneModel);
        }

        [HttpPut]//http://localhost:22146/api/ApiPhoneModels/Add?Phone=333&Surname=aaaaa&Firstname=aaaaaa&Middlename=middle&BDay=07.01.2017
        public IHttpActionResult Put(string phone, string Surname, string Firstname, string Middlename, DateTime BDay)
        {
            PhoneModel phoneModel = db.PhoneModels.Find(phone);
            if (phoneModel == null)
                return BadRequest("NotFound");
            phoneModel.Surname = Surname;
            phoneModel.Firstname = Firstname;
            phoneModel.Middlename = Middlename;
            phoneModel.BDay = BDay;
            db.Entry(phoneModel).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (db.PhoneModels.Count(e => e.Phone == phone) < 0)
                    return NotFound();
                else
                    throw;
            }
            return StatusCode(HttpStatusCode.NoContent);
        }

        [HttpPost]//http://localhost:22146/api/ApiPhoneModels/Add?Phone=333&Surname=aaaaa&Firstname=aaaaaa&Middlename=middle&BDay=07.01.2017
        public IHttpActionResult Add(string phone, string Surname, string Firstname, string Middlename, DateTime BDay)
        {
            if (db.PhoneModels.Count(e => e.Phone == phone) > 0)
                return Conflict();
            PhoneModel newPhoneModel = new PhoneModel(phone, Surname, Firstname, Middlename, BDay);
            db.PhoneModels.Add(newPhoneModel);
            db.SaveChanges();
            return Ok(newPhoneModel);
        }

        [HttpDelete]
        public IHttpActionResult Delete(string id)
        {
            PhoneModel phoneModel = db.PhoneModels.Find(id);
            if (phoneModel == null)
                return NotFound();
            db.PhoneModels.Remove(phoneModel);
            db.SaveChanges();
            return Ok(phoneModel);
        }
    }
}
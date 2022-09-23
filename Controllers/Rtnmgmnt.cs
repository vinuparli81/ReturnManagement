using JwtAuthentication.Shared.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReturnMgmt.Models;
using RtMgmt.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RtMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Rtnmgmnt : ControllerBase
    {


        //[HttpPost]
        //public IActionResult Loging(UserCredentials userCredentials)
        //{
        //    ReturnMgmntContext db = new ReturnMgmntContext();
        //    // auth = new AuthenticationService();
        //    try
        //    {
        //        string token = Authenticate(userCredentials);
        //        if (token != null)
        //        {
        //            var returnitem = db.Processheaders.Where(i => i.Username == userCredentials.Username);
        //            return Ok(returnitem);
        //        }
        //        else
        //        {
        //            return Unauthorized();
        //        }

        //    }
        //    catch (InvalidCredentialsException)
        //    {
        //        return Unauthorized();
        //    }
        //}
        [Route("PlaceRetuenOrder")]
        [HttpPost]
        public IActionResult PlaceRetuenOrder(Processheader processheader)
        {
            ReturnMgmntContext db = new ReturnMgmntContext();
            if (ModelState.IsValid)
            {
                db.Processheaders.Add(processheader);
                db.SaveChangesAsync();
                return Ok("Order Placed Successfully!");
            }
            else
            {
                return BadRequest();
            }
        }
        [Route("GetReturnDetails")]
        [HttpGet]
        public IActionResult GetReturnDetails(string username)
        {
            ReturnMgmntContext db = new ReturnMgmntContext();
              var result =  db.Processheaders.Where(i=> i.Username ==username );
              return Ok(result);
            
        }
    }
}

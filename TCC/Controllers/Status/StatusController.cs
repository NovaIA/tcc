﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TCC.Models;
using TCC.Services.Status;

namespace TCC.Controllers.Status
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private IStatusServices _statusServices;
        
        public StatusController(IStatusServices statusServices)
        {
            _statusServices = statusServices;
        }


        // GET: api/Status
        [HttpGet]
        public List<StatusModel> Get()
        {
            return _statusServices.getTodosStatus();
        }

        // GET: api/Status/5
        [HttpGet("GetEntity")]
        public List<StatusModel> GetEntity()
        {
            return _statusServices.getStatusEntity();
        }

        // POST: api/Status
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Status/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

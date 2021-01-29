using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KentIntegration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        //// GET: api/<AttendanceController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<AttendanceController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<AttendanceController>
        [HttpPost]
        public void Post([FromBody] attendanceRecord value)
        {           
            using (var context = new Context.attendanceContext())
            {
                var output = new Database.Models.Attendance();
                output.AccountId = value.accountId;                 
                output.CompanyId = value.companyId;
                output.DepartmentName = value.departmentName;
                output.DeviceId = value.deviceId;
                output.DeviceName = value.deviceName;
                output.EmpId = value.empId;
                output.EmployeeName = value.employeeName;
                output.LocationName = value.locationName;
                output.Mode = value.mode;
                output.Time = value.time;
                output.Type = value.type;
                context.Attendances.Add(output);
                context.SaveChanges();
            }
        }       
    }
}

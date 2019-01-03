using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUDListOperationPOC.Models;

namespace CRUDListOperationPOC.DataAccessLayer
{
    public class EmployeeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var empls = new List<EmployeeDetails>
            {
            new EmployeeDetails{employeeid=1234,firstName="Alex",lastName="Chris",email="alex@hotmail.com",gender="M",streetAddress="Jubilee Hills",city="Hyderabad",country="India",zipCode="500066",phone="9898989898"},
            new EmployeeDetails{employeeid=5467,firstName="vershnova",lastName="Mote",email="vershnova@hotmail.com",gender="F",streetAddress="Kavauri Hills",city="Hyderabad",country="India",zipCode="500026",phone="9595959595"},
            new EmployeeDetails{employeeid=9810,firstName="Raj",lastName="Kamal",email="raj@hotmail.com",gender="M",streetAddress="Kondapur",city="Hyderabad",country="India",zipCode="500070",phone="9696969696"},
            new EmployeeDetails{employeeid=9999,firstName="christine",lastName="rold",email="shristine@hotmail.com",gender="F",streetAddress="Madhapur",city="Hyderabad",country="India",zipCode="500081",phone="9999999999"},
            new EmployeeDetails{employeeid=3452,firstName="Teresa",lastName="Noma",email="terasa@hotmail.com",gender="F",streetAddress="Filmnagar",city="Hyderabad",country="India",zipCode="500018",phone="9292929292"},
            new EmployeeDetails{employeeid=1789,firstName="Alexander",lastName="Fleming",email="alexander@hotmail.com",gender="M",streetAddress="Koti",city="Hyderabad",country="India",zipCode="500088",phone="9797979797"},
            new EmployeeDetails{employeeid=9087,firstName="Bell",lastName="Ian",email="bell@hotmail.com",gender="M",streetAddress="Ameerpet",city="Hyderabad",country="India",zipCode="500062",phone="9191919191"},
            new EmployeeDetails{employeeid=4563,firstName="Carson",lastName="Mike",email="carson@hotmail.com",gender="M",streetAddress="Uppal",city="Hyderabad",country="India",zipCode="500064",phone="9393939393"},
            };
            empls.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
        }
}
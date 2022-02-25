using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_csharp.Controllers
{/// <summary>
/// This method method computes the total of calories based on users choice 
/// using logic to check user selection
/// if the user inputs 4 the value of burger will be 0 based on our logic
/// if the user inputs 3 the value of drink will be 118 based on our logic
/// if the user inputs 2 the value of side will be 70 based on our logic
/// if the user inputs 1 the value of dessert will be 167 based on our logic
/// these inputs are summed up to get the total calories stored in a variable total
/// return the content of the variable and concatenate it with a string of message
/// <example>Get:api/j1/menu/4/3/2/1</example>
/// </summary>
/// <return>your total calorie count is value</return>
    public class J1Controller : ApiController
    {
     [HttpGet]
     [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger,int drink,int side, int dessert)
        {
            
            if(burger == 1)
            {
                burger = 461;
            }
           else if (burger == 2)
            {
                burger = 431;
            } 
            else if (burger == 3)
            {
                burger = 420;

            }
            else
            {
                burger = 0;
            }
            

            if (drink == 1)
            {
                drink = 130;
            }
            else if(drink == 2)
            {
                drink = 160;
            }
            else if (drink == 3)
            {
                drink = 118;
            }
            else { drink = 0;}
            if (side == 1)
            {
                side = 100;
            }
            else if(side == 2)
            {
                side = 57;
            }
            else if( side == 3)
            {
                side = 70;
            }
            else { side = 0;}
            if(dessert == 1)
            {
                dessert = 167;

            }
            else if(dessert == 2)
            {
                dessert = 266;
            }
            else if (dessert == 3)
            {
                dessert = 75;
            }
            else { dessert = 0;}
            var total= burger+drink+side+dessert;
            return ("your total calorie count is " + " " + total);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_csharp.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// creates an empty variable message
        /// creates a counter variable loop and logic 
        /// use the for loop to loop  through the possible combinations
        /// using if statement to check wheather the combinations sum up to 10 
        /// using logic to print outcome statement based on the counter value
        /// <example>Get:api/J2/dicegame/6/8</example>
        /// </summary>
        /// <param name="M"></param>
        /// <param name="N"></param>
        /// <returns>there are  5 ways to get the sum 10</returns>
       

        
            [HttpGet]
            [Route("api/J2/{DiceGame}/{m}/{n}")]

            public string DiceGame(int M, int N)
            {
                string message = "";
                int counter = 0;
                for (int i = 1; i <= M; i++)
                {
                    if (((10 - i) <= N) && ((10 - i) > 0))
                    {
                        counter++;
                    }
                    if (counter == 1)
                    {
                        message = "there is " + counter + " way to get the sum 10";

                    }
                    else
                    {
                        message = "there is " + counter + " ways to get the sum 10";
                    }

                }
                return message;
            }
    }
}

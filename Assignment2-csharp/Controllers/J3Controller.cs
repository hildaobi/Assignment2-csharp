using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment2_csharp.Controllers
{
    public class J3Controller : ApiController
    {
     /// <summary>
     /// J3 problem 2021
     /// create an empty variable string message=""
     ///create an array that accepts only 5items called new string[] numberone = numberone[4]
     /// create another array that accepts only 5items called new string[] numbertwo= numbertwo[4]
     /// loop through the array  5 times using the for loop where int i=0, i<5,i++ for both arrays
     /// create a variable that stores the sum of the two first items in the array int sum1=numberone[0]+numberone[1]
     /// create a variable that stores the sum of the two first items in the array int sum2=numbertwo[0]+numbertwo[1]
     /// if (sum1%2==1) {message= "left" +" "+ n3 + n4 + n5}
     /// else if ( sum1%2==0) { message= "right" + " "+ n3 + n4 + n5}
     /// if (sum2==0 && sum1%2==1){message= "left" + " "+ n3 + n4 + n5}
     /// else if (sum2==0 && sum1%2==0) {message= "right" +" "+ n3 + n4 + n5}
     /// return message
     /// <example>Get:api/J3/numberone/numbertwo/"5,7,2,3,4"/"0,0,9,0,7"</example>
     /// </summary>
     /// <param name="number"></param>
     /// <returns>right 234</returns>
        [HttpGet]
        [Route("api/J3/SecretInstr/{n1,n2,n3,n4,n5}/{id1,id2,id3,id4,id5}")]

        public string SecretInstr(string[] numberOne={"n1","n2","n3","n4","n5"},string[] numberTwo = { "id1","id2" ,"id3","id4","id5"})
        {
            
            for (int i = 0; i < number.length; i++)
            
        }
    return "hello";
    }
}

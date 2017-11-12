using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ResistorCalculator.OhmCalculator
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {


        // GET api/values/5
        [HttpGet("{input}")]
        public string Get(string input)
        {
            OhmValueCalculator ohm = new OhmValueCalculator();

            string [] inputs = input.Split("-");

            if(inputs.Length != 4)
            {
                return "Invalid Inputs";
            }

            int value = ohm.CalculateOhmValue(inputs[0],inputs[1],inputs[2],inputs[3]);
            int tolerance = ohm.getTolerance();

            if(value != -1)
            {
                return (value + " Ohms " + tolerance + "%");
            }

            return "Invalid Inputs";
        }

     
    }
}

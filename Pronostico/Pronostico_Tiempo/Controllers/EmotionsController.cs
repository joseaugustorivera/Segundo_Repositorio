using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pronostico_Tiempo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmotionsController : ControllerBase
    {
        [HttpGet]
        [Route("ConNumero")]
        public string Emocion(int suerte)
        {
            if (suerte == 0)
                return "sos una persona indiferente.";
            if (suerte == 1)
                return "sos una persona feliz.";
            if (suerte == 3)
                return "sos una persona aburrida.";
            return "estoy muy ocupado, no puedo atender en ese momento.";
        }

        [HttpPost]
        [Route("ConNumero")]
        public string Emocion2([FromHeader] int suerte)
        {
            if (suerte == 0)
                return "sos una persona indiferente.";
            if (suerte == 1)
                return "sos una persona feliz.";
            if (suerte == 3)
                return "sos una persona aburrida.";
            return "estoy muy ocupado, no puedo atender en ese momento.";
        }
    }
}

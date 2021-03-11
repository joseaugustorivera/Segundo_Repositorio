namespace Pronostico_Tiempo.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Pronostico_Tiempo.Models;

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
        [HttpPost]
        [Route("ConModelo")]
        public string Emocion3([FromBody] Luck luck)
        {
            if (luck.LuckId == 0)
                return "sos una persona indiferente.";
            if (luck.LuckId == 1)
                return "sos una persona feliz.";
            if (luck.LuckId == 3)
                return "sos una persona aburrida.";
            return "estoy muy ocupado, no puedo atender en ese momento.";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace pato.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatoController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<string> Get()
        {
            Cisne _cisne = new Cisne();
            return _cisne.CrearPato();
        }

        [HttpGet("PonerHuevos")]
        public IEnumerable<string> PonerHuevos()
        {
            PonerHuevos _ponerHuevos = new PonerHuevos();
            List<IPato> patos=new List<IPato>();
            patos.Add(new Silvestre());
            patos.Add(new Cisne());
           return _ponerHuevos.Cantidad(patos);      
        }
    }
}

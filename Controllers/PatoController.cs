using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pato;

namespace pato.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatoController : ControllerBase
    {


        private readonly ICisne _cisne;
        public PatoController(ICisne _ICisne)
        {
            this._cisne = _ICisne;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _cisne.CrearPato();
        }

        [HttpGet("PonerHuevos")]
        public IEnumerable<string> PonerHuevos()
        {
            // PonerHuevos _ponerHuevos = new PonerHuevos();
            // List<IPato> patos = new List<IPato>();
            // patos.Add(new Silvestre());
            // patos.Add(new Cisne());
            // return _ponerHuevos.Cantidad(patos);
            throw new Exception();
        }
    }
}

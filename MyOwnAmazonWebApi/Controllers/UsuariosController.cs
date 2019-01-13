using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntitiesModelsMyOwnAmazon;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using System.Net.Http;

namespace MyOwnAmazonWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public HttpResponseMessage createNewAccount([FromBody] UsuarioData usuario)
        {

            UsuarioBLL usuarioBll = new UsuarioBLL();
            var statuscode = usuarioBll.createNewAccount(usuario);
            return statuscode;

        }
    }
}
using EntitiesModelsMyOwnAmazon;
using System;
using System.Net.Http;
using DAL;
namespace BLL
{
    public class UsuarioBLL
    {
        public HttpResponseMessage createNewAccount(UsuarioData usuario)
        {
            UsuarioDALL usuarioDal = new UsuarioDALL();
            var statuscode = usuarioDal.createNewAccount(usuario);
            return statuscode;
        }
    }
}

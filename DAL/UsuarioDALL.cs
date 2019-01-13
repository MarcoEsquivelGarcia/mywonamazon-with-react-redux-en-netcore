using EntitiesModelsMyOwnAmazon;
using EntityFrameworkDBModel.Context;
using HerramientasMyOwnAmazon;
using System;
using System.Net;
using System.Net.Http;
using System.Text;

namespace DAL
{
    public class UsuarioDALL
    {
        Herramientas herramientas = new Herramientas();
        public HttpResponseMessage createNewAccount(UsuarioData usuario)
        {

          HttpRequestMessage request = new HttpRequestMessage();
            var statuscode = request.CreateResponse(HttpStatusCode.NotModified); ;
            using (MyStoreDbContext entitiesModel = new MyStoreDbContext())
            {
                using (var transaction = entitiesModel.Database.BeginTransaction())
                {
                    try
                    {
                        var newUser = new Usuario
                        {
                            FirstName = usuario.firstName,
                            LastName = usuario.lastName,
                            Email = usuario.email,
                            Password = herramientas.GetMd5Hash(usuario.password)
                        };

                        entitiesModel.Usuario.Add(newUser);
                        entitiesModel.SaveChanges();

                        statuscode = request.CreateResponse(HttpStatusCode.Created);
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();


                    }
                }

            }

            return statuscode;
        }

       
    }
}

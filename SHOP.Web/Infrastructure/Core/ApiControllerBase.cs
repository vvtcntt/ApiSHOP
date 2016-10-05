using SHOP.Model.Model;
using SHOP.Service;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SHOP.Web.Infrastructure.Core
{
    public class ApiControllerBase : ApiController
    {
        private IErrorService _errorservice;
        public ApiControllerBase(IErrorService errorService)
        {
            this._errorservice = errorService;

        }
        protected HttpResponseMessage CreateHttpReponse(HttpRequestMessage requestMessage, Func<HttpResponseMessage> function)
        {
            HttpResponseMessage reponse = null;
            try
            {
                reponse = function.Invoke();
            }
            catch (DbEntityValidationException ex)
            {
                foreach(var eve in ex.EntityValidationErrors)
                {
                    Trace.WriteLine($"Entiry of type \"{eve.Entry.Entity.GetType().Name}\"  in state \"{eve.Entry.State}\"");
                    foreach(var ve in eve.ValidationErrors)
                    {
                        Trace.WriteLine($"_Property : \"{ve.PropertyName}\", Error : \"{ve.ErrorMessage}\"");
                    }
                }
            }
            catch (DbUpdateException dbEx)
            {
                LogError(dbEx);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, dbEx.InnerException.Message);
            }
            catch (Exception ex)
            {
                LogError(ex);
                reponse = requestMessage.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
            return reponse;
        }
        public void LogError(Exception ex)
        {
            try
            {
                Error error = new Error();
                error.DateCreate = DateTime.Now;
                error.Message = ex.Message;
                error.StackTrace = ex.StackTrace;
                _errorservice.Create(error);
                _errorservice.Save();

            }
            catch
            {

            }
        }

    }
}

using AutoMapper;
using SHOP.Model.Model;
using SHOP.Service;
using SHOP.Web.Infrastructure.Core;
using SHOP.Web.Models;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SHOP.Web.Infrastructure.Extentions;
namespace SHOP.Web.Api
{
    [RoutePrefix("api/groupproduct")]
    public class GroupProductController : ApiControllerBase
    {
        private IGroupProductService _groupProductService;

        public GroupProductController(IErrorService errorService,IGroupProductService groupProductService) : base(errorService)
        {
            this._groupProductService = groupProductService;
        }
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request )
        {
            return CreateHttpReponse(request, () =>
            {

                var listGroupProduct = _groupProductService.GetAll();
                var listGroupProductVm = Mapper.Map<List<GroupProductViewModel>>(listGroupProduct);
                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listGroupProduct);
                return response;
            });
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, GroupProductViewModel groupProductVm)
        {
            return CreateHttpReponse(request, () =>
             {
                 HttpResponseMessage response = null;
                if(ModelState.IsValid)
                 {
                     request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                 }
                else
                 {
                     GroupProduct newGroupProduct = new GroupProduct();
                     newGroupProduct.UpdateGroupProduct(groupProductVm);
                    var groupproduct = _groupProductService.Add(newGroupProduct);
                     _groupProductService.Save();
                     response = request.CreateResponse(HttpStatusCode.Created, groupproduct);
                 }
                 return response;
             });
        }
        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request,   GroupProductViewModel groupProductVm)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var groupProductDb = _groupProductService.GetById(groupProductVm.id);
                    groupProductDb.UpdateGroupProduct(groupProductVm);
                    _groupProductService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpReponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var groupproduct = _groupProductService.Delete(id);

                    _groupProductService.Save();
                    response = request.CreateResponse(HttpStatusCode.OK);
                }
                return response;
            });
        }
    }
}
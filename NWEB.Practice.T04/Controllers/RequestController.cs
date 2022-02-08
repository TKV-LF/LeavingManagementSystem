using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Model.Request;
using Model.Requests;
using Model.Response;
using NToastNotify;
using Repository.Request;
using System.Linq;

namespace NWEB.Practice.T04.Controllers
{
    public class RequestController : BaseController
    {
        private readonly IRequestRepository _requestRepository;
        private readonly IToastNotification _toastNotification;

        public RequestController(
            IRequestRepository requestRepository,
            IToastNotification toastNotification)
        {
            _requestRepository = requestRepository;
            _toastNotification = toastNotification;

        }

        [Route("list-request")]
        public IActionResult Request()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetListRequest(string searchValue)
        {
            SearchRequestModel searchModel = tableSearchModel.Get<SearchRequestModel>();
            searchModel.SearchValue = searchValue;
            var data = _requestRepository.GetListRequest(searchModel);
            /*  if (data.Code != StatusCodes.Status200OK)
                  _toastNotification.AddErrorToastMessage(data.Message);*/

            return Json(data);
        }

        [Route("manager-request")]
        public IActionResult SubmitedRequest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetSubmitedRequest(string searchValue)
        {
            SearchRequestModel searchModel = tableSearchModel.Get<SearchRequestModel>();
            searchModel.SearchValue = searchValue;
            var data = _requestRepository.GetSubmitedRequest(searchModel);
            /*  if (data.Code != StatusCodes.Status200OK)
                  _toastNotification.AddErrorToastMessage(data.Message);*/

            return Json(data);
        }

        [Route("add-request")]
        public IActionResult CreateRequest()
        {
            return View();
        }


        [HttpPost]
        public IActionResult InsertRequest(RequestModel model)
        {
            var res = _requestRepository.CreateRequest(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }

        [Route("request-detail/{id}")]
        public IActionResult RequestDetail(int Id)
        {
            var model = new RequestModel();
            model.Id = Id;
            var res = _requestRepository.GetRequestById(model);

            if (res == null)
                res = new Response<RequestModel>();
            if (res.Data == null)
                res.Data = new RequestModel();

            return View(res.Data);
        }

        [HttpPost]
        public IActionResult Approve(RequestModel model)
        {
            var res = _requestRepository.Approve(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }

        [HttpPost]
        public IActionResult Cancel(RequestModel model)
        {
            var res = _requestRepository.Cancel(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }

        [HttpPost]
        public IActionResult Reject(RequestModel model)
        {
            var res = _requestRepository.Reject(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }
        [Route("edit-request/{id}")]
        public IActionResult EditRequest(int Id)
        {
            var model = new RequestModel();
            model.Id = Id;
            var res = _requestRepository.GetRequestById(model);

            if (res == null)
                res = new Response<RequestModel>();
            if (res.Data == null)
                res.Data = new RequestModel();

            return View(res.Data);
        }

        [HttpPost]
        public IActionResult UpdateRequest(RequestModel model)
        {
            var res = _requestRepository.UpdateRequest(model);
            if (res.Code == StatusCodes.Status200OK)
            {
                _toastNotification.AddSuccessToastMessage(res.Message);
            }
            else
            {
                _toastNotification.AddErrorToastMessage(res.Message);
            }
            return Json(res);
        }


    }
}

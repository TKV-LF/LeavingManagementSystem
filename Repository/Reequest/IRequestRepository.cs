using Model.Request;
using Model.Requests;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Request
{
    public interface IRequestRepository
    {
        TableResponse<RequestViewModel> GetListRequest(SearchRequestModel search);
        Response<string> CreateRequest(RequestModel model);
        /*Response<string> DeleteRequest(RequestModel model);*/
        Response<RequestModel> GetRequestById(RequestModel model);
        Response<string> UpdateRequest(RequestModel model);
        Response<string> Approve(RequestModel model);
        Response<string> Cancel(RequestModel model);
        Response<string> Reject(RequestModel model);
        TableResponse<RequestViewModel> GetSubmitedRequest(SearchRequestModel search);
    }
}

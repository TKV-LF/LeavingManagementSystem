using Entity.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Model.Request;
using Model.Requests;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.Entity;

namespace Repository.Request
{
    public class RequestRepository : Repository<RequestRepository>, IRequestRepository
    {
        private readonly IConfiguration _configuration;
        public RequestRepository(
            ILogger<RequestRepository> logger,
            IConfiguration configuration,
            RequestContext context
            ) : base(context, logger)
        {
            _configuration = configuration;
        }

        public TableResponse<RequestViewModel> GetListRequest(SearchRequestModel search)
        {
            TableResponse<RequestViewModel> result = new TableResponse<RequestViewModel>();
            result.Draw = search.Draw;

            try
            {
                var data = _context.requests.Where(x => x.IsDeleted == false).Select(x => new RequestViewModel
                {
                    Id = x.Id,
                    StudentName = x.StudentName,
                    Class = x.Class,
                    Title = x.Title,
                    Status = x.Status,
                    LeaveType = x.LeaveType,
                    ReasonForLeave = x.ReasonForLeave

                }).ToList();

                if (search.SearchValue != null)
                {
                    data = data.Where(x => x.StudentName.ToLower().Contains(search.SearchValue.ToLower())).ToList();
                }

                var cnt = data.Count();
                result.Data = data.OrderBy(x => x.Id).Skip(search.Start).Take(search.Length).ToList();
                result.RecordsTotal = cnt;
                result.RecordsFiltered = cnt;
                result.Code = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                result.Code = StatusCodes.Status500InternalServerError;
                result.Message = "Xảy ra lỗi khi lấy danh sách yêu cầu!";
            }
            return result;
        }

        public Response<string> CreateRequest(RequestModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                if (string.IsNullOrEmpty(model.StudentName))
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Tên yêu cầu không được bỏ trống!";
                    return res;
                }

                Entity.Entity.Request request = new Entity.Entity.Request();
                request.StudentName = model.StudentName;
                request.Class = model.Class;
                request.Title = model.Title;
                request.LeaveDate = model.LeaveDate;
                request.LeaveType = model.LeaveType;
                request.ReasonForLeave = model.ReasonForLeave;



                _context.requests.Add(request);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Thêm yêu cầu thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi thêm yêu cầu!";
            }

            return res;
        }

      /*  public Response<string> DeleteCategory(CategoryModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                var category = _context.categories.FirstOrDefault(x => x.Id == model.Id && x.IsDeleted == false);
                if (category == null)
                {
                    res.Code = StatusCodes.Status404NotFound;
                    res.Message = "Không tồn tại yêu cầu, không thể xóa!";
                    return res;
                }
                category.IsDeleted = true;
                _context.categories.Update(category);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Xóa yêu cầu thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi xóa yêu cầu!";
            }

            return res;
        }*/

        public Response<RequestModel> GetRequestById(RequestModel model)
        {
            Response<RequestModel> res = new Response<RequestModel>();

            try
            {
                var query = (from a in _context.requests
                             where a.IsDeleted == false && a.Id == model.Id
                             select new
                             {
                                 a
                             }).ToList();

                var group = query.GroupBy(x => x.a.Id).Select(group => new RequestModel
                {
                    Id = group.Key,
                    StudentName = group.ToList().FirstOrDefault().a.StudentName,
                    Class = group.ToList().FirstOrDefault().a.Class,
                    Title = group.ToList().FirstOrDefault().a.Title,
                    LeaveDate = group.ToList().FirstOrDefault().a.LeaveDate,
                    LeaveType = group.ToList().FirstOrDefault().a.LeaveType,
                    ReasonForLeave = group.ToList().FirstOrDefault().a.ReasonForLeave
                }).ToList();

                res.Code = StatusCodes.Status200OK;
                res.Data = group.FirstOrDefault();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status400BadRequest;
                res.Message = "Xảy ra lỗi khi lấy thông tin yêu cầu!";
            }

            return res;
        }

        public Response<string> UpdateRequest(RequestModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                if (string.IsNullOrEmpty(model.StudentName))
                {
                    res.Code = StatusCodes.Status400BadRequest;
                    res.Message = "Tên học sinh không được bỏ trống!";
                    return res;
                }

                var request = _context.requests.FirstOrDefault(x => x.IsDeleted == false && x.Id == model.Id);
                if (request == null)
                {
                    res.Code = StatusCodes.Status404NotFound;
                    res.Message = "Không tồn tại yêu cầu, không thể cập nhật!";
                    return res;
                }

                request.StudentName = model.StudentName;
                request.Class = model.Class;
                request.Title = model.Title;
                request.LeaveDate = model.LeaveDate;
                request.LeaveType = model.LeaveType;
                request.ReasonForLeave = model.ReasonForLeave;
                _context.requests.Update(request);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Sửa yêu cầu thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi sửa yêu cầu!";
            }

            return res;
        }

        public Response<string> Approve(RequestModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                var request = _context.requests.FirstOrDefault(x => x.IsDeleted == false && x.Id == model.Id);
                request.Status = 2;
                _context.requests.Update(request);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Xác nhận thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi xác nhận!";
            }

            return res;
        }

        public Response<string> Cancel(RequestModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                var request = _context.requests.FirstOrDefault(x => x.IsDeleted == false && x.Id == model.Id);
                request.Status = 3;
                _context.requests.Update(request);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Hủy thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi hủy!";
            }

            return res;
        }

        public Response<string> Reject(RequestModel model)
        {
            Response<string> res = new Response<string>();

            try
            {
                var request = _context.requests.FirstOrDefault(x => x.IsDeleted == false && x.Id == model.Id);
                request.Status = 4;
                _context.requests.Update(request);
                _context.SaveChanges();

                res.Code = StatusCodes.Status200OK;
                res.Message = "Reject thành công!";
                return res;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                res.Code = StatusCodes.Status500InternalServerError;
                res.Message = "Xảy ra lỗi khi reject!";
            }

            return res;
        }

        public TableResponse<RequestViewModel> GetSubmitedRequest(SearchRequestModel search)
        {
            TableResponse<RequestViewModel> result = new TableResponse<RequestViewModel>();
            result.Draw = search.Draw;

            try
            {
                var data = _context.requests.Where(x => x.IsDeleted == false && x.Status == 1).Select(x => new RequestViewModel
                {
                    Id = x.Id,
                    StudentName = x.StudentName,
                    Class = x.Class,
                    Title = x.Title,
                    Status = x.Status,
                    LeaveType = x.LeaveType,
                    ReasonForLeave = x.ReasonForLeave

                }).ToList();

                if (search.SearchValue != null)
                {
                    data = data.Where(x => x.StudentName.ToLower().Contains(search.SearchValue.ToLower())).ToList();
                }

                var cnt = data.Count();
                result.Data = data.OrderBy(x => x.Id).Skip(search.Start).Take(search.Length).ToList();
                result.RecordsTotal = cnt;
                result.RecordsFiltered = cnt;
                result.Code = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "");
                result.Code = StatusCodes.Status500InternalServerError;
                result.Message = "Xảy ra lỗi khi lấy danh sách yêu cầu!";
            }
            return result;
        }

    }
}

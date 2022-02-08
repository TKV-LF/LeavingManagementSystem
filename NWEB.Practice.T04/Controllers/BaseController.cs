using Microsoft.AspNetCore.Mvc;
using Model.Requests;
using System.Linq;

namespace NWEB.Practice.T04.Controllers
{
    public class BaseController : Controller
    {
        public TableSearchModel tableSearchModel
        {
            get
            {
                TableSearchModel search = new TableSearchModel();
                var draw = Request.Form["draw"].FirstOrDefault();
                var start = Request.Form["start"].FirstOrDefault();
                var length = Request.Form["length"].FirstOrDefault();
                var searchValue = Request.Form["search[value]"].FirstOrDefault();
                var orderColumn = Request.Form["order[0][column]"].FirstOrDefault();
                var orderDir = Request.Form["order[0][dir]"].FirstOrDefault();
                search.Draw = int.Parse(draw);
                search.Start = int.Parse(start);
                search.Length = int.Parse(length);
                search.SearchValue = searchValue;
                search.OrderColumn = int.Parse(orderColumn);
                search.OrderDir = orderDir;
                return search;
            }
        }
    }
}

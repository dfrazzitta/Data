using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Controllers
{
    public class UserViewModel
    {
        public string UserId { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string FullName { get; set; }
        public string EnrollmentDate { get; set; }
        public string Enrollments { get; set; }
    }

    public class UserPagingViewModel
    {
        public List<UserViewModel> Users { get; set; }
      //  public int CurrentPage { get; set; }
      //  public int ItemCount { get; set; }
      //  public int TotalPages { get; set; }
    }

    public class PagingModel {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}

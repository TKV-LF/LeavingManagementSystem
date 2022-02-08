using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entity
{
    public class Request : EntityBase
    {

        public string StudentName { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public DateTime LeaveDate { get; set; }
        public string LeaveType { get; set; }
        public string ReasonForLeave { get; set; }
        public int Status { get; set; }

    }

    /*public enum ClassList
    {
        [Display(Name = ".Net 01")]
        Net01,
        [Display(Name = ".Net 02")]
        Net02,
        [Display(Name = "Java 01")]
        Java01,
        [Display(Name = "Java 02")]
        Java02
    }

    public enum LeaveTypeList
    {
        [Display(Name = "Leave 1")]
        Leave1,
        [Display(Name = "Leave 2")]
        Leave2,
        [Display(Name = "Leave A Half Of Day")]
        LeaveAHalfOfDay,
        [Display(Name = "Leave One Day")]
        LeaveOneDay
    }*/
}

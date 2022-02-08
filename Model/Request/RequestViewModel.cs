﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Request
{
    public class RequestViewModel : ModelBase
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Class { get; set; }
        public string Title { get; set; }
        public DateTime LeaveDate { get; set; }
        public string LeaveType { get; set; }
        public string ReasonForLeave { get; set; }
        public int Status { get; set; }
    }
}

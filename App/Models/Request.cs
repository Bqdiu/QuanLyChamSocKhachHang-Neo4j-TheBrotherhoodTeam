using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Request
    {
        public string Id { get; set; }
        public string CusId { get; set; }
        public string CusName { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public string ServiceId { get; set; }
        public string ServiceName { get; set; }
        public string Title { get; set; }
        public string Detail { get; set; }
        public string DateCreated { get; set; }
        public string ProcessStatus { get; set; }
       
    }
}

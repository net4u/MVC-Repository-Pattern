using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRepositoryDemo.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public bool IsDone { get; set; }
    }
}
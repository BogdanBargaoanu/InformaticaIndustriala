using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public class Task
    {
        public int id { get; set; }
        public string taskName { get; set; }
        public string description { get; set; }
        public DateTime dueDate { get; set; }
        public int idUser { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFrameWork.Models
{
    public class Albums
    {
        public int UserId{ get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
    }
}

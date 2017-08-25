using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnadocAI.Models
{
    public class DocumentCount
    {
        [Key]
        public int Id { get; set; }
        public int Total { get; set; }

    }
}
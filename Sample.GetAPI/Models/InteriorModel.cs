using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

using System.Web;

namespace Sample.GetAPI.Models
{
    public class InteriorModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string unit { get; set; }
        public string telephon { get; set; }
        public string fax { get; set; }
        public string address { get; set; }
        public string website { get; set; }

    }
    
}
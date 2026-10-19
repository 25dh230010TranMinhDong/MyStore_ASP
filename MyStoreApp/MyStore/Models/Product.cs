using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace MyStore.Models
{
    public partial class Product
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }

        public virtual Category Category { get; set; }

        // Additional upload property (Not mapped to DB)
        [NotMapped]
        public HttpPostedFileBase UploadImg { get; set; }
    }
}

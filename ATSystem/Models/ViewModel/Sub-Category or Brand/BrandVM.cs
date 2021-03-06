﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ATSystem.Models.ViewModel.Sub_Category_or_Brand
{
    public class BrandVM
    {
        public int Id { set; get; }

        [DisplayName("Brand Name")]
        [Required(ErrorMessage = "Brand Name Required")]
        public string Name { set; get; }

        [DisplayName("Brand Code")]
        [Required(ErrorMessage = "Brand Code Required")]
        public string Code { set; get; }

        public string Description { get; set; }

        [DisplayName("Category")]
        [Required]
        public int CategoryId { get; set; }
        public string Category { set; get; }
    }
}
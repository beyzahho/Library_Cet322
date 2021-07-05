﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Models
{
    public class Checkout
    {
        public int Id { get; set; }

    [Required]
    public LibraryAsset LibraryAsset { get; set; }
        public LibraryCard LibraryCard { get; set; }
         public DateTime Since { get; set; }
        public DateTime Until  { get; set; }



    }
}

﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Library_Web.Object.Dtos
{
    public class CreateLibraryRequest
    {
   
        public int Places { get; set; }

        public string Address { get; set; }
        public int SoldBooks { get; set; }

        public DateOnly Inauguration { get; set; }













    }
}

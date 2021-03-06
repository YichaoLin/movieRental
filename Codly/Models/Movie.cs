﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Codly.Models
{
    public class Movie
    {
        public int Id { get; set; } 

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Required]
        public Genre Genre { get; set;}

        [Display(Name="Genre")]
        [Required]
        public byte GenreId { get; set; }

        public DateTime DataAdded { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name="Number in Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}
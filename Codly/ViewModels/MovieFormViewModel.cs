﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Codly.Models;
using System.ComponentModel.DataAnnotations;

namespace Codly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable <Genre> Genres { get; set; }

        public int? Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //[Required]
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte? GenreId { get; set; }


        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
        public string Title
        {
            get
            {
                return Id != 0 ? "Edit" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}
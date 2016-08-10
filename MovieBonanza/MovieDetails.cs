using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieBonanza
{
    public class MovieDetails
    {


        public MovieDetails(string title, string category, double cost, string movieImage, string movieURL)
        {
            this.Title = title;
            this.Category = category;
            this.Cost = cost;
            this.MovieImage = movieImage;
            this.MovieURL = movieURL;
        }

        public string Title
        {
            get;set;
        }

        public string Category
        {
            get; set;
        }

        public double Cost
        {
            get; set;
        }

        public string MovieImage
        {
            get; set;
        }
        public string MovieURL
        {
            get; set;
        }

    }
}
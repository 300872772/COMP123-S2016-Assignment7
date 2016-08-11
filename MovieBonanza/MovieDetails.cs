using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/* 
 *Author: Md Mamunur Rahman 
 * Student ID: 300872772  
 * 
 * Date last modified: August 09, 2016 
 * Description: This application demonstrates a Online Movie Streaming Solution  
 *  
 * Version: 0.0.6 - added all comments
 */
namespace MovieBonanza
{
    /**  
     * <summary>  
     * This is the public MovieDetails class to generate movie detail properties.  
     * </summary>  
     *   
     * @class MovieDetails  
     */
    public class MovieDetails
    {
        //PUBLIC PROPERTIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is a property named Title
        * </summary>
        * 
        * @property {string} Title 
        *
        * 
        */
        public string Title
        {
            get;set;
        }

        /**
        * <summary>
        * This is a property named Category
        * </summary>
        * 
        * @property {string} Category 
        *
        * 
        */
        public string Category
        {
            get; set;
        }

        /**
        * <summary>
        * This is a property named Cost
        * </summary>
        * 
        * @property {double} Cost 
        *
        * 
        */
        public double Cost
        {
            get; set;
        }
        /**
        * <summary>
        * This is a property named MovieImage
        * </summary>
        * 
        * @property {string} MovieImage 
        *
        * 
        */
        public string MovieImage
        {
            get; set;
        }
        /**
        * <summary>
        * This is a property named MovieURL
        * </summary>
        * 
        * @property {string} MovieURL 
        *
        * 
        */
        public string MovieURL
        {
            get; set;
        }

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that initialize all properties of this class.
        * </summary>
        * 
        * @constructor MovieDetails 
        * @param {string} title
        * @param {string} category
        * @param {double} cost
        * @param {string} movieImage
        * @param {string} movieURL
        */
        public MovieDetails(string title, string category, double cost, string movieImage, string movieURL)
        {
            this.Title = title;
            this.Category = category;
            this.Cost = cost;
            this.MovieImage = movieImage;
            this.MovieURL = movieURL;
        }

    }
}
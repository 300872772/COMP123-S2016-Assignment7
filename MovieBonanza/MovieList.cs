using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
    * This is the public MovieList class extended as list to create movie list.  
    * </summary>  
    *   
    * @class MovieList  
    */
    public class MovieList: List<MovieDetails>
    {

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the constructor that calls CreatLIst method.
        * </summary>
        * 
        * @constructor MovieList 
        * @param {string} dataFileName
        */
        public MovieList(string dataFileName)
        {
            this._createList(dataFileName);
        }


        //PRIVATE METHODES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /**
        * <summary>
        * This is the privte method for _createList for movies and to read data from file.
        * </summary>
        * 
        * @method _createList
        * @returns {void} 
        * @param {string} dataFileName
        * 
        */
        private void _createList(string dataFileName)
        {
            //to open to get movie data
            try
            {
                string fileName = "..\\..\\" + dataFileName + ".txt";
                const char DELIM = ',';

                //Opening filestream
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                StreamReader streamReader = new StreamReader(fileStream);


                // temporary data holder
                string recordString;
                string[] recordArray;

                //read line
                recordString = streamReader.ReadLine();

                while (recordString != null)
                {

                    recordArray = recordString.Split(DELIM);
                    //added data in list
                    this.Add(new MovieDetails(recordArray[0].Trim(), recordArray[1].Trim(),Convert.ToDouble (recordArray[2].Trim()), recordArray[3].Trim(), recordArray[4].Trim()));

                    recordString = streamReader.ReadLine();
                }


                streamReader.Close();
                fileStream.Close();

                this.Sort();
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine("No such file");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error: " + exception.Message);
            }

        }



    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MovieBonanza
{
    
    public class MovieList: List<MovieDetails>
    {
        public MovieList(string dataFileName)
        {
            this._createList(dataFileName);
        }



        private  void _createList(string dataFileName)
        {
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


                recordString = streamReader.ReadLine();

                while (recordString != null)
                {

                    recordArray = recordString.Split(DELIM);
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
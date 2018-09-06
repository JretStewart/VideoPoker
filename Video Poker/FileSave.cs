using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
JS
*/
namespace Azara_Video_Poker
{
    class FileSave
    {
        private string path = "CreditSave.txt";
        private FileStream fileOutput;
        private StreamWriter fileWriter;

/// <summary>
/// writes lbl data to file
/// </summary>
/// <param name="creditSave"></param>
/// <returns></returns>
        public bool SaveGame(CreditAmount creditSave)
        {
            try
            {
                //calling filestream and streamwriter constructors
                fileOutput = new FileStream(path, FileMode.Create, FileAccess.Write);
                fileWriter = new StreamWriter(fileOutput);
                
                //Write data and close file
                fileWriter.WriteLine(creditSave.ToString());
                fileWriter.Close();

            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }
        
        }//End SaveGame 
}//End namespace

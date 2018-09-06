using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
/*
AA && JS
*/
namespace Azara_Video_Poker
{
    class LoadGame
    {
        private FileStream fileInput;
        private StreamReader fileReader;
        private string path = "CreditSave.txt";

        public string loadGame()
        {
            //Variables
            string strCredits = "500";

            //FileStream and Stream Reader Constructor
            fileInput = new FileStream(path, FileMode.Open, FileAccess.Read);
            fileReader = new StreamReader(fileInput);

            //Loads the credits from the save file
            try
            {
                //Read through the file
                while (!fileReader.EndOfStream)
                {
                    strCredits = fileReader.ReadLine();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("No previous save found!");
            }

            return strCredits;
        }
    }//End LoadGame
}//End namespace

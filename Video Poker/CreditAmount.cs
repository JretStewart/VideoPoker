using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
JS
*/
namespace Azara_Video_Poker
{
    class CreditAmount
    {
        public string CredAmount { get; set; }
        
        public CreditAmount(string credamount)
        {
            CredAmount = credamount;
        }//end CreditAmount()

            public override string ToString()
        {
            return string.Format("{0}", CredAmount);
        }//end override 

    }//End Class 

}//End namespace

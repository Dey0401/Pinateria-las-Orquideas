using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnDescVta
{
    public class clsRnDescVta
    {
        #region Atributos   
        private int intCod;
        private string strError;
        #endregion

        #region Propiedades   
        public int Codigo
        { set { intCod = value; } }

        public string Error 
        { get { return strError; } }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnDescVta
{
    public class clsRnDescVta
    {
        #region Atributos   
        private int intCod;
        private int intCantProd;
        private float fltDesc;
        private string strError;
        #endregion

        #region Constructor's
        public clsRnDescVta()
        {
            this.intCod = 0;
            this.intCantProd = 0;
            this.fltDesc = 0;
            this.strError = string.Empty;
        }
        #endregion

        #region Propiedades   
        public int Codigo
        { set { intCod = value; } }

        public int Cantidad
        { set { intCantProd = value; } }

        public string Error 
        { get { return strError; } }

        public float Descuento
        { get { return fltDesc; } }
        #endregion

        #region Metodos Privados
        private bool Validar() 
        {
            if (intCantProd<=0)
            {
                strError = "La cantidad no es valida debe ser mayor a cero";
                return false;
            }
            if (intCod <= 0)
            {
                strError = "El código no es valido debe ser mayor a cero";
                return false;
            }
            return true;
        }
        private bool leerArchivo()
        {
            if (!Validar())
                return false;
            try
            {
                string strPath = AppDomain.CurrentDomain.BaseDirectory + @"Descuentos.txt";
                int intCant = 0, intCodLeido, intCantLeido;
                float fltPorcLeido;
                string strLinea;
                string[] vectorLinea;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); //Crear objeto para leer el archivo
                while ((strLinea = Archivo.ReadLine()) != null)      //Leer línea * línea el archivo
                {
                    vectorLinea = strLinea.Split(':');
                    intCodLeido = Convert.ToInt32(vectorLinea[0]);    //Codigo de producto
                    intCantLeido = Convert.ToInt32(vectorLinea[1]);   //Cantidad minima
                    fltPorcLeido = Convert.ToSingle(vectorLinea[2]);  //Promedio de descuento
                    if (intCod == intCodLeido && intCantProd > intCantLeido)
                    {
                        fltDesc = fltPorcLeido; 
                        break;
                    }
                }
                Archivo.Close();
                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                return false;
            }
        }

        #endregion

        #region Metodos Publicos
        public bool hallarDscto()
        {
            if(!Validar()) return false;
            return leerArchivo();
        }
        #endregion
    }
}

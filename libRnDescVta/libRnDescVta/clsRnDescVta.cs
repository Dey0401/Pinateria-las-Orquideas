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
        private int intCant;
        private float fltDesc;
        private string strError;
        #endregion

        #region Propiedades   
        public int Codigo
        { set { intCod = value; } }

        public int Cantidad
        { set { intCant = value; } }

        public string Error 
        { get { return strError; } }

        public float Descuento
        { get { return fltDesc; } }
        #endregion

        #region Metodos Privados
        private bool Validar() 
        {
            if (intCant<=0)
            {
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
                int intCant = 0;
                string strLinea;
                string[] vectorLinea;
                string strCodigo; //atributo propio que toma
                float fltNota; //atributo propio que toma
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); //Crear objeto para leer el archivo
                while ((strLinea = Archivo.ReadLine()) != null)      //Leer línea * línea el archivo
                {
                    vectorLinea = strLinea.Split(':');
                    strCodigo = vectorLinea[0];          //Tipo de estudiante (Programa)
                    fltNota = Convert.ToSingle(vectorLinea[1]);  //Promedio mínimo de nota
                                                                 //if (strCodigo == _intTipoEst.ToString() && _fltProm >= fltNota)
                    {
                        //_fltValCredito = Convert.ToSingle(vectorLinea[2]); //Valor crédito
                        //_intCredit = Convert.ToInt16(vectorLinea[3]); //Cantidad Créditos
                        //_fltDesc = Convert.ToSingle(vectorLinea[4]); //Porcentaje de Dscto
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
            Validar();
            leerArchivo();
            return false;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libRnDescVta;

namespace libOpeDescVta
{
    public class clsOpeDescVta
    {
        #region Atributos
        private int intCod, intCant;
        private float fltVrDoc, fltPorcIva, fltSubTot, fltPorDscto, fltVrDscto, fltVrIVA, fltTotAPag;
        private string strError;
        #endregion

        #region Constructor
        public clsOpeDescVta()
        {
            intCod = 0;
            intCant = 0;
            fltVrDoc = 0;
            fltPorcIva = 0;
            fltSubTot = 0;
            fltPorDscto = 0; 
            fltVrDscto = 0;
            fltVrIVA = 0; 
            fltTotAPag = 0;
            strError = string.Empty; 
    }
        #endregion

        #region Propiedades
        public int Codigo
        { set { intCod = value; } }
        public int Cantidad
        { set { intCant = value; } }
        public float vrDocena
        { set { fltVrDoc = value; } }
        public float porcIVA
        { set { fltPorcIva = value; } }

        public float subTotal
        { get { return fltSubTot; } }
        public float porcDscto
        { get { return fltPorDscto; } }
        public float vrDscto
        { get { return fltVrDscto; } }
        public float vrIva
        { get { return fltVrIVA; } }
        public float totalAPagar
        { get { return fltTotAPag; } }
        public string Error
        { get { return strError; } }
        #endregion

        #region Metodos privados
         private bool Validar()
        {
            if ( intCod <= 0 )
            {
                strError = "Código no válido";
                return false;
            }
            if (fltVrDoc <= 0)
            {
                strError = "Valor docena no válido";
                return false;
            }
            if (intCant <= 0)
            {
                strError = "Cantidad no válida";
                return false;
            }
            if(fltPorcIva < 0 || fltPorcIva > 20)
            {
                strError = "Porcentaje de IVA no válido";
                return false;
            }
            return true;
        }
        #endregion

        #region Metodos publicos
            public bool Facturar ()
        {
            if (!Validar())
            {  
                return false;
            }
            try
            {
                fltSubTot = intCant * fltVrDoc / 12;
                //Crear el objeto
                clsRnDescVta objR = new clsRnDescVta();
                //Enviar info al objeto
                objR.Codigo    = intCod;
                objR.Cantidad  = intCant;
                //Invocar métodos y tratamiento del error
                if ( ! objR.hallarDscto())
                {
                    strError = objR.Error;
                    return false;
                }
                fltPorDscto = objR.Descuento;
                fltVrDscto = fltSubTot * fltPorDscto/100;
                fltVrIVA = (fltSubTot - fltVrDscto) * fltPorcIva/100;
                fltTotAPag = fltSubTot - fltVrDscto + fltVrIVA;

                return true;
            }
            catch (Exception ex)
            {
                strError = ex.Message;
                throw;
            }
            
        }
        #endregion
    }
}

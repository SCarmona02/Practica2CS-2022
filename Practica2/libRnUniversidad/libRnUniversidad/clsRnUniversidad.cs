using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRnUniversidad
{
    public class clsRnUniversidad
    {
        #region "Atributos"

        private int intTipoEst, intCredit;
        private float fltProm, fltValCredito, fltDesc;
        private string strError;

        #endregion

        #region "Constructor"

        public clsRnUniversidad()
        {
            intTipoEst = 0;
            intCredit = 0;
            fltProm = 0;
            fltValCredito = 0;
            fltDesc = 0;
            strError = string.Empty;
        }

        #endregion

        #region "Propiedades"
        //Valores de Entrada
        public int tipoEstudiante
        {
            set { intTipoEst = value; }
        }

        public float Promedio
        {
            set { fltProm = value; }
        }

        //Valores de Salida
        public int numCreditos
        {
            get { return intCredit; }
        }

        public float valorCredito
        {
            get { return fltValCredito; }
        }

        public float Descuento
        {
            get { return fltDesc; }
        }

        public string Error
        {
            get { return strError; }
        }

        #endregion

        #region "Métodos Privados"

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
                string strCodigo;
                float fltNota;
                intCant = File.ReadAllLines(strPath).Length;
                if (intCant <= 0)
                    return true;
                StreamReader Archivo = new StreamReader(@strPath); //Crear objeto para leer el archivo 
                while ((strLinea = Archivo.ReadLine()) != null)    //Leer línea * línea el archivo 
                {
                    vectorLinea = strLinea.Split(':');
                    strCodigo = vectorLinea[0];                        //Tipo de Estudiante (Programa) 
                    fltNota = Convert.ToSingle(vectorLinea[1]);        //Promedio Mínimo de Nota
                    if (strCodigo == intTipoEst.ToString() && fltProm >= fltNota)
                    {
                        fltValCredito = Convert.ToSingle(vectorLinea[2]);   //Valor Crédito
                        intCredit = Convert.ToInt16(vectorLinea[3]);   //Cantidad Créditos
                        fltDesc = Convert.ToSingle(vectorLinea[4]);   //Porcentaje de Dscto 
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

        #region "Métodos Públicos"

        public bool hallarDatos()
        {
            return leerArchivo();
        }

        #endregion
    }
}

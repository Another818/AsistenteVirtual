using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asistente_virtual
{
    class clsClima
    {
        #region Propiedades de clase
        //Propiedades de clase
        string sName;
        string sPais;
        //Weather
        string sWeather;
        string sWdescrip;
        //
        double dTemperatura;
        double dSensacion;
        double dTemp_Max;
        double dTemp_Min;
        int iPresion;
        int iHumedad;
        //Viento
        double dVelocidad;
        #endregion

        #region Encapsulamiento de las propiedades

        public string pSName 
        {
            get { return sName; }
            set { sName = value; }
        }

        public string pSPais 
        {
            get { return sPais; }
            set { sPais = value; }
        }
        //Weather
        public string pSWeather
        {
            get { return sWeather; }
            set { sWeather = value; }
        }
        public string pSDescrip
        {
            get { return sWdescrip; }
            set { sWdescrip = value; }
        }
        //
        public double pDTemperatura
        {
            get { return dTemperatura; }
            set { dTemperatura = value; }
        }

        public double pDSensacion 
        {
            get { return dSensacion; }
            set { dSensacion = value; }
        }

        public double pDTemp_Max 
        {
            get { return dTemp_Max; }
            set { dTemp_Max = value; }
        }

        public double pDTemp_Min 
        {
            get { return dTemp_Min; }
            set { dTemp_Min = value; }
        }

        public int pIPresion 
        {
            get { return iPresion; }
            set { iPresion = value; }
        }

        public int pIHumedad 
        {
            get { return iHumedad; }
            set { iHumedad = value; }
        }

        //Viento
        public double pDVelocidad 
        {
            get { return dVelocidad; }
            set { dVelocidad = value; }
        }

        #endregion

        #region Métodos constructores de la clase
        //Constructor sin párametros
        public clsClima()
        {
            pSName = "";
            pSPais = "";
            pSWeather = "";
            pSDescrip = "";
            pDTemperatura = 0;
            pDSensacion = 0;
            pDTemp_Max = 0;
            pDTemp_Min = 0;
            pIPresion = 0;
            pIHumedad = 0;
            pDVelocidad = 0;
        }

        //Constructor con párametros
        public clsClima(string sName, string sPais, string sWeath, string sDescr, double dTemp, double dSensa, double dTemp_Max, double dTemp_Min, int iPresion, int iHume, double dVeloc) 
        {
            pSName = sName;
            pSPais = sPais;
            pSWeather = sWeath;
            pSDescrip = sDescr;
            pDTemperatura = dTemp;
            pDSensacion = dSensa;
            pDTemp_Max = dTemp_Max;
            pDTemp_Min = dTemp_Min;
            pIPresion = iPresion;
            pIHumedad = iHume;
            pDVelocidad = dVeloc;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proforma.Models;

namespace Proforma.Modules
{
    public static class CustomFormat
    {
        public static string gConvierteCifra(string Texto, bool SW)
        {
            string Centena="";
            string Decena="";
            string Unidad="";
            string txtCentena="";
            string txtDecena="";
            string txtUnidad="";

            Centena = Texto.Substring(0, 1);
            Decena = Texto.Substring(1, 1);
            Unidad = Texto.Substring(2, 1);

            switch (Centena)
            {
                case "1":
                    {
                        txtCentena = "CIEN";
                        if (Decena + Unidad != "00")
                            txtCentena = "CIENTO";
                        break;
                    }

                case "2":
                    {
                        txtCentena = "DOSCIENTOS";
                        break;
                    }

                case "3":
                    {
                        txtCentena = "TRESCIENTOS";
                        break;
                    }

                case "4":
                    {
                        txtCentena = "CUATROCIENTOS";
                        break;
                    }

                case "5":
                    {
                        txtCentena = "QUINIENTOS";
                        break;
                    }

                case "6":
                    {
                        txtCentena = "SEISCIENTOS";
                        break;
                    }

                case "7":
                    {
                        txtCentena = "SETECIENTOS";
                        break;
                    }

                case "8":
                    {
                        txtCentena = "OCHOCIENTOS";
                        break;
                    }

                case "9":
                    {
                        txtCentena = "NOVECIENTOS";
                        break;
                    }
            }

            switch (Decena)
            {
                case "1":
                    {
                        txtDecena = "DIEZ";
                        switch (Unidad)
                        {
                            case "1":
                                {
                                    txtDecena = "ONCE";
                                    break;
                                }

                            case "2":
                                {
                                    txtDecena = "DOCE";
                                    break;
                                }

                            case "3":
                                {
                                    txtDecena = "TRECE";
                                    break;
                                }

                            case "4":
                                {
                                    txtDecena = "CATORCE";
                                    break;
                                }

                            case "5":
                                {
                                    txtDecena = "QUINCE";
                                    break;
                                }

                            case "6":
                                {
                                    txtDecena = "DIECISEIS";
                                    break;
                                }

                            case "7":
                                {
                                    txtDecena = "DIECISIETE";
                                    break;
                                }

                            case "8":
                                {
                                    txtDecena = "DIECIOCHO";
                                    break;
                                }

                            case "9":
                                {
                                    txtDecena = "DIECINUEVE";
                                    break;
                                }
                        }

                        break;
                    }

                case "2":
                    {
                        txtDecena = "VEINTE";
                        if (Unidad != "0")
                            txtDecena = "VEINTI";
                        break;
                    }

                case "3":
                    {
                        txtDecena = "TREINTA";
                        if (Unidad != "0")
                            txtDecena = "TREINTA Y ";
                        break;
                    }

                case "4":
                    {
                        txtDecena = "CUARENTA";
                        if (Unidad != "0")
                            txtDecena = "CUARENTA Y ";
                        break;
                    }

                case "5":
                    {
                        txtDecena = "CINCUENTA";
                        if (Unidad != "0")
                            txtDecena = "CINCUENTA Y ";
                        break;
                    }

                case "6":
                    {
                        txtDecena = "SESENTA";
                        if (Unidad != "0")
                            txtDecena = "SESENTA Y ";
                        break;
                    }

                case "7":
                    {
                        txtDecena = "SETENTA";
                        if (Unidad != "0")
                            txtDecena = "SETENTA Y ";
                        break;
                    }

                case "8":
                    {
                        txtDecena = "OCHENTA";
                        if (Unidad != "0")
                            txtDecena = "OCHENTA Y ";
                        break;
                    }

                case "9":
                    {
                        txtDecena = "NOVENTA";
                        if (Unidad != "0")
                            txtDecena = "NOVENTA Y ";
                        break;
                    }
            }

            if (Decena != "1")
            {
                switch (Unidad)
                {
                    case "1":
                        {
                            if (SW)
                                txtUnidad = "UN";
                            else
                                txtUnidad = "UNO";
                            break;
                        }

                    case "2":
                        {
                            txtUnidad = "DOS";
                            break;
                        }

                    case "3":
                        {
                            txtUnidad = "TRES";
                            break;
                        }

                    case "4":
                        {
                            txtUnidad = "CUATRO";
                            break;
                        }

                    case "5":
                        {
                            txtUnidad = "CINCO";
                            break;
                        }

                    case "6":
                        {
                            txtUnidad = "SEIS";
                            break;
                        }

                    case "7":
                        {
                            txtUnidad = "SIETE";
                            break;
                        }

                    case "8":
                        {
                            txtUnidad = "OCHO";
                            break;
                        }

                    case "9":
                        {
                            txtUnidad = "NUEVE";
                            break;
                        }
                }
            }

            return txtCentena + " " + txtDecena + txtUnidad;
        }
        public static string gNum_texto(decimal Numero)
        {
            string Texto="";
            string Millones="";
            string Miles="";
            string Cientos="";
            string Decimales="";
            string Cadena="";
            string CadMillones="";
            string CadMiles="";
            string CadCientos="";
            string _moneda = "";

            using (BD_ERPEntities contexto = new BD_ERPEntities())
            {
                var monedas = contexto.tblMonedas.ToList();
                tblConfiguracion con = contexto.tblConfiguracion.FirstOrDefault(x => x.decIdConfiguracion == 1);

                if (Convert.ToBoolean(con.bitImprimirFacturaUS))
                {
                    _moneda = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda != con.intMoneda).strDescripcion).ToUpper();
                }
                else
                {
                    _moneda = Convert.ToString(monedas.FirstOrDefault(x => x.intIdMoneda == con.intMoneda).strDescripcion).ToUpper();
                }             
            }

            Texto = String.Format("{0:n2}", Numero);
            Texto = "              " + Texto;
            Texto = Texto.Substring(Texto.Length - 14, 14);
            Millones = Texto.Substring(0, 3);
            Miles = Texto.Substring(4, 3);
            Cientos = Texto.Substring(8, 3);
            Decimales = Texto.Substring(12, 2);
            CadMillones = gConvierteCifra(Millones, true);
            CadMiles = gConvierteCifra(Miles, true);
            CadCientos = gConvierteCifra(Cientos, false);

            if (CadMillones.Trim().Length > 0)
            {
                if (CadMillones.Trim() == "UN")
                    Cadena = CadMillones + " MILLON";
                else
                    Cadena = CadMillones + " MILLONES";
            }
            if (CadMiles.Trim().Length > 0)
                Cadena = Cadena + " " + CadMiles + " MIL";

            if (CadMiles.Trim() + CadCientos.Trim() == "UN")
                Cadena = Cadena + " " + _moneda + " CON " + Decimales + "/100";
            else if (Miles + Cientos == "000000")
                Cadena = Cadena + " " + CadCientos.Trim() + " " + _moneda + " CON " + Decimales + "/100 CENTAVOS";
            else
                Cadena = Cadena + " " + CadCientos.Trim() + " " + _moneda + " CON " + Decimales + "/100 CENTAVOS";

            return Cadena.Trim();
        }
    }
}

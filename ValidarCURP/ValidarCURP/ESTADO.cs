using System;
using System.Collections.Generic;
using System.Text;

namespace ValidarCURP
{
    class ESTADO
    {
        public string Estado = "";

       public string ESTADONACIMIENTO(string EstadoNacimiento)
        {
            switch (EstadoNacimiento)
            {
                case "AGUASCALIENTES":
                    Estado = "AS";
                    break;
            case "BAJA CALIFORNIA":  
                    Estado = "BC";
                    break;
                case "BAJA CALIFORNIA SUR":
                    Estado = "BS";
                    break;
                case "CAMPECHE":
                    Estado = "CC";
                    break;
                case "COAHUILA":
                    Estado = "CL";
                    break;
                case "COLIMA":
                    Estado = "CM";
                    break;        
                case "CHIAPAS":
                    Estado = "CS";
                    break;    
                case "CHIHUAHUA":
                    Estado = "CH";
                    break;  
                case "DISTRITO FEDERAL":
                    Estado = "DF";
                    break;           
                case "DURANGO":
                    Estado = "DG";
                    break;        
                case "GUANAJUATO":
                    Estado = "GT";
            break;
                case "GUERRERO":
                    Estado = "GR";
                    break;
                case "HIDALGO":
                    Estado = "HG";
                    break;
                case "JALISCO":
                    Estado = "JC";
                    break;
                case "MEXICO":
                    Estado = "MC";
                    break;
                case "MICHOACAN":
                    Estado = "MN";
                    break;
                case "MORELOS":
                    Estado = "MS";
                    break;
                case "NAYARIT":
                    Estado = "NT";
                    break;
                case "NUEVO LEON":
                    Estado = "NL";
                    break;
                case "OAXACA":
                    Estado = "OC";
                    break;
                case "PUEBLA":
                    Estado = "PL";
                    break;
                case "QUERETARO":
                    Estado = "QT";
                    break;
                case "SAN LUIS POTOSI":
                    Estado = "SP";
                    break;
                case "SINALOA":
                    Estado = "SL";
                    break;
                case "SONORA":
                    Estado = "SR";
                    break;
                case "QUINTANA ROO":
                    Estado = "QR";
                    break;
                case "TABASCO":
                    Estado = "TC";
                    break;
                case "TAMAULIPAS":
                    Estado = "TS";
                    break;
                case "TLAXCALA":
                    Estado = "TL";
                    break;
                case "VERACRUZ":
                    Estado = "VZ";
                    break;
                case "YUATAN":
                    Estado = "YN";
                    break; 
                case "ZACATECAS":
                    Estado = "YN";
                    break;
                default :
                    Estado = "NS";
                    break;
            }
            return Estado;
        }
    }
}

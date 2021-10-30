using System;
using System.Collections;
using CalcularResistencia.Domain.Interface;
namespace CalcularResistencia.Domain.Entities
{
    public class ColorBandas: ICalculosResistencia
    {

    private string _Banda1,_Banda2,_Banda3,_Banda4,Resultado1,Resultado2,Default,_result;
    private int valor = 0;
    public double Multi = 0.0,_Resultado2 = 0.0,_Resultado3 = 0.0,ResultMenos=0.0,ResultMas=0.0;

        
        public void Bandas1(string Color1)
        {
            _Banda1 = Color1.ToLower();
            switch(_Banda1){
                case "negro":
                Resultado1="0";
                break;
                case "cafe":
                Resultado1 = "1";
                break;
                case "rojo":
                Resultado1 = "2";
                break;
                case "naranja":
                Resultado1 = "3";
                break;
                case "amarillo":
                Resultado1 = "4";
                break;
                case "verde":
                Resultado1 = "5";
                break;
                case "azul":
                Resultado1 = "6";
                break;
                case "violeta":
                Resultado1 = "7";
                break;
                case "gris":
                Resultado1 = "8";
                break;
                case "blanco":
                Resultado1 = "9";
                break;
                default:
                Default = "Dato no valido";
                break;
            }
        }
        public void Bandas2(string Color2)
        {
            _Banda2 = Color2.ToLower();
            switch(_Banda2){
                case "negro":
                Resultado2="0";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "cafe":
                Resultado2 = "1";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "rojo":
                Resultado2 = "2";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "naranja":
                Resultado2 = "3";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "amarillo":
                Resultado2 = "4";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "verde":
                Resultado2 = "5";
                _result = 1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "azul":
                Resultado2 = "6";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "violeta":
                Resultado2 = "7";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "gris":
                Resultado2 = "8";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                case "blanco":
                Resultado2 = "9";
                _result = Resultado1 + Resultado2;
                valor = int.Parse(_result);
                break;
                default:
                Default = "Dato no valido";
                break;
            }
        }
        public void Bandas3(string Color3)
        {
            _Banda3 = Color3.ToLower();
            switch(_Banda3){
                case "negro":
                _Resultado2 = 1;
                Multi = valor * _Resultado2;
                break;
                case "cafe":
                _Resultado2 = 10;
                Multi = valor * _Resultado2;
                break;
                case "rojo":
                _Resultado2 = 100;
                Multi = valor * _Resultado2;
                break;
                case "naranja":
                _Resultado2 = 1000;
                Multi = valor * _Resultado2;
                break;
                case "amarillo":
                _Resultado2 = 10000;
                Multi = valor * _Resultado2;
                break;
                case "verde":
                _Resultado2 = 100000;
                Multi = valor * _Resultado2;
                break;
                case "azul":
                _Resultado2 = 1000000;
                Multi = valor * _Resultado2;
                break;
                case "violeta":
                _Resultado2 = 10000000;
                Multi = valor * _Resultado2;
                break;
                case "gris":
                _Resultado2 = 100000000;
                Multi = valor * _Resultado2;
                break;
                case "blanco":
                _Resultado2 = 1000000000;
                Multi = valor * _Resultado2;
                break;
                default:
                Default = "Dato no valido";
                break;
            }
        }
        public void Bandas4(string Color4)
        {
            _Banda4 = Color4.ToLower();

                if(_Banda4 == "dorado"){
                _Resultado3 = (Multi* 5)/100;
                }
                if(_Banda4 == "plata"){
                _Resultado3 = Multi * 10/100;
                }
    
            
         ResultMas= Multi + _Resultado3;
         ResultMenos= Multi - _Resultado3;  
        }

        public string Returnoperacion()
        {
             return $"el valor es {Multi} y la tolerancia + o - {_Resultado3} El rango de toleracia si tiene mas el {_Resultado3} es de: {ResultMas} El rango de tolerancia si tiene menos el {_Resultado3} es de : {ResultMenos}  ";
        }
    }
}


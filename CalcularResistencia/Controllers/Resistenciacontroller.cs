/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a servicios 
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad 2: Calcular Resistencia 
    Nombre del alumno: Erika Guadalupe Bojon Martinez 
    Cuatrimestre: 4
    Grupo: A
    Parcial: 2
    */
using CalcularResistencia.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
namespace CalcularResistencia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Resistenciacontroller : ControllerBase
    {
        [HttpGet]
        [Route("CalculosBandas")]
        public IActionResult CalculaBandas (string _Bandas1, string _Bandas2, string _Bandas3, string _Bandas4)
        { 
            var Bandas = new ColorBandas();
            Bandas.Bandas1(_Bandas1);
             if(_Bandas1.ToLower() != "negro" && _Bandas1.ToLower() != "cafe" && _Bandas1.ToLower() != "rojo" && _Bandas1.ToLower() != "amarillo" &&_Bandas1.ToLower() != "gris" &&_Bandas1.ToLower() != "verde" && _Bandas1.ToLower()!= "azul" && _Bandas1.ToLower() != "violeta"&& _Bandas1.ToLower()!= "naranja" && _Bandas1.ToLower() != "blanco"  )
            {
                return Ok( "Error Banda 1: Asegure que sea el color adecuado :)");
            }
            Bandas.Bandas2(_Bandas2);
             if(_Bandas2.ToLower() != "negro" && _Bandas2.ToLower() != "cafe" && _Bandas2.ToLower() != "rojo" && _Bandas2.ToLower()!= "naranja"&& _Bandas2.ToLower() != "amarillo" &&_Bandas2.ToLower() != "verde" &&   _Bandas2.ToLower()!= "azul"&& _Bandas2.ToLower() != "violeta"&&_Bandas2.ToLower() != "gris"   && _Bandas2.ToLower() != "blanco"  )
            {
                return Ok("Error Banda 2 : Asegure que sea el color adecuado :)");
            }
            Bandas.Bandas3(_Bandas3);
             if(_Bandas3.ToLower() != "negro" && _Bandas3.ToLower() != "cafe" && _Bandas3.ToLower() != "rojo" && _Bandas3.ToLower()!= "naranja"&& _Bandas3.ToLower() != "amarillo" &&_Bandas3.ToLower() != "verde" &&   _Bandas3.ToLower()!= "azul" || _Bandas3.ToLower() == "violeta"||_Bandas3.ToLower() == "gris"   || _Bandas3.ToLower() == "blanco"  )
            {
                return Ok("Error Banda 3: Asegure que sea el color adecuado :)");
            }

            Bandas.Bandas4(_Bandas4);
            if(_Bandas4.ToLower() != "dorado" && _Bandas4.ToLower() != "plata")
            {
                return Ok("Error la Banda 4 : Asegure que sea el color dorado o plata :)");
            }
            Bandas.Returnoperacion();
            return Ok (Bandas.Returnoperacion ());
        }

    
    }
}

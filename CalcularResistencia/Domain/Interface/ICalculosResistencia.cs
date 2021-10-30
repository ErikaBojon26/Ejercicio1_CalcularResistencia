using System;
namespace CalcularResistencia.Domain.Interface
{
    public interface ICalculosResistencia
    {
        void Bandas1(string Color1);
        void Bandas2(string Color2);
        void Bandas3(string Color3);
        void Bandas4(string Color4);
        string Returnoperacion();
    }
}
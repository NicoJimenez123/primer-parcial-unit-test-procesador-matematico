using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primer_parcial_unit_test_procesador_matematico
{
    public class ProcesadorMatematico
    {
        private double _resultado;

        public void Sumar(double primerNumero, double segundoNumero)
        {
            this._resultado = primerNumero + segundoNumero;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }
        }

        public void Dividir(double dividendo, double divisor)
        {
            this._resultado = dividendo / divisor;
            if (this.EsNegativo())
            {
                this._resultado = 0;
            }
        }
        private bool EsNegativo()
        {
            return (this._resultado < 0);
        }

        public void CalcularMayor(double primerNumero, double segundoNumero)
        {
            if (primerNumero > segundoNumero)
            {
                this._resultado = primerNumero;
            }
            else if (primerNumero < segundoNumero)
            {
                this._resultado = segundoNumero;
            }
            else
            {
                this._resultado = segundoNumero;
            }
        }

        public double getResultado()
        {
            return this._resultado;
        }
    }
}

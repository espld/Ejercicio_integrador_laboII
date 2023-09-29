using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion GetPrimerOperando()
        {
            return primerOperando;
        }
        public void SetPrimerOperando(Numeracion operando)
        {
            this.primerOperando = operando;
        }
        public Numeracion GetSegundoOperando()
        {
            return segundoOperando;
        }
        public void SetSegundoOperando(Numeracion operando)
        {
            this.segundoOperando = operando;
        }

        public Numeracion Operar(char operador)
        {

            switch (operador)
            {
                case '-':
                    return primerOperando - segundoOperando;
                   
                case '*':
                    return primerOperando * segundoOperando;
                    
                case '/':
                    return primerOperando / segundoOperando;
                    
                default:
                    return primerOperando + segundoOperando;                   
            }
        }

    }
}

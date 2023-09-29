namespace Entidades
{
    public class Numeracion
    {
        
    public enum ESistema { Decimal, Binario }

        private ESistema sistema;
        private double valorNumerico;

        public Numeracion(double valor, ESistema sistema)
        {
            this.valorNumerico = valor;
            this.sistema = sistema;
        }
        public Numeracion(string valor, ESistema sistema)
        {
            InicializarValores(valor, sistema);
        }

        public ESistema GetSistema()
        {
            return sistema;
        }
        public string GetValor()
        {
            return valorNumerico.ToString();
        }

        private bool EsBinario(string valor)
        {
            foreach (char caracter in valor)
            {
                if (caracter != '0' && caracter != '1')
                {
                    return false;
                }
            }
            return true;
        }

        private double BinarioADecimal(string valor)
        {
            if (EsBinario(valor))
            {
                return Convert.ToInt32(valor, 2);

            }
            else
            {
                return 0;
            }
        }

        private string DecimalABinario(string valor)
        {
            if (!EsBinario(valor))
            {
                int.TryParse(valor, out int numeroParseado);
                if (numeroParseado < 0)
                {
                    return "Numero Invalido";
                }
                return Convert.ToString(numeroParseado, 2);
            }
            {
                return "Numero inválido";
            }
        }

        private string DecimalABinario(int valor)
        {

            if (valor < 0)
            {
                return "Numero invalido";
            }

            string numeroConvertido = Convert.ToString(valor, 2);

            if (EsBinario(numeroConvertido))
            {

                return numeroConvertido;


            }
            else
            {
                return "Numero inválido";

            }
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return DecimalABinario((int)this.valorNumerico);
            }
            else
            {
                return this.valorNumerico.ToString();
            }
        }

        private void InicializarValores(string valor, ESistema sistema)
        {

            if (EsBinario(valor) && sistema == ESistema.Binario)
            {
                this.valorNumerico = BinarioADecimal(valor);

            }
            else if (int.TryParse(valor, out int vDecimal))
            {

                this.valorNumerico = vDecimal;

            }
            else
            {
                this.valorNumerico = double.MinValue;

            }

        }



        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion.sistema);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }
        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1.sistema == n2.sistema);
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico + n2.valorNumerico;
            Numeracion numResultado = new Numeracion(resultado, ESistema.Decimal);
            return numResultado;
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico - n2.valorNumerico;
            Numeracion numResultado = new Numeracion(resultado, ESistema.Decimal);
            return numResultado;
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            double resultado = n1.valorNumerico * n2.valorNumerico;
            Numeracion numResultado = new Numeracion(resultado, ESistema.Decimal);
            return numResultado;
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {

            double resultado = n1.valorNumerico / n2.valorNumerico;
            Numeracion numResultado = new Numeracion(resultado, ESistema.Decimal);
            return numResultado;
        }
    }
}
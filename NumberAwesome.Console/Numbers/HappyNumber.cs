using System;

namespace NumberAwesome.Console.Numbers
{
    public class HappyNumber
    {
        private long _number;

        public HappyNumber(long number)
        {
            _number = number;
        }

        public bool IsHappy()
        {
            for (int i = 1; i <= 100; i++)
            {
                var lista = _number.ToString().ToCharArray();
                double resultado = 0;

                foreach (var item in lista)
                {
                    resultado += Math.Pow(double.Parse(item.ToString()), 2);
                }

                if(resultado == 1)
                {
                    return true;
                }
                else
                {
                    _number = long.Parse(resultado.ToString());
                }
            }

            return false;
        }
    }
}
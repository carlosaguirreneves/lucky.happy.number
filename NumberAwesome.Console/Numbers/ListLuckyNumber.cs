using System;
using System.Collections.Generic;

namespace NumberAwesome.Console.Numbers
{
    public class ListLuckyNumber : LuckyNumber
    {
        private long _number;

        public ListLuckyNumber(long number)
        {
            _number = number;
        }

        public override bool IsLucky()
        {
            if (_number % 2 == 0) {
                return false;
            }

            var numeros = new List<long>();
            long removeAt = 2;

            for (var i = 1; i <= _number; i++) 
            {
                if(i % removeAt != 0)
                {
                    numeros.Add(i);
                }
            }

            long value = 0;

            for (var i = 1; i < numeros.Count; i++) 
            {
                value = removeAt = numeros[i];
                if (removeAt > _number)
                {
                    return true;
                }

                while (true)
                {
                    if (removeAt > numeros.Count)
                        break;

                    var isNotLucky = numeros[Convert.ToInt32(removeAt -1)];
                    if (isNotLucky == _number) 
                        return false;
                    
                    //Remove sempre usando -1, pois o index da lista inicia de zero.
                    numeros.RemoveAt(Convert.ToInt32(removeAt -1));

                    //Temos um item a menos na lista, então devemos usar -1
                    removeAt = removeAt + value -1;
                }
            }

            return true;
        }
    }
}
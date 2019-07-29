namespace NumberAwesome.Console.Numbers
{
    /*
        ArrayLuckyNumber possui melhor performance em relação ao ListLuckyNumber
    */
    public class ArrayLuckyNumber : LuckyNumber
    {
        private long _number;

        public ArrayLuckyNumber(long number)
        {
            _number = number;
        }

        public override bool IsLucky()
        {
            if (_number % 2 == 0) {
                return false;
            }

            var size = _number;
            var numbers = new long[size-size/2];

            var j = 0;

            for(var i = 1; i <= size; i++) 
            {
                if(i % 2 != 0)
                {
                    numbers[j] = i;
                    j++;
                }
            }

            long step = 1;
            long value = 0;
            long removeAt = 2;

            value = removeAt = numbers[step];
            size = numbers.Length - (numbers.Length/value);
            var newArray = new long[size];

            while(step < size) 
            {
                j = 0;
                
                for(var i = 0; i < numbers.Length; i++) 
                {
                    if (i != removeAt -1) {
                        newArray[j] = numbers[i];
                        j++;
                    }
                    else
                    {
                        if (numbers[i] == _number) {
                            return false;
                        }

                        removeAt = removeAt + value;
                    }
                }

                numbers = newArray;
                step++;
                value = removeAt = numbers[step];

                if (value > numbers.Length)
                {
                    return true;
                }

                size = numbers.Length - (numbers.Length/value);
                newArray = new long[size];
            }

            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb11
{
    

    class Runtime
    {
        public delegate void Analyzenumber(int number);
        public event Analyzenumber NumberInput;

        public void Start()
        {
            Console.WriteLine("Skriv in ett heltal: ");
            int uInput = int.Parse(Console.ReadLine());

            NumberInput += new Analyzenumber(IsEven);
            NumberInput += new Analyzenumber(IsDivisibleByThree);
            NumberInput += new Analyzenumber(IsPrimeNumber);
            OnNumberInput(uInput);

        }

        private void OnNumberInput(int uInput)
        {
            NumberInput?.Invoke(uInput);
        }

        public void IsDivisibleByThree(int number)
        {
            Console.WriteLine("{0} {1} delbart med tre", number, number % 3 == 0 ? "är" : "är inte" );
        }

        public void IsPrimeNumber(int number)
        {
            bool isPrime = true;

            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                    isPrime = false;
               
                }
            }

            Console.WriteLine("{0} {1} ett primtal", number, isPrime == true ? "är" : "är inte");
        }
        
        public void IsEven(int number)
        {
            Console.WriteLine("{0} {1} ett jämnt tal", number, number % 2 == 0 ? "är" : "är inte");
        }
        
    }
}

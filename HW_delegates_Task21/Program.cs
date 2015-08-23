using System;


namespace HW_delegates_Task21
{
    class Program
    {
        public delegate double ArrDelegate();

        public delegate double Delegate(ArrDelegate[] delegates);
        static void Main(string[] args)
        {
            Random randVal = new Random();
            ArrDelegate[]  delegates = new ArrDelegate[5];
            for (int i = 0; i < delegates.Length; i++)
            {
                delegates[i] = () => randVal.Next(10);
            }
            Delegate arrDel = myDelegates =>     
            {
                double sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    sum += delegates[i]();
                }               
                Console.WriteLine("sum is -> {0}",sum);
                return sum/5;
            };
            Console.WriteLine("Среднее арифметическое : {0}", arrDel(delegates));
            Console.WriteLine("Значения переменных в делегатах: ");
            for (int i = 0; i < delegates.Length; i++)
            {
                Console.WriteLine("{0}", delegates[i]());
            }
        }
    }
}

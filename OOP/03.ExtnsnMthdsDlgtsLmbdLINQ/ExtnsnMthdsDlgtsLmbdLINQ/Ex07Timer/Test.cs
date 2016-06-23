namespace Ex07Timer
{
    using System;
   
    public class Test
    {
        public static void Main()
        {
            var timer = new Timer(Tick, 2000);
        }

        private static void Tick()
        {
            Console.WriteLine("Tick {0}", DateTime.Now);
        }
    }
}

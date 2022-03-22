using Microsoft.Extensions.ObjectPool;
using System;
using System.Text;

namespace StringManipulationDemos
{
    public partial class Module07
    {
        private static readonly ObjectPool<StringBuilder> Pool =
            new DefaultObjectPoolProvider().CreateStringBuilderPool();

        public static void PoolingStringBuilders()
        {
            Console.Clear();

            var sbPooled = Pool.Get();

            try
            {
                Console.WriteLine(sbPooled.Append("Some text"));
            }
            finally
            {
                Pool.Return(sbPooled);
            }           

            Console.WriteLine();
            Console.WriteLine("Press a key to continue");
            Console.ReadKey();
        }
    }
}
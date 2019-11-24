using System;
using System.Buffers;

namespace CoreBug
{
    class Program
    {
        static void Main(string[] args)
        {
            var buffer = SpanJson.JsonSerializer.NonGeneric.Utf8.SerializeToArrayPool(new object[] { 1 });
            ArrayPool<byte>.Shared.Return(buffer.Array);
            Console.ReadLine();
        }
    }
}

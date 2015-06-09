namespace _06.BitArray
{
    using System;
    using System.Numerics;

    public static class BitArrayExec
    {
        public static void Main()
        {
            BitArray bitarray = new BitArray(9);
            bitarray[0] = 1;

            BigInteger bigInteger = BigInteger.Parse("1234567890123456789012345678901234567890123456789012345678901234567890");

            BitArray bigBitArray = new BitArray(bigInteger);
            bigBitArray[0] = 1;

            Console.WriteLine(bitarray.ToString());
            Console.WriteLine(bigBitArray.ToString());
        }
    }
}

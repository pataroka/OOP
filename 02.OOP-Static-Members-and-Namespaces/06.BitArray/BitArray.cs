namespace _06.BitArray
{
    using System;
    using System.Numerics;

    public class BitArray
    {
        private int length;

        public BitArray(int length)
        {
            this.Length = length;
            this.Bits = new bool[length];
        }

        public BitArray(BigInteger bigint)
        {
            string binaryNumber = bigint.ToBinaryString();
            this.Length = binaryNumber.Length;
            this.Bits = ToBools(binaryNumber);
        }

        public bool[] Bits { get; private set; }

        public int Length
        {
            get
            {
                return this.length;
            }

            set
            {
                if (value < 1 || value > 100000)
                {
                    throw new ArgumentOutOfRangeException("value", "The length must be in the range:[1...100 000]");
                }

                this.length = value;
            }
        }

        public int this[int index]
        {
            get
            {
                return this.Bits[index] ? 1 : 0;
            }

            set
            {
                if (index < 0 || index >= this.Bits.Length)
                {
                    throw new ArgumentOutOfRangeException(
                        string.Format("The index must be in the range:[0...{0}]", this.Bits.Length - 1));
                }

                switch (value)
                {
                    case 0:
                        this.Bits[index] = false;
                        break;
                    case 1:
                        this.Bits[index] = true;
                        break;
                    default:
                        throw new ArgumentException("Value must be either 1 or 0!");
                }
            }
        }

        public override string ToString()
        {
            BigInteger result = 0;
            for (int i = this.Bits.Length - 1; i >= 0; i--)
            {
                result <<= 1;
                result += this.Bits[i] ? 1 : 0;
            }

            return result.ToString();
        }

        private static bool[] ToBools(string binary)
        {
            bool[] bools = new bool[binary.Length];
            for (int i = 0, j = binary.Length - 1; i < binary.Length; i++, j--)
            {
                if (binary[i] == '1')
                {
                    bools[j] = true;
                }
            }

            return bools;
        }
    }
}
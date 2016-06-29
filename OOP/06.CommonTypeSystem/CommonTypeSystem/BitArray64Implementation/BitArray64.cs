namespace BitArray64Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        public BitArray64(ulong value = 0)
        {
            this.Value = value;
        }

        public ulong Value { get; private set; }

        public int Length
        {
            get
            {
                return sizeof(ulong) * 8;
            }
        }

        public int this[int index]
        {
            get
            {
                ValidateIndex(index);

                return (int)((this.Value >> index) & 1);
            }

            set
            {
                ValidateIndex(index);

                switch (value)
                {
                    case 0: this.Value &= ~(1UL << index); break;
                    case 1: this.Value |= 1UL << index; break;
                    default: throw new ArgumentException("Each bit value can only be set to 1 or 0.");
                }
            }
        }

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > 63)
            {
                throw new IndexOutOfRangeException("Index must be within the range [0...63].");
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = this.Length - 1; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }

            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return this.Value == value.Value;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if ((object)temp == null)
                return false;

            return this.Equals(temp);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = result * 23 + this.Value.GetHashCode();
                return result;
            }
        }

        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return Equals(a, b);
        }

        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !Equals(a, b);
        }

        public override string ToString()
        {
            var info = new StringBuilder();

            foreach (var bit in this)
            {
                info.Append(bit);
            }

            return info.ToString();
        }
    }
}
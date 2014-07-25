namespace System.IO
{
    public static class BinaryWriterExtensions
    {
        public static void Write(this BinaryWriter writer, double value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, Int16 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, Int32 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, Int64 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, Single value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, UInt16 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, UInt32 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        public static void Write(this BinaryWriter writer, UInt64 value, bool invertEndian = false)
        {
            if (invertEndian)
            {
                writer.WriteInvertedBytes(BitConverter.GetBytes(value));
            }
            else
            {
                writer.Write(value);
            }
        }

        private static void WriteInvertedBytes(this BinaryWriter writer, byte[] buffer)
        {
            Array.Reverse(buffer);
            writer.Write(buffer);
        }
    }
}

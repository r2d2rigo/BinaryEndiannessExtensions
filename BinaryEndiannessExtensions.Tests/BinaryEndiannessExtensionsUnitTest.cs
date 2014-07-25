using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Diagnostics;

namespace BinaryEndiannessExtensions.Tests
{
    [TestClass]
    public class BinaryEndiannessExtensionsUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            MemoryStream stream = new MemoryStream(100000);

            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(UInt16.MinValue, true);
            writer.Write(UInt16.MaxValue, true);
            writer.Write(UInt32.MinValue, true);
            writer.Write(UInt32.MaxValue, true);
            writer.Write(UInt64.MinValue, true);
            writer.Write(UInt64.MaxValue, true);

            writer.Write(Int16.MinValue, true);
            writer.Write(Int16.MaxValue, true);
            writer.Write(Int32.MinValue, true);
            writer.Write(Int32.MaxValue, true);
            writer.Write(Int64.MinValue, true);
            writer.Write(Int64.MaxValue, true);

            writer.Write(Single.MinValue, true);
            writer.Write(Single.MaxValue, true);
            writer.Write(Double.MinValue, true);
            writer.Write(Double.MaxValue, true);

            writer.Flush();

            BinaryReader reader = new BinaryReader(stream);
            stream.Seek(0, SeekOrigin.Begin);

            Assert.AreEqual(UInt16.MinValue, reader.ReadUInt16(true));
            Assert.AreEqual(UInt16.MaxValue, reader.ReadUInt16(true));
            Assert.AreEqual(reader.ReadUInt32(true), UInt32.MinValue);
            Assert.AreEqual(reader.ReadUInt32(true), UInt32.MaxValue);
            Assert.AreEqual(reader.ReadUInt64(true), UInt64.MinValue);
            Assert.AreEqual(reader.ReadUInt64(true), UInt64.MaxValue);

            Assert.AreEqual(reader.ReadInt16(true), Int16.MinValue);
            Assert.AreEqual(reader.ReadInt16(true), Int16.MaxValue);
            Assert.AreEqual(reader.ReadInt32(true), Int32.MinValue);
            Assert.AreEqual(reader.ReadInt32(true), Int32.MaxValue);
            Assert.AreEqual(reader.ReadInt64(true), Int64.MinValue);
            Assert.AreEqual(reader.ReadInt64(true), Int64.MaxValue);

            Assert.AreEqual(reader.ReadSingle(true), Single.MinValue);
            Assert.AreEqual(reader.ReadSingle(true), Single.MaxValue);
            Assert.AreEqual(reader.ReadDouble(true), Double.MinValue);
            Assert.AreEqual(reader.ReadDouble(true), Double.MaxValue);
        }
    }
}

BinaryEndiannessExtensions
==========================

Extension methods for BinaryReader/BinaryWriter for switching byte endianness.


What is it?
-----------

Override methods for **BinaryWriter.Read** and **BinaryReader.ReadXXX** that receive an additional boolean parameter that switches the endianness of the data when writing/reading. 

The code doesn't have any dependencies and is currently distributed in binary form as a Portable Class Library compatible with .NET 4.5, Windows Phone 8+ and Windows 8+.


How to use
----------

Download the project and add it your solution or download one of the precompiled PCL libraries from the **Binaries** folder.

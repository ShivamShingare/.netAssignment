using System;
using System.IO;

class BinaryFileOperations
{
    private static string binaryFilePath = "binarydata.dat";

    public static void Run()
    {
        WriteBinaryFile();
        ReadBinaryFile();
    }

    private static void WriteBinaryFile()
    {
        using (FileStream fs = new FileStream(binaryFilePath, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(1234); // Writing an integer
            writer.Write(3.14); // Writing a double
            writer.Write("Hello Binary File"); // Writing a string
        }
        Console.WriteLine("Binary file written successfully.");
    }

    private static void ReadBinaryFile()
    {
        if (File.Exists(binaryFilePath))
        {
            using (FileStream fs = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fs))
            {
                int num = reader.ReadInt32();
                double pi = reader.ReadDouble();
                string text = reader.ReadString();

                Console.WriteLine("\nBinary File Content:");
                Console.WriteLine($"Integer: {num}");
                Console.WriteLine($"Double: {pi}");
                Console.WriteLine($"String: {text}");
            }
        }
        else
        {
            Console.WriteLine("Binary file does not exist.");
        }
    }
}

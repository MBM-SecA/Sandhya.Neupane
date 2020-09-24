// Q.2. Create a folder "ABC", create 10 subfolders in "ABC". Each
// subfolder contain a C# file with hello world program.


using System;
using System.Linq;
using System.IO;
public class FileAndDirectories
{
    public void AboutDirectories()
    {
        Directory.CreateDirectory(@".../ABC");
        string fileHelloWorld = File.ReadAllText("HelloWorld.cs");
        for (int i = 0; i < 10; i++)
        {
            Directory.CreateDirectory($"../ABC/{i + 1}Folder");
            File.WriteAllText($"../ABC/{i + 1}Folder/HelloWorld.cs", fileHelloWorld);
        }
    }
    static void Main (string[] args)
    {
        FileAndDirectories fileAndDirectories = new FileAndDirectories();
        fileAndDirectories.AboutDirectories();
    }
}
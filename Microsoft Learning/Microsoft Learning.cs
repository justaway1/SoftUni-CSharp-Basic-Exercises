using Humanizer;
using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Collections;



//Return Directory Folders in folder Lola
IEnumerable<string> listofDirectories = Directory.EnumerateDirectories("Lola", "*", SearchOption.AllDirectories);

foreach (var dir in listofDirectories)
{
    Console.WriteLine(dir);
}



//This return files within that folder Lola
//IEnumerable<string> files = Directory.EnumerateFiles("Lola", "*.txt", SearchOption.AllDirectories);


//foreach (var file in files)
//{
//    Console.WriteLine(file);
//}
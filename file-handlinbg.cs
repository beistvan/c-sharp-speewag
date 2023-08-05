using System;
using System.IO;

namespace File_Handling
{
	class Program
	{
		public static void Main(string[] args)
		{			
			FileStream fsw = new FileStream("test.txt", FileMode.Append, FileAccess.Write);  
			StreamWriter sw = new StreamWriter(fsw);  
			Console.Write("Enter the text to store in 'test.txt' file: ");  
			string inputString = Console.ReadLine();  
			sw.WriteLine(inputString);  
			sw.Flush();  
			sw.Close();  
			fsw.Close();			
			
            FileStream fsr = new FileStream("test.txt", FileMode.Open, FileAccess.Read);  
            StreamReader sr = new StreamReader(fsr);            
            sr.BaseStream.Seek(0, SeekOrigin.Begin);  
            string outputString = sr.ReadToEnd();
            Console.WriteLine("Content of 'test.txt' file:");   
            Console.WriteLine(outputString);            
            sr.Close();  
            fsr.Close();
            
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
		}
	}
}

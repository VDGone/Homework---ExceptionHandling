using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

namespace _03.ReadFileContents
{
    class ReadFileContents
    {
        static void Main(string[] args)
        {
            //Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
            //reads its contents and prints it on the console.
            //Find in MSDN how to use System.IO.File.ReadAllText(…).
            //Be sure to catch all possible exceptions and print user-friendly error messages.

            Console.WriteLine("Type full file path and name:");
            try
            {
                Console.WriteLine(File.ReadAllText(Console.ReadLine()));
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("The file reference path is missing!", ane.Message);
            }
            catch (ArgumentException ar)
            {
                Console.WriteLine("The file reference path is incorrect or contains one or more invalid characters!", ar.Message);
            }
            catch (PathTooLongException ptle)
            {
                Console.WriteLine("The file reference path or file name is to long!", ptle.Message);
            }
            catch (DirectoryNotFoundException dnfe)
            {
                Console.WriteLine("You do not have the required permission!", dnfe.Message);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine("The file specified in path was not found!", fnfe.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine("Path is in an invalid format!", nse.Message);
            }
        }
    }
}

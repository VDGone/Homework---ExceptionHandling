using System;
using System.Net;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            //Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
            //Find in Google how to download files in C#.
            //Be sure to catch all exceptions and to free any used resources in the finally block.
            try
            {
                WebClient webClient = new WebClient();
                webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "img01.png");
                Console.WriteLine("The image has been successfully downloaded.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter must not be null!");
            }
            catch (WebException)
            {
                Console.WriteLine("Error, file cannot be downloaded!");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method DownloadFile() cannot be called simultaneously on multiple threads.");
            }
        }
    }
}

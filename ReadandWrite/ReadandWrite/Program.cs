using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadandWrite
{
    class Program
    {


        static void Main(string[] args)
        {
            // Copied the Test folder to this directory for testing
           // string filepath ="C:\\Training\\Projects\\Selenium\\SeleniumFirst\\SeleniumFirst\\Test";
            string filepath = @"C:\OfficeClipnew\qa\Selenium\NUnit\Verification\SeleniumFirst\Test";
            DirSearch(filepath); //C:\temp\test\Selenium
        }


        
        private static void Transform(string inputFile, string outputFile)
        {
            string strFile = ReadTextFile(inputFile);

            StringReader sr = new StringReader(strFile);
            string  input;
            StringBuilder sb = new StringBuilder();

            //string originalPath = "\\server\\folderName1\\another\ name\\something\\another folder\\";
            string[] filesArray = inputFile.Split(Path.AltDirectorySeparatorChar,
                                          Path.DirectorySeparatorChar);

            //Console.WriteLine($".{filesArray[7]}.{filesArray[8]};" + "\n" + "//added from ReadAndWrite program  ");

           

            //foreach (var item in filesArray)
            //{
            //    Console.WriteLine(item.ToString());
            //    Console.ReadLine();
            //}


            int lineCounter = 0;

            while ((input = sr.ReadLine()) != null)
            {
                //if (input.Contains("using SeleniumFirst.Test;"))
                //{
                //    Console.WriteLine("program is ok ");
                //    return;
                //}

                if (input.Contains("namespace "))
                {
                    input = "//" + input + "\n" ;

                    if (filesArray.Contains("Admin"))
                    {
                       // OnlyAdmin(filesArray);
                        input += ( $"namespace {filesArray[6]}.{filesArray[7]}.{filesArray[8]}.{filesArray[9]}.Admin" +
                        "\n" + "//added from ReadAndWrite program for OnlyAdmin ");
                    }
                    else
                    {
                        //NonAdmin(filesArray);
                        input += ($"namespace {filesArray[6]}.{filesArray[7]}.{filesArray[8]}.{filesArray[9]}" +
                        "\n" + "//added from ReadAndWrite program for NonAdmin ");
                    }

                    // Debug.writeline()
                    //input += $".{filesArray[7]}.{filesArray[8]}" + "\n" + "//added from ReadAndWritex program  ";
                }

                //input += "using SeleniumFirst.Tests;"  ;

                //if (input.Contains("using NUnit.Framework;"))
                //{
                //    input += "\n" + "using SeleniumFirst.Tests;";
                //}
                //if (input.Contains("public class"))
                //{
                //    input += " : Base";
                //}
                //if (input.Contains("IWebDriver driver = new ChromeDriver();"))
                //{
                //    input = "//" + input;
                //}
                //if (input.Contains("private StringBuilder verificationErrors;"))
                //{
                //    input = "//" + input;
                //}

                //if (input.Contains("[SetUp]"))
                //{
                //    lineCounter += 1;
                //}
                //if ((lineCounter > 0) && (lineCounter <= 19))
                //{
                //    lineCounter += 1;
                //    input = "//" + input;
                //}
                sb.Append(input);
                sb.Append("\r\n");
            }

            WriteTextFile(outputFile, sb.ToString());
        }

        private static void NonAdmin(string[] filesArray)
        {
            Console.WriteLine("non admin");
            Console.WriteLine($"namespace {filesArray[6]}.{filesArray[7]}.{filesArray[8]}.{filesArray[9]}" + 
                "\n" + "//added from ReadAndWrite program  ");

            //input += ($"namespace {filesArray[6]}.{filesArray[7]}.{filesArray[8]}.{filesArray[9]}" + 
           //             "\n" + "//added from ReadAndWrite program  ");
        }

        private static void OnlyAdmin(string[] filesArray)
        {
            Console.WriteLine("Array has admin");
            Console.WriteLine($"namespace {filesArray[6]}.{filesArray[7]}.{filesArray[8]}.{filesArray[9]}.Admin" +
                "\n" + "//added from ReadAndWrite program  ");

           
        }

        /// <summary>
        /// From http://stackoverflow.com/a/929277
        /// </summary>
        /// <param name="sDir"></param>
        static void DirSearch(string sDir)
        {
            List<string> filePaths = new List<string>();
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                
                    foreach (string f in Directory.GetFiles(d))
                    {
                        Transform(f, f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        public static string ReadTextFile(string filePath)
        {
            string strText = string.Empty;
            if (File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(File.OpenRead(filePath));
                strText = sr.ReadToEnd();
                sr.Close();
            }
            return strText;
        }

        public static void WriteTextFile(string filePath, string dataStr)
        {
            StreamWriter sr = File.CreateText(filePath);
            sr.Write(dataStr);
            sr.Close();


        }

        //public static List<string> Split(this DirectoryInfo path)
        //{
        //    if (path == null) throw new ArgumentNullException("path");
        //    var ret = new List<string>();
        //    if (path.Parent != null) ret.AddRange(Split(path.Parent));
        //    ret.Add(path.Name);
        //    return ret;
        //}


    }
}

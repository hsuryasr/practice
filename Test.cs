

using System;
using System.Data.Common;
using System.Diagnostics;
using System.IO;


public class Test
{
    public static void Main()
    {
        try
        {
            try
            {
                Console.WriteLine("Enter First Number");
                int FN = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Second Number");
                int SN = Convert.ToInt32(Console.ReadLine());

                int Result = FN / SN;
                Console.WriteLine("Result = {0}", Result);
            }
            catch (Exception ex)
            {
                string filePath = @"C:\Program Files\log1.txt";
                if (File.Exists(filePath))
                {
                    StreamWriter sw = new StreamWriter(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("There is a Problem,please try later");
                }
                else
                {
                    throw new FileNotFoundException(filePath + " is not present", ex);
                }
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
            if (exception.InnerException != null)
            {
                Console.WriteLine("Inner Exception = {0}", exception.InnerException.GetType().Name);
            }
        }
    }
}




﻿using System;
using System.Collections.Generic;           
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Text_File
{
    internal class Program
   
    {
       
        
            static void Main(string[] args)
            {
                doApp();
            }
            public static void doApp()
            {
                string dir = Directory.GetCurrentDirectory();
                string filename = dir + "data.txt";

                if (File.Exists(filename))
                    Console.WriteLine(filename + " exists");
                else
                    Console.WriteLine(filename + " does not exist");

                using (StreamWriter wrt = File.CreateText(filename))
                {
                wrt.WriteLine("Student Name, Age, Class");
                wrt.WriteLine("Vinselcia,15,10th Class");
                    wrt.WriteLine("Sam,14,10th Class");
                    wrt.WriteLine("Abi,13,8th Class");
                    wrt.WriteLine("Ria,9,4th Class");
                }
               Console.WriteLine(filename + " created");

                string[] lines = File.ReadAllLines(filename);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

               // string text = File.ReadAllText(filename);
               // Console.WriteLine(text);

                File.Delete(filename);
                Console.WriteLine(filename + " was deleted");
            }
        }
    }



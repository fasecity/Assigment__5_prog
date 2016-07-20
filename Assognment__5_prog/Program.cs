﻿using System;
using System.IO;
namespace Assognment__5_prog
{   //Name:Mohamoud Mohamed
    //Student#:300435435
    //Assignment: 5
    //Version: 0.2 with notes
    
    /// <summary>
    /// This is the class program
    /// </summary>
    class Program
    {   /// <summary>
    /// this is the main method 
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            //defile variable
            string[] grades = new string[4];

            //read the text from the textfile and insert into grades array
            StreamReader SR =
                new StreamReader(
                    @"c:\users\admin\documents\visual studio 2015\Projects\Assognment__5_prog\Assognment__5_prog\Gradesof\gradesOfStudents.txt");

            for (int i = 0; i < 4; i++)
            {
                grades[i] = SR.ReadLine();
            }
            //close the textfile so other apps can use it
            SR.Close();

        
            
        
            // user Input 
            Console.WriteLine("Please press 1 to display and 2 to exit");
            
            string input = Console.ReadLine();

            try
            {

                switch (input)
                {

                       case "1":
                   
                    {
                        Console.WriteLine("what is the name of the file");
                            string fileInput = Console.ReadLine();
                            if (fileInput == "gradesOfStudents.txt")

                            {
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.WriteLine(grades[i]);
                                }
                                //pause the aplication

                                Console.ReadLine();
                               
                            }

                            
                    else
                        {
                            Console.WriteLine("incorrect file"); 
                        }
                           break;
                        }

                }
        
            }
            //catch error
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine($"1error {e.Message}");
            }


        }
    }
}

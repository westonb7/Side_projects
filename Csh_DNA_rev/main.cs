using System.IO;
using System;

/* 
This program creates a short DNA sequence, 
then runs a method which converts this to the reverse 
complement of that sequence, then prints the final 
sequence to the console.
*/

class Program
{
    static int Main()
    {
        
        // Creates a string of DNA for testing purposes
        string exampleDNA = "CCCCCACACGGTCGACACTTTTTAAATCCC";  
        string revCompDNA = null;
        
        // Test to make sure the DNA sequence is not empty
        
        if (exampleDNA.Length <= 0) 
        {
            Console.WriteLine("Invalid string");    // Gives error message if string is empty
            return(1);                              // exits the program if given an empty string
        };
        
        // Test to make sure DNA sequence only contains the characters "ACGT"
        
        for (int i = 0; i < exampleDNA.Length; i++)
        {
            if (exampleDNA[i] != 'A' && exampleDNA[i] != 'C' && exampleDNA[i] != 'G' && exampleDNA[i] != 'T')
            {
                Console.WriteLine("Invalid character in DNA sequence");
                return(1);
            }
        }
        
        for (int i = 0; i < exampleDNA.Length; i++)
        {
            if (exampleDNA[i] == 'A') { revCompDNA += "T"; }
            if (exampleDNA[i] == 'T') { revCompDNA += "A"; }
            if (exampleDNA[i] == 'C') { revCompDNA += "G"; }
            if (exampleDNA[i] == 'G') { revCompDNA += "C"; }

        }
        
        Console.WriteLine(exampleDNA.Length);
        Console.WriteLine(revCompDNA.Length);
        Console.WriteLine(exampleDNA);
        Console.WriteLine(revCompDNA);
        return(0);
    }
}

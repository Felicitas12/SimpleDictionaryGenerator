using System;
using System.IO;
using System.Text;

const string fileName = "obf.txt";
var rand = new Random();
var randomLetter = ((char)('a' + rand.Next(0, 26))).ToString();

try
{
    using (FileStream fs = File.Create(fileName))
    {

        using (StreamWriter stream = new StreamWriter(fs))
        {
           const int columnsQuantity = 300;


            for (int i = 0; i < columnsQuantity; i++)
            {
                for (int j = 0; j < rand.Next(250, 300); j++)
                {
                    stream.Write(randomLetter+randomLetter.ToUpper());
                }
                stream.WriteLine();

            }

        }



    }

    using (StreamReader sr = File.OpenText(fileName))
    {
        string s = "";
        while ((s = sr.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }
    }
}

catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
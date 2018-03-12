using System;
using System.IO;

namespace ArchivosBytes
{
    class CEscribirBytes
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];
            int nbytes = 0, car;

            try
            {
                //Crear un flujo hacia el fichero
                fs = new FileStream(@"C:\Archivostxt\file1.txt", FileMode.Create, FileAccess.Write);
                
                Console.WriteLine("Escriba el texto que desea almacenar en el fichero: ");

                while((car = Console.Read()) != '\r' && nbytes < buffer.Length)
                {
                    buffer[nbytes] = (byte)car;
                    nbytes++;
                }

                fs.Write(buffer, 0, nbytes);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);                         
            }
            finally
            {
                fs.Close();
            }
        }
    }
}

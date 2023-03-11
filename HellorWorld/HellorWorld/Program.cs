using System; //É tipo um #include de C
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellorWorld   //é como se fosse uma pasta com o projeto
{
    internal class Program
    {
        static void Main(string[] args) //Essa função main é igual a main em C
        {
            int numero = 10;
            string nome = "Dyego";
            char caracter = 'x';
            double tamanho = 1.5; //tendo o d ele também indentifica como o double
            float litros = 5.5f;
            decimal nasa = 5.9m;
            bool vivo = false;

            Console.WriteLine("Ola mundo"); //É o printf do C#
            
            Console.WriteLine(nome);        //Tipo String
            Console.WriteLine(numero);      //int
            Console.WriteLine(caracter);    //char
            Console.WriteLine(tamanho);     //double
            Console.WriteLine(litros);      //float
            Console.WriteLine(nasa);        //decimal
            Console.WriteLine(vivo);        //bool

            /*
                Diferença entre float, double e Decimal.
                Para ser um float é preciso ter um f no final, se não tiver é double e para ser um decimal tem que ter o m no final.
                O double armazena mais casas decimais do que o float e o decimal armazena mais do que eles 2

                Float: 32bits
                Double: 64bits
                Decimal: 128bits
            */

            
            tamanho = Convert.ToDouble(Console.ReadLine()); //É o scanf do C# só que ele SEMPRE retorna uma string então tem que converter antes de atribuir usando o Convert.<o tipo>

            /*
                Convert.ToBoolean() Para Boleano
                Convert.ToInt32()   Para INT
                Convert.ToSingle()  Para Float
                Convert.ToDouble()  Para Double
                Convert.ToDecimal() Para Decimal
                Convert.ToChat()    Para Char
                Convert.ToString()  Para String
            */


            Console.WriteLine(nome);

            Console.ReadLine();
        }
    }
}

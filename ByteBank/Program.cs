using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;
using ByteBank.Models;

namespace ByteBank
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria("jackson", "26139506840", "CC", 1234, "1234");
            ContaBancaria c2 = new ContaBancaria("luciana", "34258119830", "CP", 1234, "1234");

            c1.Depositar(550.00);
            c2.Depositar(100.00);
            c1.Transferir(100.00, c2);
            //c2.EstaAtiva = false;
            c1.StatusConta();
            Console.WriteLine("===========================");
            c2.StatusConta();


        } 
    }
}




    




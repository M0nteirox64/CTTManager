using System;
using System.Threading;


class Program {

    static void Main()
    {
        List<string> ctts = new List<string>();

        while (true) 
        {
            Console.WriteLine("Bem vindo!");
            Console.WriteLine("1) adicionar contacto");
            Console.WriteLine("2) remover contacto");
            Console.WriteLine("3) mostrar contactos");

            Console.Write("> ");
            string chc = Console.ReadLine();

            if (chc == "1") {
                Console.Write("nome do contacto: ");
                string ctn = Console.ReadLine();
                ctts.Add($"{ctn}");
                Console.WriteLine("[*] contacto adicionado com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
            }
        
            else if (chc == "2") {
                Console.Write("nome do contacto a remover: ");
                string rct = Console.ReadLine();
                ctts.Remove($"{rct}");
                Console.WriteLine("[*] contacto removido com sucesso!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else if (chc == "3") {
                if (ctts.Count <= 0) {
                    Console.WriteLine("[*] não tens contactos!");
                } else {
                    for (int i = 0; i < ctts.Count; i++) {
                    Console.WriteLine($"{i} - {ctts[i]}");
                }
                Thread.Sleep(2000);
                Console.Clear();
                }
            }
        }
    }   
}

using System;

namespace testeeturn {

    class Program {

        static void Main(string[] args) {

            ListarEventos evento = new ListarEventos();
            NovoRegistro novo = new NovoRegistro();

            try {
                novo.novoregistros();

                Console.WriteLine("Trilha 1.");
                evento.ListarEvento(novo.trilha1);
                Console.WriteLine("Trilha 2.");
                evento.ListarEvento(novo.trilha2);

            } catch {
                Console.WriteLine("Valores digitados incorretamente, programa encerrado.");
            }

        }

    }

}
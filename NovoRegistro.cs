using System;
using System.Collections.Generic;

namespace testeeturn {
    public class NovoRegistro {

        public List<Palestra> trilha1 = new List<Palestra>();
        public List<Palestra> trilha2 = new List<Palestra>();

        public void novoregistros() {

            string nomeEvento, trilhaEvento, novoEvento;
            int tempoEvento;
            AgendarPalestra palestra = new AgendarPalestra();

            Console.WriteLine("Digite o nome do evento: ");
            nomeEvento = Console.ReadLine();
            Console.WriteLine("Digite o tempo: ");
            tempoEvento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite 1 para a Trilha 1 e 2 para a Trilha 2: ");
            trilhaEvento = Console.ReadLine();

            if (trilhaEvento == "1") {
                palestra.AgendarPalestras(nomeEvento, tempoEvento, trilha1);
            } else if (trilhaEvento == "2") {
                palestra.AgendarPalestras(nomeEvento, tempoEvento, trilha2);
            } else {
                Console.WriteLine("Valor digitado incorreto. Digite 1 para a Trilha 1 e 2 para a Trilha 2: ");
                trilhaEvento = Console.ReadLine();
            }

             Console.WriteLine("Deseja adicionar um novo evento? caso sim clique na tecla S. caso não clique em qualquer outra tecla.");
            novoEvento = Console.ReadLine();

            if(novoEvento=="S" || novoEvento=="s"){
                 novoregistros();
            }

        }

    }

}
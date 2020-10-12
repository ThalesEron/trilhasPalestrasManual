using System;
using System.Collections.Generic;

namespace testeeturn {
    public class ListarEventos {
        public void ListarEvento(List<Palestra> palestras) {
           DateTime data1 = new DateTime();
            data1 = data1.AddHours(9);
            data1 = data1.AddMinutes(0);

            foreach (var palestra in palestras) {
                string horario = data1.GetDateTimeFormats('t')[0];
                if (data1.Hour == 12) {
                    Console.WriteLine("{0} Almoço", horario);
                    data1 = data1.AddMinutes(60);
                    horario = data1.GetDateTimeFormats('t')[0];
                }

                Console.WriteLine("{0} {1} {2}min", horario, palestra.Nome, palestra.Time);
                data1 = data1.AddMinutes(palestra.Time);

            }

            Console.WriteLine("17:00 Evento de Networking");

        }

    }

}
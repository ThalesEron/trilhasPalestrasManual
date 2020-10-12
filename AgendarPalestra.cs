using System.Collections.Generic;

namespace testeeturn {
    public class AgendarPalestra {
        public void AgendarPalestras(string nome, int time, List<Palestra> palestras) {

            palestras.Add(new Palestra {
                Nome = nome,
                    Time = time
            });

        }

    }

}
using System;
using System.Collections.Generic;
using System.Text;

namespace KosmosZadanie.Data
{
    public class Wszechswiat
    {
        public IList<Galaktyka> Galaktyki { get; }

        public Wszechswiat(List<Galaktyka> galaktyki) {
            Galaktyki = galaktyki;
        }
        public Wszechswiat() {

        }
    }
}

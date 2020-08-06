using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KosmosZadanie.Data
{
    class GwiazdaHandler
    {
        private Repository _repository { get; }

        public GwiazdaHandler(Repository repository)
        {
            _repository = repository;
        }
        public bool Save(Gwiazda gwiazda, string nazwa)
        {

            Wszechswiat wszechswiat = _repository.Wszechswiat;

            var tmp = wszechswiat.Galaktyki.Where(x => x.Nazwa == nazwa).ToList();
            var tmp2 = tmp.First().Gwiazdy.Where(y => y.Nazwa == gwiazda.Nazwa);
            if (tmp != null && !tmp2.Any()) {
                wszechswiat.Galaktyki.Where(x => x.Nazwa == nazwa).Single().Gwiazdy.Add(gwiazda);
                _repository.Save(wszechswiat);
                return true;
            }
            return false;
        }
    }
}

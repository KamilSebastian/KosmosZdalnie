using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KosmosZadanie.Data
{
    public class GalaktykaHandler
    {
        private Repository _repository { get; }

        public GalaktykaHandler(Repository repository) {
            _repository = repository;
        }
        public bool Save(Galaktyka galaktyka) {

            Wszechswiat wszechswiat = _repository.Wszechswiat;

            var tmp = wszechswiat.Galaktyki.Where(x => x.Nazwa == galaktyka.Nazwa);
            if (tmp != null && !tmp.Any())
            {
                wszechswiat.Galaktyki.Add(galaktyka);
                _repository.Save(wszechswiat);
                return true;
            }
            return false;
        }
    }

}

using Domen;
using System;
using System.Collections.Generic;

namespace Zajednicki
{
    [Serializable]
    public class Odgovor
    {
        public Signal Signal { get; set; }
        public List<Takmicar> Takmicari { get; set; }
    }

    public enum Signal
    {
        UspesnoZapamcenTakmicar,
        GreskaPriZahtevu,
        UspesnaPretragaTakmicara
    }
}

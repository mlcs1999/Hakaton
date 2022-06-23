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
        public KoordinatorLogistike Koordinator { get; set; }
        public List<Tim> Timovi { get; set; }
        public Takmicar Takmicar { get; set; }
        public Tim Tim { get; set; }
        public List<Mesto> Mesta { get; set; }
        public List<Takmicenje> Takmicenja { get; set; }
        public Takmicenje Takmicenje { get; set; }
    }

    public enum Signal
    {
        UspesnoZapamcenTakmicar,
        GreskaPriZahtevu,
        UspesnaPretragaTakmicara,
        UspesnoAzuriranTakmicar,
        UspesnoPrijavljenKoordinator,
        TimoviUspesnoVraceni,
        TakmicariUspesnoVraceni,
        TakmicarUspesnoObrisan,
        TakmicarUspesnoNadjen,
        UspesnoZapamcenTim,
        UspesnoAzuriranTim,
        UspesnaPretragaTimova,
        TimUspesnoNadjen,
        MestaUspesnoVracena,
        UspesnoZapamcenoTakmicenje,
        UspesnaPretragaTakmicenja,
        TakmicenjaUspesnoVracena,
        TakmicenjeUspesnoNadjeno,
        UspesnoZapamcenRezultat
    }
}

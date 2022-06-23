using Domen;
using System;
using System.Collections.Generic;

namespace Zajednicki
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public Takmicar Takmicar { get; set; }
        public KoordinatorLogistike Koordinator { get; set; }
        public Tim Tim { get; set; }
        public Takmicenje Takmicenje { get; set; }
        public List<Plasman> Plasmani { get; set; }
    }

    public enum Operacija
    {
        Login,
        ZapamtiTakmicara,
        TraziTakmicare,
        AzurirajTakmicara,
        UcitajTimove,
        UcitajTakmicare,
        ObrisiTakmicara,
        PrikaziTakmicara,
        ZapamtiTim,
        AzurirajTim,
        TraziTimove,
        PrikaziTim,
        UcitajMesta,
        ZapamtiTakmicenje,
        TraziTakmicenja,
        UcitajTakmicenja,
        PrikaziTakmicenje,
        ZapamtiRezultat
    }
}

using Domen;
using System;

namespace Zajednicki
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public Takmicar Takmicar { get; set; }
    }

    public enum Operacija
    {
        Login,
        ZapamtiTakmicara,
        TraziTakmicare
    }
}

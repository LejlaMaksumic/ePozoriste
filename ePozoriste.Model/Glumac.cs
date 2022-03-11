﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ePozoriste.Model
{
    public class Glumac
    {
        public int GlumacId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public long BrojUgovora { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
    }
}

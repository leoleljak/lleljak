using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Govedo
    {
        public string naziv { get; set; }
        public string boja { get; set; }
        public char spol { get; set; }

        public Govedo(string naziv, string boja,char spol) {
            this.naziv = naziv;
            this.boja = boja;
            this.spol = spol;
            }

    }
}

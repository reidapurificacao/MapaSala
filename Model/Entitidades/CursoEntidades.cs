using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entitidades
{
    public class CursoEntidades
    {
        public int id {get; set; }
        public string nome { get; set; }
        public string Turno { get; set; }
        public bool Ativo { get; set; }
    }
}

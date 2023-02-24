using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_DOTNET
{
    public class Evenement
    {
        public int id;
        public Owner owner;
        public string label;
        public string description;
        public DateTime dateDebut;
        public DateTime dateFin;
        public bool confirme;

        public Evenement(int id, Owner owner, string label, string description, DateTime dateDebut, DateTime dateFin, bool confirme)
        {
            this.id = id;
            this.owner = owner;
            this.label = label;
            this.description = description;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.confirme = confirme;
        }
    }
}

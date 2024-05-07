using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asimov
{
    public class Scolarite
    {
        public int id_scolarite {  get; set; }

        public string nom { get; set; }

        public string libelle_classe { get; set; }
        public int numero_semestre {  get; set; }
        public string moyenne_semestre { get; set; }
        public string annee_scolaire {  get; set; }
        public bool estvalide { get; set; }




        private List<Scolarite> listeNote = new List<Scolarite>();

        public List<Scolarite> Scolarites
        {
            get { return listeNote; }
        }

    }

}

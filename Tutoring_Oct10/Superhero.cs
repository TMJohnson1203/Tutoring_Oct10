using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutoring_Oct10
{
    class Superhero
    {
        // fields
        private string secretIdentity;
        private bool hasCape;
        private int strengthLevel;
        private string archnenesis;

        //panetOfOrigin under invisibility cloak

        // properties

        public string SecretIdentity
        {
            get { return this.secretIdentity; }
            set { this.secretIdentity = value; }
        }

        public bool HasCape { get; set; }
        public string PlanetOfOrigin { get; set; }
        public int StrengthLevel { get; set; }
        public string Archnemesis { get; set; }

        // constructors
        public Superhero()
        {

        }

        public Superhero(string secretIdentity, bool hasCape, int strengthLevel, string archnemesis)

    }
}

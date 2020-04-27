using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Apocalypse
{
    public class NPC
    {
        //  0human, 1zombie, 2 soldier
        public int type { get; set; }
        //lokacja
        public int x { get; set; }
        public int y { get; set; }
        //------------------------
        public int money { get; set; }
        //tylko zombie
        public int liczba_tur_do_konca { get; set; }
        public int str { get; set; }
        //tylko soldier
        public int health { get; set; }

        public string Litera()
        {
                if (type == 0) return "H";
                if (type == 1) return "Z"; 
                return "S";
        }
        
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_blueprint
{
    public class Entity
    {
        protected int X_poz {  get; set; }
        protected int Y_poz {  get; set; }
        protected int Speed {  get; set; }
        protected int Damage { get; set; }
        protected int Hp {  get; set; }
        protected int Defense { get; set; }
    }
}

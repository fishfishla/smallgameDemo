using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo1129
{
    class myRole:Role
    {
        public myRole(string name, string myrole,int hp):base(name,myrole, hp)
        {

        }
        
        public override void 受傷害(int hurt)
        {
            Random randomHurt = new Random();
            hurt = randomHurt.Next(1, 35);

            if (hurt > hp)
            {
                hp = 0;
            }
            else
            {
                hp -= hurt;
            }

        }

    }
}

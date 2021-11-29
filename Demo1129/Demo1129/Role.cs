using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1129
{
    class Role
    {
        protected string name;
        protected int hp;
        protected string myrole;
        public Role(string name,string myrole,int hp)
        {
            this.name = name;
            this.myrole = myrole;
            this.hp = hp;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public virtual int getHp()
        {
            return this.hp;
        }
  
        public string say()
        {
            return this.name+",剩"+this.hp+"滴血";
        }
        public virtual void 受傷害 (int hurt)
        {
            
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

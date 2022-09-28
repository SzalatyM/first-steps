using System;
using System.Collections.Generic;
using System.Text;

namespace FirstSteps.RPG
{
    public class Boss 
    {
        private string _name;
        public int hp;
        public int dmg;
        
        

               
        public Boss (string name, int HP, int DMG)
        {
            _name = name;
            hp = HP;
            dmg = DMG;
          
        }
        public override string ToString()
        {
            return "Name: "  + _name + " hp: " + hp + " dmg: " + dmg;
        }









    }
}

        
        

        
        





        


        

    
        

           
    
        
    


using System;
using System.Collections.Generic;
using System.Text;

namespace kamenapaperpapir
{
    class player1
    {
        public int money { get; set; }
        public int last { get; set; }

        public player1(int basem)
        {
            money = basem;
        }

        public void tah()
        {
            Random r = new Random();
            last = r.Next(0,3);
            
           
            
        }
    }
    public enum nazev 
    { 
        rock,
        paper,
        scisors
    }



    
}

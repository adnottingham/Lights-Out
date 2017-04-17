using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightsOut
{
    class Light
    {
        
        public bool on;
        public int row, column;
       

        public Light(int row, int column, bool on )
        {
            this.column = row;
            this.row = row;
            this.on = on;
        }

        public void reverseLight()
        {
            on = !on;
        }
        public void lightOff()
        {
            on = false;
        }

        public String onString()
        {
            if (on)
            {
                return "On";
            } else
            {
                return "off";
            }
        }
    }
}

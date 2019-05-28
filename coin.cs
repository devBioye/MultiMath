using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiMath
{
    class coin
    {
        public int coins;
        public void coinsValue()
        {
            int coin;
            if (Properties.Settings.Default.coin == "")
            {
               coins = 0;
            }
            else
            {
                string strcoin =  Properties.Settings.Default.coin;
               coin = Convert.ToInt32(strcoin);
                   
            }

        }
    }
}

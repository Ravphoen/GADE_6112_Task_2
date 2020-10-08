﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class GameEngine
    {
        private Map m = new Map(10, 20, 10, 20, 5, 3 );

        public Map M
        {
            get { return m; }
            set { m = value; }
        }
        public bool MovePlayer(movement direction)
        {
            if (m.PLAYER.ReturnMove(direction) == movement.NoMovement)
            {
                return false;
            }
            else
            {
                Item P_item = m.GetItemAtPosition(m.PLAYER.POSX, m.PLAYER.POSY);
                if (P_item != null)
                {
                    m.PLAYER.PickUp(P_item);
                }
                return true;
            }
        }
        public override string ToString()
        {
            string map = "";
            for (int i = 0; i < m.MapWidth; i++)
            {
                for (int j = 0; j < m.MapHeight; j++)
                {
                    map += m.map[i, j].SYMBOL + " ";
                }
                map += "\n";
            }
            //map += m.map[0, 0].SYMBOL;
            return map;
        }
        public void UpdateEnemies()
        {
            movement movetemp;

            foreach (Enemy e in m.enemies)
            {
                movetemp = e.ReturnMove();
                m.UpdateVision();
            }
            m.UpdateMap();
        }       
    }
}

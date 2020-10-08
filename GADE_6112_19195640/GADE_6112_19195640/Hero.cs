using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_19195640
{
    class Hero : Character
    {
        public Hero(int _posx, int _posy, int _hp, string _symbol = "H", int _damage = 2 ) : base(_posx, _posy, _symbol)
        {
            HP = _hp;
            DAMAGE = _damage;
            MAXHP = _hp;
        }
        public override movement ReturnMove(movement move)
        {
            if (move == movement.Left)
            {
                if (CHARACTERVISION[1] is EmptyTile)
                {
                    move = movement.Left;
                    POSY--;
                }
                else
                {
                    move = movement.NoMovement;
                }
            }
            else if (move == movement.Up)
            {
                if (CHARACTERVISION[0] is EmptyTile)
                {
                    move = movement.Up;
                    POSX--;
                }
                else
                {
                    move = movement.NoMovement;
                }
            }
            else if (move == movement.Right)
            {
                if (CHARACTERVISION[3] is EmptyTile)
                {
                    move = movement.Right;
                    POSY++;
                }
                else
                {
                    move = movement.NoMovement;
                }
            }
            else if (move == movement.Down)
            {
                if (CHARACTERVISION[2] is EmptyTile)
                {
                    move = movement.Down;
                    POSX++;
                }
                else
                {
                    move = movement.NoMovement;
                }
            }
            return move;
        }

        public override string ToString()
        {
            return "Player Stats:\n"
                + "HP:" + HP + "/" + MAXHP + "\nDamage:"
                + DAMAGE + "\n[" + POSX + "," + POSY + "]";
                
        }
    }
}

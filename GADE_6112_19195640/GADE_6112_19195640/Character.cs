﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_19195640
{
    public enum movement
    {
        NoMovement,
        Up,
        Down,
        Left,
        Right
    }

    abstract class Character : Tile
    {
        //variables
        protected int hp;
        protected int maxhp;
        protected int damage;
        protected Tile[] characterVision = new Tile[4];
        protected movement move;

        //properties (accessors)
        public int HP
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MAXHP
        {
            get { return maxhp; }
            set { maxhp = value; }
        }
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
        }
        public Tile[] CHARACTERVISION
        {
            get { return characterVision; }
            set { characterVision = value; }
        }
        public movement MOVE
        {
            get { return move; }
            set { move = value; }
        }

        public Character(int _posx, int _posy, string _symbol):base(_posx, _posy, _symbol)
        {
            
        }

        //methods
        public virtual void Attack(Character target)
        {

        }
        public bool IsDead()
        {
            if (hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public virtual bool CheckRange(Character target)
        {
            if (DistanceTo(target) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int DistanceTo(Character target)
        {
            int xdist;
            int ydist;
            int distance;

            xdist = Math.Abs((POSX - target.POSX) * (POSX - target.POSX));
            ydist = Math.Abs((POSY - target.POSY) * (POSY - target.POSY));

            distance = (int)Math.Round(Math.Sqrt(xdist + ydist),0);
            return distance;
        }
        public void Move(movement direction)
        {
            if (direction == movement.Down)
            {
                POSY++;
            }
            else if (direction == movement.Up)
            {
                POSY--;
            }
            else if (direction == movement.Left)
            {
                POSX--;
            }
            else if (direction == movement.Right)
            {
                POSX++;
            }
            else
            {
                //do nothing
            }
        }
        public abstract movement ReturnMove(movement move = 0);
        public abstract override string ToString();
        
    }
}
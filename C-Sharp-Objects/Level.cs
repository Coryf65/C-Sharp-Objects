using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    class Level
    {
        private readonly IInvader[] _invaders;

        public Tower[] Towers { get; set; }

        //when creating a level, pass in how many invaders will be in the array
        public Level(IInvader[] invaders)
        {
            _invaders = invaders;
        }

        // returns true if player has won, returns false if loses
        public bool Play()
        {
            // Run until all the invaders are nuetralized or an invader reaches the end of the path.
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                // Each tower has an opportunity to fire on invaders.
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                // Count and move the invaderds that are still active
                remainingInvaders = 0;

                foreach (IInvader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }
                }
            }
            return true;
        }
    }
}

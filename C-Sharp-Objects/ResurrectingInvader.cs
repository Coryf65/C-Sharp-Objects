using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Objects
{
    /// <summary>
    ///   The idea of Composition is to create a new type by combining one or
    ///   more other types together.
    ///   Behaves like an Invader but does not 
    ///   directly inherit from it's base class
    ///   one this is destroyed it ressurects into a stronger invader
    /// </summary>

    class ResurrectingInvader : IInvader // implement the Iinvader
    {

        private BasicInvader _incarnation1;
        private BasicInvader _incarnation2;

        // Properties, above constructor

        public MapLocation Location => _incarnation1.IsNeutralized ? _incarnation2.Location : _incarnation1.Location;

        public bool HasScored => _incarnation1.HasScored || _incarnation2.HasScored;
     
        public int Health => _incarnation1.IsNeutralized ? _incarnation2.Health : _incarnation1.Health;

        public bool IsNeutralized => _incarnation1.IsNeutralized && _incarnation2.IsNeutralized;

        public bool IsActive => !(IsNeutralized || HasScored);

        public ResurrectingInvader(Path path)
        {
            _incarnation1 = new BasicInvader(path);
            _incarnation2 = new BasicInvader(path);
            //_incarnation2 = new StrongInvader(path); Error converting
        }

        // Methods, below constructor

        public void Move()
        {
            _incarnation1.Move();
            _incarnation2.Move();
        }

        public void DecreaseHealth(int factor)
        {
            if (! _incarnation1.IsNeutralized)
            {
                _incarnation1.DecreaseHealth(factor);
            }
            else
            {
                _incarnation2.DecreaseHealth(factor);
            }
        }
               
    }
}

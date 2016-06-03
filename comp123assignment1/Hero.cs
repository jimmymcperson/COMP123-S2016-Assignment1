using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace comp123assignment1
    {

    /** <summary>
     * This class defines a generic hero.
     * </summary>
     * 
     * @class Hero
     */
    public class Hero
        {

        // PRIVATE INSTANCE VARIABLES =====================================================

        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        // PUBLIC PROPTERTIES =====================================================

        /** <summary>
         * This is the property that read/writes the _name field
         * </summary>
         *
         * @property {string} Name
         */
        public string Name
            {
            get
                {
                return this._name;
                }
            set
                {
                this._name = value;
                Console.WriteLine("Name set as: '{0}'" , this._name);
                }
            }

        // CONSTRUCTORS =====================================================

        /** <summary>
         * This is the default/empty constructor
         * </summary>
         *
         * @constructor Hero
         */
        public Hero()
            {
            _initializeAll();
            Console.WriteLine("A hero has been generated!");
            }

         // PRIVATE METHODS =====================================================

        /** <summary>
         * This method initializes all variables at a default value
         * </summary>
         *
         * @method initializeAll
         * @returns {void}
         */
        private void _initializeAll()
            {
//temp stats until I figure out how to randomize
             _strength = 1;
             _speed = 1;
             _health = 100;
             this.Name = "Hero";
            }

         // PUBLIC METHODS =====================================================

        /** <summary>
         * This method displays the hero's parameters
         * </summary>
         *
         * @method Show
         * @returns {void}
         */
        public void Show()
            {
// gotta make it pretty
            Console.WriteLine(this.Name);
            Console.WriteLine("STR " + _strength);
            Console.WriteLine("SPD " + _speed);
            Console.WriteLine("HP " + _health);
            }

        }
    }

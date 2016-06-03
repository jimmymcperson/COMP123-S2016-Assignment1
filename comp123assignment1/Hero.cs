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
         * This is the property that read/writes the _name field.
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
         * This is the default/empty constructor.
         * </summary>
         *
         * @constructor Hero
         */
        public Hero()
            {
            this._initializeAll();
            Console.WriteLine("A hero has been generated!");
            }

        /** <summary>
         * This constructor takes a string and sets it as the hero's name.
         * It also randomly sets the hero's stats using the generateAbilities method.
         * </summary>
         *
         * @constructor Hero
         * @param {string} name
         */
        public Hero(string name)
            {
            this.Name = name;
// insert generateAbilities method
            }

         // PRIVATE METHODS =====================================================

        /** <summary>
         * This method initializes all fields at a default value.
         * </summary>
         *
         * @method initializeAll
         * @returns {void}
         */
        private void _initializeAll()
            {
//temp stats until I figure out how to randomize
             this._strength = 1;
             this._speed = 1;
             this._health = 1;
             this.Name = "Hero";
            }

        /** <summary>
         * This method randomly sets the hero's stats
         * </summary>
         *
         * @method generateAbilities
         * @returns {void}
         */
        private void generateAbilities
            {
            this._strength = Random(1, 100);
            this._speed = Random(1, 100);
            this._health = Random(1, 100);
            }

         // PUBLIC METHODS =====================================================

        /** <summary>
         * This method displays the hero's parameters.
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

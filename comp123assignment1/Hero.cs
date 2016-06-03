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
        private int _statSeed;
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
            this._generateAbilities();
            }

        // PRIVATE METHODS =====================================================

        /** <summary>
         * This method returns a random number between the specified values (minimum inclusive, maximum exclusive) using a Random object.
         * </summary>
         *
         * @method randomNumber
         * @params {Random} number
         * @params {int} n1
         * @params {int} n2
         * @returns {int}
         */
        private int _randomNumber(Random number, int n1, int n2)
            {          
            this._statSeed = number.Next(n1, n2);
            return this._statSeed;
            }

        /** <summary>
         * This method initializes all fields at a default value.
         * </summary>
         *
         * @method initializeAll
         * @returns {void}
         */
        private void _initializeAll()
            {
             this._strength = 1;
             this._speed = 1;
             this._health = 1;
             this.Name = "Default Hero";
            }

        /** <summary>
         * This method randomly sets the hero's stats
         * </summary>
         *
         * @method generateAbilities
         * @returns {void}
         */
        private void _generateAbilities()
            {
            Random roll = new Random();
            this._strength = this._randomNumber(roll, 1, 101);
            this._speed = this._randomNumber(roll, 1, 101);
            this._health = this._randomNumber(roll, 1, 101);
            Console.WriteLine("A hero has been generated!");
            }

         // PUBLIC METHODS =====================================================

        /** <summary>
         * This method displays the hero's name and parameters.
         * </summary>
         *
         * @method Show
         * @returns {void}
         */
        public void Show()
            {
            Console.WriteLine("====================\n{0}\n====================", this._name);
            Console.WriteLine("Stats");
            Console.WriteLine("____________________");
            Console.WriteLine("HP  {0,3}", _health);
            Console.WriteLine("____________________");
            Console.WriteLine("STR {0,3}" , _strength);
            Console.WriteLine("____________________");
            Console.WriteLine("SPD {0,3}" , _speed);
            Console.WriteLine("____________________");
            }

        }
    }

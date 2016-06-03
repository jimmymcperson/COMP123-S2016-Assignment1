using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * ==================================================================================================
 * Author: Jonathan Hao
 * Date: June 3, 2016
 * Date Modified: June 3, 2016
 * Description: This is a demonstration of the basics of object-oriented programming.
 * Version: 0.0.6 - Added Fight, _hitAttempt, _hitDamage methods.
 * ==================================================================================================
 */
namespace comp123assignment1
    {

    /** <summary>
     * This is the "driver" class for our program.
     * </summary>
     * 
     * @class Program
     */
    public class Program
        {

        /** <summary>
         * This is the "main" method.
         * </summary>
         * 
         * @method Main
         * @param {string} args
         * @returns {void}
         */
        public static void Main(string[] args)
            {
            Hero heroOfJustice = new Hero();

            Console.WriteLine();

            heroOfJustice.Name = "Hero of Justice";

            Console.WriteLine();

            heroOfJustice.Show();

            Console.WriteLine();
            Console.WriteLine();

            Hero imhotep = new Hero("Imhotep");

            Console.WriteLine();

            imhotep.Show();
            
            Console.WriteLine();

            imhotep.Fight();

            Console.WriteLine();

            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    //GUILLAUME VERSCHAVE !
    public class CalculatorEngine
    {
        /// <summary>
        /// Fonction d'addition de deux valeurs.
        /// </summary>
        /// <param name="a">Valeur 1.</param>
        /// <param name="b">Valeur 2.</param>
        /// <returns>Le résultat de l'addition.</returns>
        public int Addition(int a, int b)
        {
            // Updated
            return a + b;

        }

        /// <summary>
        /// Fonction de soustraction de deux valeurs.
        /// </summary>
        /// <param name="a">Valeur 1.</param>
        /// <param name="b">Valeur 2.</param>
        /// <returns>Le résultat de la soustraction.</returns>
        public int Soustraction(int a, int b)
        {

            return a - b;
        }
        /// <summary>
        /// Fonction de multiplication de deux valeurs.
        /// </summary>
        /// <param name="a">Valeur 1.</param>
        /// <param name="b">Valeur 2.</param>
        /// <returns>Le résultat de la multiplication.</returns>
        public int Multiplication(int a, int b)
        {

            return a * b;
        }
        /// <summary>
        /// Fonction de division de deux valeurs.
        /// </summary>
        /// <param name="a">Valeur 1.</param>
        /// <param name="b">Valeur 2.</param>
        /// <returns>Le résultat de la division.</returns>
        public int Division(int a, int b)
        {
            int res;

            res = a / b;

            return res;

        }
    }
}

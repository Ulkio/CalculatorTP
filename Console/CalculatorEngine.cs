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
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de l'addition.</returns>
        public virtual int Addition(int val1, int val2)
        {
            // Updated
            return val1 + val2;

        }

        /// <summary>
        /// Fonction de soustraction de deux valeurs.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la soustraction.</returns>
        public virtual int Soustraction(int val1, int val2)
        {

            return val1 - val2;
        }
        /// <summary>
        /// Fonction de multiplication de deux valeurs.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la multiplication.</returns>
        public virtual int Multiplication(int val1, int val2)
        {

            return val1 * val2;
        }
        /// <summary>
        /// Fonction de division de deux valeurs.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la division.</returns>
        public virtual int Division(int val1, int val2)
        {
            int res;

            res = val1 / val2;

            return res;

        }
    }
}

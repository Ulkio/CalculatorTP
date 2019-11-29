using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class CalculatorEngine
    {
        /// <summary>
        /// Fonction d'addition de deux valeurs entières.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de l'addition.</returns>
        public virtual int Addition(int val1, int val2)
        {
            int result = val1 + val2;
            return result;
        }

        /// <summary>
        /// Fonction de soustraction de deux valeurs entières.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la soustraction.</returns>
        public virtual int Soustraction(int val1, int val2)
        {
            int result = val1 - val2;
            return result;
        }
        /// <summary>
        /// Fonction de multiplication de deux valeurs entières.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la multiplication.</returns>
        public virtual int Multiplication(int val1, int val2)
        {
            int result = val1 * val2;
            return result;
        }
        /// <summary>
        /// Fonction de division de deux valeurs entières.
        /// </summary>
        /// <param name="val1">Valeur 1.</param>
        /// <param name="val2">Valeur 2.</param>
        /// <returns>Le résultat de la division.</returns>
        public virtual double Division(int val1, int val2)
        {
            double result = val1 / val2;
            return result;
        }

        /// <summary>
        /// Fonction qui met la valeur au carré
        /// </summary>
        /// <param name="valeur">valeur à mettre au carré.</param>
        /// <returns>Le résultat de l'opération x².</returns>
        public virtual double PuissanceDeux(double valeur)
        {
            double resultat = Math.Pow(valeur, 2);
            return resultat;
        }

        /// <summary>
        /// Fonction qui donne la racine carré de la valeur.
        /// </summary>
        /// <param name="valeur">Valeur</param>
        /// <returns>Le résultat de l'opération sqrt(x).</returns>
        public virtual double RacineCarre(double valeur)
        {
            double resultat = Math.Sqrt(valeur);
            return resultat;
        }

        /// <summary>
        /// Fonction qui divise par 100 une valeur.
        /// </summary>
        /// <param name="valeur">valeur à diviser.</param>
        /// <returns>Le résultat de la division</returns>
        public virtual double Pourcentage(int valeur)
        {
            double resultat = valeur / 100;

            return resultat;
        }
    }
}

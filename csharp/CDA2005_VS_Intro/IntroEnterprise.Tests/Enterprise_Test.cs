using Microsoft.VisualStudio.TestTools.UnitTesting; // espace de noms des tests unitaires
using IntroEnterprise.Models; // espace de noms des annotations
using System.Collections.Generic; // espace de noms des collections (List, ArrayList...)

namespace IntroEnterprise.Tests
{
    /// <summary>
    /// TEST UNITAIRE
    /// Permet de tester le fonctionnement des m�thodes d'un objet.
    /// Afficher l'explorateur de tests = Menu --> Affichage --> Explorateur de tests
    /// La d�claration d'une classe de test est pr�c�d�e de l'annotation [TestClass]
    /// Toutes les classes annot�es [TestClass] seront r�f�renc�es dans l'explorateur de tests
    /// click droit sur le nom d'une classe pour �x�cuter tous les tests de la classe
    /// </summary>
    [TestClass]
    public class Enterprise_Test
    {
        /// <summary>
        /// On peut ajouter des attriobuts, propri�t�s comme dans toute classe.
        /// </summary>
        private Enterprise ets;

        /// <summary>
        /// La d�claration d'une m�thode de test est pr�c�d�e de l'annotation [TestMethod]
        /// Toutes les m�thodes annot�es [TestMethod] seront r�f�renc�es dans l'explorateur de tests
        /// click droit sur le nom d'une m�thode pour l'�x�cuter.
        /// </summary>
        [TestMethod]
        public void Test_Name()
        {
            ets = new Enterprise("CRM");

            // Assert permet de v�rifier le retour des m�thodes d'un objet
            // Explorez ses possibilit�s ;)

            Assert.IsNotNull(ets.Employees); // v�rifie que l'objet fourni en argument n'est pas null

            Assert.AreEqual(0, ets.Employees.Count); // Contr�le l'�galit� entre 2 valeurs

            ets.Employees.Add(new Employee("A", "B"));

            Assert.AreEqual(1, ets.Employees.Count);

            Person emp = ets.Employees[0];

            Assert.IsNotNull(emp);

            Employee realEmp = emp as Employee;

            Assert.IsNotNull(realEmp);

            // d'autres tests sont possibles, � vous de les d�couvrir :)
        }
    }
}

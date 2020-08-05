using Microsoft.VisualStudio.TestTools.UnitTesting; // espace de noms des tests unitaires
using IntroEnterprise.Models; // espace de noms des annotations
using System.Collections.Generic; // espace de noms des collections (List, ArrayList...)

namespace IntroEnterprise.Tests
{
    /// <summary>
    /// TEST UNITAIRE
    /// Permet de tester le fonctionnement des méthodes d'un objet.
    /// Afficher l'explorateur de tests = Menu --> Affichage --> Explorateur de tests
    /// La déclaration d'une classe de test est précédée de l'annotation [TestClass]
    /// Toutes les classes annotées [TestClass] seront référencées dans l'explorateur de tests
    /// click droit sur le nom d'une classe pour éxécuter tous les tests de la classe
    /// </summary>
    [TestClass]
    public class Enterprise_Test
    {
        /// <summary>
        /// On peut ajouter des attriobuts, propriétés comme dans toute classe.
        /// </summary>
        private Enterprise ets;

        /// <summary>
        /// La déclaration d'une méthode de test est précédée de l'annotation [TestMethod]
        /// Toutes les méthodes annotées [TestMethod] seront référencées dans l'explorateur de tests
        /// click droit sur le nom d'une méthode pour l'éxécuter.
        /// </summary>
        [TestMethod]
        public void Test_Name()
        {
            ets = new Enterprise("CRM");

            // Assert permet de vérifier le retour des méthodes d'un objet
            // Explorez ses possibilités ;)

            Assert.IsNotNull(ets.Employees); // vérifie que l'objet fourni en argument n'est pas null

            Assert.AreEqual(0, ets.Employees.Count); // Contrôle l'égalité entre 2 valeurs

            ets.Employees.Add(new Employee("A", "B"));

            Assert.AreEqual(1, ets.Employees.Count);

            Person emp = ets.Employees[0];

            Assert.IsNotNull(emp);

            Employee realEmp = emp as Employee;

            Assert.IsNotNull(realEmp);

            // d'autres tests sont possibles, à vous de les découvrir :)
        }
    }
}

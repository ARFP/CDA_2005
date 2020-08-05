using IntroEnterprise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace IntroEnterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Enterprise ets = new Enterprise("CRM");

            ets.PropertyChanged += MyEvent; // Abonnement de la méthode MyEvent à l'évènement PropertyChanged de lo'bjet ets (instance de la classe Enterprise)

            ets.PropertyChanged += MyEvent2; // Il est possible d'ajouter plusieurs abonnés à un même évènement

            Employee emp = new Employee("Doe", "John");

            ets.CreateEmployee(emp);

            List<Person> l = ets.Employees;

            int i;
            for(i = 0; i < ets.Employees.Count; i++)
            {

            }

            foreach(Employee item in ets.Employees) 
            {
                Console.WriteLine(item);
            }

            //ets.Employees = new List<Person>();


            // A chaque changement du nom de l'entreprise, l'évènement PropertyChanged est déclenché
            // Les méthodes MyEvent et MyEvent2 (toutes 2 abonnées) seront exécutées à chaque changement.
            ets.Name = "Joe"; 
            ets.Name = "Ho";
            ets.Name = "a";

            ets.PropertyChanged -= MyEvent2; // Désabonnement de la méthode MyEvent2 (elle ne sera plus exécutée au déclenchement de l'évènement)

            // La méthode MyEvent2 n'est plus abonnée
            // Désormais, uniquement la méthode MyEvent sera exécutée à chaque changement.
            ets.Name = "b";
            ets.Name = "s";
            ets.Name = "q";

            

        }

        /// <summary>
        /// Cette méthode sera abonnée à l'évènement PropertyChanged de la classe Enterprise
        /// A chaque déclenchement de l'évènement, cette méthode sera appelée et exécutée.
        /// Pour pouvoir s'abonner à un évènement, une méthode doit respecter la signature suivante :
        /// 
        ///  NomMethode ( sender : object , e : EventArgs ) : void
        ///  
        /// La méthode devra convertir le type object reçu vers le type d'origine
        /// Cela implique une dépendance entre la classe courante et la classe dont est issue l'instance reçue dans le 1er paramètre
        /// </summary>
        /// <param name="sender">Objet qui a déclenché l'évènement. Paramètre obligatoirement de type "object"</param>
        /// <param name="e">Une instance de "EventArgs" ou un de ses descendants</param>
        static void MyEvent(object sender, PropertyChangedEventArgs e)
        {
            Enterprise ets = sender as Enterprise;

            if (ets == null)
            {
                return;
            }

            // Database.save(new values);

            Console.WriteLine("Le nom de l'entreprise a changé : " + ets.Name);

        }

        /// <summary>
        /// Voir Méthode MyEvent ci-dessus
        /// </summary>
        /// <param name="sender">Paramètre obligatoirement de type "object"</param>
        /// <param name="e">Une instance de "EventArgs" ou un de ses descendants</param>
        static void MyEvent2(object sender, EventArgs e)
        {
            Enterprise ets = sender as Enterprise;

            if (ets == null)
            {
                return;
            }

            // Database.save(new values);

            Console.WriteLine("SUPER !");
        }
    }
}

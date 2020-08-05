using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace IntroEnterprise.Models
{
    public class Enterprise
    {
        private string name;

        private List<Person> employees;

        /// <summary>
        /// Création d'un évènement
        /// Cet évènement sera déclenché à chaque fois que la valeur de la propriété "Name" sera modifiée
        /// Cet attribut "PropertyChanged" permet à des objets de s'abonner à l'évènement
        /// Il sera utilisé au déclenchement de l'évènement
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        public List<Person> Employees 
        { 
            get => employees; 
            protected set => employees = value; 
        }

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                // Une fois la valeur de "name" modifiée, on déclenche l'évènement
                OnPropertyChanged("Name"); // Déclenchement de l'évènement pour PropertyChanged
            }
        }

        /// <summary>
        /// Cette méthode déclenche l'éveènement "PropertyChanged"
        /// Tous les objets abonnés à "PropertyChanged" sont notifiés
        /// </summary>
        /// <param name="propertyName">Le nom de la propriété dont la valeur à été modifiée</param>
        protected void OnPropertyChanged(string propertyName)
        {
            // On invoque tous les abonnés à l'évènement
            // 1er paramètre = l'objet modifié qui sera transmis aux abonnés (généralement l'instance courante, this)
            // 2nd paramètre = une instance de EventArgs (ou enfant) qui contiendra des informations sur l'évènement (info diverses selon le type d'évènement)
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public Enterprise(string _name)
        {
            
            name = _name;

            employees = new List<Person>();

        }

        public void CreateEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public int CalculerPrime(ISalary emp)
        {
            //Employee p = (Employee)emp;

            return 0;

        }
    }
}

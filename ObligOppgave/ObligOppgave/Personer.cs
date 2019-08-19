using System;

namespace ObligOppgave
{
    class Personer
    {
        public string firstName;
        public string lastName;
        public int yearBorn;
        public int deathYear;
        public int id;
        public Personer father;
        public Personer mother;

        public Personer(string _firstName, string _lastName, int _yearBorn, int _id, int _deathYear = default, Personer _father = null,
            Personer _mother = null)
        {
            firstName = _firstName;
            lastName = _lastName;
            yearBorn = _yearBorn;
            deathYear = _deathYear;
            id = _id;
            father = _father;
            mother = _mother;
        }



        public void Print()
        {
            Console.WriteLine("Navn: " + firstName);
            Console.WriteLine("Etternavn: " + lastName);
            Console.WriteLine("Fødselsår: " + yearBorn);
            Console.WriteLine("Id: " + id);
            Console.WriteLine();
            if (father != null)
            {
                Console.WriteLine("Far: " + father.firstName + " ID: " + father.id);
            }
            if (mother != null)
            {
                Console.WriteLine("Mor: " + mother.firstName + " ID: " + mother.id);
            }
            if (deathYear != default) Console.WriteLine("Dødsår: " + deathYear);
            Console.WriteLine();
        }
    }
}
//Lag klassen Person.En person skal ha fornavn, etternavn, fødselår og dødsår.
//Det siste skal selvsagt bare ha verdi hvis personen er død.Alle feltene er frivillige.
//For eksempel skal du kunne legge inn en person selv om du ikke vet fødselsår.
//Om man ikke har verdi for noen av feltene, skal man likevel ikke få lov å lage et Person-objekt.
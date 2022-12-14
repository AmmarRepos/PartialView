using PartialView.Models;

namespace PartialView.wwwroot.ViewModels
{
    public class PeopleViewModel
    {
        static public List<Person> people = new List<Person>();

        public List<Person> tempPeople = new List<Person>();

        public static void FetchPeople()
        {
	    people.Add(new Person(Guid.NewGuid().ToString(), "First1 Last1", "1111111111", "City1"));
	    people.Add(new Person(Guid.NewGuid().ToString(), "First2 Last2", "1111111111", "City2"));
	    people.Add(new Person(Guid.NewGuid().ToString(), "First3 Last3", "2222222222", "City3"));
	    people.Add(new Person(Guid.NewGuid().ToString(), "First4 Last4", "3333333333", "City4"));
	    people.Add(new Person(Guid.NewGuid().ToString(), "First5 Last5", "4444444444", "City5"));
	    people.Add(new Person(Guid.NewGuid().ToString(), "First6 Last6", "5555555555", "City6"));
        }

    }
}

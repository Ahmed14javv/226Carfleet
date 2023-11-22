

namespace Carfleet
{
    public class Person
    {
        private string name;
        private string firstname;
        private string phonenumber;
        private string emailAddress;
        private string language;

        public Person(string name, string firstname, string phonenumber, string emailAddress)
        {
            this.name = name;
            this.firstname = firstname;
            this.phonenumber = phonenumber;
            this.emailAddress = emailAddress;
        }

        public Person(string name, string firstname, string phonenumber, string emailAddress, string language="")
        {
            this.name = name;
            this.firstname = firstname;
            this.phonenumber = phonenumber;
            this.emailAddress = emailAddress;
            this.language = language;
        }
    }
}

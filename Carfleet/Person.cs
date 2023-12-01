
using System.Collections.Generic;

namespace Carfleet
{
    public class Person
    {

        #region private attributes
        private string _name;
        private string _firstname;
        private string _phonenumber;
        private string _emailaddress;
        private List<string> _languages;
        #endregion private attributes

        #region public methods
        public Person(string name, string firstname, string phonenumber, string emailaddress, List<string> languages = null)
        {
            _name = name;
            _firstname = firstname;
            _phonenumber = phonenumber;
            _emailaddress = emailaddress;
            _languages = languages;
        }

        public string Name
        {
            get
            {
                return _name;   
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
        }

        public string Phonenumber
        {
            get
            {
                return _phonenumber;
            }
        }

        public string Emailaddress
        {
            get
            {
                return _emailaddress;
            }
        }

        public List<string> Languages
        {
            get
            {
                return _languages;
            }
            set
            {

                foreach (string LanguageToAdd in value)
                {
                    if (!DoesExist(LanguageToAdd))
                    {
                        _languages.Add(LanguageToAdd);
                    }
                }
            }
        }
        #endregion public methods

        private bool DoesExist(string LanguageToVerify)
        {
            foreach (string existingLanguage in _languages)
            {
                if(existingLanguage == LanguageToVerify)
                {
                    return true;
                }
            }
            return false;
        }
    }
}


using System.Collections.Generic;
using System.Dynamic;

namespace Carfleet
{
    public class Driver : Person
    {
        #region private attributes
        private string _workZone;
        private Vehicle vehicule;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, string workZone, List<string> language) : base(name, firstname, phonenumber, emailaddress, language)
        {
            _workZone = workZone;
        }

        public string WorkZone
        {
            get
            {
                return _workZone;
            }
        }



        #endregion public methods
    }
}


using System.Collections.Generic;

namespace Carfleet
{
    public class Driver:Person
    {
        #region private attributes
        private string workZone;
        private Vehicle vehicule;
        #endregion private attributes

        #region public methods
        public Driver(string name, string firstname, string phonenumber, string emailaddress, List<string> language , string workZone = "") : base( name,  firstname,  phonenumber, emailaddress, language)
        {
            this.workZone = workZone;
        }

       
        #endregion public methods
    }
}

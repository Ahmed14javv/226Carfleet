
using System.Collections.Generic;
using System.Dynamic;
using System;

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

        public void TakeAVehicle (Vehicle vehicule)
        {
           
        }

        public Vehicle Vehicle
        {
            get
            {
                return vehicule;
            }
        }


        #endregion public methods
    }
}

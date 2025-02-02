using NUnit.Framework;

namespace Carfleet
{
    public class TestCar
    {
        #region private attributes
        string _registration = "VD 123 567";
        string _brand = "Mercedes-Benz";
        string _model = "Vito";
        string _chassisNumber = "SV30-0169266";
        Car _car;
        #endregion private attributes


        [SetUp]
        public void Setup()
        {
            _car = new Car(_registration, _brand, _model, _chassisNumber);
        }

        [Test]
        public void AllProperties_AfterInstantiation_GetCorrectValues()
        {
            //given

            //when

            //then
            Assert.AreEqual(_registration, _car.Registration);
            Assert.AreEqual(_brand, _car.Brand);
            Assert.AreEqual(_model, _car.Model);
            Assert.AreEqual(_chassisNumber, _car.ChassisNumber);
        }
    }
}
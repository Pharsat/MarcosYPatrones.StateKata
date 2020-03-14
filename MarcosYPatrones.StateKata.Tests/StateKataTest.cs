using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarcosYPatrones.StateKata.Tests
{
    [TestClass]
    public class StateKataTest
    {
        [TestMethod]
        public void TankState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            Assert.AreEqual(5, tank.Damage);
        }

        [TestMethod]
        public void SiegeState()
        {
            IUnit tank = new Tank();
            tank.State = new SiegeState();

            Assert.AreEqual(false, tank.CanMove);
            Assert.AreEqual(20, tank.Damage);
        }

        [TestMethod]
        public void MixState()
        {
            IUnit tank = new Tank();

            Assert.AreEqual(true, tank.CanMove);
            tank.State = new SiegeState();
            Assert.AreEqual(20, tank.Damage);
        }
    }
}

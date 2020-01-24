using Dnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndTests
{
    [TestClass]
    public class CharacterTest
    {
        private Character _character;

        [TestInitialize]
        public void Init()
        {
            _character = new Character();
        }

        [TestMethod]
        public void HasName()
        {
            _character.Name = "Jim";
            Assert.AreEqual("Jim", _character.Name);
        }

        [TestMethod]
        public void HasAlignment()
        {
            _character.Alignment = DndEnum.Alignment.Good;
            Assert.AreEqual(DndEnum.Alignment.Good, _character.Alignment);
        }

        [TestMethod]
        public void HasArmorClassThatDefaultsTo10()
        {
            Assert.AreEqual(10, _character.ArmorClass);
        }

        [TestMethod]
        public void HitPointsDefaultTo5()
        {
            Assert.AreEqual(5, _character.HitPoints);
        }

        [TestMethod]
        public void IsDeadWhenHitpointsAreZero()
        {
            _character.HitPoints = 0;
            Assert.IsTrue(_character.IsDead);
        }

        [TestMethod]
        public void AbilitiesDefaultTo10()
        {
            Assert.AreEqual(10, _character.Strength.Score);
            Assert.AreEqual(10, _character.Dexterity.Score);
            Assert.AreEqual(10, _character.Constitution.Score);
            Assert.AreEqual(10, _character.Wisdom.Score);
            Assert.AreEqual(10, _character.Intelligence.Score);
            Assert.AreEqual(10, _character.Charisma.Score);
        }

    }
}

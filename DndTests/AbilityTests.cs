using Dnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndTests
{
    [TestClass]
    public class AbilityTests
    {
        private Ability _ability;

        [TestInitialize]
        public void Init()
        {
            _ability = new Ability();
        }

        [TestMethod]
        public void DefaultAbilitiesTo10()
        {
            Assert.AreEqual(10, _ability.Score);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsExceptionIfValueIsSetLowerThan1()
        {
            _ability.Score = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsExceptionIfValueIsSetHigherThan20()
        {
            _ability.Score = 21;
        }

        [DataTestMethod]
        [DataRow(1, -5)]
        [DataRow(2, -4)]
        [DataRow(3, -4)]
        [DataRow(4, -3)]
        [DataRow(5, -3)]
        [DataRow(6, -2)]
        [DataRow(7, -2)]
        [DataRow(8, -1)]
        [DataRow(9, -1)]
        [DataRow(10, 0)]
        [DataRow(11, 0)]
        [DataRow(16, 3)]
        [DataRow(12, 1)]
        [DataRow(17, 3)]
        [DataRow(13, 1)]
        [DataRow(18, 4)]
        [DataRow(13, 1)]
        [DataRow(18, 4)]
        [DataRow(14, 2)]
        [DataRow(19, 4)]
        [DataRow(15, 2)]
        [DataRow(20, 5)]
        public void ScoreOneHasModifierofMinus5(int score, int modifier)
        {
            _ability.Score = score;
            Assert.AreEqual(modifier, _ability.Modifier);
        }
    }
}

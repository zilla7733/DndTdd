using Dnd;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndTests
{
    [TestClass]
    public class CombatTests
    {
        private Character _attacker;
        private Character _defender;
        private Combat _combat;

        [TestInitialize]
        public void Init()
        {
            _attacker = new Character();
            _defender = new Character();
            _combat = new Combat();
        }
        
        [TestMethod]
        public void ResolvesAttackDoesNotDamageWhenDieRollWithModifierIsZeroIsLowerThanArmorClass()
        {
 
            _combat.ResolveAttack(9, _attacker, _defender);
            Assert.AreEqual(5, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttackDoesDamageWhenDieRollWithModifierIsFiveIsGreaterThanArmorClass()
        {
            _attacker.Strength.Score = 19;
            _combat.ResolveAttack(9, _attacker, _defender);
            Assert.AreEqual(0, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttackDoesCausesDamageWhenDieRollIsGreaterThanArmorClass()
        {

            _combat.ResolveAttack(19, _attacker, _defender);
            Assert.AreEqual(4, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttackDoesCausesDamageWhenDieRollIsEqualToArmorClass()
        {

            _combat.ResolveAttack(10, _attacker, _defender);
            Assert.AreEqual(4, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttachCausesDoubleDamangeWhenDieRollis20()
        {
            _combat.ResolveAttack(20, _attacker, _defender);
            Assert.AreEqual(3, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttachCausesDoubleStrenghtModifierDoubleDamangeWhenDieRollis20()
        {
            _attacker.Strength.Score = 12;
            _combat.ResolveAttack(20, _attacker, _defender);
            Assert.AreEqual(1, _defender.HitPoints);
        }

        [TestMethod]
        public void ResolvesAttackHasMinimumDamageOfOne()
        {
            _attacker.Strength.Score = 1;
            _combat.ResolveAttack(19, _attacker, _defender);
            Assert.AreEqual(4, _defender.HitPoints);
        }

    }
}

namespace UnitTestLB_426
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void HelpVillager_IncreasesMagielevelAndGoldm�nzen()
        {
            var character = new Character(5, 35);
            int initialMagielevel = character.Magielevel;
            int initialGoldm�nzen = character.Goldm�nzen;
            character.HelpVillager();
            Assert.AreEqual(initialMagielevel + 10, character.Magielevel);
            Assert.AreEqual(initialGoldm�nzen + 5, character.Goldm�nzen);
        }

        [TestMethod]
        public void IgnoreVillager_DecreasesReputation()
        {
            var character = new Character(5, 35);
            int initialReputation = character.Reputation;
            character.IgnoreVillager();
            Assert.AreEqual(initialReputation - 10, character.Reputation);
        }

        [TestMethod]
        public void BuyArmor_DecreasesGoldm�nzenAndIncreasesR�stung()
        {
            var character = new Character(5, 50);
            int initialGoldm�nzen = character.Goldm�nzen;
            int initialR�stung = character.R�stung;
            character.BuyArmor();
            Assert.AreEqual(initialGoldm�nzen - 15, character.Goldm�nzen);
            Assert.AreEqual(initialR�stung + 20, character.R�stung);
        }
    }
}
namespace UnitTestLB_426
{
    [TestClass]
    public class CharacterTests
    {
        [TestMethod]
        public void HelpVillager_IncreasesMagielevelAndGoldmünzen()
        {
            var character = new Character(5, 35);
            int initialMagielevel = character.Magielevel;
            int initialGoldmünzen = character.Goldmünzen;
            character.HelpVillager();
            Assert.AreEqual(initialMagielevel + 10, character.Magielevel);
            Assert.AreEqual(initialGoldmünzen + 5, character.Goldmünzen);
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
        public void BuyArmor_DecreasesGoldmünzenAndIncreasesRüstung()
        {
            var character = new Character(5, 50);
            int initialGoldmünzen = character.Goldmünzen;
            int initialRüstung = character.Rüstung;
            character.BuyArmor();
            Assert.AreEqual(initialGoldmünzen - 15, character.Goldmünzen);
            Assert.AreEqual(initialRüstung + 20, character.Rüstung);
        }
    }
}
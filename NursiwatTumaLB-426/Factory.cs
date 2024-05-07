using System;

namespace consolegame
{
    // Abstract Character Factory
    public abstract class CharacterFactory
    {
        public abstract Character CreateCharacter();
    }

    // Concrete Character Factory
    public class BertolfFactory : CharacterFactory
    {
        public override Character CreateCharacter()
        {
            Character bertolf = new Character();
            bertolf.MagieLevel = 5;
            return bertolf;
        }
    }

}

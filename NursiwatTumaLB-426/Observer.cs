using System;
using System.Collections.Generic;

namespace NursiwatTumaLB-426;
{
    // Observer Interface
    public interface IObserver
    {
        void Update();
    }

    // Subject Interface
    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
    }

    // Character class
    public class Character : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        private int magieLevel;
        public int MagieLevel
        {
            get { return magieLevel; }
            set
            {
                magieLevel = value;
                Notify();
            }
        }

        // Add other properties similarly...

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }

    // Concrete Observer
    public class CharacterObserver : IObserver
    {
        private Character character;

        public CharacterObserver(Character character)
        {
            this.character = character;
        }

        public void Update()
        {
            // React to changes in character properties
            Console.WriteLine("Character state has changed!");
            // You can add specific actions here based on changes
        }
    }
}

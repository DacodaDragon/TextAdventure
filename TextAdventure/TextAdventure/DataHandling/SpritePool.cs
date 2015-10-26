using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class SpritePool
    {
        #region Singleton
        // Create SpritePool Singleton

        static readonly SpritePool instance = new SpritePool();

        static SpritePool() { }
        private SpritePool() { }

        public static SpritePool Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        public List<Sprite> pool = new List<Sprite>();

        public void AddToPool(Sprite _sprite)
        {
            pool.Add(_sprite);
        }

        public Sprite Find(string _spriteName)
        {
            foreach(Sprite element in pool)
            {
                if (element.name == _spriteName)
                {
                    return element;
                }
            }
            return null;
        }

        public void Remove(string _spriteName)
        {
            foreach (Sprite element in pool)
            {
                if (element.name == _spriteName)
                {
                    pool.Remove(element);
                    break;
                }
            }
        }
    }
}

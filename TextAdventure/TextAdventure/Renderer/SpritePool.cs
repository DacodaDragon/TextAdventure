using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


    }
}

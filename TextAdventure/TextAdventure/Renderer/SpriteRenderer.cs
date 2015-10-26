using System;
using System.Collections.Generic;

namespace TextAdventure
{
    class SpriteRenderer
    {

        // ===========================================
        // Will contain everything to render "Sprites"
        // ===========================================

        #region ForPossibleDebug
        //public int renderCount{ get { return spritesToRender.Count; } }
        #endregion

        private Queue<Sprite> spritesToRender = new Queue<Sprite>();

        public void AddSpriteList(Sprite sprite)
        {
            spritesToRender.Enqueue(sprite);
        }

        public void ClearSpriteList()
        {
            spritesToRender.Clear();
        }

        public void RenderToCanvas(bool clearList)
        {
            foreach (Sprite item in spritesToRender)
            {
                // Render sprites here
            }

            if (clearList)
            {
                ClearSpriteList();
            }
        }
    }
}

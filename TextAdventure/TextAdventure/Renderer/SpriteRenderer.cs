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
        //public int renderCount{ get { return PreviousTotalDrawCycles } }
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

        public void RenderToCanvas(Canvas targetCanvas, bool clearList = false)
        {
            foreach (Sprite item in spritesToRender)
            {
                int width = targetCanvas.frame.width;
                int height = targetCanvas.frame.height;

                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        // Render sprite to canvas.
                    }
                }
            }

            if (clearList)
            {
                ClearSpriteList();
            }
        }
    }
}

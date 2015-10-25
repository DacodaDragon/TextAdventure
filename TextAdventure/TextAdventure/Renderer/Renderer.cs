using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Renderer
    {
        private Canvas previousRender;
        private Canvas currentRender;

        #region Singleton
        // Create Renderer Singleton

        static readonly Renderer instance = new Renderer();

        static Renderer() { }
        private Renderer() { }

        public static Renderer Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        #region Drawing

        public void DrawSprite(Sprite sprite, int posX, int posY, ConsoleColor color = ConsoleColor.White)
        {
            // draw all the sprites
        }

        public void DrawCanvas(Canvas canvas)
        {
            // draw all the canvases
        }

        #endregion

        public void Render()
        {
            // render all the things
        }

        public void Clear()
        {
            Console.Clear();
        }
    }
}

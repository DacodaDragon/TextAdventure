using System;

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

        public void Clear()
        {
            Console.Clear();
        }
    }
}

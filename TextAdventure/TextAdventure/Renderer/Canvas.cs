namespace TextAdventure
{
    public struct CanvasFrame
    {
        public readonly int width, height;

        public CanvasFrame(int _width, int _height)
        {
            width = _width;
            height = _height;
        }
    }

    class Canvas
    {
        CanvasFrame frame;
        
        void Init()
        {
            frame = new CanvasFrame(1, 1);
        }
    }
}

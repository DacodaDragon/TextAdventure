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
        public readonly CanvasFrame frame;
        public Canvas(int _width, int _height)
        {
            frame = new CanvasFrame(10, 10);
        }
    }
}
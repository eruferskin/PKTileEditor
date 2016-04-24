using System;

namespace TileEditor
{
    [Serializable]
    public class World
    {
        public int Height { get; }

        public int Width { get; }

        public TileDefinition[,] _world;

        public World(int width, int height)
        {
            _world = new TileDefinition[width, height];
            Width = width;
            Height = height;
        }

        public void SetTile(int x, int y, TileDefinition brush)
        {
            _world[x, y] = brush;
        }

        public TileDefinition GetTile(int x, int y)
        {
            return _world[x, y];
        }
    }
}

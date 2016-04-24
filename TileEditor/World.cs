using System;

namespace TileEditor
{
    [Serializable]
    public class World
    {
        public int Height { get; }

        public int Width { get; }

        public IWorldDefinition[,] _world;

        public World(int width, int height)
        {
            _world = new IWorldDefinition[width, height];
            Width = width;
            Height = height;
        }

        //public void SetTile(int x, int y, TileDefinition brush)
        //{
        //    _world[x, y] = brush;
        //}

        //public TileDefinition GetTile(int x, int y)
        //{
        //    return _world[x, y];
        //}

        public void SetItem(int x, int y, IWorldDefinition definition )
        {
            _world[x, y] = definition;
        }


         
        // Maybe we need to split this for each type
        public IWorldDefinition GetItem(int x, int y)
        {
            return _world[x, y];
        }

     
    }
}

using System;

namespace TileEditor
{
    [Serializable]
    public class Actor
    {
        public string Name { get; set; }

        public int[,] StartPosition { get; set; }


        public Actor()
        {
            
        }
    }
}

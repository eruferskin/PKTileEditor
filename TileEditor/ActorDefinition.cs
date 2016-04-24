using System;

namespace TileEditor
{
    [Serializable]
    public struct ActorDefinition : IWorldDefinition
    {  
        public string Name { get; set; }
       

        public ActorDefinition(string name): this()
        {
            Name = name;
        }
    }
}

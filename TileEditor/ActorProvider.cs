using System.Collections.Generic;
using System.Linq;

namespace TileEditor
{
    public static class ActorProvider
    {
        private static IList<ActorDefinition> _actorDefinitions = new List<ActorDefinition>
        {
            new ActorDefinition("Mob1"),
            new ActorDefinition("Mob2")
        };

        public static ActorDefinition GetActor(string name)
        {
            return _actorDefinitions.FirstOrDefault(x => x.Name == name);
        }

        public static IEnumerable<ActorDefinition> GetAll()
            => _actorDefinitions;
    }
}

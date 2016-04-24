using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace TileEditor
{
    public static class TileProvider
    {
        private static IList<TileDefinition> _brushDefinitions = new List<TileDefinition>
        {
            TileDefinition.Default,

            new TileDefinition("Grass", collision: false) { EditorColor = Color.Green },
            new TileDefinition("CliffSide", collision: true) { EditorColor = Color.SlateGray }
        };

        public static TileDefinition GetBrush(string name)
        {
            return _brushDefinitions.FirstOrDefault(bd => bd.Name == name);
        }

        public static IEnumerable<TileDefinition> GetAll()
            => _brushDefinitions;
    }
}

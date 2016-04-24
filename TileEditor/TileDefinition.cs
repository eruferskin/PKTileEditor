﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileEditor
{
    [Serializable]
    public struct TileDefinition
    {
        public static TileDefinition Default { get; } = new TileDefinition("Default", false)
        {
            EditorColor = Color.Red
        };
        
        public string Name { get; set; }

        public bool Collision { get; set; }

        public Color EditorColor { get; set; }

        public TileDefinition(string name, bool collision = false): this()
        {
            Name = name;
            Collision = collision;
            EditorColor = Color.Red;
        }
    }
}

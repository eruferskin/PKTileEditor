using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace TileEditor
{
    public partial class Form1 : Form
    {
        private World _world;

        private TileDefinition _seletedTile;
        private ActorDefinition _selectedActor;
        private int _numberOfColumns;
        private int _numberOfRows;
        private const int _defaultRows = 10;
        private const int _defaultColumns = 10;

        public Form1()
        { 
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var brush in TileProvider.GetAll())
            {
                brushSelect.Items.Add(brush.Name);
            }

            foreach(var actor in ActorProvider.GetAll())
            {
                actorSelect.Items.Add(actor.Name);
            }

            _seletedTile = TileDefinition.Default;
            brushSelect.SelectedIndex = 0;
            actorSelect.SelectedIndex = 0;
            btnSave.Enabled = false;
        }

        private void initializeEditor()
        {
            CreateGrid(_numberOfRows, _numberOfColumns);

            _world = new World(_numberOfColumns, _numberOfRows);

            for (int x = 0; x < _world.Width; x++)
            {
                for (int y = 0; y < _world.Height; y++)
                {
                    _world.SetItem(x, y, TileDefinition.Default);
                }
            }
        }

        private void btnGenerateGrid_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtColumns.Text, out _numberOfColumns) && int.TryParse(txtRows.Text, out _numberOfRows))
            {
                initializeEditor();
            }
        }

        private void CreateGrid(int numberOfRows, int numberOfColumns)
        {
            tileContainer.Controls.Clear();
            btnGenerateGrid.Enabled = false;

            int tileWidth = 40;
            int tileHeight = 40;

            var totalWidth = tileWidth * numberOfColumns;
            var totalHeight = tileWidth * numberOfRows;

            tileContainer.Width = totalWidth;
            tileContainer.Height = totalHeight;
            
            var controlsToAdd = new List<Control>(numberOfColumns * numberOfRows);

            for (var row = 0; row < numberOfRows; row++)
            {
                int offsetTop = tileHeight * row;

                for (var column = 0; column < numberOfColumns; column++)
                {
                    int offsetLeft = tileWidth * column;

                    var tile = TileDefinition.Default;
                    

                    if (_world != null)
                    {
                        if (tabControl.SelectedTab.Name == "tabGrid")
                        {
                            tile = (TileDefinition)_world.GetItem(column, row);
                        }
                         else
                        {
                            tile = (TileDefinition)_world.GetItem(column, row);
                        }  
                    }

                    var panel = new Panel
                    {
                        Width = tileWidth,
                        Height = tileHeight,
                        BackColor = tile.EditorColor,
                        Left = offsetLeft,
                        Top = offsetLeft,
                        Anchor = AnchorStyles.Top | AnchorStyles.Left,
                        Padding = new Padding(0),
                        Margin = new Padding(0),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    panel.Click += tile_Click;

                    controlsToAdd.Add(panel);
                }
            }

            tileContainer.Controls.AddRange(controlsToAdd.ToArray());
            btnSave.Enabled = true;
        }

        private void tile_Click(object sender, EventArgs e)
        {
            
            var tile = (Panel)sender;

            var tileIndex = tile.Parent.Controls.IndexOf(tile);

            if (_world != null)
            {
                int x, y = 0;

                var tileWidth = tileContainer.Width;
                var rowNumber = 1;
                var columnNumber = 0;

                while(tileIndex >= _numberOfColumns)
                {
                    tileIndex -= _numberOfColumns;
                    rowNumber++;
                }

                columnNumber = tileIndex + 1;

                x = columnNumber - 1;
                y = rowNumber - 1;

                if (tabControl.SelectedTab.Name == "tabGrid")
                {
                    _world.SetItem(x, y, _seletedTile);
                    tile.BackColor = _seletedTile.EditorColor;
                }
                else if (tabControl.SelectedTab.Name == "tabActors")
                {
                    _world.SetItem(x, y, _selectedActor);
                    var label = new Label()
                    {
                        Text = _selectedActor.Name,
                        AutoSize = false,
                        Dock = DockStyle.Fill
                    };

                    label.Parent = tile;
                }
               
            }

           
        }

        private void SerializeItem(Stream stream)
        {
            var selector = new SurrogateSelector();
            var context = new StreamingContext(StreamingContextStates.All);
            var formatter = new BinaryFormatter(selector, context);

            formatter.Serialize(stream, _world);
        }

        private World DeserializeItem(Stream stream)
        {
            var selector = new SurrogateSelector();
            var context = new StreamingContext(StreamingContextStates.All);
            var formatter = new BinaryFormatter(selector, context);   

            return formatter.Deserialize(stream) as World;
        }

        private void brush_Click(object sender, EventArgs e)
        {
            var brushControl = (Control)sender;
            var brushName = (string)brushControl.Tag;
            
            _seletedTile = TileProvider.GetBrush(brushName);
        }

        private void brushSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBrushName = (string)brushSelect.SelectedItem;
            var selectedBrush = TileProvider.GetBrush(selectedBrushName);

            brushSelect.BackColor = selectedBrush.EditorColor;

            _seletedTile = selectedBrush;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Save where?";
            dialog.DefaultExt = ".pkmap";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                using (var stream = new FileStream(fileName, FileMode.Create))
                {
                    SerializeItem(stream);
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open what?";
            dialog.DefaultExt = ".pkmap";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    Text = "Loading...";

                    var world = DeserializeItem(stream);

                    _world = world;

                    CreateGrid(_world.Height, _world.Width);
     
                    _numberOfColumns = _world.Width > 0 ? _world.Width : _defaultColumns;
                    _numberOfRows = _world.Height > 0 ? _world.Height : _defaultRows;
                    Text = "TileEdit - " + fileName;
                }
            }
        }

        private void actorSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedActorName = (string)actorSelect.SelectedItem;
            var selectedActor = ActorProvider.GetActor(selectedActorName);

            _selectedActor = selectedActor;
        }

        private void btnSaveActors_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Title = "Save where?";
            dialog.DefaultExt = ".pkactors";

            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                using (var stream = new FileStream(fileName, FileMode.Create))
                {
                    SerializeItem(stream);
                }
            }
        }

        private void btnOpenActors_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.Title = "Open what?";
            dialog.DefaultExt = ".pkactors";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var fileName = dialog.FileName;

                using (var stream = new FileStream(fileName, FileMode.Open))
                {
                    Text = "Loading...";
                    // TODO
                }
            }
        }
    }
}

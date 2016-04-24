namespace TileEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnGenerateGrid = new System.Windows.Forms.Button();
            this.tileContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.brushSelect = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGrid = new System.Windows.Forms.TabPage();
            this.tabActors = new System.Windows.Forms.TabPage();
            this.actorSelect = new System.Windows.Forms.ListBox();
            this.btnSaveActors = new System.Windows.Forms.Button();
            this.btnOpenActors = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGrid.SuspendLayout();
            this.tabActors.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(33, 58);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(371, 62);
            this.txtColumns.TabIndex = 1;
            this.txtColumns.Text = "10";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(33, 171);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(371, 62);
            this.txtRows.TabIndex = 2;
            this.txtRows.Text = "10";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(35, 26);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(108, 29);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(35, 139);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(74, 29);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Rows";
            // 
            // btnGenerateGrid
            // 
            this.btnGenerateGrid.Location = new System.Drawing.Point(33, 251);
            this.btnGenerateGrid.Name = "btnGenerateGrid";
            this.btnGenerateGrid.Size = new System.Drawing.Size(371, 50);
            this.btnGenerateGrid.TabIndex = 5;
            this.btnGenerateGrid.Text = "Generate grid";
            this.btnGenerateGrid.UseVisualStyleBackColor = true;
            this.btnGenerateGrid.Click += new System.EventHandler(this.btnGenerateGrid_Click);
            // 
            // tileContainer
            // 
            this.tileContainer.Location = new System.Drawing.Point(518, 65);
            this.tileContainer.Name = "tileContainer";
            this.tileContainer.Size = new System.Drawing.Size(372, 243);
            this.tileContainer.TabIndex = 7;
            // 
            // brushSelect
            // 
            this.brushSelect.FormattingEnabled = true;
            this.brushSelect.ItemHeight = 20;
            this.brushSelect.Location = new System.Drawing.Point(33, 322);
            this.brushSelect.Name = "brushSelect";
            this.brushSelect.Size = new System.Drawing.Size(371, 464);
            this.brushSelect.TabIndex = 8;
            this.brushSelect.SelectedIndexChanged += new System.EventHandler(this.brushSelect_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(33, 802);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(371, 68);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save world";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(33, 889);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(371, 68);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open world";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tabControl
            // 
            this.tabControl.AccessibleName = "";
            this.tabControl.Controls.Add(this.tabGrid);
            this.tabControl.Controls.Add(this.tabActors);
            this.tabControl.Location = new System.Drawing.Point(23, 36);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(446, 1007);
            this.tabControl.TabIndex = 11;
            // 
            // tabGrid
            // 
            this.tabGrid.Controls.Add(this.lblColumns);
            this.tabGrid.Controls.Add(this.btnOpen);
            this.tabGrid.Controls.Add(this.btnSave);
            this.tabGrid.Controls.Add(this.txtColumns);
            this.tabGrid.Controls.Add(this.txtRows);
            this.tabGrid.Controls.Add(this.brushSelect);
            this.tabGrid.Controls.Add(this.lblRows);
            this.tabGrid.Controls.Add(this.btnGenerateGrid);
            this.tabGrid.Location = new System.Drawing.Point(4, 29);
            this.tabGrid.Name = "tabGrid";
            this.tabGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabGrid.Size = new System.Drawing.Size(438, 974);
            this.tabGrid.TabIndex = 0;
            this.tabGrid.Text = "Grid";
            this.tabGrid.UseVisualStyleBackColor = true;
            // 
            // tabActors
            // 
            this.tabActors.Controls.Add(this.btnOpenActors);
            this.tabActors.Controls.Add(this.actorSelect);
            this.tabActors.Controls.Add(this.btnSaveActors);
            this.tabActors.Location = new System.Drawing.Point(4, 29);
            this.tabActors.Name = "tabActors";
            this.tabActors.Padding = new System.Windows.Forms.Padding(3);
            this.tabActors.Size = new System.Drawing.Size(438, 974);
            this.tabActors.TabIndex = 1;
            this.tabActors.Text = "Actors";
            this.tabActors.UseVisualStyleBackColor = true;
            // 
            // actorSelect
            // 
            this.actorSelect.FormattingEnabled = true;
            this.actorSelect.ItemHeight = 20;
            this.actorSelect.Location = new System.Drawing.Point(33, 27);
            this.actorSelect.Name = "actorSelect";
            this.actorSelect.Size = new System.Drawing.Size(371, 724);
            this.actorSelect.TabIndex = 12;
            this.actorSelect.SelectedIndexChanged += new System.EventHandler(this.actorSelect_SelectedIndexChanged);
            // 
            // btnSaveActors
            // 
            this.btnSaveActors.Location = new System.Drawing.Point(33, 783);
            this.btnSaveActors.Name = "btnSaveActors";
            this.btnSaveActors.Size = new System.Drawing.Size(371, 68);
            this.btnSaveActors.TabIndex = 12;
            this.btnSaveActors.Text = "Save actors";
            this.btnSaveActors.UseVisualStyleBackColor = true;
            this.btnSaveActors.Click += new System.EventHandler(this.btnSaveActors_Click);
            // 
            // btnOpenActors
            // 
            this.btnOpenActors.Location = new System.Drawing.Point(33, 879);
            this.btnOpenActors.Name = "btnOpenActors";
            this.btnOpenActors.Size = new System.Drawing.Size(371, 68);
            this.btnOpenActors.TabIndex = 13;
            this.btnOpenActors.Text = "Open actors";
            this.btnOpenActors.UseVisualStyleBackColor = true;
            this.btnOpenActors.Click += new System.EventHandler(this.btnOpenActors_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1792, 1076);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.tileContainer);
            this.Name = "Form1";
            this.Text = "TileEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGrid.ResumeLayout(false);
            this.tabGrid.PerformLayout();
            this.tabActors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Button btnGenerateGrid;
        private System.Windows.Forms.FlowLayoutPanel tileContainer;
        private System.Windows.Forms.ListBox brushSelect;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGrid;
        private System.Windows.Forms.TabPage tabActors;
        private System.Windows.Forms.ListBox actorSelect;
        private System.Windows.Forms.Button btnOpenActors;
        private System.Windows.Forms.Button btnSaveActors;
    }
}


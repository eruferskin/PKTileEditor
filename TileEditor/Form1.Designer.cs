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
            this.SuspendLayout();
            // 
            // txtColumns
            // 
            this.txtColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumns.Location = new System.Drawing.Point(29, 82);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.Size = new System.Drawing.Size(252, 62);
            this.txtColumns.TabIndex = 1;
            this.txtColumns.Text = "10";
            // 
            // txtRows
            // 
            this.txtRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRows.Location = new System.Drawing.Point(29, 195);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(252, 62);
            this.txtRows.TabIndex = 2;
            this.txtRows.Text = "10";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumns.Location = new System.Drawing.Point(24, 50);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(108, 29);
            this.lblColumns.TabIndex = 3;
            this.lblColumns.Text = "Columns";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRows.Location = new System.Drawing.Point(24, 163);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(74, 29);
            this.lblRows.TabIndex = 4;
            this.lblRows.Text = "Rows";
            // 
            // btnGenerateGrid
            // 
            this.btnGenerateGrid.Location = new System.Drawing.Point(29, 275);
            this.btnGenerateGrid.Name = "btnGenerateGrid";
            this.btnGenerateGrid.Size = new System.Drawing.Size(252, 50);
            this.btnGenerateGrid.TabIndex = 5;
            this.btnGenerateGrid.Text = "Generate grid";
            this.btnGenerateGrid.UseVisualStyleBackColor = true;
            this.btnGenerateGrid.Click += new System.EventHandler(this.btnGenerateGrid_Click);
            // 
            // tileContainer
            // 
            this.tileContainer.Location = new System.Drawing.Point(287, 82);
            this.tileContainer.Name = "tileContainer";
            this.tileContainer.Size = new System.Drawing.Size(372, 243);
            this.tileContainer.TabIndex = 7;
            // 
            // brushSelect
            // 
            this.brushSelect.FormattingEnabled = true;
            this.brushSelect.ItemHeight = 20;
            this.brushSelect.Location = new System.Drawing.Point(29, 343);
            this.brushSelect.Name = "brushSelect";
            this.brushSelect.Size = new System.Drawing.Size(252, 444);
            this.brushSelect.TabIndex = 8;
            this.brushSelect.SelectedIndexChanged += new System.EventHandler(this.brushSelect_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(29, 802);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(252, 68);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save world";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(29, 876);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(252, 68);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open world";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1792, 1076);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.brushSelect);
            this.Controls.Add(this.tileContainer);
            this.Controls.Add(this.btnGenerateGrid);
            this.Controls.Add(this.lblRows);
            this.Controls.Add(this.lblColumns);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.txtColumns);
            this.Name = "Form1";
            this.Text = "TileEdit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}


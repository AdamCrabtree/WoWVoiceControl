namespace WoWVoiceControl
{
    partial class WarlockBaseForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.bAffliction = new System.Windows.Forms.Button();
            this.bDestruction = new System.Windows.Forms.Button();
            this.bDemonology = new System.Windows.Forms.Button();
            this.bStart = new System.Windows.Forms.Button();
            this.abilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.abilityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keybindColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check Submenus for specifc hotkeys";
            // 
            // bAffliction
            // 
            this.bAffliction.Location = new System.Drawing.Point(13, 43);
            this.bAffliction.Name = "bAffliction";
            this.bAffliction.Size = new System.Drawing.Size(75, 23);
            this.bAffliction.TabIndex = 7;
            this.bAffliction.Text = "Affliction";
            this.bAffliction.UseVisualStyleBackColor = true;
            this.bAffliction.Click += new System.EventHandler(this.bAffliction_Click);
            // 
            // bDestruction
            // 
            this.bDestruction.Location = new System.Drawing.Point(247, 43);
            this.bDestruction.Name = "bDestruction";
            this.bDestruction.Size = new System.Drawing.Size(75, 23);
            this.bDestruction.TabIndex = 8;
            this.bDestruction.Text = "Destruction";
            this.bDestruction.UseVisualStyleBackColor = true;
            this.bDestruction.Click += new System.EventHandler(this.bDestruction_Click);
            // 
            // bDemonology
            // 
            this.bDemonology.Location = new System.Drawing.Point(128, 43);
            this.bDemonology.Name = "bDemonology";
            this.bDemonology.Size = new System.Drawing.Size(75, 23);
            this.bDemonology.TabIndex = 9;
            this.bDemonology.Text = "Demonology";
            this.bDemonology.UseVisualStyleBackColor = true;
            this.bDemonology.Click += new System.EventHandler(this.bDemonology_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(128, 526);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 10;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // abilitiesDataGridView
            // 
            this.abilitiesDataGridView.AllowUserToAddRows = false;
            this.abilitiesDataGridView.AllowUserToDeleteRows = false;
            this.abilitiesDataGridView.AllowUserToResizeColumns = false;
            this.abilitiesDataGridView.AllowUserToResizeRows = false;
            this.abilitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.abilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.abilityNameColumn,
            this.keybindColumn});
            this.abilitiesDataGridView.Location = new System.Drawing.Point(13, 72);
            this.abilitiesDataGridView.Name = "abilitiesDataGridView";
            this.abilitiesDataGridView.RowHeadersVisible = false;
            this.abilitiesDataGridView.Size = new System.Drawing.Size(309, 448);
            this.abilitiesDataGridView.TabIndex = 48;
            // 
            // abilityNameColumn
            // 
            this.abilityNameColumn.HeaderText = "Ability";
            this.abilityNameColumn.Name = "abilityNameColumn";
            this.abilityNameColumn.ReadOnly = true;
            // 
            // keybindColumn
            // 
            this.keybindColumn.HeaderText = "Keybind";
            this.keybindColumn.Name = "keybindColumn";
            this.keybindColumn.ReadOnly = true;
            // 
            // WarlockBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 561);
            this.Controls.Add(this.abilitiesDataGridView);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bDemonology);
            this.Controls.Add(this.bDestruction);
            this.Controls.Add(this.bAffliction);
            this.Controls.Add(this.label2);
            this.Name = "WarlockBaseForm";
            this.Text = "Warlock";
            this.Load += new System.EventHandler(this.WarlockBaseForm_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WarlockBaseForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.abilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAffliction;
        private System.Windows.Forms.Button bDestruction;
        private System.Windows.Forms.Button bDemonology;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.DataGridView abilitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn abilityNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keybindColumn;
    }
}
namespace WoWVoiceControl
{
    partial class DemonHunterBaseForm
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
            this.bVengeance = new System.Windows.Forms.Button();
            this.bHavoc = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(63, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check Submenus for specifc hotkeys";
            // 
            // bVengeance
            // 
            this.bVengeance.Location = new System.Drawing.Point(12, 65);
            this.bVengeance.Name = "bVengeance";
            this.bVengeance.Size = new System.Drawing.Size(137, 23);
            this.bVengeance.TabIndex = 7;
            this.bVengeance.Text = "Vengeance";
            this.bVengeance.UseVisualStyleBackColor = true;
            this.bVengeance.Click += new System.EventHandler(this.bVengeance_Click);
            // 
            // bHavoc
            // 
            this.bHavoc.Location = new System.Drawing.Point(238, 65);
            this.bHavoc.Name = "bHavoc";
            this.bHavoc.Size = new System.Drawing.Size(137, 23);
            this.bHavoc.TabIndex = 8;
            this.bHavoc.Text = "Havoc";
            this.bHavoc.UseVisualStyleBackColor = true;
            this.bHavoc.Click += new System.EventHandler(this.bHavoc_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(123, 446);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(137, 23);
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
            this.abilitiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.abilitiesDataGridView.Location = new System.Drawing.Point(12, 104);
            this.abilitiesDataGridView.Name = "abilitiesDataGridView";
            this.abilitiesDataGridView.RowHeadersVisible = false;
            this.abilitiesDataGridView.Size = new System.Drawing.Size(363, 327);
            this.abilitiesDataGridView.TabIndex = 17;
            // 
            // abilityNameColumn
            // 
            this.abilityNameColumn.HeaderText = "Ability Name";
            this.abilityNameColumn.Name = "abilityNameColumn";
            this.abilityNameColumn.ReadOnly = true;
            // 
            // keybindColumn
            // 
            this.keybindColumn.HeaderText = "Keybind";
            this.keybindColumn.Name = "keybindColumn";
            this.keybindColumn.ReadOnly = true;
            // 
            // DemonHunterBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 496);
            this.Controls.Add(this.abilitiesDataGridView);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bHavoc);
            this.Controls.Add(this.bVengeance);
            this.Controls.Add(this.label2);
            this.Name = "DemonHunterBaseForm";
            this.Text = "DemonHunterBaseForm";
            this.Load += new System.EventHandler(this.DHBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVengeance;
        private System.Windows.Forms.Button bHavoc;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.DataGridView abilitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn abilityNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keybindColumn;
    }
}
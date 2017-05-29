namespace WoWVoiceControl.ClassForms.Warlock.Specs
{
    partial class AfflictionHotkeysForm
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
            this.bAccept = new System.Windows.Forms.Button();
            this.abilitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.abilityNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keybindColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abilitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(113, 284);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(109, 23);
            this.bAccept.TabIndex = 11;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
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
            this.abilitiesDataGridView.Location = new System.Drawing.Point(12, 12);
            this.abilitiesDataGridView.Name = "abilitiesDataGridView";
            this.abilitiesDataGridView.RowHeadersVisible = false;
            this.abilitiesDataGridView.Size = new System.Drawing.Size(309, 266);
            this.abilitiesDataGridView.TabIndex = 49;
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
            // AfflictionHotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 319);
            this.Controls.Add(this.abilitiesDataGridView);
            this.Controls.Add(this.bAccept);
            this.Name = "AfflictionHotkeysForm";
            this.Text = "Affliction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AfflictionHotkeysForm_FormClosed);
            this.Load += new System.EventHandler(this.AfflictionHotkeysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAccept;
        private System.Windows.Forms.DataGridView abilitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn abilityNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keybindColumn;
    }
}
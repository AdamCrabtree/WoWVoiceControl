namespace WoWVoiceControl
{
    partial class DHBaseForm
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
            this.bConsume_Magic = new System.Windows.Forms.Button();
            this.bGlide = new System.Windows.Forms.Button();
            this.bImprison = new System.Windows.Forms.Button();
            this.bMetamorphosis = new System.Windows.Forms.Button();
            this.bSpectral_Sight = new System.Windows.Forms.Button();
            this.bThrow_Glaive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Check Submenus for specifc hotkeys";
            // 
            // bVengeance
            // 
            this.bVengeance.Location = new System.Drawing.Point(64, 103);
            this.bVengeance.Name = "bVengeance";
            this.bVengeance.Size = new System.Drawing.Size(137, 23);
            this.bVengeance.TabIndex = 7;
            this.bVengeance.Text = "Vengeance";
            this.bVengeance.UseVisualStyleBackColor = true;
            this.bVengeance.Click += new System.EventHandler(this.bVengeance_Click);
            // 
            // bHavoc
            // 
            this.bHavoc.Location = new System.Drawing.Point(64, 132);
            this.bHavoc.Name = "bHavoc";
            this.bHavoc.Size = new System.Drawing.Size(137, 23);
            this.bHavoc.TabIndex = 8;
            this.bHavoc.Text = "Havoc";
            this.bHavoc.UseVisualStyleBackColor = true;
            this.bHavoc.Click += new System.EventHandler(this.bHavoc_Click);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(74, 437);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(137, 23);
            this.bStart.TabIndex = 10;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bConsume_Magic
            // 
            this.bConsume_Magic.Location = new System.Drawing.Point(1, 300);
            this.bConsume_Magic.Name = "bConsume_Magic";
            this.bConsume_Magic.Size = new System.Drawing.Size(137, 23);
            this.bConsume_Magic.TabIndex = 13;
            this.bConsume_Magic.Text = "Consume Magic";
            this.bConsume_Magic.UseVisualStyleBackColor = true;
            // 
            // bGlide
            // 
            this.bGlide.Location = new System.Drawing.Point(1, 271);
            this.bGlide.Name = "bGlide";
            this.bGlide.Size = new System.Drawing.Size(137, 23);
            this.bGlide.TabIndex = 12;
            this.bGlide.Text = "Glide";
            this.bGlide.UseVisualStyleBackColor = true;
            // 
            // bImprison
            // 
            this.bImprison.Location = new System.Drawing.Point(1, 242);
            this.bImprison.Name = "bImprison";
            this.bImprison.Size = new System.Drawing.Size(137, 23);
            this.bImprison.TabIndex = 11;
            this.bImprison.Text = "Imprison";
            this.bImprison.UseVisualStyleBackColor = true;
            // 
            // bMetamorphosis
            // 
            this.bMetamorphosis.Location = new System.Drawing.Point(144, 300);
            this.bMetamorphosis.Name = "bMetamorphosis";
            this.bMetamorphosis.Size = new System.Drawing.Size(137, 23);
            this.bMetamorphosis.TabIndex = 16;
            this.bMetamorphosis.Text = "Metamorphosis";
            this.bMetamorphosis.UseVisualStyleBackColor = true;
            // 
            // bSpectral_Sight
            // 
            this.bSpectral_Sight.Location = new System.Drawing.Point(144, 329);
            this.bSpectral_Sight.Name = "bSpectral_Sight";
            this.bSpectral_Sight.Size = new System.Drawing.Size(137, 23);
            this.bSpectral_Sight.TabIndex = 15;
            this.bSpectral_Sight.Text = "Spectral Sight";
            this.bSpectral_Sight.UseVisualStyleBackColor = true;
            // 
            // bThrow_Glaive
            // 
            this.bThrow_Glaive.Location = new System.Drawing.Point(1, 329);
            this.bThrow_Glaive.Name = "bThrow_Glaive";
            this.bThrow_Glaive.Size = new System.Drawing.Size(137, 23);
            this.bThrow_Glaive.TabIndex = 14;
            this.bThrow_Glaive.Text = "Throw Glaive";
            this.bThrow_Glaive.UseVisualStyleBackColor = true;
            // 
            // DemonHunterBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 561);
            this.Controls.Add(this.bMetamorphosis);
            this.Controls.Add(this.bSpectral_Sight);
            this.Controls.Add(this.bThrow_Glaive);
            this.Controls.Add(this.bConsume_Magic);
            this.Controls.Add(this.bGlide);
            this.Controls.Add(this.bImprison);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.bHavoc);
            this.Controls.Add(this.bVengeance);
            this.Controls.Add(this.label2);
            this.Name = "DemonHunterBaseForm";
            this.Text = "DemonHunterBaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bVengeance;
        private System.Windows.Forms.Button bHavoc;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bConsume_Magic;
        private System.Windows.Forms.Button bGlide;
        private System.Windows.Forms.Button bImprison;
        private System.Windows.Forms.Button bMetamorphosis;
        private System.Windows.Forms.Button bSpectral_Sight;
        private System.Windows.Forms.Button bThrow_Glaive;
    }
}
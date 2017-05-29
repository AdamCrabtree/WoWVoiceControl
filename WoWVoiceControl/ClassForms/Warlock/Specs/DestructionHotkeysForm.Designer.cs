namespace WoWVoiceControl.ClassForms.Warlock.Specs
{
    partial class DestructionHotkeysForm
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
            this.bHavoc = new System.Windows.Forms.Button();
            this.bRainOfFire = new System.Windows.Forms.Button();
            this.bChaosBolt = new System.Windows.Forms.Button();
            this.bConflagrate = new System.Windows.Forms.Button();
            this.bIncinerate = new System.Windows.Forms.Button();
            this.bImmolate = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bHavoc
            // 
            this.bHavoc.Location = new System.Drawing.Point(77, 156);
            this.bHavoc.Name = "bHavoc";
            this.bHavoc.Size = new System.Drawing.Size(136, 23);
            this.bHavoc.TabIndex = 12;
            this.bHavoc.Text = "Havoc";
            this.bHavoc.UseVisualStyleBackColor = true;
            this.bHavoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bHavoc_KeyPress);
            // 
            // bRainOfFire
            // 
            this.bRainOfFire.Location = new System.Drawing.Point(77, 127);
            this.bRainOfFire.Name = "bRainOfFire";
            this.bRainOfFire.Size = new System.Drawing.Size(136, 23);
            this.bRainOfFire.TabIndex = 11;
            this.bRainOfFire.Text = "Rain of Fire";
            this.bRainOfFire.UseVisualStyleBackColor = true;
            this.bRainOfFire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bRainOfFire_KeyPress);
            // 
            // bChaosBolt
            // 
            this.bChaosBolt.Location = new System.Drawing.Point(77, 98);
            this.bChaosBolt.Name = "bChaosBolt";
            this.bChaosBolt.Size = new System.Drawing.Size(136, 23);
            this.bChaosBolt.TabIndex = 10;
            this.bChaosBolt.Text = "Chaos Bolt";
            this.bChaosBolt.UseVisualStyleBackColor = true;
            this.bChaosBolt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bChaosBolt_KeyPress);
            // 
            // bConflagrate
            // 
            this.bConflagrate.Location = new System.Drawing.Point(77, 70);
            this.bConflagrate.Name = "bConflagrate";
            this.bConflagrate.Size = new System.Drawing.Size(136, 23);
            this.bConflagrate.TabIndex = 9;
            this.bConflagrate.Text = "Conflagrate";
            this.bConflagrate.UseVisualStyleBackColor = true;
            this.bConflagrate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bConflagrate_KeyPress);
            // 
            // bIncinerate
            // 
            this.bIncinerate.Location = new System.Drawing.Point(77, 41);
            this.bIncinerate.Name = "bIncinerate";
            this.bIncinerate.Size = new System.Drawing.Size(136, 23);
            this.bIncinerate.TabIndex = 8;
            this.bIncinerate.Text = "Incinerate";
            this.bIncinerate.UseVisualStyleBackColor = true;
            this.bIncinerate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bIncinerate_KeyPress);
            // 
            // bImmolate
            // 
            this.bImmolate.Location = new System.Drawing.Point(77, 12);
            this.bImmolate.Name = "bImmolate";
            this.bImmolate.Size = new System.Drawing.Size(136, 23);
            this.bImmolate.TabIndex = 7;
            this.bImmolate.Text = "Immolate";
            this.bImmolate.UseVisualStyleBackColor = true;
            this.bImmolate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bImmolate_KeyPress);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(77, 226);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(136, 23);
            this.bAccept.TabIndex = 13;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // DestructionHotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.bHavoc);
            this.Controls.Add(this.bRainOfFire);
            this.Controls.Add(this.bChaosBolt);
            this.Controls.Add(this.bConflagrate);
            this.Controls.Add(this.bIncinerate);
            this.Controls.Add(this.bImmolate);
            this.Name = "DestructionHotkeysForm";
            this.Text = "DestructionHotkeysForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DestructionHotkeysForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bHavoc;
        private System.Windows.Forms.Button bRainOfFire;
        private System.Windows.Forms.Button bChaosBolt;
        private System.Windows.Forms.Button bConflagrate;
        private System.Windows.Forms.Button bIncinerate;
        private System.Windows.Forms.Button bImmolate;
        private System.Windows.Forms.Button bAccept;
    }
}
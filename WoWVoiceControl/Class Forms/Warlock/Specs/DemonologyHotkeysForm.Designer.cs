namespace WoWVoiceControl.Class_Forms.Warlock.Specs
{
    partial class DemonologyHotkeysForm
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
            this.bShadowBolt = new System.Windows.Forms.Button();
            this.bHandOfGulDan = new System.Windows.Forms.Button();
            this.bDemonicEmpowerment = new System.Windows.Forms.Button();
            this.bCallDreadstalkers = new System.Windows.Forms.Button();
            this.bDoom = new System.Windows.Forms.Button();
            this.bDemonwrath = new System.Windows.Forms.Button();
            this.bSummonFelguard = new System.Windows.Forms.Button();
            this.bAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bShadowBolt
            // 
            this.bShadowBolt.Location = new System.Drawing.Point(93, 4);
            this.bShadowBolt.Name = "bShadowBolt";
            this.bShadowBolt.Size = new System.Drawing.Size(136, 23);
            this.bShadowBolt.TabIndex = 0;
            this.bShadowBolt.Text = "Shadow Bolt";
            this.bShadowBolt.UseVisualStyleBackColor = true;
            this.bShadowBolt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bShadowBolt_KeyPress);
            // 
            // bHandOfGulDan
            // 
            this.bHandOfGulDan.Location = new System.Drawing.Point(93, 33);
            this.bHandOfGulDan.Name = "bHandOfGulDan";
            this.bHandOfGulDan.Size = new System.Drawing.Size(136, 23);
            this.bHandOfGulDan.TabIndex = 1;
            this.bHandOfGulDan.Text = "Hand of Gul\'dan";
            this.bHandOfGulDan.UseVisualStyleBackColor = true;
            this.bHandOfGulDan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bHandOfGulDan_KeyPress);
            // 
            // bDemonicEmpowerment
            // 
            this.bDemonicEmpowerment.Location = new System.Drawing.Point(93, 62);
            this.bDemonicEmpowerment.Name = "bDemonicEmpowerment";
            this.bDemonicEmpowerment.Size = new System.Drawing.Size(136, 23);
            this.bDemonicEmpowerment.TabIndex = 2;
            this.bDemonicEmpowerment.Text = "Demonic Empowerment";
            this.bDemonicEmpowerment.UseVisualStyleBackColor = true;
            this.bDemonicEmpowerment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bDemonicEmpowerment_KeyPress);
            // 
            // bCallDreadstalkers
            // 
            this.bCallDreadstalkers.Location = new System.Drawing.Point(93, 90);
            this.bCallDreadstalkers.Name = "bCallDreadstalkers";
            this.bCallDreadstalkers.Size = new System.Drawing.Size(136, 23);
            this.bCallDreadstalkers.TabIndex = 3;
            this.bCallDreadstalkers.Text = "Call Dreadstalkers";
            this.bCallDreadstalkers.UseVisualStyleBackColor = true;
            this.bCallDreadstalkers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bCallDreadstalkers_KeyPress);
            // 
            // bDoom
            // 
            this.bDoom.Location = new System.Drawing.Point(93, 119);
            this.bDoom.Name = "bDoom";
            this.bDoom.Size = new System.Drawing.Size(136, 23);
            this.bDoom.TabIndex = 4;
            this.bDoom.Text = "Doom";
            this.bDoom.UseVisualStyleBackColor = true;
            this.bDoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bDoom_KeyPress);
            // 
            // bDemonwrath
            // 
            this.bDemonwrath.Location = new System.Drawing.Point(93, 148);
            this.bDemonwrath.Name = "bDemonwrath";
            this.bDemonwrath.Size = new System.Drawing.Size(136, 23);
            this.bDemonwrath.TabIndex = 5;
            this.bDemonwrath.Text = "Demonwrath";
            this.bDemonwrath.UseVisualStyleBackColor = true;
            this.bDemonwrath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bDemonwrath_KeyPress);
            // 
            // bSummonFelguard
            // 
            this.bSummonFelguard.Location = new System.Drawing.Point(93, 177);
            this.bSummonFelguard.Name = "bSummonFelguard";
            this.bSummonFelguard.Size = new System.Drawing.Size(136, 23);
            this.bSummonFelguard.TabIndex = 6;
            this.bSummonFelguard.Text = "Summon Felguard";
            this.bSummonFelguard.UseVisualStyleBackColor = true;
            this.bSummonFelguard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bSummonFelguard_KeyPress);
            // 
            // bAccept
            // 
            this.bAccept.Location = new System.Drawing.Point(93, 226);
            this.bAccept.Name = "bAccept";
            this.bAccept.Size = new System.Drawing.Size(136, 23);
            this.bAccept.TabIndex = 7;
            this.bAccept.Text = "Accept";
            this.bAccept.UseVisualStyleBackColor = true;
            this.bAccept.Click += new System.EventHandler(this.bAccept_Click);
            // 
            // DemonologyHotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bAccept);
            this.Controls.Add(this.bSummonFelguard);
            this.Controls.Add(this.bDemonwrath);
            this.Controls.Add(this.bDoom);
            this.Controls.Add(this.bCallDreadstalkers);
            this.Controls.Add(this.bDemonicEmpowerment);
            this.Controls.Add(this.bHandOfGulDan);
            this.Controls.Add(this.bShadowBolt);
            this.Name = "DemonologyHotkeysForm";
            this.Text = "DemonologyHotkeysForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DemonologyHotkeysForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShadowBolt;
        private System.Windows.Forms.Button bHandOfGulDan;
        private System.Windows.Forms.Button bDemonicEmpowerment;
        private System.Windows.Forms.Button bCallDreadstalkers;
        private System.Windows.Forms.Button bDoom;
        private System.Windows.Forms.Button bDemonwrath;
        private System.Windows.Forms.Button bSummonFelguard;
        private System.Windows.Forms.Button bAccept;
    }
}
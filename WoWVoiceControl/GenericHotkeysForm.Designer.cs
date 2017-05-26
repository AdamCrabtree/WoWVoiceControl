namespace WoWVoiceControl
{
    partial class GenericHotkeysForm
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
            this.bAutoRun = new System.Windows.Forms.Button();
            this.bMount = new System.Windows.Forms.Button();
            this.bEat = new System.Windows.Forms.Button();
            this.bTabTarget = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bAutoRun
            // 
            this.bAutoRun.Location = new System.Drawing.Point(103, 12);
            this.bAutoRun.Name = "bAutoRun";
            this.bAutoRun.Size = new System.Drawing.Size(75, 23);
            this.bAutoRun.TabIndex = 0;
            this.bAutoRun.Text = "Auto Run";
            this.bAutoRun.UseVisualStyleBackColor = true;
            this.bAutoRun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bAutoRun_KeyPress);
            // 
            // bMount
            // 
            this.bMount.Location = new System.Drawing.Point(103, 99);
            this.bMount.Name = "bMount";
            this.bMount.Size = new System.Drawing.Size(75, 23);
            this.bMount.TabIndex = 1;
            this.bMount.Text = "Mount";
            this.bMount.UseVisualStyleBackColor = true;
            this.bMount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bMount_KeyPress);
            // 
            // bEat
            // 
            this.bEat.Location = new System.Drawing.Point(103, 70);
            this.bEat.Name = "bEat";
            this.bEat.Size = new System.Drawing.Size(75, 23);
            this.bEat.TabIndex = 2;
            this.bEat.Text = "Eat";
            this.bEat.UseVisualStyleBackColor = true;
            this.bEat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bEat_KeyPress);
            // 
            // bTabTarget
            // 
            this.bTabTarget.Location = new System.Drawing.Point(103, 41);
            this.bTabTarget.Name = "bTabTarget";
            this.bTabTarget.Size = new System.Drawing.Size(75, 23);
            this.bTabTarget.TabIndex = 3;
            this.bTabTarget.Text = "Tab Target";
            this.bTabTarget.UseVisualStyleBackColor = true;
            this.bTabTarget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bTabTarget_KeyPress);
            // 
            // GenericHotkeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bTabTarget);
            this.Controls.Add(this.bEat);
            this.Controls.Add(this.bMount);
            this.Controls.Add(this.bAutoRun);
            this.Name = "GenericHotkeysForm";
            this.Text = "GenericHotkeysForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAutoRun;
        private System.Windows.Forms.Button bMount;
        private System.Windows.Forms.Button bEat;
        private System.Windows.Forms.Button bTabTarget;
    }
}
namespace SDRSharp.TemplatePlugin
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.enableFrontEndControlcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Settings Control";
            // 
            // enableFrontEndControlcheckBox
            // 
            this.enableFrontEndControlcheckBox.AutoSize = true;
            this.enableFrontEndControlcheckBox.Location = new System.Drawing.Point(8, 28);
            this.enableFrontEndControlcheckBox.Name = "enableFrontEndControlcheckBox";
            this.enableFrontEndControlcheckBox.Size = new System.Drawing.Size(161, 24);
            this.enableFrontEndControlcheckBox.TabIndex = 1;
            this.enableFrontEndControlcheckBox.Text = "Front End Control";
            this.enableFrontEndControlcheckBox.UseVisualStyleBackColor = true;
            this.enableFrontEndControlcheckBox.CheckedChanged += new System.EventHandler(this.enableFrontEndControlcheckBox_CheckedChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.enableFrontEndControlcheckBox);
            this.Controls.Add(this.label1);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox enableFrontEndControlcheckBox;
    }
}

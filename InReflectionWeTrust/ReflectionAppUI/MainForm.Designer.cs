namespace ReflectionAppUI
{
    partial class MainForm
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
            this.btn_relaod = new System.Windows.Forms.Button();
            this.grbx_providers = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // btn_relaod
            // 
            this.btn_relaod.Location = new System.Drawing.Point(705, 13);
            this.btn_relaod.Name = "btn_relaod";
            this.btn_relaod.Size = new System.Drawing.Size(135, 43);
            this.btn_relaod.TabIndex = 0;
            this.btn_relaod.Text = "Reload providers";
            this.btn_relaod.UseVisualStyleBackColor = true;
            this.btn_relaod.Click += new System.EventHandler(this.btn_relaod_Click);
            // 
            // grbx_providers
            // 
            this.grbx_providers.Location = new System.Drawing.Point(13, 62);
            this.grbx_providers.Name = "grbx_providers";
            this.grbx_providers.Size = new System.Drawing.Size(827, 399);
            this.grbx_providers.TabIndex = 1;
            this.grbx_providers.TabStop = false;
            this.grbx_providers.Text = "Providers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.grbx_providers);
            this.Controls.Add(this.btn_relaod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainForm";
            this.Text = "ReflectionAppUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_relaod;
        private System.Windows.Forms.GroupBox grbx_providers;
    }
}


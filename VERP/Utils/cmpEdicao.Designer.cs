namespace VERP.Utils
{
    partial class cmpEdicao
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
            this.gbxGeral = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbxGeral
            // 
            this.gbxGeral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxGeral.Location = new System.Drawing.Point(0, 0);
            this.gbxGeral.Name = "gbxGeral";
            this.gbxGeral.Size = new System.Drawing.Size(218, 131);
            this.gbxGeral.TabIndex = 0;
            this.gbxGeral.TabStop = false;
            this.gbxGeral.Text = "groupBox1";
            // 
            // cmpEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxGeral);
            this.Name = "cmpEdicao";
            this.Size = new System.Drawing.Size(218, 131);
            this.Load += new System.EventHandler(this.cmpEdicao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGeral;
    }
}

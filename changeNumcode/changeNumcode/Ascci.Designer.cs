namespace changeNumcode
{
    partial class Ascci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ascci));
            this.ToAsk = new System.Windows.Forms.TextBox();
            this.toAskButton = new System.Windows.Forms.Button();
            this.toStrButton = new System.Windows.Forms.Button();
            this.ToLang = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ToAsk
            // 
            this.ToAsk.Location = new System.Drawing.Point(210, 45);
            this.ToAsk.Name = "ToAsk";
            this.ToAsk.Size = new System.Drawing.Size(367, 22);
            this.ToAsk.TabIndex = 0;
            // 
            // toAskButton
            // 
            this.toAskButton.Location = new System.Drawing.Point(33, 38);
            this.toAskButton.Name = "toAskButton";
            this.toAskButton.Size = new System.Drawing.Size(117, 37);
            this.toAskButton.TabIndex = 2;
            this.toAskButton.Text = "文字→アスキー";
            this.toAskButton.UseVisualStyleBackColor = true;
            this.toAskButton.Click += new System.EventHandler(this.toAskButton_Click);
            // 
            // toStrButton
            // 
            this.toStrButton.Location = new System.Drawing.Point(33, 109);
            this.toStrButton.Name = "toStrButton";
            this.toStrButton.Size = new System.Drawing.Size(117, 37);
            this.toStrButton.TabIndex = 3;
            this.toStrButton.Text = "アスキー→文字";
            this.toStrButton.UseVisualStyleBackColor = true;
            this.toStrButton.Click += new System.EventHandler(this.toStrButton_Click);
            // 
            // ToLang
            // 
            this.ToLang.Location = new System.Drawing.Point(210, 117);
            this.ToLang.Name = "ToLang";
            this.ToLang.Size = new System.Drawing.Size(367, 22);
            this.ToLang.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "変換";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.printLabel.Location = new System.Drawing.Point(206, 208);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(0, 22);
            this.printLabel.TabIndex = 6;
            // 
            // Ascci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 311);
            this.Controls.Add(this.printLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ToLang);
            this.Controls.Add(this.toStrButton);
            this.Controls.Add(this.toAskButton);
            this.Controls.Add(this.ToAsk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ascci";
            this.Text = "Ascci";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ToAsk;
        private System.Windows.Forms.Button toAskButton;
        private System.Windows.Forms.Button toStrButton;
        private System.Windows.Forms.TextBox ToLang;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label printLabel;
    }
}
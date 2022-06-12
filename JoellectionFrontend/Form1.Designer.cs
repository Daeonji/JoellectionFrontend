namespace JoellectionFrontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.joeName = new System.Windows.Forms.TextBox();
            this.joeDesc = new System.Windows.Forms.TextBox();
            this.joeLink = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(421, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 162);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.label1_Click);
            // 
            // joeName
            // 
            this.joeName.Location = new System.Drawing.Point(12, 12);
            this.joeName.Name = "joeName";
            this.joeName.PlaceholderText = "Name:";
            this.joeName.Size = new System.Drawing.Size(100, 23);
            this.joeName.TabIndex = 1;
            // 
            // joeDesc
            // 
            this.joeDesc.Location = new System.Drawing.Point(12, 41);
            this.joeDesc.Name = "joeDesc";
            this.joeDesc.PlaceholderText = "Description:";
            this.joeDesc.Size = new System.Drawing.Size(100, 23);
            this.joeDesc.TabIndex = 2;
            // 
            // joeLink
            // 
            this.joeLink.Location = new System.Drawing.Point(12, 70);
            this.joeLink.Name = "joeLink";
            this.joeLink.PlaceholderText = "Image Link:";
            this.joeLink.Size = new System.Drawing.Size(100, 23);
            this.joeLink.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(376, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(247, 169);
            this.listBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Insert the Name of Your Joe";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Provide a Description of said Joe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "A link to your joepic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.joeLink);
            this.Controls.Add(this.joeDesc);
            this.Controls.Add(this.joeName);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Joellection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox joeName;
        private TextBox joeDesc;
        private TextBox joeLink;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
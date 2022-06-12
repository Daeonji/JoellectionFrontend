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
            this.refreshJoes = new System.Windows.Forms.Button();
            this.joeSelectedPic = new System.Windows.Forms.PictureBox();
            this.nametag = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.joeSelectedPic)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(604, 418);
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
            this.listBox1.Location = new System.Drawing.Point(614, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(202, 274);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            // refreshJoes
            // 
            this.refreshJoes.Image = ((System.Drawing.Image)(resources.GetObject("refreshJoes.Image")));
            this.refreshJoes.Location = new System.Drawing.Point(654, 289);
            this.refreshJoes.Name = "refreshJoes";
            this.refreshJoes.Size = new System.Drawing.Size(120, 68);
            this.refreshJoes.TabIndex = 8;
            this.refreshJoes.UseVisualStyleBackColor = true;
            this.refreshJoes.Click += new System.EventHandler(this.refreshJoes_Click);
            // 
            // joeSelectedPic
            // 
            this.joeSelectedPic.Location = new System.Drawing.Point(12, 109);
            this.joeSelectedPic.Name = "joeSelectedPic";
            this.joeSelectedPic.Size = new System.Drawing.Size(473, 394);
            this.joeSelectedPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.joeSelectedPic.TabIndex = 9;
            this.joeSelectedPic.TabStop = false;
            // 
            // nametag
            // 
            this.nametag.AutoSize = true;
            this.nametag.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nametag.Location = new System.Drawing.Point(12, 506);
            this.nametag.Name = "nametag";
            this.nametag.Size = new System.Drawing.Size(89, 28);
            this.nametag.TabIndex = 10;
            this.nametag.Text = "nametag";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description.Location = new System.Drawing.Point(12, 534);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(83, 20);
            this.description.TabIndex = 11;
            this.description.Text = "description";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(624, 363);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(552, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 592);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.nametag);
            this.Controls.Add(this.joeSelectedPic);
            this.Controls.Add(this.refreshJoes);
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
            ((System.ComponentModel.ISupportInitialize)(this.joeSelectedPic)).EndInit();
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
        private Button refreshJoes;
        private PictureBox joeSelectedPic;
        private Label nametag;
        private Label description;
        private ProgressBar progressBar1;
        private Button button2;
    }
}
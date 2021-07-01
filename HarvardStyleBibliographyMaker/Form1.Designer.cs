
namespace HarvardStyleBibliographyMaker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Author = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.WebsiteName = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.YearOfPublishment = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Author
            // 
            this.Author.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Author.Location = new System.Drawing.Point(23, 77);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(206, 20);
            this.Author.TabIndex = 0;
            this.Author.TextChanged += new System.EventHandler(this.Author_TextChanged);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(23, 348);
            this.URL.Multiline = true;
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(206, 20);
            this.URL.TabIndex = 1;
            this.URL.TextChanged += new System.EventHandler(this.URL_TextChanged);
            // 
            // Title
            // 
            this.Title.Location = new System.Drawing.Point(24, 213);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(206, 20);
            this.Title.TabIndex = 2;
            this.Title.TextChanged += new System.EventHandler(this.Title_TextChanged);
            // 
            // WebsiteName
            // 
            this.WebsiteName.Location = new System.Drawing.Point(24, 284);
            this.WebsiteName.Multiline = true;
            this.WebsiteName.Name = "WebsiteName";
            this.WebsiteName.Size = new System.Drawing.Size(206, 20);
            this.WebsiteName.TabIndex = 3;
            this.WebsiteName.TextChanged += new System.EventHandler(this.WebsiteName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(19, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Author";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year of Publishment";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(18, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Title";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(19, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Website Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(19, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "URL";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Lavender;
            this.AddButton.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.Location = new System.Drawing.Point(23, 391);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(201, 111);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add to the list";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // YearOfPublishment
            // 
            this.YearOfPublishment.Location = new System.Drawing.Point(23, 143);
            this.YearOfPublishment.Multiline = true;
            this.YearOfPublishment.Name = "YearOfPublishment";
            this.YearOfPublishment.Size = new System.Drawing.Size(206, 20);
            this.YearOfPublishment.TabIndex = 16;
            this.YearOfPublishment.TextChanged += new System.EventHandler(this.YearOfPublishment_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(769, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(286, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(465, 500);
            this.textBox1.TabIndex = 19;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ClientSize = new System.Drawing.Size(769, 630);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.YearOfPublishment);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WebsiteName);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "HarvardReferencer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox WebsiteName;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox YearOfPublishment;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
    }
}


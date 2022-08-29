namespace PokeFusionApp
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.pokemon1 = new System.Windows.Forms.ComboBox();
            this.pokemon2 = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.Label();
            this.pokemon1Label = new System.Windows.Forms.Label();
            this.pokemon2Label = new System.Windows.Forms.Label();
            this.fuseThem = new System.Windows.Forms.Button();
            this.poke1pic = new System.Windows.Forms.PictureBox();
            this.poke2pic = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.poke1stats = new System.Windows.Forms.Label();
            this.poke2stats = new System.Windows.Forms.Label();
            this.fusedStatsLabel = new System.Windows.Forms.Label();
            this.fusedStats = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.poke1pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poke2pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pokemon1
            // 
            this.pokemon1.FormattingEnabled = true;
            this.pokemon1.Location = new System.Drawing.Point(128, 19);
            this.pokemon1.Name = "pokemon1";
            this.pokemon1.Size = new System.Drawing.Size(121, 23);
            this.pokemon1.TabIndex = 0;
            // 
            // pokemon2
            // 
            this.pokemon2.FormattingEnabled = true;
            this.pokemon2.Location = new System.Drawing.Point(125, 19);
            this.pokemon2.Name = "pokemon2";
            this.pokemon2.Size = new System.Drawing.Size(121, 23);
            this.pokemon2.TabIndex = 1;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Snap ITC", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(203, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(392, 25);
            this.title.TabIndex = 2;
            this.title.Text = "Pokemon Fusion Stat Generator";
            // 
            // pokemon1Label
            // 
            this.pokemon1Label.AutoSize = true;
            this.pokemon1Label.Location = new System.Drawing.Point(29, 22);
            this.pokemon1Label.Name = "pokemon1Label";
            this.pokemon1Label.Size = new System.Drawing.Size(67, 15);
            this.pokemon1Label.TabIndex = 3;
            this.pokemon1Label.Text = "Pokemon 1";
            // 
            // pokemon2Label
            // 
            this.pokemon2Label.AutoSize = true;
            this.pokemon2Label.Location = new System.Drawing.Point(19, 22);
            this.pokemon2Label.Name = "pokemon2Label";
            this.pokemon2Label.Size = new System.Drawing.Size(67, 15);
            this.pokemon2Label.TabIndex = 4;
            this.pokemon2Label.Text = "Pokemon 2";
            // 
            // fuseThem
            // 
            this.fuseThem.Location = new System.Drawing.Point(367, 415);
            this.fuseThem.Name = "fuseThem";
            this.fuseThem.Size = new System.Drawing.Size(75, 23);
            this.fuseThem.TabIndex = 5;
            this.fuseThem.Text = "Fuse";
            this.fuseThem.UseVisualStyleBackColor = true;
            this.fuseThem.Click += new System.EventHandler(this.fuseThem_Click);
            // 
            // poke1pic
            // 
            this.poke1pic.Location = new System.Drawing.Point(22, 58);
            this.poke1pic.Name = "poke1pic";
            this.poke1pic.Size = new System.Drawing.Size(100, 50);
            this.poke1pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poke1pic.TabIndex = 6;
            this.poke1pic.TabStop = false;
            // 
            // poke2pic
            // 
            this.poke2pic.Location = new System.Drawing.Point(19, 58);
            this.poke2pic.Name = "poke2pic";
            this.poke2pic.Size = new System.Drawing.Size(100, 50);
            this.poke2pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.poke2pic.TabIndex = 7;
            this.poke2pic.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 63);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pokemon1Label);
            this.splitContainer1.Panel1.Controls.Add(this.poke1stats);
            this.splitContainer1.Panel1.Controls.Add(this.pokemon1);
            this.splitContainer1.Panel1.Controls.Add(this.poke1pic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.poke2stats);
            this.splitContainer1.Panel2.Controls.Add(this.pokemon2);
            this.splitContainer1.Panel2.Controls.Add(this.poke2pic);
            this.splitContainer1.Panel2.Controls.Add(this.pokemon2Label);
            this.splitContainer1.Size = new System.Drawing.Size(776, 183);
            this.splitContainer1.SplitterDistance = 381;
            this.splitContainer1.TabIndex = 8;
            // 
            // poke1stats
            // 
            this.poke1stats.AutoSize = true;
            this.poke1stats.Location = new System.Drawing.Point(128, 74);
            this.poke1stats.Name = "poke1stats";
            this.poke1stats.Size = new System.Drawing.Size(0, 15);
            this.poke1stats.TabIndex = 9;
            // 
            // poke2stats
            // 
            this.poke2stats.AutoSize = true;
            this.poke2stats.Location = new System.Drawing.Point(125, 74);
            this.poke2stats.Name = "poke2stats";
            this.poke2stats.Size = new System.Drawing.Size(0, 15);
            this.poke2stats.TabIndex = 10;
            // 
            // fusedStatsLabel
            // 
            this.fusedStatsLabel.AutoSize = true;
            this.fusedStatsLabel.Location = new System.Drawing.Point(34, 292);
            this.fusedStatsLabel.Name = "fusedStatsLabel";
            this.fusedStatsLabel.Size = new System.Drawing.Size(66, 15);
            this.fusedStatsLabel.TabIndex = 9;
            this.fusedStatsLabel.Text = "Fused Stats";
            // 
            // fusedStats
            // 
            this.fusedStats.AutoSize = true;
            this.fusedStats.Location = new System.Drawing.Point(140, 292);
            this.fusedStats.Name = "fusedStats";
            this.fusedStats.Size = new System.Drawing.Size(0, 15);
            this.fusedStats.TabIndex = 10;
            this.toolTip1.SetToolTip(this.fusedStats, "Double-Click here to copy to clipboard!");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fusedStats);
            this.Controls.Add(this.fusedStatsLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.fuseThem);
            this.Controls.Add(this.title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Pokemon Fusion Stat Generator";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.poke1pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poke2pic)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox pokemon1;
        private ComboBox pokemon2;
        private Label title;
        private Label pokemon1Label;
        private Label pokemon2Label;
        private Button fuseThem;
        private PictureBox poke1pic;
        private PictureBox poke2pic;
        private SplitContainer splitContainer1;
        private Label poke1stats;
        private Label poke2stats;
        private Label fusedStatsLabel;
        private Label fusedStats;
        private ToolTip toolTip1;
    }
}
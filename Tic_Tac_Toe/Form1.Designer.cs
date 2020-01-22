namespace Tic_Tac_Toe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nowaGraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nowaGraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.C3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem,
            this.pomocToolStripMenuItem,
            this.wynikiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(545, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nowaGraToolStripMenuItem
            // 
            this.nowaGraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nowaGraToolStripMenuItem1,
            this.zakończToolStripMenuItem});
            this.nowaGraToolStripMenuItem.Name = "nowaGraToolStripMenuItem";
            this.nowaGraToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.nowaGraToolStripMenuItem.Text = "Menu";
            // 
            // nowaGraToolStripMenuItem1
            // 
            this.nowaGraToolStripMenuItem1.Name = "nowaGraToolStripMenuItem1";
            this.nowaGraToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.nowaGraToolStripMenuItem1.Text = "Nowa gra";
            this.nowaGraToolStripMenuItem1.Click += new System.EventHandler(this.nowaGraToolStripMenuItem1_Click);
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            this.pomocToolStripMenuItem.Click += new System.EventHandler(this.pomocToolStripMenuItem_Click);
            // 
            // wynikiToolStripMenuItem
            // 
            this.wynikiToolStripMenuItem.Name = "wynikiToolStripMenuItem";
            this.wynikiToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.wynikiToolStripMenuItem.Text = "Wyniki";
            this.wynikiToolStripMenuItem.Click += new System.EventHandler(this.wynikiToolStripMenuItem_Click);
            // 
            // C3
            // 
            this.C3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C3.BackgroundImage")));
            this.C3.Location = new System.Drawing.Point(364, 379);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(170, 170);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.b_click);
            // 
            // B2
            // 
            this.B2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B2.BackgroundImage")));
            this.B2.Location = new System.Drawing.Point(188, 203);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(170, 170);
            this.B2.TabIndex = 8;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.b_click);
            // 
            // B3
            // 
            this.B3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B3.BackgroundImage")));
            this.B3.Location = new System.Drawing.Point(364, 203);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(170, 170);
            this.B3.TabIndex = 7;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.b_click);
            // 
            // C2
            // 
            this.C2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C2.BackgroundImage")));
            this.C2.Location = new System.Drawing.Point(188, 379);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(170, 170);
            this.C2.TabIndex = 6;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.b_click);
            // 
            // A3
            // 
            this.A3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A3.BackgroundImage")));
            this.A3.Location = new System.Drawing.Point(364, 27);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(170, 170);
            this.A3.TabIndex = 5;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.b_click);
            // 
            // A2
            // 
            this.A2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A2.BackgroundImage")));
            this.A2.Location = new System.Drawing.Point(188, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(170, 170);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.b_click);
            // 
            // C1
            // 
            this.C1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C1.BackgroundImage")));
            this.C1.Location = new System.Drawing.Point(12, 379);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(170, 170);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.b_click);
            // 
            // B1
            // 
            this.B1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B1.BackgroundImage")));
            this.B1.Location = new System.Drawing.Point(12, 203);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(170, 170);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.b_click);
            // 
            // A1
            // 
            this.A1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("A1.BackgroundImage")));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(170, 170);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.b_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 558);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowaGraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wynikiToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C3;
    }
}


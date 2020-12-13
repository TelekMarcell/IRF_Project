namespace GymManagement
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tartozékokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagKereséseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelentkezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bezárásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMemberToolStripMenuItem,
            this.newStaffToolStripMenuItem,
            this.tartozékokToolStripMenuItem,
            this.tagKereséseToolStripMenuItem,
            this.tagTörléseToolStripMenuItem,
            this.kijelentkezésToolStripMenuItem,
            this.bezárásToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 54);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newMemberToolStripMenuItem
            // 
            this.newMemberToolStripMenuItem.AutoSize = false;
            this.newMemberToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.newMemberToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newMemberToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newMemberToolStripMenuItem.Image")));
            this.newMemberToolStripMenuItem.Name = "newMemberToolStripMenuItem";
            this.newMemberToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.newMemberToolStripMenuItem.Text = "Új tag";
            this.newMemberToolStripMenuItem.Click += new System.EventHandler(this.newMemberToolStripMenuItem_Click);
            // 
            // newStaffToolStripMenuItem
            // 
            this.newStaffToolStripMenuItem.AutoSize = false;
            this.newStaffToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newStaffToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newStaffToolStripMenuItem.Image")));
            this.newStaffToolStripMenuItem.Name = "newStaffToolStripMenuItem";
            this.newStaffToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.newStaffToolStripMenuItem.Text = "Új munkatárs";
            this.newStaffToolStripMenuItem.Click += new System.EventHandler(this.newStaffToolStripMenuItem_Click);
            // 
            // tartozékokToolStripMenuItem
            // 
            this.tartozékokToolStripMenuItem.AutoSize = false;
            this.tartozékokToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.tartozékokToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tartozékokToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tartozékokToolStripMenuItem.Image")));
            this.tartozékokToolStripMenuItem.Name = "tartozékokToolStripMenuItem";
            this.tartozékokToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.tartozékokToolStripMenuItem.Text = "Tartozékok";
            this.tartozékokToolStripMenuItem.Click += new System.EventHandler(this.tartozékokToolStripMenuItem_Click);
            // 
            // tagKereséseToolStripMenuItem
            // 
            this.tagKereséseToolStripMenuItem.AutoSize = false;
            this.tagKereséseToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagKereséseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagKereséseToolStripMenuItem.Image")));
            this.tagKereséseToolStripMenuItem.Name = "tagKereséseToolStripMenuItem";
            this.tagKereséseToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.tagKereséseToolStripMenuItem.Text = "Tag keresése ";
            this.tagKereséseToolStripMenuItem.Click += new System.EventHandler(this.tagKereséseToolStripMenuItem_Click);
            // 
            // tagTörléseToolStripMenuItem
            // 
            this.tagTörléseToolStripMenuItem.AutoSize = false;
            this.tagTörléseToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.tagTörléseToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagTörléseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tagTörléseToolStripMenuItem.Image")));
            this.tagTörléseToolStripMenuItem.Name = "tagTörléseToolStripMenuItem";
            this.tagTörléseToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.tagTörléseToolStripMenuItem.Text = "Tag törlése";
            this.tagTörléseToolStripMenuItem.Click += new System.EventHandler(this.tagTörléseToolStripMenuItem_Click);
            // 
            // kijelentkezésToolStripMenuItem
            // 
            this.kijelentkezésToolStripMenuItem.AutoSize = false;
            this.kijelentkezésToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kijelentkezésToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kijelentkezésToolStripMenuItem.Image")));
            this.kijelentkezésToolStripMenuItem.Name = "kijelentkezésToolStripMenuItem";
            this.kijelentkezésToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.kijelentkezésToolStripMenuItem.Text = "Kijelentkezés";
            this.kijelentkezésToolStripMenuItem.Click += new System.EventHandler(this.kijelentkezésToolStripMenuItem_Click);
            // 
            // bezárásToolStripMenuItem
            // 
            this.bezárásToolStripMenuItem.AutoSize = false;
            this.bezárásToolStripMenuItem.BackColor = System.Drawing.Color.Silver;
            this.bezárásToolStripMenuItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bezárásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bezárásToolStripMenuItem.Image")));
            this.bezárásToolStripMenuItem.Name = "bezárásToolStripMenuItem";
            this.bezárásToolStripMenuItem.Size = new System.Drawing.Size(130, 50);
            this.bezárásToolStripMenuItem.Text = "Bezárás";
            this.bezárásToolStripMenuItem.Click += new System.EventHandler(this.bezárásToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tartozékokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagKereséseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelentkezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bezárásToolStripMenuItem;
    }
}


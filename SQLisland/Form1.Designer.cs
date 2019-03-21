namespace SQLisland
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_exec = new System.Windows.Forms.Button();
            this.tb_exec = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_continue = new System.Windows.Forms.Label();
            this.tb_mission = new System.Windows.Forms.RichTextBox();
            this.lbl_mIndex = new System.Windows.Forms.Label();
            this.lbl_mission = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exec
            // 
            this.btn_exec.BackColor = System.Drawing.Color.LightCoral;
            this.btn_exec.FlatAppearance.BorderSize = 0;
            this.btn_exec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exec.Location = new System.Drawing.Point(731, 508);
            this.btn_exec.Name = "btn_exec";
            this.btn_exec.Size = new System.Drawing.Size(141, 41);
            this.btn_exec.TabIndex = 0;
            this.btn_exec.Text = "Ausführen";
            this.btn_exec.UseVisualStyleBackColor = false;
            this.btn_exec.Click += new System.EventHandler(this.btn_exec_Click);
            // 
            // tb_exec
            // 
            this.tb_exec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_exec.Location = new System.Drawing.Point(394, 389);
            this.tb_exec.Name = "tb_exec";
            this.tb_exec.Size = new System.Drawing.Size(478, 98);
            this.tb_exec.TabIndex = 3;
            this.tb_exec.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(26, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 456);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 289);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_continue);
            this.panel2.Controls.Add(this.tb_mission);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 167);
            this.panel2.TabIndex = 6;
            // 
            // lbl_continue
            // 
            this.lbl_continue.AutoSize = true;
            this.lbl_continue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lbl_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_continue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_continue.ForeColor = System.Drawing.Color.Red;
            this.lbl_continue.Location = new System.Drawing.Point(243, 136);
            this.lbl_continue.Name = "lbl_continue";
            this.lbl_continue.Size = new System.Drawing.Size(64, 24);
            this.lbl_continue.TabIndex = 8;
            this.lbl_continue.Text = "Weiter";
            this.lbl_continue.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_mission
            // 
            this.tb_mission.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_mission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tb_mission.Location = new System.Drawing.Point(0, 0);
            this.tb_mission.Name = "tb_mission";
            this.tb_mission.Size = new System.Drawing.Size(310, 133);
            this.tb_mission.TabIndex = 7;
            this.tb_mission.Text = "";
            // 
            // lbl_mIndex
            // 
            this.lbl_mIndex.AutoSize = true;
            this.lbl_mIndex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lbl_mIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mIndex.ForeColor = System.Drawing.Color.Red;
            this.lbl_mIndex.Location = new System.Drawing.Point(247, 46);
            this.lbl_mIndex.Name = "lbl_mIndex";
            this.lbl_mIndex.Size = new System.Drawing.Size(85, 20);
            this.lbl_mIndex.TabIndex = 9;
            this.lbl_mIndex.Text = "lbl_mIndex";
            // 
            // lbl_mission
            // 
            this.lbl_mission.AutoSize = true;
            this.lbl_mission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.lbl_mission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mission.ForeColor = System.Drawing.Color.Red;
            this.lbl_mission.Location = new System.Drawing.Point(175, 46);
            this.lbl_mission.Name = "lbl_mission";
            this.lbl_mission.Size = new System.Drawing.Size(66, 20);
            this.lbl_mission.TabIndex = 10;
            this.lbl_mission.Text = "Mission:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(26, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(846, 45);
            this.panel3.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(158, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staedte (ID, Name)                     Bewohner (ID, Name, Wohnort, B_alter, Beru" +
    "f, Item)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(394, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(478, 243);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(884, 632);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_mission);
            this.Controls.Add(this.lbl_mIndex);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_exec);
            this.Controls.Add(this.btn_exec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exec;
        private System.Windows.Forms.RichTextBox tb_exec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_continue;
        private System.Windows.Forms.RichTextBox tb_mission;
        private System.Windows.Forms.Label lbl_mIndex;
        private System.Windows.Forms.Label lbl_mission;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


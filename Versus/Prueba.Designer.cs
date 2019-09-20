namespace Versus
{
    partial class Prueba
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
            this.txtTeamPrueba1 = new System.Windows.Forms.TextBox();
            this.txtTeamPrueba2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.teamPrueba1 = new System.Windows.Forms.PictureBox();
            this.teamPrueba2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamPrueba1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPrueba2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTeamPrueba1
            // 
            this.txtTeamPrueba1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTeamPrueba1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeamPrueba1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamPrueba1.ForeColor = System.Drawing.Color.White;
            this.txtTeamPrueba1.Location = new System.Drawing.Point(25, 328);
            this.txtTeamPrueba1.Name = "txtTeamPrueba1";
            this.txtTeamPrueba1.Size = new System.Drawing.Size(207, 29);
            this.txtTeamPrueba1.TabIndex = 14;
            this.txtTeamPrueba1.Text = "Equipo #1";
            // 
            // txtTeamPrueba2
            // 
            this.txtTeamPrueba2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTeamPrueba2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeamPrueba2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeamPrueba2.ForeColor = System.Drawing.Color.White;
            this.txtTeamPrueba2.Location = new System.Drawing.Point(451, 328);
            this.txtTeamPrueba2.Name = "txtTeamPrueba2";
            this.txtTeamPrueba2.Size = new System.Drawing.Size(207, 29);
            this.txtTeamPrueba2.TabIndex = 15;
            this.txtTeamPrueba2.Text = "Equipo #2";
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(343, 176);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 83);
            this.button4.TabIndex = 7;
            this.button4.Text = "VS";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // teamPrueba1
            // 
            this.teamPrueba1.Location = new System.Drawing.Point(25, 117);
            this.teamPrueba1.Name = "teamPrueba1";
            this.teamPrueba1.Size = new System.Drawing.Size(312, 185);
            this.teamPrueba1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teamPrueba1.TabIndex = 2;
            this.teamPrueba1.TabStop = false;
            this.teamPrueba1.Click += new System.EventHandler(this.Team1_Click);
            // 
            // teamPrueba2
            // 
            this.teamPrueba2.Location = new System.Drawing.Point(451, 117);
            this.teamPrueba2.Name = "teamPrueba2";
            this.teamPrueba2.Size = new System.Drawing.Size(312, 185);
            this.teamPrueba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.teamPrueba2.TabIndex = 16;
            this.teamPrueba2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(800, 53);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.teamPrueba2);
            this.Controls.Add(this.teamPrueba1);
            this.Controls.Add(this.txtTeamPrueba1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtTeamPrueba2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prueba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prueba";
            ((System.ComponentModel.ISupportInitialize)(this.teamPrueba1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamPrueba2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTeamPrueba1;
        private System.Windows.Forms.TextBox txtTeamPrueba2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox teamPrueba1;
        private System.Windows.Forms.PictureBox teamPrueba2;
        private System.Windows.Forms.Button btnClose;
    }
}
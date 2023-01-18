
namespace packman
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.jugar = new System.Windows.Forms.Button();
            this.no_jugar = new System.Windows.Forms.Button();
            this.titulo = new System.Windows.Forms.Label();
            this.cartel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cartel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arcade Normal", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(158, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUIERES VOLVER A JUGAR?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // jugar
            // 
            this.jugar.BackColor = System.Drawing.Color.Transparent;
            this.jugar.FlatAppearance.BorderSize = 2;
            this.jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jugar.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jugar.ForeColor = System.Drawing.Color.White;
            this.jugar.Location = new System.Drawing.Point(206, 320);
            this.jugar.Name = "jugar";
            this.jugar.Size = new System.Drawing.Size(90, 30);
            this.jugar.TabIndex = 2;
            this.jugar.TabStop = false;
            this.jugar.Text = "Yes";
            this.jugar.UseVisualStyleBackColor = false;
            this.jugar.Click += new System.EventHandler(this.jugar_Click);
            // 
            // no_jugar
            // 
            this.no_jugar.BackColor = System.Drawing.Color.Transparent;
            this.no_jugar.FlatAppearance.BorderSize = 2;
            this.no_jugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.no_jugar.Font = new System.Drawing.Font("Arcade Normal", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_jugar.ForeColor = System.Drawing.Color.White;
            this.no_jugar.Location = new System.Drawing.Point(404, 320);
            this.no_jugar.Name = "no_jugar";
            this.no_jugar.Size = new System.Drawing.Size(90, 30);
            this.no_jugar.TabIndex = 3;
            this.no_jugar.TabStop = false;
            this.no_jugar.Text = "No";
            this.no_jugar.UseVisualStyleBackColor = false;
            this.no_jugar.Click += new System.EventHandler(this.no_jugar_Click);
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Arcade Normal", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.titulo.Location = new System.Drawing.Point(12, 95);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(696, 56);
            this.titulo.TabIndex = 4;
            this.titulo.Text = "GAME OVER";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartel
            // 
            this.cartel.Image = global::packman.Properties.Resources.w20;
            this.cartel.Location = new System.Drawing.Point(528, 222);
            this.cartel.Name = "cartel";
            this.cartel.Size = new System.Drawing.Size(30, 30);
            this.cartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cartel.TabIndex = 7;
            this.cartel.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(720, 400);
            this.Controls.Add(this.cartel);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.no_jugar);
            this.Controls.Add(this.jugar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Packman";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.cartel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jugar;
        private System.Windows.Forms.Button no_jugar;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.PictureBox cartel;
    }
}
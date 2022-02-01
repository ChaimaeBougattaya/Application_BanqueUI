
namespace Application_BanqueGUI.UserControls
{
    partial class DepotRetraitUI
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDebiter = new System.Windows.Forms.Button();
            this.btnCrediter = new System.Windows.Forms.Button();
            this.montant = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnDebiter);
            this.panel1.Controls.Add(this.btnCrediter);
            this.panel1.Controls.Add(this.montant);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(159, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 340);
            this.panel1.TabIndex = 6;
            // 
            // btnDebiter
            // 
            this.btnDebiter.AutoSize = true;
            this.btnDebiter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDebiter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDebiter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebiter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebiter.ForeColor = System.Drawing.Color.White;
            this.btnDebiter.Location = new System.Drawing.Point(287, 236);
            this.btnDebiter.Name = "btnDebiter";
            this.btnDebiter.Size = new System.Drawing.Size(96, 34);
            this.btnDebiter.TabIndex = 11;
            this.btnDebiter.Text = "débiter";
            this.btnDebiter.UseVisualStyleBackColor = false;
            this.btnDebiter.Click += new System.EventHandler(this.btnDebiter_Click);
            // 
            // btnCrediter
            // 
            this.btnCrediter.AutoSize = true;
            this.btnCrediter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCrediter.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCrediter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrediter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrediter.ForeColor = System.Drawing.Color.White;
            this.btnCrediter.Location = new System.Drawing.Point(161, 236);
            this.btnCrediter.Name = "btnCrediter";
            this.btnCrediter.Size = new System.Drawing.Size(96, 34);
            this.btnCrediter.TabIndex = 10;
            this.btnCrediter.Text = "créditer";
            this.btnCrediter.UseVisualStyleBackColor = false;
            this.btnCrediter.Click += new System.EventHandler(this.btnCrediter_Click);
            // 
            // montant
            // 
            this.montant.Location = new System.Drawing.Point(270, 162);
            this.montant.Multiline = true;
            this.montant.Name = "montant";
            this.montant.Size = new System.Drawing.Size(222, 30);
            this.montant.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(222, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(80, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Montant (DH) :";
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(80, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "N° du compte :";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DH",
            "Euro",
            "Dollar"});
            this.comboBox2.Location = new System.Drawing.Point(270, 120);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(222, 21);
            this.comboBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(80, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 34);
            this.label3.TabIndex = 12;
            this.label3.Text = "Devise :";
            // 
            // DepotRetraitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.panel1);
            this.Name = "DepotRetraitUI";
            this.Size = new System.Drawing.Size(939, 578);
            this.Load += new System.EventHandler(this.DepotRetraitUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDebiter;
        private System.Windows.Forms.Button btnCrediter;
        private System.Windows.Forms.TextBox montant;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
    }
}

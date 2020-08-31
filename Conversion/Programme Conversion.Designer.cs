namespace Conversion
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btndecimal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHexadecimal = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbinaire = new System.Windows.Forms.TextBox();
            this.txthexadecimal = new System.Windows.Forms.TextBox();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.btnSortie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndecimal
            // 
            this.btndecimal.Location = new System.Drawing.Point(38, 137);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(75, 23);
            this.btndecimal.TabIndex = 0;
            this.btndecimal.Text = "Décimal";
            this.btndecimal.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBinaire);
            this.groupBox1.Controls.Add(this.btnHexadecimal);
            this.groupBox1.Controls.Add(this.txtValeur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btndecimal);
            this.groupBox1.Location = new System.Drawing.Point(170, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valeur à convertir";
            // 
            // txtValeur
            // 
            this.txtValeur.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValeur.Location = new System.Drawing.Point(152, 62);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(100, 20);
            this.txtValeur.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversion de valeurs non signées";
            // 
            // btnHexadecimal
            // 
            this.btnHexadecimal.Location = new System.Drawing.Point(180, 137);
            this.btnHexadecimal.Name = "btnHexadecimal";
            this.btnHexadecimal.Size = new System.Drawing.Size(85, 23);
            this.btnHexadecimal.TabIndex = 2;
            this.btnHexadecimal.Text = "Hexadécimal";
            this.btnHexadecimal.UseVisualStyleBackColor = true;
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(322, 137);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(75, 23);
            this.btnBinaire.TabIndex = 3;
            this.btnBinaire.Text = "Binaire";
            this.btnBinaire.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Binaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hexadécimal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(522, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Décimal";
            // 
            // txtbinaire
            // 
            this.txtbinaire.Location = new System.Drawing.Point(170, 133);
            this.txtbinaire.Name = "txtbinaire";
            this.txtbinaire.Size = new System.Drawing.Size(100, 20);
            this.txtbinaire.TabIndex = 6;
            // 
            // txthexadecimal
            // 
            this.txthexadecimal.Location = new System.Drawing.Point(322, 133);
            this.txthexadecimal.Name = "txthexadecimal";
            this.txthexadecimal.Size = new System.Drawing.Size(100, 20);
            this.txthexadecimal.TabIndex = 7;
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(492, 133);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(100, 20);
            this.txtDecimal.TabIndex = 8;
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(642, 361);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(75, 23);
            this.btnSortie.TabIndex = 9;
            this.btnSortie.Text = "Sortie ";
            this.btnSortie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.txthexadecimal);
            this.Controls.Add(this.txtbinaire);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.Button btnHexadecimal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbinaire;
        private System.Windows.Forms.TextBox txthexadecimal;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.Button btnSortie;
    }
}


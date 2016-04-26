namespace Port_Classe
{
    partial class FrmGestionPort
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbPort = new System.Windows.Forms.GroupBox();
            this.lbNbStockage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreerPort = new System.Windows.Forms.Button();
            this.grbStockage = new System.Windows.Forms.GroupBox();
            this.comboBoxAfficherStockage = new System.Windows.Forms.ComboBox();
            this.CapaciteCreer = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAfficherStockage = new System.Windows.Forms.Button();
            this.btnCreerStockage = new System.Windows.Forms.Button();
            this.grbNavire = new System.Windows.Forms.GroupBox();
            this.txQte = new System.Windows.Forms.TextBox();
            this.txFret = new System.Windows.Forms.TextBox();
            this.txNom = new System.Windows.Forms.TextBox();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAfficherNomBateau = new System.Windows.Forms.Button();
            this.btnCreerNavire = new System.Windows.Forms.Button();
            this.grbAction = new System.Windows.Forms.GroupBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnDecharger = new System.Windows.Forms.Button();
            this.grbPort.SuspendLayout();
            this.grbStockage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapaciteCreer)).BeginInit();
            this.grbNavire.SuspendLayout();
            this.grbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les Classes et les Winforms";
            // 
            // grbPort
            // 
            this.grbPort.Controls.Add(this.lbNbStockage);
            this.grbPort.Controls.Add(this.label2);
            this.grbPort.Controls.Add(this.btnCreerPort);
            this.grbPort.Location = new System.Drawing.Point(38, 80);
            this.grbPort.Name = "grbPort";
            this.grbPort.Size = new System.Drawing.Size(654, 118);
            this.grbPort.TabIndex = 1;
            this.grbPort.TabStop = false;
            this.grbPort.Text = "Port";
            // 
            // lbNbStockage
            // 
            this.lbNbStockage.AutoSize = true;
            this.lbNbStockage.Location = new System.Drawing.Point(304, 46);
            this.lbNbStockage.Name = "lbNbStockage";
            this.lbNbStockage.Size = new System.Drawing.Size(0, 13);
            this.lbNbStockage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NbStockages";
            // 
            // btnCreerPort
            // 
            this.btnCreerPort.Location = new System.Drawing.Point(38, 37);
            this.btnCreerPort.Name = "btnCreerPort";
            this.btnCreerPort.Size = new System.Drawing.Size(118, 34);
            this.btnCreerPort.TabIndex = 0;
            this.btnCreerPort.Text = "Créer un Port";
            this.btnCreerPort.UseVisualStyleBackColor = true;
            this.btnCreerPort.Click += new System.EventHandler(this.btnCreerPort_Click);
            // 
            // grbStockage
            // 
            this.grbStockage.Controls.Add(this.comboBoxAfficherStockage);
            this.grbStockage.Controls.Add(this.CapaciteCreer);
            this.grbStockage.Controls.Add(this.label4);
            this.grbStockage.Controls.Add(this.btnAfficherStockage);
            this.grbStockage.Controls.Add(this.btnCreerStockage);
            this.grbStockage.Enabled = false;
            this.grbStockage.Location = new System.Drawing.Point(38, 219);
            this.grbStockage.Name = "grbStockage";
            this.grbStockage.Size = new System.Drawing.Size(654, 131);
            this.grbStockage.TabIndex = 2;
            this.grbStockage.TabStop = false;
            this.grbStockage.Text = "Stockage";
            // 
            // comboBoxAfficherStockage
            // 
            this.comboBoxAfficherStockage.FormattingEnabled = true;
            this.comboBoxAfficherStockage.Location = new System.Drawing.Point(38, 104);
            this.comboBoxAfficherStockage.Name = "comboBoxAfficherStockage";
            this.comboBoxAfficherStockage.Size = new System.Drawing.Size(195, 21);
            this.comboBoxAfficherStockage.TabIndex = 5;
            // 
            // CapaciteCreer
            // 
            this.CapaciteCreer.Location = new System.Drawing.Point(90, 39);
            this.CapaciteCreer.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CapaciteCreer.Name = "CapaciteCreer";
            this.CapaciteCreer.Size = new System.Drawing.Size(84, 20);
            this.CapaciteCreer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacité";
            // 
            // btnAfficherStockage
            // 
            this.btnAfficherStockage.Location = new System.Drawing.Point(38, 74);
            this.btnAfficherStockage.Name = "btnAfficherStockage";
            this.btnAfficherStockage.Size = new System.Drawing.Size(136, 23);
            this.btnAfficherStockage.TabIndex = 2;
            this.btnAfficherStockage.Text = "Afficher les Stockages";
            this.btnAfficherStockage.UseVisualStyleBackColor = true;
            this.btnAfficherStockage.Click += new System.EventHandler(this.btnAfficherStockage_Click);
            // 
            // btnCreerStockage
            // 
            this.btnCreerStockage.Location = new System.Drawing.Point(214, 39);
            this.btnCreerStockage.Name = "btnCreerStockage";
            this.btnCreerStockage.Size = new System.Drawing.Size(125, 23);
            this.btnCreerStockage.TabIndex = 1;
            this.btnCreerStockage.Text = "Créer un Stockage";
            this.btnCreerStockage.UseVisualStyleBackColor = true;
            this.btnCreerStockage.Click += new System.EventHandler(this.btnCreerStockage_Click);
            // 
            // grbNavire
            // 
            this.grbNavire.Controls.Add(this.txQte);
            this.grbNavire.Controls.Add(this.txFret);
            this.grbNavire.Controls.Add(this.txNom);
            this.grbNavire.Controls.Add(this.txNumero);
            this.grbNavire.Controls.Add(this.label8);
            this.grbNavire.Controls.Add(this.label7);
            this.grbNavire.Controls.Add(this.label6);
            this.grbNavire.Controls.Add(this.label5);
            this.grbNavire.Controls.Add(this.btnAfficherNomBateau);
            this.grbNavire.Controls.Add(this.btnCreerNavire);
            this.grbNavire.Enabled = false;
            this.grbNavire.Location = new System.Drawing.Point(38, 371);
            this.grbNavire.Name = "grbNavire";
            this.grbNavire.Size = new System.Drawing.Size(654, 139);
            this.grbNavire.TabIndex = 3;
            this.grbNavire.TabStop = false;
            this.grbNavire.Text = "Navire";
            // 
            // txQte
            // 
            this.txQte.Location = new System.Drawing.Point(98, 104);
            this.txQte.Name = "txQte";
            this.txQte.Size = new System.Drawing.Size(216, 20);
            this.txQte.TabIndex = 11;
            // 
            // txFret
            // 
            this.txFret.Location = new System.Drawing.Point(98, 78);
            this.txFret.Name = "txFret";
            this.txFret.Size = new System.Drawing.Size(216, 20);
            this.txFret.TabIndex = 10;
            // 
            // txNom
            // 
            this.txNom.Location = new System.Drawing.Point(98, 53);
            this.txNom.Name = "txNom";
            this.txNom.Size = new System.Drawing.Size(216, 20);
            this.txNom.TabIndex = 9;
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(98, 29);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(216, 20);
            this.txNumero.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Qté";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Frêt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Numéro";
            // 
            // btnAfficherNomBateau
            // 
            this.btnAfficherNomBateau.Location = new System.Drawing.Point(401, 80);
            this.btnAfficherNomBateau.Name = "btnAfficherNomBateau";
            this.btnAfficherNomBateau.Size = new System.Drawing.Size(117, 44);
            this.btnAfficherNomBateau.TabIndex = 4;
            this.btnAfficherNomBateau.Text = "Voir Nom du Bateau";
            this.btnAfficherNomBateau.UseVisualStyleBackColor = true;
            this.btnAfficherNomBateau.Click += new System.EventHandler(this.btnAfficherNomBateau_Click);
            // 
            // btnCreerNavire
            // 
            this.btnCreerNavire.Location = new System.Drawing.Point(401, 31);
            this.btnCreerNavire.Name = "btnCreerNavire";
            this.btnCreerNavire.Size = new System.Drawing.Size(117, 41);
            this.btnCreerNavire.TabIndex = 3;
            this.btnCreerNavire.Text = "Créer Navire";
            this.btnCreerNavire.UseVisualStyleBackColor = true;
            this.btnCreerNavire.Click += new System.EventHandler(this.btnCreerNavire_Click);
            // 
            // grbAction
            // 
            this.grbAction.Controls.Add(this.btnQuitter);
            this.grbAction.Controls.Add(this.btnDecharger);
            this.grbAction.Enabled = false;
            this.grbAction.Location = new System.Drawing.Point(38, 516);
            this.grbAction.Name = "grbAction";
            this.grbAction.Size = new System.Drawing.Size(654, 118);
            this.grbAction.TabIndex = 4;
            this.grbAction.TabStop = false;
            this.grbAction.Text = "Action";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(214, 43);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(100, 38);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnDecharger
            // 
            this.btnDecharger.Location = new System.Drawing.Point(66, 43);
            this.btnDecharger.Name = "btnDecharger";
            this.btnDecharger.Size = new System.Drawing.Size(90, 38);
            this.btnDecharger.TabIndex = 5;
            this.btnDecharger.Text = "Décharger";
            this.btnDecharger.UseVisualStyleBackColor = true;
            this.btnDecharger.Click += new System.EventHandler(this.btnDecharger_Click);
            // 
            // FrmGestionPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 657);
            this.Controls.Add(this.grbAction);
            this.Controls.Add(this.grbNavire);
            this.Controls.Add(this.grbStockage);
            this.Controls.Add(this.grbPort);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionPort";
            this.Text = "Mon petit port";
            this.grbPort.ResumeLayout(false);
            this.grbPort.PerformLayout();
            this.grbStockage.ResumeLayout(false);
            this.grbStockage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CapaciteCreer)).EndInit();
            this.grbNavire.ResumeLayout(false);
            this.grbNavire.PerformLayout();
            this.grbAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbPort;
        private System.Windows.Forms.Label lbNbStockage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreerPort;
        private System.Windows.Forms.GroupBox grbStockage;
        private System.Windows.Forms.ComboBox comboBoxAfficherStockage;
        private System.Windows.Forms.NumericUpDown CapaciteCreer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAfficherStockage;
        private System.Windows.Forms.Button btnCreerStockage;
        private System.Windows.Forms.GroupBox grbNavire;
        private System.Windows.Forms.TextBox txQte;
        private System.Windows.Forms.TextBox txFret;
        private System.Windows.Forms.TextBox txNom;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAfficherNomBateau;
        private System.Windows.Forms.Button btnCreerNavire;
        private System.Windows.Forms.GroupBox grbAction;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnDecharger;
    }
}


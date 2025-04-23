namespace GenerateurDeScenario
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
            this.btnGenerer = new System.Windows.Forms.Button();
            this.rtbScenario = new System.Windows.Forms.RichTextBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnGenerer
            // 
            this.btnGenerer.Location = new System.Drawing.Point(288, 31);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(168, 49);
            this.btnGenerer.TabIndex = 0;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // rtbScenario
            // 
            this.rtbScenario.Location = new System.Drawing.Point(162, 203);
            this.rtbScenario.Name = "rtbScenario";
            this.rtbScenario.Size = new System.Drawing.Size(440, 186);
            this.rtbScenario.TabIndex = 1;
            this.rtbScenario.Text = "";
            // 
            // cbStyle
            // 
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Classique",
            "Absurde",
            "Thriller",
            "Fantastique",
            "SF"});
            this.cbStyle.Location = new System.Drawing.Point(310, 128);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(121, 28);
            this.cbStyle.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.rtbScenario);
            this.Controls.Add(this.btnGenerer);
            this.Name = "Form1";
            this.Text = "Générateur de scénario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.RichTextBox rtbScenario;
        private System.Windows.Forms.ComboBox cbStyle;
    }
}


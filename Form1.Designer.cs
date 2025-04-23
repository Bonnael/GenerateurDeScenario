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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGenerer = new System.Windows.Forms.Button();
            this.rtbScenario = new System.Windows.Forms.RichTextBox();
            this.cbStyle = new System.Windows.Forms.ComboBox();
            this.btnCopier = new System.Windows.Forms.Button();
            this.lblChoix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerer
            // 
            this.btnGenerer.BackColor = System.Drawing.Color.LightCyan;
            this.btnGenerer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerer.Location = new System.Drawing.Point(146, 63);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(181, 77);
            this.btnGenerer.TabIndex = 0;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = false;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // rtbScenario
            // 
            this.rtbScenario.BackColor = System.Drawing.Color.Azure;
            this.rtbScenario.Font = new System.Drawing.Font("Alef", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbScenario.Location = new System.Drawing.Point(73, 162);
            this.rtbScenario.Name = "rtbScenario";
            this.rtbScenario.Size = new System.Drawing.Size(621, 225);
            this.rtbScenario.TabIndex = 1;
            this.rtbScenario.Text = "";
            // 
            // cbStyle
            // 
            this.cbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStyle.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStyle.FormattingEnabled = true;
            this.cbStyle.Items.AddRange(new object[] {
            "Classique",
            "Absurde",
            "Thriller",
            "Fantastique",
            "SF"});
            this.cbStyle.Location = new System.Drawing.Point(349, 87);
            this.cbStyle.Name = "cbStyle";
            this.cbStyle.Size = new System.Drawing.Size(251, 39);
            this.cbStyle.TabIndex = 2;
            // 
            // btnCopier
            // 
            this.btnCopier.BackColor = System.Drawing.Color.LightCyan;
            this.btnCopier.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopier.Location = new System.Drawing.Point(307, 415);
            this.btnCopier.Name = "btnCopier";
            this.btnCopier.Size = new System.Drawing.Size(125, 59);
            this.btnCopier.TabIndex = 3;
            this.btnCopier.Text = "Copier";
            this.btnCopier.UseVisualStyleBackColor = false;
            this.btnCopier.Click += new System.EventHandler(this.btnCopier_Click);
            // 
            // lblChoix
            // 
            this.lblChoix.AutoSize = true;
            this.lblChoix.Font = new System.Drawing.Font("MV Boli", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoix.Location = new System.Drawing.Point(345, 63);
            this.lblChoix.Name = "lblChoix";
            this.lblChoix.Size = new System.Drawing.Size(136, 21);
            this.lblChoix.TabIndex = 4;
            this.lblChoix.Text = "Choisis le style :";
            this.lblChoix.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.lblChoix);
            this.Controls.Add(this.btnCopier);
            this.Controls.Add(this.cbStyle);
            this.Controls.Add(this.rtbScenario);
            this.Controls.Add(this.btnGenerer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Générateur de scénario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.RichTextBox rtbScenario;
        private System.Windows.Forms.ComboBox cbStyle;
        private System.Windows.Forms.Button btnCopier;
        private System.Windows.Forms.Label lblChoix;
    }
}


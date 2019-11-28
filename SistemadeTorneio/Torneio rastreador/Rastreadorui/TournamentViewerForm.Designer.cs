namespace TrackerUI
{
    partial class VersusLabel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FaseSuspensa = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ListadeConfrontos = new System.Windows.Forms.ListBox();
            this.NomePrimeiroTime = new System.Windows.Forms.Label();
            this.PlacarPrimeiroTimeLabel = new System.Windows.Forms.Label();
            this.ValorPlacarPrimeiroTime = new System.Windows.Forms.TextBox();
            this.PlacarSegundoTimeLabel = new System.Windows.Forms.Label();
            this.NomeSegundoTime = new System.Windows.Forms.Label();
            this.ValorPlacarSegundoTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.headerLabel.Location = new System.Drawing.Point(28, 32);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(142, 47);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Torneio:";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(163, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 47);
            this.label2.TabIndex = 1;
            this.label2.Text = "<nenhum>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(41, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fase";
            // 
            // FaseSuspensa
            // 
            this.FaseSuspensa.FormattingEnabled = true;
            this.FaseSuspensa.Location = new System.Drawing.Point(117, 90);
            this.FaseSuspensa.Name = "FaseSuspensa";
            this.FaseSuspensa.Size = new System.Drawing.Size(209, 38);
            this.FaseSuspensa.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(117, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 41);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Não jogado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ListadeConfrontos
            // 
            this.ListadeConfrontos.FormattingEnabled = true;
            this.ListadeConfrontos.ItemHeight = 30;
            this.ListadeConfrontos.Location = new System.Drawing.Point(36, 195);
            this.ListadeConfrontos.Name = "ListadeConfrontos";
            this.ListadeConfrontos.Size = new System.Drawing.Size(305, 334);
            this.ListadeConfrontos.TabIndex = 5;
            // 
            // NomePrimeiroTime
            // 
            this.NomePrimeiroTime.AutoSize = true;
            this.NomePrimeiroTime.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomePrimeiroTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomePrimeiroTime.Location = new System.Drawing.Point(373, 181);
            this.NomePrimeiroTime.Name = "NomePrimeiroTime";
            this.NomePrimeiroTime.Size = new System.Drawing.Size(226, 40);
            this.NomePrimeiroTime.TabIndex = 6;
            this.NomePrimeiroTime.Text = "<Primeiro Time>";
            // 
            // PlacarPrimeiroTimeLabel
            // 
            this.PlacarPrimeiroTimeLabel.AutoSize = true;
            this.PlacarPrimeiroTimeLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarPrimeiroTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlacarPrimeiroTimeLabel.Location = new System.Drawing.Point(373, 236);
            this.PlacarPrimeiroTimeLabel.Name = "PlacarPrimeiroTimeLabel";
            this.PlacarPrimeiroTimeLabel.Size = new System.Drawing.Size(90, 40);
            this.PlacarPrimeiroTimeLabel.TabIndex = 7;
            this.PlacarPrimeiroTimeLabel.Text = "Placar";
            // 
            // ValorPlacarPrimeiroTime
            // 
            this.ValorPlacarPrimeiroTime.Location = new System.Drawing.Point(469, 236);
            this.ValorPlacarPrimeiroTime.Name = "ValorPlacarPrimeiroTime";
            this.ValorPlacarPrimeiroTime.Size = new System.Drawing.Size(100, 35);
            this.ValorPlacarPrimeiroTime.TabIndex = 8;
            // 
            // PlacarSegundoTimeLabel
            // 
            this.PlacarSegundoTimeLabel.AutoSize = true;
            this.PlacarSegundoTimeLabel.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacarSegundoTimeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlacarSegundoTimeLabel.Location = new System.Drawing.Point(390, 377);
            this.PlacarSegundoTimeLabel.Name = "PlacarSegundoTimeLabel";
            this.PlacarSegundoTimeLabel.Size = new System.Drawing.Size(90, 40);
            this.PlacarSegundoTimeLabel.TabIndex = 10;
            this.PlacarSegundoTimeLabel.Text = "Placar";
            // 
            // NomeSegundoTime
            // 
            this.NomeSegundoTime.AutoSize = true;
            this.NomeSegundoTime.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeSegundoTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NomeSegundoTime.Location = new System.Drawing.Point(385, 325);
            this.NomeSegundoTime.Name = "NomeSegundoTime";
            this.NomeSegundoTime.Size = new System.Drawing.Size(232, 40);
            this.NomeSegundoTime.TabIndex = 9;
            this.NomeSegundoTime.Text = "<Segundo Time>";
            // 
            // ValorPlacarSegundoTime
            // 
            this.ValorPlacarSegundoTime.Location = new System.Drawing.Point(469, 377);
            this.ValorPlacarSegundoTime.Name = "ValorPlacarSegundoTime";
            this.ValorPlacarSegundoTime.Size = new System.Drawing.Size(100, 35);
            this.ValorPlacarSegundoTime.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(462, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "VS";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(609, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 13;
            this.button1.Text = "Score";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VersusLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 615);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorPlacarSegundoTime);
            this.Controls.Add(this.PlacarSegundoTimeLabel);
            this.Controls.Add(this.NomeSegundoTime);
            this.Controls.Add(this.ValorPlacarPrimeiroTime);
            this.Controls.Add(this.PlacarPrimeiroTimeLabel);
            this.Controls.Add(this.NomePrimeiroTime);
            this.Controls.Add(this.ListadeConfrontos);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.FaseSuspensa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "VersusLabel";
            this.Text = "Torneio";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FaseSuspensa;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox ListadeConfrontos;
        private System.Windows.Forms.Label NomePrimeiroTime;
        private System.Windows.Forms.Label PlacarPrimeiroTimeLabel;
        private System.Windows.Forms.TextBox ValorPlacarPrimeiroTime;
        private System.Windows.Forms.Label PlacarSegundoTimeLabel;
        private System.Windows.Forms.Label NomeSegundoTime;
        private System.Windows.Forms.TextBox ValorPlacarSegundoTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}


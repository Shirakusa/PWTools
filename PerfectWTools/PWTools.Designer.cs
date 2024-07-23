namespace PerfectWTools
{
	partial class PWTools
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.Personagens = new System.Windows.Forms.Label();
			this.ExecuteButton = new System.Windows.Forms.Button();
			this.CreateButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
			this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(1, 55);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(696, 273);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// Personagens
			// 
			this.Personagens.AutoSize = true;
			this.Personagens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.Personagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Personagens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.Personagens.Location = new System.Drawing.Point(-3, 28);
			this.Personagens.Name = "Personagens";
			this.Personagens.Size = new System.Drawing.Size(133, 24);
			this.Personagens.TabIndex = 1;
			this.Personagens.Text = "Personagens";
			this.Personagens.Click += new System.EventHandler(this.Personagens_Click);
			// 
			// ExecuteButton
			// 
			this.ExecuteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(181)))), ((int)(((byte)(91)))));
			this.ExecuteButton.FlatAppearance.BorderSize = 0;
			this.ExecuteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ExecuteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ExecuteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.ExecuteButton.Location = new System.Drawing.Point(586, 357);
			this.ExecuteButton.Name = "ExecuteButton";
			this.ExecuteButton.Size = new System.Drawing.Size(100, 30);
			this.ExecuteButton.TabIndex = 2;
			this.ExecuteButton.Text = "Executar";
			this.ExecuteButton.UseVisualStyleBackColor = false;
			this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
			// 
			// CreateButton
			// 
			this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(111)))), ((int)(((byte)(181)))));
			this.CreateButton.FlatAppearance.BorderSize = 0;
			this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateButton.ForeColor = System.Drawing.Color.White;
			this.CreateButton.Location = new System.Drawing.Point(480, 357);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(100, 30);
			this.CreateButton.TabIndex = 3;
			this.CreateButton.Text = "Criar";
			this.CreateButton.UseVisualStyleBackColor = false;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// PWTools
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
			this.ClientSize = new System.Drawing.Size(698, 415);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.ExecuteButton);
			this.Controls.Add(this.Personagens);
			this.Controls.Add(this.listBox1);
			this.MaximizeBox = false;
			this.Name = "PWTools";
			this.Text = "PWTools";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label Personagens;
		private System.Windows.Forms.Button ExecuteButton;
		private System.Windows.Forms.Button CreateButton;
	}
}


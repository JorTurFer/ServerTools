namespace ServerTools.Items
{
  partial class ItemsReaderForm
    {    

        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.button1 = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.cb_players = new System.Windows.Forms.ComboBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.cb_Action = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(31, 28);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Abrir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 69);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(776, 369);
      this.dataGridView1.TabIndex = 1;
      // 
      // cb_players
      // 
      this.cb_players.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cb_players.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cb_players.FormattingEnabled = true;
      this.cb_players.Location = new System.Drawing.Point(190, 28);
      this.cb_players.Name = "cb_players";
      this.cb_players.Size = new System.Drawing.Size(121, 21);
      this.cb_players.TabIndex = 2;
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(329, 28);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 3;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(610, 11);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Buscar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(610, 40);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(75, 23);
      this.button3.TabIndex = 5;
      this.button3.Text = "Reset";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // cb_Action
      // 
      this.cb_Action.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cb_Action.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cb_Action.FormattingEnabled = true;
      this.cb_Action.Location = new System.Drawing.Point(447, 28);
      this.cb_Action.Name = "cb_Action";
      this.cb_Action.Size = new System.Drawing.Size(121, 21);
      this.cb_Action.TabIndex = 6;
      // 
      // ItemsReader
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.cb_Action);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.cb_players);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Name = "ItemsReader";
      this.Text = "Items Tool";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_players;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cb_Action;
    }
}


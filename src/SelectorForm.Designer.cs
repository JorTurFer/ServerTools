namespace ServerTools
{
  partial class SelectorForm
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
      this.btn_Items = new System.Windows.Forms.Button();
      this.btn_Arenas = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_Items
      // 
      this.btn_Items.Location = new System.Drawing.Point(23, 33);
      this.btn_Items.Name = "btn_Items";
      this.btn_Items.Size = new System.Drawing.Size(75, 23);
      this.btn_Items.TabIndex = 0;
      this.btn_Items.Text = "Items";
      this.btn_Items.UseVisualStyleBackColor = true;
      this.btn_Items.Click += new System.EventHandler(this.btn_Items_Click);
      // 
      // btn_Arenas
      // 
      this.btn_Arenas.Location = new System.Drawing.Point(138, 33);
      this.btn_Arenas.Name = "btn_Arenas";
      this.btn_Arenas.Size = new System.Drawing.Size(75, 23);
      this.btn_Arenas.TabIndex = 1;
      this.btn_Arenas.Text = "Arenas";
      this.btn_Arenas.UseVisualStyleBackColor = true;
      this.btn_Arenas.Click += new System.EventHandler(this.btn_Arenas_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(250, 33);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "BGs";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // SelectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(351, 88);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btn_Arenas);
      this.Controls.Add(this.btn_Items);
      this.Name = "SelectorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Selector";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_Items;
    private System.Windows.Forms.Button btn_Arenas;
    private System.Windows.Forms.Button button2;
  }
}


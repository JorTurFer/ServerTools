namespace ServerTools.BGs
{
  partial class BGsReaderForm
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
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.cb_PreFilter = new System.Windows.Forms.CheckBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.cb_Date = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(426, 22);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 5;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(11, 71);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(779, 360);
      this.dataGridView1.TabIndex = 4;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(22, 20);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "Abrir";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // cb_PreFilter
      // 
      this.cb_PreFilter.AutoSize = true;
      this.cb_PreFilter.Location = new System.Drawing.Point(103, 12);
      this.cb_PreFilter.Name = "cb_PreFilter";
      this.cb_PreFilter.Size = new System.Drawing.Size(64, 17);
      this.cb_PreFilter.TabIndex = 6;
      this.cb_PreFilter.Text = "PreFilter";
      this.cb_PreFilter.UseVisualStyleBackColor = true;
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Location = new System.Drawing.Point(190, 21);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
      this.dateTimePicker1.TabIndex = 7;
      // 
      // cb_Date
      // 
      this.cb_Date.AutoSize = true;
      this.cb_Date.Location = new System.Drawing.Point(103, 35);
      this.cb_Date.Name = "cb_Date";
      this.cb_Date.Size = new System.Drawing.Size(71, 17);
      this.cb_Date.TabIndex = 8;
      this.cb_Date.Text = "WithDate";
      this.cb_Date.UseVisualStyleBackColor = true;
      // 
      // BGsReaderForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.cb_Date);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.cb_PreFilter);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button1);
      this.Name = "BGsReaderForm";
      this.Text = "BGsReaderForm";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.CheckBox cb_PreFilter;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.CheckBox cb_Date;
  }
}
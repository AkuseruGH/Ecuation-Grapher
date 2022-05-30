namespace WindowsFormsApp1
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datosBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chartA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.ecuacionBox = new System.Windows.Forms.TextBox();
            this.button_Calcular = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(44, 119);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(831, 409);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.datosBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(823, 383);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos";
            // 
            // datosBox
            // 
            this.datosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datosBox.Location = new System.Drawing.Point(30, 23);
            this.datosBox.Name = "datosBox";
            this.datosBox.Size = new System.Drawing.Size(256, 334);
            this.datosBox.TabIndex = 0;
            this.datosBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chartA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(823, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gráfica";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chartA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartA.Legends.Add(legend1);
            this.chartA.Location = new System.Drawing.Point(25, 6);
            this.chartA.Name = "chartA";
            this.chartA.Size = new System.Drawing.Size(774, 381);
            this.chartA.TabIndex = 0;
            this.chartA.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Formula    Y=";
            // 
            // ecuacionBox
            // 
            this.ecuacionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecuacionBox.Location = new System.Drawing.Point(174, 53);
            this.ecuacionBox.Name = "ecuacionBox";
            this.ecuacionBox.Size = new System.Drawing.Size(209, 29);
            this.ecuacionBox.TabIndex = 2;
            // 
            // button_Calcular
            // 
            this.button_Calcular.Location = new System.Drawing.Point(401, 59);
            this.button_Calcular.Name = "button_Calcular";
            this.button_Calcular.Size = new System.Drawing.Size(75, 23);
            this.button_Calcular.TabIndex = 3;
            this.button_Calcular.Text = "Calcular";
            this.button_Calcular.UseVisualStyleBackColor = true;
            this.button_Calcular.Click += new System.EventHandler(this.button_Calcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 556);
            this.Controls.Add(this.button_Calcular);
            this.Controls.Add(this.ecuacionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox datosBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ecuacionBox;
        private System.Windows.Forms.Button button_Calcular;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartA;
    }
}


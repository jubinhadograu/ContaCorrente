namespace ContaCorrente
{
    partial class Form1
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
            this.lblCorretista1 = new System.Windows.Forms.Label();
            this.lblCorretista2 = new System.Windows.Forms.Label();
            this.lblSaldoCorretista1 = new System.Windows.Forms.Label();
            this.lblSaldoCorretista2 = new System.Windows.Forms.Label();
            this.btnVerSaldoC1 = new System.Windows.Forms.Button();
            this.btnVerSaldoC2 = new System.Windows.Forms.Button();
            this.btnAddC1 = new System.Windows.Forms.Button();
            this.btnAddC2 = new System.Windows.Forms.Button();
            this.btnSubC1 = new System.Windows.Forms.Button();
            this.btnSubC2 = new System.Windows.Forms.Button();
            this.btnTransC1ToC2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCorretista1
            // 
            this.lblCorretista1.AutoSize = true;
            this.lblCorretista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretista1.Location = new System.Drawing.Point(80, 23);
            this.lblCorretista1.Name = "lblCorretista1";
            this.lblCorretista1.Size = new System.Drawing.Size(70, 31);
            this.lblCorretista1.TabIndex = 0;
            this.lblCorretista1.Text = "Julia";
            // 
            // lblCorretista2
            // 
            this.lblCorretista2.AutoSize = true;
            this.lblCorretista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorretista2.Location = new System.Drawing.Point(364, 23);
            this.lblCorretista2.Name = "lblCorretista2";
            this.lblCorretista2.Size = new System.Drawing.Size(139, 31);
            this.lblCorretista2.TabIndex = 1;
            this.lblCorretista2.Text = "Geovanna";
            this.lblCorretista2.Click += new System.EventHandler(this.lblCorretista2_Click);
            // 
            // lblSaldoCorretista1
            // 
            this.lblSaldoCorretista1.AutoSize = true;
            this.lblSaldoCorretista1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCorretista1.Location = new System.Drawing.Point(80, 117);
            this.lblSaldoCorretista1.Name = "lblSaldoCorretista1";
            this.lblSaldoCorretista1.Size = new System.Drawing.Size(149, 31);
            this.lblSaldoCorretista1.TabIndex = 2;
            this.lblSaldoCorretista1.Text = "---------------";
            this.lblSaldoCorretista1.Click += new System.EventHandler(this.lblSSaldoCorretista1_Click);
            // 
            // lblSaldoCorretista2
            // 
            this.lblSaldoCorretista2.AutoSize = true;
            this.lblSaldoCorretista2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoCorretista2.Location = new System.Drawing.Point(370, 117);
            this.lblSaldoCorretista2.Name = "lblSaldoCorretista2";
            this.lblSaldoCorretista2.Size = new System.Drawing.Size(149, 31);
            this.lblSaldoCorretista2.TabIndex = 3;
            this.lblSaldoCorretista2.Text = "---------------";
            // 
            // btnVerSaldoC1
            // 
            this.btnVerSaldoC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSaldoC1.Location = new System.Drawing.Point(86, 287);
            this.btnVerSaldoC1.Name = "btnVerSaldoC1";
            this.btnVerSaldoC1.Size = new System.Drawing.Size(167, 64);
            this.btnVerSaldoC1.TabIndex = 4;
            this.btnVerSaldoC1.Text = "Ver Saldo";
            this.btnVerSaldoC1.UseVisualStyleBackColor = true;
            this.btnVerSaldoC1.Click += new System.EventHandler(this.btnVerSaldoC1_Click);
            // 
            // btnVerSaldoC2
            // 
            this.btnVerSaldoC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSaldoC2.Location = new System.Drawing.Point(370, 287);
            this.btnVerSaldoC2.Name = "btnVerSaldoC2";
            this.btnVerSaldoC2.Size = new System.Drawing.Size(167, 64);
            this.btnVerSaldoC2.TabIndex = 5;
            this.btnVerSaldoC2.Text = "Ver Saldo";
            this.btnVerSaldoC2.UseVisualStyleBackColor = true;
            this.btnVerSaldoC2.Click += new System.EventHandler(this.btnVerSaldoC2_Click);
            // 
            // btnAddC1
            // 
            this.btnAddC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC1.Location = new System.Drawing.Point(86, 381);
            this.btnAddC1.Name = "btnAddC1";
            this.btnAddC1.Size = new System.Drawing.Size(167, 64);
            this.btnAddC1.TabIndex = 6;
            this.btnAddC1.Text = "+ R$ 100";
            this.btnAddC1.UseVisualStyleBackColor = true;
            this.btnAddC1.Click += new System.EventHandler(this.btnAddC1_Click);
            // 
            // btnAddC2
            // 
            this.btnAddC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddC2.Location = new System.Drawing.Point(370, 381);
            this.btnAddC2.Name = "btnAddC2";
            this.btnAddC2.Size = new System.Drawing.Size(167, 64);
            this.btnAddC2.TabIndex = 7;
            this.btnAddC2.Text = "+ R$ 100";
            this.btnAddC2.UseVisualStyleBackColor = true;
            this.btnAddC2.Click += new System.EventHandler(this.btnAddC2_Click);
            // 
            // btnSubC1
            // 
            this.btnSubC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubC1.Location = new System.Drawing.Point(86, 470);
            this.btnSubC1.Name = "btnSubC1";
            this.btnSubC1.Size = new System.Drawing.Size(167, 64);
            this.btnSubC1.TabIndex = 8;
            this.btnSubC1.Text = "- R$ 100";
            this.btnSubC1.UseVisualStyleBackColor = true;
            this.btnSubC1.Click += new System.EventHandler(this.btnSubC1_Click);
            // 
            // btnSubC2
            // 
            this.btnSubC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubC2.Location = new System.Drawing.Point(370, 470);
            this.btnSubC2.Name = "btnSubC2";
            this.btnSubC2.Size = new System.Drawing.Size(167, 64);
            this.btnSubC2.TabIndex = 9;
            this.btnSubC2.Text = "- R$ 100";
            this.btnSubC2.UseVisualStyleBackColor = true;
            this.btnSubC2.Click += new System.EventHandler(this.btnSubC2_Click);
            // 
            // btnTransC1ToC2
            // 
            this.btnTransC1ToC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransC1ToC2.Location = new System.Drawing.Point(221, 180);
            this.btnTransC1ToC2.Name = "btnTransC1ToC2";
            this.btnTransC1ToC2.Size = new System.Drawing.Size(167, 64);
            this.btnTransC1ToC2.TabIndex = 10;
            this.btnTransC1ToC2.Text = "> R$ 100";
            this.btnTransC1ToC2.UseVisualStyleBackColor = true;
            this.btnTransC1ToC2.Click += new System.EventHandler(this.btnTransC1ToC2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 587);
            this.Controls.Add(this.btnTransC1ToC2);
            this.Controls.Add(this.btnSubC2);
            this.Controls.Add(this.btnSubC1);
            this.Controls.Add(this.btnAddC2);
            this.Controls.Add(this.btnAddC1);
            this.Controls.Add(this.btnVerSaldoC2);
            this.Controls.Add(this.btnVerSaldoC1);
            this.Controls.Add(this.lblSaldoCorretista2);
            this.Controls.Add(this.lblSaldoCorretista1);
            this.Controls.Add(this.lblCorretista2);
            this.Controls.Add(this.lblCorretista1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCorretista1;
        private System.Windows.Forms.Label lblCorretista2;
        private System.Windows.Forms.Label lblSaldoCorretista1;
        private System.Windows.Forms.Label lblSaldoCorretista2;
        private System.Windows.Forms.Button btnVerSaldoC1;
        private System.Windows.Forms.Button btnVerSaldoC2;
        private System.Windows.Forms.Button btnAddC1;
        private System.Windows.Forms.Button btnAddC2;
        private System.Windows.Forms.Button btnSubC1;
        private System.Windows.Forms.Button btnSubC2;
        private System.Windows.Forms.Button btnTransC1ToC2;
    }
}


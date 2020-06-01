namespace CPU
{
    partial class CPU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPU));
            this.label1 = new System.Windows.Forms.Label();
            this.PC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IR = new System.Windows.Forms.TextBox();
            this.AC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memory";
            // 
            // PC
            // 
            this.PC.Location = new System.Drawing.Point(397, 43);
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(100, 20);
            this.PC.TabIndex = 2;
            this.PC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IR";
            // 
            // IR
            // 
            this.IR.Location = new System.Drawing.Point(397, 81);
            this.IR.Name = "IR";
            this.IR.Size = new System.Drawing.Size(100, 20);
            this.IR.TabIndex = 6;
            // 
            // AC
            // 
            this.AC.Location = new System.Drawing.Point(397, 119);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(100, 20);
            this.AC.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "AC";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(363, 239);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(134, 81);
            this.Next.TabIndex = 9;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Memory
            // 
            this.Memory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Memory.Location = new System.Drawing.Point(16, 40);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(289, 280);
            this.Memory.TabIndex = 10;
            this.Memory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Memory_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(549, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 312);
            this.label6.TabIndex = 11;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // CPU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 332);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.IR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PC);
            this.Controls.Add(this.label1);
            this.Name = "CPU";
            this.Text = "CPU";
            ((System.ComponentModel.ISupportInitialize)(this.Memory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IR;
        private System.Windows.Forms.TextBox AC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.DataGridView Memory;
        private System.Windows.Forms.Label label6;
    }
}


namespace ind_Col_3_Kaigorodov
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxVectors = new System.Windows.Forms.ListBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.txtZ1 = new System.Windows.Forms.TextBox();
            this.txtZ2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSum = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSub = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDot = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLength = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCos = new System.Windows.Forms.ToolStripMenuItem();
            this.lblResult = new System.Windows.Forms.Label();
            this.numIndex1 = new System.Windows.Forms.NumericUpDown();
            this.numIndex2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxVectors
            // 
            this.listBoxVectors.FormattingEnabled = true;
            this.listBoxVectors.ItemHeight = 25;
            this.listBoxVectors.Location = new System.Drawing.Point(114, 92);
            this.listBoxVectors.Name = "listBoxVectors";
            this.listBoxVectors.Size = new System.Drawing.Size(548, 79);
            this.listBoxVectors.TabIndex = 0;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(114, 405);
            this.txtX1.Name = "txtX1";
            this.txtX1.Size = new System.Drawing.Size(100, 31);
            this.txtX1.TabIndex = 1;
            this.txtX1.Text = "0";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(424, 405);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 31);
            this.txtY1.TabIndex = 2;
            this.txtY1.Text = "0";
            // 
            // txtZ1
            // 
            this.txtZ1.Location = new System.Drawing.Point(764, 405);
            this.txtZ1.Name = "txtZ1";
            this.txtZ1.Size = new System.Drawing.Size(100, 31);
            this.txtZ1.TabIndex = 3;
            this.txtZ1.Text = "0";
            // 
            // txtZ2
            // 
            this.txtZ2.Location = new System.Drawing.Point(764, 494);
            this.txtZ2.Name = "txtZ2";
            this.txtZ2.Size = new System.Drawing.Size(100, 31);
            this.txtZ2.TabIndex = 6;
            this.txtZ2.Text = "0";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(424, 494);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 31);
            this.txtY2.TabIndex = 5;
            this.txtY2.Text = "0";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(114, 494);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(100, 31);
            this.txtX2.TabIndex = 4;
            this.txtX2.Text = "1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnSum,
            this.btnSub,
            this.btnDot,
            this.btnLength,
            this.btnCos});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1293, 48);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(223, 38);
            this.btnAdd.Text = "Добавить вектор";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSum
            // 
            this.btnSum.Enabled = false;
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(148, 36);
            this.btnSum.Text = "Сложение";
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnSub
            // 
            this.btnSub.Enabled = false;
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(142, 36);
            this.btnSub.Text = "Вычтание";
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDot
            // 
            this.btnDot.Enabled = false;
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(320, 36);
            this.btnDot.Text = "Скалярное произведение";
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnLength
            // 
            this.btnLength.Enabled = false;
            this.btnLength.Name = "btnLength";
            this.btnLength.Size = new System.Drawing.Size(199, 36);
            this.btnLength.Text = "Длина вектора";
            this.btnLength.Click += new System.EventHandler(this.btnLength_Click);
            // 
            // btnCos
            // 
            this.btnCos.Enabled = false;
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(177, 36);
            this.btnCos.Text = "Косинус угла";
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(772, 110);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 8;
            // 
            // numIndex1
            // 
            this.numIndex1.Location = new System.Drawing.Point(140, 211);
            this.numIndex1.Name = "numIndex1";
            this.numIndex1.Size = new System.Drawing.Size(120, 31);
            this.numIndex1.TabIndex = 9;
            // 
            // numIndex2
            // 
            this.numIndex2.Location = new System.Drawing.Point(435, 211);
            this.numIndex2.Name = "numIndex2";
            this.numIndex2.Size = new System.Drawing.Size(120, 31);
            this.numIndex2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Индекс 1 вектора";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Индекс 2 вектора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(973, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Координаты начала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(973, 494);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Координаты конца";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 787);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numIndex2);
            this.Controls.Add(this.numIndex1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtZ2);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtZ1);
            this.Controls.Add(this.txtY1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.listBoxVectors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIndex2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxVectors;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.TextBox txtZ1;
        private System.Windows.Forms.TextBox txtZ2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnSum;
        private System.Windows.Forms.ToolStripMenuItem btnSub;
        private System.Windows.Forms.ToolStripMenuItem btnDot;
        private System.Windows.Forms.ToolStripMenuItem btnLength;
        private System.Windows.Forms.ToolStripMenuItem btnCos;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown numIndex1;
        private System.Windows.Forms.NumericUpDown numIndex2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}


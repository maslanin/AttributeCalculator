namespace AttributeCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvl = new System.Windows.Forms.NumericUpDown();
            this.atr3x = new System.Windows.Forms.NumericUpDown();
            this.atr2x = new System.Windows.Forms.NumericUpDown();
            this.atr1x = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.hp = new System.Windows.Forms.NumericUpDown();
            this.mana = new System.Windows.Forms.NumericUpDown();
            this.atk = new System.Windows.Forms.NumericUpDown();
            this.def = new System.Windows.Forms.NumericUpDown();
            this.free = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr3x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr2x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr1x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.def)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.free)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровень персонажа:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Куплено x3 атрибутов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Куплено x2 атрибутов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Куплено x1 атрибутов:";
            // 
            // lvl
            // 
            this.lvl.Location = new System.Drawing.Point(141, 7);
            this.lvl.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.lvl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lvl.Name = "lvl";
            this.lvl.Size = new System.Drawing.Size(52, 20);
            this.lvl.TabIndex = 4;
            this.lvl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // atr3x
            // 
            this.atr3x.Location = new System.Drawing.Point(141, 27);
            this.atr3x.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.atr3x.Name = "atr3x";
            this.atr3x.Size = new System.Drawing.Size(52, 20);
            this.atr3x.TabIndex = 5;
            // 
            // atr2x
            // 
            this.atr2x.Location = new System.Drawing.Point(141, 47);
            this.atr2x.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.atr2x.Name = "atr2x";
            this.atr2x.Size = new System.Drawing.Size(52, 20);
            this.atr2x.TabIndex = 6;
            // 
            // atr1x
            // 
            this.atr1x.Location = new System.Drawing.Point(141, 67);
            this.atr1x.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.atr1x.Name = "atr1x";
            this.atr1x.Size = new System.Drawing.Size(52, 20);
            this.atr1x.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Считать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Всего атрибутов:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(52, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(199, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hitpoints:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mana:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Attack:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Defence:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Свободно:";
            // 
            // hp
            // 
            this.hp.Location = new System.Drawing.Point(256, 7);
            this.hp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(73, 20);
            this.hp.TabIndex = 16;
            // 
            // mana
            // 
            this.mana.Location = new System.Drawing.Point(256, 27);
            this.mana.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.mana.Name = "mana";
            this.mana.Size = new System.Drawing.Size(73, 20);
            this.mana.TabIndex = 17;
            // 
            // atk
            // 
            this.atk.Location = new System.Drawing.Point(256, 47);
            this.atk.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.atk.Name = "atk";
            this.atk.Size = new System.Drawing.Size(73, 20);
            this.atk.TabIndex = 18;
            // 
            // def
            // 
            this.def.Location = new System.Drawing.Point(256, 67);
            this.def.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.def.Name = "def";
            this.def.Size = new System.Drawing.Size(73, 20);
            this.def.TabIndex = 19;
            // 
            // free
            // 
            this.free.Location = new System.Drawing.Point(256, 87);
            this.free.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.free.Name = "free";
            this.free.Size = new System.Drawing.Size(73, 20);
            this.free.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Разница:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 107);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(73, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 149);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.free);
            this.Controls.Add(this.def);
            this.Controls.Add(this.atk);
            this.Controls.Add(this.mana);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.atr1x);
            this.Controls.Add(this.atr2x);
            this.Controls.Add(this.atr3x);
            this.Controls.Add(this.lvl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr3x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr2x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atr1x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.def)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.free)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lvl;
        private System.Windows.Forms.NumericUpDown atr3x;
        private System.Windows.Forms.NumericUpDown atr2x;
        private System.Windows.Forms.NumericUpDown atr1x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown hp;
        private System.Windows.Forms.NumericUpDown mana;
        private System.Windows.Forms.NumericUpDown atk;
        private System.Windows.Forms.NumericUpDown def;
        private System.Windows.Forms.NumericUpDown free;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
    }
}


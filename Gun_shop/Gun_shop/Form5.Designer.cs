namespace Gun_shop
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch3 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.зброяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клієнтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замовленняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(469, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.btnSearch3);
            this.groupBox1.Controls.Add(this.button20);
            this.groupBox1.Controls.Add(this.button19);
            this.groupBox1.Controls.Add(this.textBox18);
            this.groupBox1.Controls.Add(this.textBox17);
            this.groupBox1.Controls.Add(this.textBox15);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox14);
            this.groupBox1.Controls.Add(this.button18);
            this.groupBox1.Controls.Add(this.button17);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(536, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 420);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редагування";
            // 
            // btnSearch3
            // 
            this.btnSearch3.Location = new System.Drawing.Point(108, 292);
            this.btnSearch3.Name = "btnSearch3";
            this.btnSearch3.Size = new System.Drawing.Size(150, 23);
            this.btnSearch3.TabIndex = 14;
            this.btnSearch3.Text = "Пошук за видом зрбої";
            this.btnSearch3.UseVisualStyleBackColor = true;
            this.btnSearch3.Click += new System.EventHandler(this.btnSearch3_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(22, 334);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(80, 25);
            this.button20.TabIndex = 13;
            this.button20.Text = "Змінити";
            this.toolTip1.SetToolTip(this.button20, "Щоб змінити дані потрібно ввести: ");
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(22, 383);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(94, 25);
            this.button19.TabIndex = 12;
            this.button19.Text = "Видалити";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(152, 231);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 11;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(152, 195);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 22);
            this.textBox17.TabIndex = 10;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(152, 100);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 22);
            this.textBox15.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Вид зброї";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Номер телефону";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(152, 58);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 2;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(22, 290);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(80, 25);
            this.button18.TabIndex = 1;
            this.button18.Text = "Додати";
            this.toolTip1.SetToolTip(this.button18, "Щоб додати текст потрібно ввести: Прізвище, Номер телефону, Адресу та вид зброї\r\n" +
        "");
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(166, 387);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(92, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "Вихід";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.зброяToolStripMenuItem,
            this.клієнтиToolStripMenuItem,
            this.замовленняToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // зброяToolStripMenuItem
            // 
            this.зброяToolStripMenuItem.Name = "зброяToolStripMenuItem";
            this.зброяToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.зброяToolStripMenuItem.Text = "Зброя";
            this.зброяToolStripMenuItem.Click += new System.EventHandler(this.зброяToolStripMenuItem_Click);
            // 
            // клієнтиToolStripMenuItem
            // 
            this.клієнтиToolStripMenuItem.Name = "клієнтиToolStripMenuItem";
            this.клієнтиToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.клієнтиToolStripMenuItem.Text = "Клієнти";
            this.клієнтиToolStripMenuItem.Click += new System.EventHandler(this.клієнтиToolStripMenuItem_Click);
            // 
            // замовленняToolStripMenuItem
            // 
            this.замовленняToolStripMenuItem.Name = "замовленняToolStripMenuItem";
            this.замовленняToolStripMenuItem.Size = new System.Drawing.Size(109, 26);
            this.замовленняToolStripMenuItem.Text = "Замовлення";
            this.замовленняToolStripMenuItem.Click += new System.EventHandler(this.замовленняToolStripMenuItem_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(149, 147);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(103, 22);
            this.maskedTextBox1.TabIndex = 15;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Постачальники";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem зброяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клієнтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замовленняToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button btnSearch3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
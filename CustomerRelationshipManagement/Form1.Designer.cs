
namespace CustomerRelationshipManagement
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sawDataGridView = new System.Windows.Forms.DataGridView();
            this.drillDataGridView = new System.Windows.Forms.DataGridView();
            this.hammerDataGridView = new System.Windows.Forms.DataGridView();
            this.nutsDataGridView = new System.Windows.Forms.DataGridView();
            this.sausageDataGridView = new System.Windows.Forms.DataGridView();
            this.cheeseDataGridView = new System.Windows.Forms.DataGridView();
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.toolDataGridView = new System.Windows.Forms.DataGridView();
            this.productTypeDataGridView = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sawDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drillDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sausageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(876, 213);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 34);
            this.button6.TabIndex = 40;
            this.button6.Text = "Изменить данные выделенного клиента";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(876, 271);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 34);
            this.button5.TabIndex = 39;
            this.button5.Text = "Удалить выделенного клиента";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(876, 158);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 34);
            this.button3.TabIndex = 36;
            this.button3.Text = "Добавить нового клиента";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(821, 275);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // sawDataGridView
            // 
            this.sawDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sawDataGridView.Location = new System.Drawing.Point(69, 143);
            this.sawDataGridView.Name = "sawDataGridView";
            this.sawDataGridView.RowHeadersWidth = 51;
            this.sawDataGridView.Size = new System.Drawing.Size(300, 220);
            this.sawDataGridView.TabIndex = 31;
            // 
            // drillDataGridView
            // 
            this.drillDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drillDataGridView.Location = new System.Drawing.Point(69, 143);
            this.drillDataGridView.Name = "drillDataGridView";
            this.drillDataGridView.RowHeadersWidth = 51;
            this.drillDataGridView.Size = new System.Drawing.Size(300, 220);
            this.drillDataGridView.TabIndex = 30;
            // 
            // hammerDataGridView
            // 
            this.hammerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hammerDataGridView.Location = new System.Drawing.Point(69, 143);
            this.hammerDataGridView.Name = "hammerDataGridView";
            this.hammerDataGridView.RowHeadersWidth = 51;
            this.hammerDataGridView.Size = new System.Drawing.Size(300, 220);
            this.hammerDataGridView.TabIndex = 29;
            // 
            // nutsDataGridView
            // 
            this.nutsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nutsDataGridView.Location = new System.Drawing.Point(69, 143);
            this.nutsDataGridView.Name = "nutsDataGridView";
            this.nutsDataGridView.RowHeadersWidth = 51;
            this.nutsDataGridView.Size = new System.Drawing.Size(300, 220);
            this.nutsDataGridView.TabIndex = 28;
            // 
            // sausageDataGridView
            // 
            this.sausageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sausageDataGridView.Location = new System.Drawing.Point(69, 143);
            this.sausageDataGridView.Name = "sausageDataGridView";
            this.sausageDataGridView.RowHeadersWidth = 51;
            this.sausageDataGridView.Size = new System.Drawing.Size(300, 220);
            this.sausageDataGridView.TabIndex = 27;
            // 
            // cheeseDataGridView
            // 
            this.cheeseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cheeseDataGridView.Location = new System.Drawing.Point(69, 143);
            this.cheeseDataGridView.Name = "cheeseDataGridView";
            this.cheeseDataGridView.RowHeadersWidth = 51;
            this.cheeseDataGridView.Size = new System.Drawing.Size(300, 220);
            this.cheeseDataGridView.TabIndex = 26;
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Location = new System.Drawing.Point(69, 143);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.RowHeadersWidth = 51;
            this.foodDataGridView.Size = new System.Drawing.Size(300, 220);
            this.foodDataGridView.TabIndex = 25;
            // 
            // toolDataGridView
            // 
            this.toolDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toolDataGridView.Location = new System.Drawing.Point(69, 143);
            this.toolDataGridView.Name = "toolDataGridView";
            this.toolDataGridView.RowHeadersWidth = 51;
            this.toolDataGridView.Size = new System.Drawing.Size(300, 220);
            this.toolDataGridView.TabIndex = 24;
            // 
            // productTypeDataGridView
            // 
            this.productTypeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypeDataGridView.Location = new System.Drawing.Point(69, 143);
            this.productTypeDataGridView.Name = "productTypeDataGridView";
            this.productTypeDataGridView.RowHeadersWidth = 51;
            this.productTypeDataGridView.Size = new System.Drawing.Size(300, 220);
            this.productTypeDataGridView.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(1060, 79);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 334);
            this.textBox2.TabIndex = 42;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(34, 79);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 43;
            this.button8.Text = "Клиенты";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(114, 79);
            this.button9.Margin = new System.Windows.Forms.Padding(2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(170, 23);
            this.button9.TabIndex = 44;
            this.button9.Text = "Дополнительная информация";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(609, 79);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 23);
            this.button10.TabIndex = 45;
            this.button10.Text = "Применить фильтр";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(734, 79);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(121, 23);
            this.button11.TabIndex = 46;
            this.button11.Text = "Сбросить фильтр";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(1443, 636);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sawDataGridView);
            this.Controls.Add(this.drillDataGridView);
            this.Controls.Add(this.hammerDataGridView);
            this.Controls.Add(this.nutsDataGridView);
            this.Controls.Add(this.sausageDataGridView);
            this.Controls.Add(this.cheeseDataGridView);
            this.Controls.Add(this.foodDataGridView);
            this.Controls.Add(this.toolDataGridView);
            this.Controls.Add(this.productTypeDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sawDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drillDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sausageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheeseDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView sawDataGridView;
        private System.Windows.Forms.DataGridView drillDataGridView;
        private System.Windows.Forms.DataGridView hammerDataGridView;
        private System.Windows.Forms.DataGridView nutsDataGridView;
        private System.Windows.Forms.DataGridView sausageDataGridView;
        private System.Windows.Forms.DataGridView cheeseDataGridView;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.DataGridView toolDataGridView;
        private System.Windows.Forms.DataGridView productTypeDataGridView;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
    }
}


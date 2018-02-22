namespace Лабораторная_Работа__8
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.началоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.передТекущимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вКонецToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКлючуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКлючуToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выбранныйToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.средняяТемператураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискОтрезкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.правкаToolStripMenuItem,
            this.операцииToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(300, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.создатьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.обновитьToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.Выход_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.началоToolStripMenuItem,
            this.передТекущимToolStripMenuItem,
            this.вКонецToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // началоToolStripMenuItem
            // 
            this.началоToolStripMenuItem.Name = "началоToolStripMenuItem";
            this.началоToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.началоToolStripMenuItem.Text = "В начало";
            this.началоToolStripMenuItem.Click += new System.EventHandler(this.началоToolStripMenuItem_Click);
            // 
            // передТекущимToolStripMenuItem
            // 
            this.передТекущимToolStripMenuItem.Name = "передТекущимToolStripMenuItem";
            this.передТекущимToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.передТекущимToolStripMenuItem.Text = "Перед текущим";
            this.передТекущимToolStripMenuItem.Click += new System.EventHandler(this.передТекущимToolStripMenuItem_Click);
            // 
            // вКонецToolStripMenuItem
            // 
            this.вКонецToolStripMenuItem.Name = "вКонецToolStripMenuItem";
            this.вКонецToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.вКонецToolStripMenuItem.Text = "В конец";
            this.вКонецToolStripMenuItem.Click += new System.EventHandler(this.вКонецToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКлючуToolStripMenuItem,
            this.выбранныйToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // поКлючуToolStripMenuItem
            // 
            this.поКлючуToolStripMenuItem.Name = "поКлючуToolStripMenuItem";
            this.поКлючуToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.поКлючуToolStripMenuItem.Text = "По ключу";
            this.поКлючуToolStripMenuItem.ToolTipText = "Ключом является \"День\"";
            this.поКлючуToolStripMenuItem.Click += new System.EventHandler(this.изменитьПоКлючуToolStripMenuItem_Click);
            // 
            // выбранныйToolStripMenuItem
            // 
            this.выбранныйToolStripMenuItem.Name = "выбранныйToolStripMenuItem";
            this.выбранныйToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.выбранныйToolStripMenuItem.Text = "Выбранный";
            this.выбранныйToolStripMenuItem.Click += new System.EventHandler(this.изменитьВыбранныйToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКлючуToolStripMenuItem1,
            this.выбранныйToolStripMenuItem1});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // поКлючуToolStripMenuItem1
            // 
            this.поКлючуToolStripMenuItem1.Name = "поКлючуToolStripMenuItem1";
            this.поКлючуToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.поКлючуToolStripMenuItem1.Text = "По ключу";
            this.поКлючуToolStripMenuItem1.ToolTipText = "Ключом является \"День\"";
            this.поКлючуToolStripMenuItem1.Click += new System.EventHandler(this.удалитьПоКлючуToolStripMenuItem1_Click);
            // 
            // выбранныйToolStripMenuItem1
            // 
            this.выбранныйToolStripMenuItem1.Name = "выбранныйToolStripMenuItem1";
            this.выбранныйToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.выбранныйToolStripMenuItem1.Text = "Выбранный";
            this.выбранныйToolStripMenuItem1.Click += new System.EventHandler(this.выбранныйToolStripMenuItem1_Click);
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.средняяТемператураToolStripMenuItem,
            this.поискОтрезкаToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // средняяТемператураToolStripMenuItem
            // 
            this.средняяТемператураToolStripMenuItem.Name = "средняяТемператураToolStripMenuItem";
            this.средняяТемператураToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.средняяТемператураToolStripMenuItem.Text = "Средняя температура";
            this.средняяТемператураToolStripMenuItem.Click += new System.EventHandler(this.средняяТемператураToolStripMenuItem_Click);
            // 
            // поискОтрезкаToolStripMenuItem
            // 
            this.поискОтрезкаToolStripMenuItem.Name = "поискОтрезкаToolStripMenuItem";
            this.поискОтрезкаToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.поискОтрезкаToolStripMenuItem.Text = "Поиск отрезка";
            this.поискОтрезкаToolStripMenuItem.ToolTipText = "Нахождение самого длинного отрезка между днями с отрицательной температурой";
            this.поискОтрезкаToolStripMenuItem.Click += new System.EventHandler(this.поискОтрезкаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 237);
            this.listBox1.TabIndex = 1;
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem средняяТемператураToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискОтрезкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem началоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem передТекущимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вКонецToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКлючуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выбранныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКлючуToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выбранныйToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
    }
}


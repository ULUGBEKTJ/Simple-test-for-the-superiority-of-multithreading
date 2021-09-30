namespace WindowsFormsApplication3
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Weight = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.D_limit = new System.Windows.Forms.TextBox();
            this.U_limit = new System.Windows.Forms.TextBox();
            this.All_cpu = new System.Windows.Forms.RadioButton();
            this.cpu4 = new System.Windows.Forms.RadioButton();
            this.cpu5 = new System.Windows.Forms.RadioButton();
            this.cpu6 = new System.Windows.Forms.RadioButton();
            this.cpu7 = new System.Windows.Forms.RadioButton();
            this.cpu8 = new System.Windows.Forms.RadioButton();
            this.Plus = new System.Windows.Forms.CheckBox();
            this.Minus = new System.Windows.Forms.CheckBox();
            this.Mult = new System.Windows.Forms.CheckBox();
            this.Rex = new System.Windows.Forms.CheckBox();
            this.size_massiv = new System.Windows.Forms.Label();
            this.Rand = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cpu3 = new System.Windows.Forms.RadioButton();
            this.cpu1 = new System.Windows.Forms.RadioButton();
            this.cpu2 = new System.Windows.Forms.RadioButton();
            this.Oper = new System.Windows.Forms.Label();
            this.Up = new System.Windows.Forms.Label();
            this.Down = new System.Windows.Forms.Label();
            this.UU = new System.Windows.Forms.Label();
            this.DD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.First = new System.Windows.Forms.Button();
            this.Second = new System.Windows.Forms.Button();
            this.Third = new System.Windows.Forms.Button();
            this.Fourth = new System.Windows.Forms.Button();
            this.Fiveth = new System.Windows.Forms.Button();
            this.Sixth = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Sevnth = new System.Windows.Forms.Button();
            this.size_array = new System.Windows.Forms.Button();
            this.randomize = new System.Windows.Forms.Button();
            this.operation = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Weight
            // 
            this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight.Location = new System.Drawing.Point(12, 119);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(100, 23);
            this.Weight.TabIndex = 0;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height.Location = new System.Drawing.Point(12, 145);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(100, 23);
            this.Height.TabIndex = 1;
            // 
            // D_limit
            // 
            this.D_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.D_limit.Location = new System.Drawing.Point(12, 232);
            this.D_limit.Name = "D_limit";
            this.D_limit.Size = new System.Drawing.Size(100, 23);
            this.D_limit.TabIndex = 2;
            // 
            // U_limit
            // 
            this.U_limit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.U_limit.Location = new System.Drawing.Point(12, 206);
            this.U_limit.Name = "U_limit";
            this.U_limit.Size = new System.Drawing.Size(100, 23);
            this.U_limit.TabIndex = 3;
            // 
            // All_cpu
            // 
            this.All_cpu.AutoSize = true;
            this.All_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.All_cpu.Location = new System.Drawing.Point(12, 314);
            this.All_cpu.Name = "All_cpu";
            this.All_cpu.Size = new System.Drawing.Size(296, 21);
            this.All_cpu.TabIndex = 4;
            this.All_cpu.TabStop = true;
            this.All_cpu.Text = "Поочерёдное вычисление всеми ядрами";
            this.All_cpu.UseVisualStyleBackColor = true;
            // 
            // cpu4
            // 
            this.cpu4.AutoSize = true;
            this.cpu4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu4.Location = new System.Drawing.Point(54, 406);
            this.cpu4.Name = "cpu4";
            this.cpu4.Size = new System.Drawing.Size(70, 21);
            this.cpu4.TabIndex = 6;
            this.cpu4.TabStop = true;
            this.cpu4.Text = "4 ядра";
            this.cpu4.UseVisualStyleBackColor = true;
            // 
            // cpu5
            // 
            this.cpu5.AutoSize = true;
            this.cpu5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu5.Location = new System.Drawing.Point(127, 337);
            this.cpu5.Name = "cpu5";
            this.cpu5.Size = new System.Drawing.Size(70, 21);
            this.cpu5.TabIndex = 7;
            this.cpu5.TabStop = true;
            this.cpu5.Text = "5 ядер";
            this.cpu5.UseVisualStyleBackColor = true;
            // 
            // cpu6
            // 
            this.cpu6.AutoSize = true;
            this.cpu6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu6.Location = new System.Drawing.Point(127, 360);
            this.cpu6.Name = "cpu6";
            this.cpu6.Size = new System.Drawing.Size(70, 21);
            this.cpu6.TabIndex = 8;
            this.cpu6.TabStop = true;
            this.cpu6.Text = "6 ядер";
            this.cpu6.UseVisualStyleBackColor = true;
            // 
            // cpu7
            // 
            this.cpu7.AutoSize = true;
            this.cpu7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu7.Location = new System.Drawing.Point(127, 383);
            this.cpu7.Name = "cpu7";
            this.cpu7.Size = new System.Drawing.Size(70, 21);
            this.cpu7.TabIndex = 9;
            this.cpu7.TabStop = true;
            this.cpu7.Text = "7 ядер";
            this.cpu7.UseVisualStyleBackColor = true;
            // 
            // cpu8
            // 
            this.cpu8.AutoSize = true;
            this.cpu8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu8.Location = new System.Drawing.Point(127, 406);
            this.cpu8.Name = "cpu8";
            this.cpu8.Size = new System.Drawing.Size(70, 21);
            this.cpu8.TabIndex = 10;
            this.cpu8.TabStop = true;
            this.cpu8.Text = "8 ядер";
            this.cpu8.UseVisualStyleBackColor = true;
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Plus.Location = new System.Drawing.Point(45, 291);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(35, 21);
            this.Plus.TabIndex = 12;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minus.Location = new System.Drawing.Point(83, 291);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(32, 21);
            this.Minus.TabIndex = 13;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // Mult
            // 
            this.Mult.AutoSize = true;
            this.Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mult.Location = new System.Drawing.Point(118, 291);
            this.Mult.Name = "Mult";
            this.Mult.Size = new System.Drawing.Size(32, 21);
            this.Mult.TabIndex = 14;
            this.Mult.Text = "*";
            this.Mult.UseVisualStyleBackColor = true;
            // 
            // Rex
            // 
            this.Rex.AutoSize = true;
            this.Rex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rex.Location = new System.Drawing.Point(154, 291);
            this.Rex.Name = "Rex";
            this.Rex.Size = new System.Drawing.Size(31, 21);
            this.Rex.TabIndex = 15;
            this.Rex.Text = "/";
            this.Rex.UseVisualStyleBackColor = true;
            // 
            // size_massiv
            // 
            this.size_massiv.AutoSize = true;
            this.size_massiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_massiv.Location = new System.Drawing.Point(9, 93);
            this.size_massiv.Name = "size_massiv";
            this.size_massiv.Size = new System.Drawing.Size(219, 17);
            this.size_massiv.TabIndex = 17;
            this.size_massiv.Text = "Введите Размер Массива  N x M";
            // 
            // Rand
            // 
            this.Rand.AutoSize = true;
            this.Rand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rand.Location = new System.Drawing.Point(9, 178);
            this.Rand.Name = "Rand";
            this.Rand.Size = new System.Drawing.Size(287, 17);
            this.Rand.TabIndex = 18;
            this.Rand.Text = "Введите нижнюю и верхнюю границу Rand";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(12, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cpu3
            // 
            this.cpu3.AutoSize = true;
            this.cpu3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu3.Location = new System.Drawing.Point(54, 383);
            this.cpu3.Name = "cpu3";
            this.cpu3.Size = new System.Drawing.Size(70, 21);
            this.cpu3.TabIndex = 20;
            this.cpu3.TabStop = true;
            this.cpu3.Text = "3 ядра";
            this.cpu3.UseVisualStyleBackColor = true;
            // 
            // cpu1
            // 
            this.cpu1.AutoSize = true;
            this.cpu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu1.Location = new System.Drawing.Point(54, 337);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(70, 21);
            this.cpu1.TabIndex = 21;
            this.cpu1.TabStop = true;
            this.cpu1.Text = "1 ядро";
            this.cpu1.UseVisualStyleBackColor = true;
            // 
            // cpu2
            // 
            this.cpu2.AutoSize = true;
            this.cpu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cpu2.Location = new System.Drawing.Point(54, 360);
            this.cpu2.Name = "cpu2";
            this.cpu2.Size = new System.Drawing.Size(70, 21);
            this.cpu2.TabIndex = 22;
            this.cpu2.TabStop = true;
            this.cpu2.Text = "2 ядра";
            this.cpu2.UseVisualStyleBackColor = true;
            // 
            // Oper
            // 
            this.Oper.AutoSize = true;
            this.Oper.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Oper.Location = new System.Drawing.Point(51, 266);
            this.Oper.Name = "Oper";
            this.Oper.Size = new System.Drawing.Size(148, 17);
            this.Oper.TabIndex = 23;
            this.Oper.Text = "Выберите операцию ";
            // 
            // Up
            // 
            this.Up.AutoSize = true;
            this.Up.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Up.Location = new System.Drawing.Point(115, 213);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(18, 17);
            this.Up.TabIndex = 24;
            this.Up.Text = "▲";
            // 
            // Down
            // 
            this.Down.AutoSize = true;
            this.Down.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Down.Location = new System.Drawing.Point(115, 232);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(18, 17);
            this.Down.TabIndex = 25;
            this.Down.Text = "▼";
            // 
            // UU
            // 
            this.UU.AutoSize = true;
            this.UU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UU.Location = new System.Drawing.Point(115, 126);
            this.UU.Name = "UU";
            this.UU.Size = new System.Drawing.Size(18, 17);
            this.UU.TabIndex = 26;
            this.UU.Text = "▲";
            // 
            // DD
            // 
            this.DD.AutoSize = true;
            this.DD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DD.Location = new System.Drawing.Point(115, 145);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(18, 17);
            this.DD.TabIndex = 27;
            this.DD.Text = "▼";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(101, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // First
            // 
            this.First.BackColor = System.Drawing.Color.White;
            this.First.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.First.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.First.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.First.Location = new System.Drawing.Point(315, 60);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(75, 50);
            this.First.TabIndex = 30;
            this.First.Text = "Cpu 1";
            this.First.UseVisualStyleBackColor = false;
            // 
            // Second
            // 
            this.Second.BackColor = System.Drawing.Color.White;
            this.Second.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Second.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Second.Location = new System.Drawing.Point(315, 110);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(75, 50);
            this.Second.TabIndex = 31;
            this.Second.Text = "Cpu 2";
            this.Second.UseVisualStyleBackColor = false;
            // 
            // Third
            // 
            this.Third.BackColor = System.Drawing.Color.White;
            this.Third.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Third.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Third.Location = new System.Drawing.Point(315, 160);
            this.Third.Name = "Third";
            this.Third.Size = new System.Drawing.Size(75, 50);
            this.Third.TabIndex = 32;
            this.Third.Text = "Cpu 3";
            this.Third.UseVisualStyleBackColor = false;
            // 
            // Fourth
            // 
            this.Fourth.BackColor = System.Drawing.Color.White;
            this.Fourth.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fourth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fourth.Location = new System.Drawing.Point(315, 210);
            this.Fourth.Name = "Fourth";
            this.Fourth.Size = new System.Drawing.Size(75, 50);
            this.Fourth.TabIndex = 33;
            this.Fourth.Text = "Cpu 4";
            this.Fourth.UseVisualStyleBackColor = false;
            // 
            // Fiveth
            // 
            this.Fiveth.BackColor = System.Drawing.Color.White;
            this.Fiveth.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fiveth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fiveth.Location = new System.Drawing.Point(390, 60);
            this.Fiveth.Name = "Fiveth";
            this.Fiveth.Size = new System.Drawing.Size(75, 50);
            this.Fiveth.TabIndex = 34;
            this.Fiveth.Text = "Cpu 5";
            this.Fiveth.UseVisualStyleBackColor = false;
            // 
            // Sixth
            // 
            this.Sixth.BackColor = System.Drawing.Color.White;
            this.Sixth.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sixth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sixth.Location = new System.Drawing.Point(390, 110);
            this.Sixth.Name = "Sixth";
            this.Sixth.Size = new System.Drawing.Size(75, 50);
            this.Sixth.TabIndex = 35;
            this.Sixth.Text = "Cpu 6";
            this.Sixth.UseVisualStyleBackColor = false;
            // 
            // Eight
            // 
            this.Eight.BackColor = System.Drawing.Color.White;
            this.Eight.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eight.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eight.Location = new System.Drawing.Point(390, 210);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(75, 50);
            this.Eight.TabIndex = 36;
            this.Eight.Text = "Cpu 8";
            this.Eight.UseVisualStyleBackColor = false;
            // 
            // Sevnth
            // 
            this.Sevnth.BackColor = System.Drawing.Color.White;
            this.Sevnth.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sevnth.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Sevnth.Location = new System.Drawing.Point(390, 160);
            this.Sevnth.Name = "Sevnth";
            this.Sevnth.Size = new System.Drawing.Size(75, 50);
            this.Sevnth.TabIndex = 37;
            this.Sevnth.Text = "Cpu 7";
            this.Sevnth.UseVisualStyleBackColor = false;
            // 
            // size_array
            // 
            this.size_array.BackColor = System.Drawing.Color.White;
            this.size_array.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.size_array.Location = new System.Drawing.Point(475, 60);
            this.size_array.Name = "size_array";
            this.size_array.Size = new System.Drawing.Size(120, 50);
            this.size_array.TabIndex = 38;
            this.size_array.Text = " ";
            this.size_array.UseVisualStyleBackColor = false;
            // 
            // randomize
            // 
            this.randomize.BackColor = System.Drawing.Color.White;
            this.randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomize.Location = new System.Drawing.Point(475, 110);
            this.randomize.Name = "randomize";
            this.randomize.Size = new System.Drawing.Size(120, 50);
            this.randomize.TabIndex = 39;
            this.randomize.Text = " ";
            this.randomize.UseVisualStyleBackColor = false;
            // 
            // operation
            // 
            this.operation.BackColor = System.Drawing.Color.White;
            this.operation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operation.Location = new System.Drawing.Point(475, 160);
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(120, 50);
            this.operation.TabIndex = 40;
            this.operation.Text = " ";
            this.operation.UseVisualStyleBackColor = false;
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.White;
            this.timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timer.Location = new System.Drawing.Point(475, 210);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(120, 50);
            this.timer.TabIndex = 41;
            this.timer.Text = " ";
            this.timer.UseVisualStyleBackColor = false;
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.White;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.DarkRed;
            this.result.Location = new System.Drawing.Point(315, 266);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(280, 50);
            this.result.TabIndex = 42;
            this.result.Text = " ";
            this.result.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(390, 321);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 148);
            this.listBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(602, 481);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.operation);
            this.Controls.Add(this.randomize);
            this.Controls.Add(this.size_array);
            this.Controls.Add(this.Sevnth);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Sixth);
            this.Controls.Add(this.Fiveth);
            this.Controls.Add(this.Fourth);
            this.Controls.Add(this.Third);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.UU);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Oper);
            this.Controls.Add(this.cpu2);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.cpu3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rand);
            this.Controls.Add(this.size_massiv);
            this.Controls.Add(this.Rex);
            this.Controls.Add(this.Mult);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.cpu8);
            this.Controls.Add(this.cpu7);
            this.Controls.Add(this.cpu6);
            this.Controls.Add(this.cpu5);
            this.Controls.Add(this.cpu4);
            this.Controls.Add(this.All_cpu);
            this.Controls.Add(this.U_limit);
            this.Controls.Add(this.D_limit);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.Weight);
            this.Name = "Form1";
            this.Text = "test Cpu\'s";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox D_limit;
        private System.Windows.Forms.TextBox U_limit;
        private System.Windows.Forms.RadioButton All_cpu;
        private System.Windows.Forms.RadioButton cpu4;
        private System.Windows.Forms.RadioButton cpu5;
        private System.Windows.Forms.RadioButton cpu6;
        private System.Windows.Forms.RadioButton cpu7;
        private System.Windows.Forms.RadioButton cpu8;
        private System.Windows.Forms.CheckBox Plus;
        private System.Windows.Forms.CheckBox Minus;
        private System.Windows.Forms.CheckBox Mult;
        private System.Windows.Forms.CheckBox Rex;
        private System.Windows.Forms.Label size_massiv;
        private System.Windows.Forms.Label Rand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton cpu3;
        private System.Windows.Forms.RadioButton cpu1;
        private System.Windows.Forms.RadioButton cpu2;
        private System.Windows.Forms.Label Oper;
        private System.Windows.Forms.Label Up;
        private System.Windows.Forms.Label Down;
        private System.Windows.Forms.Label UU;
        private System.Windows.Forms.Label DD;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button First;
        private System.Windows.Forms.Button Second;
        private System.Windows.Forms.Button Third;
        private System.Windows.Forms.Button Fourth;
        private System.Windows.Forms.Button Fiveth;
        private System.Windows.Forms.Button Sixth;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Sevnth;
        private System.Windows.Forms.Button size_array;
        private System.Windows.Forms.Button randomize;
        private System.Windows.Forms.Button operation;
        private System.Windows.Forms.Button timer;
        private System.Windows.Forms.Button result;
        private System.Windows.Forms.ListBox listBox1;

    }
}


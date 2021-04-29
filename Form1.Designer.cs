namespace PathFinding
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
            this.AStar = new System.Windows.Forms.RadioButton();
            this.Dijkstra = new System.Windows.Forms.RadioButton();
            this.BestFirst = new System.Windows.Forms.RadioButton();
            this.MenuCell = new System.Windows.Forms.GroupBox();
            this.ButtonEndCell = new System.Windows.Forms.Button();
            this.ButtonStartCell = new System.Windows.Forms.Button();
            this.ButtonClearMap = new System.Windows.Forms.Button();
            this.LabelSelect = new System.Windows.Forms.Label();
            this.PicSelectType = new System.Windows.Forms.Label();
            this.LabelBesckonechnost = new System.Windows.Forms.Label();
            this.NumericSand = new System.Windows.Forms.NumericUpDown();
            this.NumericLava = new System.Windows.Forms.NumericUpDown();
            this.NumericRoad = new System.Windows.Forms.NumericUpDown();
            this.NumericTaiga = new System.Windows.Forms.NumericUpDown();
            this.NumericForest = new System.Windows.Forms.NumericUpDown();
            this.LabelCost = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.LabelSand = new System.Windows.Forms.Label();
            this.Pic6 = new System.Windows.Forms.Label();
            this.LabelLava = new System.Windows.Forms.Label();
            this.LabelRoad = new System.Windows.Forms.Label();
            this.LabelForest = new System.Windows.Forms.Label();
            this.LabelTaiga = new System.Windows.Forms.Label();
            this.LabelWall = new System.Windows.Forms.Label();
            this.LabelType = new System.Windows.Forms.Label();
            this.Pic5 = new System.Windows.Forms.Label();
            this.Pic4 = new System.Windows.Forms.Label();
            this.Pic3 = new System.Windows.Forms.Label();
            this.Pic2 = new System.Windows.Forms.Label();
            this.Pic1 = new System.Windows.Forms.Label();
            this.ButtonRun = new System.Windows.Forms.Button();
            this.ViewResults_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Results_dgv = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Algorithms = new System.Windows.Forms.GroupBox();
            this.Results_pnl = new System.Windows.Forms.Panel();
            this.MenuCell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLava)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTaiga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForest)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results_dgv)).BeginInit();
            this.Algorithms.SuspendLayout();
            this.Results_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // AStar
            // 
            this.AStar.AutoSize = true;
            this.AStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AStar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AStar.Location = new System.Drawing.Point(10, 67);
            this.AStar.Name = "AStar";
            this.AStar.Size = new System.Drawing.Size(54, 17);
            this.AStar.TabIndex = 2;
            this.AStar.TabStop = true;
            this.AStar.Text = "A-Star";
            this.AStar.UseVisualStyleBackColor = true;
            this.AStar.CheckedChanged += new System.EventHandler(this.SelectAlgorithm);
            // 
            // Dijkstra
            // 
            this.Dijkstra.AutoSize = true;
            this.Dijkstra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dijkstra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Dijkstra.Location = new System.Drawing.Point(10, 44);
            this.Dijkstra.Name = "Dijkstra";
            this.Dijkstra.Size = new System.Drawing.Size(60, 17);
            this.Dijkstra.TabIndex = 1;
            this.Dijkstra.Text = "Dijkstra";
            this.Dijkstra.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Dijkstra.UseVisualStyleBackColor = true;
            this.Dijkstra.CheckedChanged += new System.EventHandler(this.SelectAlgorithm);
            // 
            // BestFirst
            // 
            this.BestFirst.AutoSize = true;
            this.BestFirst.Checked = true;
            this.BestFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BestFirst.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BestFirst.Location = new System.Drawing.Point(10, 21);
            this.BestFirst.Name = "BestFirst";
            this.BestFirst.Size = new System.Drawing.Size(68, 17);
            this.BestFirst.TabIndex = 0;
            this.BestFirst.TabStop = true;
            this.BestFirst.Text = "Best-First";
            this.BestFirst.UseVisualStyleBackColor = true;
            this.BestFirst.CheckedChanged += new System.EventHandler(this.SelectAlgorithm);
            // 
            // MenuCell
            // 
            this.MenuCell.BackColor = System.Drawing.SystemColors.Control;
            this.MenuCell.Controls.Add(this.ButtonEndCell);
            this.MenuCell.Controls.Add(this.ButtonStartCell);
            this.MenuCell.Controls.Add(this.ButtonClearMap);
            this.MenuCell.Controls.Add(this.LabelSelect);
            this.MenuCell.Controls.Add(this.PicSelectType);
            this.MenuCell.Controls.Add(this.LabelBesckonechnost);
            this.MenuCell.Controls.Add(this.NumericSand);
            this.MenuCell.Controls.Add(this.NumericLava);
            this.MenuCell.Controls.Add(this.NumericRoad);
            this.MenuCell.Controls.Add(this.NumericTaiga);
            this.MenuCell.Controls.Add(this.NumericForest);
            this.MenuCell.Controls.Add(this.LabelCost);
            this.MenuCell.Controls.Add(this.LabelColor);
            this.MenuCell.Controls.Add(this.LabelSand);
            this.MenuCell.Controls.Add(this.Pic6);
            this.MenuCell.Controls.Add(this.LabelLava);
            this.MenuCell.Controls.Add(this.LabelRoad);
            this.MenuCell.Controls.Add(this.LabelForest);
            this.MenuCell.Controls.Add(this.LabelTaiga);
            this.MenuCell.Controls.Add(this.LabelWall);
            this.MenuCell.Controls.Add(this.LabelType);
            this.MenuCell.Controls.Add(this.Pic5);
            this.MenuCell.Controls.Add(this.Pic4);
            this.MenuCell.Controls.Add(this.Pic3);
            this.MenuCell.Controls.Add(this.Pic2);
            this.MenuCell.Controls.Add(this.Pic1);
            this.MenuCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MenuCell.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MenuCell.Location = new System.Drawing.Point(4, 137);
            this.MenuCell.Name = "MenuCell";
            this.MenuCell.Size = new System.Drawing.Size(176, 364);
            this.MenuCell.TabIndex = 3;
            this.MenuCell.TabStop = false;
            // 
            // ButtonEndCell
            // 
            this.ButtonEndCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEndCell.ForeColor = System.Drawing.Color.Red;
            this.ButtonEndCell.Location = new System.Drawing.Point(93, 19);
            this.ButtonEndCell.Name = "ButtonEndCell";
            this.ButtonEndCell.Size = new System.Drawing.Size(63, 29);
            this.ButtonEndCell.TabIndex = 28;
            this.ButtonEndCell.Text = "КОНЕЦ";
            this.ButtonEndCell.UseVisualStyleBackColor = true;
            this.ButtonEndCell.Click += new System.EventHandler(this.SelectEndCell_Click);
            // 
            // ButtonStartCell
            // 
            this.ButtonStartCell.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStartCell.ForeColor = System.Drawing.Color.Green;
            this.ButtonStartCell.Location = new System.Drawing.Point(24, 19);
            this.ButtonStartCell.Name = "ButtonStartCell";
            this.ButtonStartCell.Size = new System.Drawing.Size(60, 29);
            this.ButtonStartCell.TabIndex = 27;
            this.ButtonStartCell.Text = "СТАРТ";
            this.ButtonStartCell.UseVisualStyleBackColor = true;
            this.ButtonStartCell.Click += new System.EventHandler(this.SelectStartCell_Click);
            // 
            // ButtonClearMap
            // 
            this.ButtonClearMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonClearMap.FlatAppearance.BorderSize = 0;
            this.ButtonClearMap.ForeColor = System.Drawing.Color.Black;
            this.ButtonClearMap.Location = new System.Drawing.Point(43, 317);
            this.ButtonClearMap.Name = "ButtonClearMap";
            this.ButtonClearMap.Size = new System.Drawing.Size(89, 41);
            this.ButtonClearMap.TabIndex = 25;
            this.ButtonClearMap.Text = "ОЧИСТИТЬ КАРТУ";
            this.ButtonClearMap.UseVisualStyleBackColor = true;
            this.ButtonClearMap.Click += new System.EventHandler(this.button5_Click);
            // 
            // LabelSelect
            // 
            this.LabelSelect.AutoSize = true;
            this.LabelSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSelect.ForeColor = System.Drawing.Color.Black;
            this.LabelSelect.Location = new System.Drawing.Point(59, 297);
            this.LabelSelect.Name = "LabelSelect";
            this.LabelSelect.Size = new System.Drawing.Size(83, 17);
            this.LabelSelect.TabIndex = 24;
            this.LabelSelect.Text = "- ВЫБРАН";
            // 
            // PicSelectType
            // 
            this.PicSelectType.BackColor = System.Drawing.Color.Navy;
            this.PicSelectType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicSelectType.Location = new System.Drawing.Point(32, 297);
            this.PicSelectType.Name = "PicSelectType";
            this.PicSelectType.Size = new System.Drawing.Size(21, 17);
            this.PicSelectType.TabIndex = 23;
            this.PicSelectType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBesckonechnost
            // 
            this.LabelBesckonechnost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LabelBesckonechnost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LabelBesckonechnost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelBesckonechnost.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelBesckonechnost.Location = new System.Drawing.Point(115, 83);
            this.LabelBesckonechnost.Name = "LabelBesckonechnost";
            this.LabelBesckonechnost.Size = new System.Drawing.Size(55, 20);
            this.LabelBesckonechnost.TabIndex = 22;
            this.LabelBesckonechnost.Text = "БЕСК";
            this.LabelBesckonechnost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumericSand
            // 
            this.NumericSand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericSand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericSand.Location = new System.Drawing.Point(115, 260);
            this.NumericSand.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericSand.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericSand.Name = "NumericSand";
            this.NumericSand.Size = new System.Drawing.Size(55, 20);
            this.NumericSand.TabIndex = 20;
            this.NumericSand.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.NumericSand.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // NumericLava
            // 
            this.NumericLava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericLava.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericLava.Increment = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericLava.Location = new System.Drawing.Point(115, 224);
            this.NumericLava.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericLava.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericLava.Name = "NumericLava";
            this.NumericLava.Size = new System.Drawing.Size(55, 20);
            this.NumericLava.TabIndex = 19;
            this.NumericLava.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.NumericLava.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // NumericRoad
            // 
            this.NumericRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericRoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericRoad.Location = new System.Drawing.Point(115, 190);
            this.NumericRoad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericRoad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericRoad.Name = "NumericRoad";
            this.NumericRoad.Size = new System.Drawing.Size(55, 20);
            this.NumericRoad.TabIndex = 18;
            this.NumericRoad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericRoad.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // NumericTaiga
            // 
            this.NumericTaiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericTaiga.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericTaiga.Location = new System.Drawing.Point(115, 155);
            this.NumericTaiga.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericTaiga.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericTaiga.Name = "NumericTaiga";
            this.NumericTaiga.Size = new System.Drawing.Size(55, 20);
            this.NumericTaiga.TabIndex = 17;
            this.NumericTaiga.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericTaiga.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // NumericForest
            // 
            this.NumericForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericForest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NumericForest.Location = new System.Drawing.Point(115, 120);
            this.NumericForest.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumericForest.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericForest.Name = "NumericForest";
            this.NumericForest.Size = new System.Drawing.Size(55, 20);
            this.NumericForest.TabIndex = 16;
            this.NumericForest.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumericForest.ValueChanged += new System.EventHandler(this.NumericValueChanged);
            // 
            // LabelCost
            // 
            this.LabelCost.AutoSize = true;
            this.LabelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCost.ForeColor = System.Drawing.Color.Black;
            this.LabelCost.Location = new System.Drawing.Point(124, 61);
            this.LabelCost.Name = "LabelCost";
            this.LabelCost.Size = new System.Drawing.Size(41, 13);
            this.LabelCost.TabIndex = 14;
            this.LabelCost.Text = "ЦЕНА";
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelColor.ForeColor = System.Drawing.Color.Black;
            this.LabelColor.Location = new System.Drawing.Point(3, 61);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(40, 13);
            this.LabelColor.TabIndex = 13;
            this.LabelColor.Text = "ЦВЕТ";
            // 
            // LabelSand
            // 
            this.LabelSand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelSand.AutoSize = true;
            this.LabelSand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSand.ForeColor = System.Drawing.Color.Black;
            this.LabelSand.Location = new System.Drawing.Point(51, 262);
            this.LabelSand.Name = "LabelSand";
            this.LabelSand.Size = new System.Drawing.Size(44, 13);
            this.LabelSand.TabIndex = 12;
            this.LabelSand.Text = "ПЕСОК";
            // 
            // Pic6
            // 
            this.Pic6.BackColor = System.Drawing.Color.Gold;
            this.Pic6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic6.Location = new System.Drawing.Point(6, 255);
            this.Pic6.Name = "Pic6";
            this.Pic6.Size = new System.Drawing.Size(29, 26);
            this.Pic6.TabIndex = 5;
            this.Pic6.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // LabelLava
            // 
            this.LabelLava.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelLava.AutoSize = true;
            this.LabelLava.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLava.ForeColor = System.Drawing.Color.Black;
            this.LabelLava.Location = new System.Drawing.Point(55, 226);
            this.LabelLava.Name = "LabelLava";
            this.LabelLava.Size = new System.Drawing.Size(36, 13);
            this.LabelLava.TabIndex = 10;
            this.LabelLava.Text = "ЛАВА";
            // 
            // LabelRoad
            // 
            this.LabelRoad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelRoad.AutoSize = true;
            this.LabelRoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelRoad.ForeColor = System.Drawing.Color.Black;
            this.LabelRoad.Location = new System.Drawing.Point(50, 192);
            this.LabelRoad.Name = "LabelRoad";
            this.LabelRoad.Size = new System.Drawing.Size(52, 13);
            this.LabelRoad.TabIndex = 9;
            this.LabelRoad.Text = "ДОРОГА";
            // 
            // LabelForest
            // 
            this.LabelForest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelForest.AutoSize = true;
            this.LabelForest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelForest.ForeColor = System.Drawing.Color.Black;
            this.LabelForest.Location = new System.Drawing.Point(59, 122);
            this.LabelForest.Name = "LabelForest";
            this.LabelForest.Size = new System.Drawing.Size(29, 13);
            this.LabelForest.TabIndex = 8;
            this.LabelForest.Text = "ЛЕС";
            // 
            // LabelTaiga
            // 
            this.LabelTaiga.AutoSize = true;
            this.LabelTaiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelTaiga.ForeColor = System.Drawing.Color.Black;
            this.LabelTaiga.Location = new System.Drawing.Point(51, 157);
            this.LabelTaiga.Name = "LabelTaiga";
            this.LabelTaiga.Size = new System.Drawing.Size(42, 13);
            this.LabelTaiga.TabIndex = 7;
            this.LabelTaiga.Text = "ТАЙГА";
            // 
            // LabelWall
            // 
            this.LabelWall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelWall.AutoSize = true;
            this.LabelWall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelWall.ForeColor = System.Drawing.Color.Black;
            this.LabelWall.Location = new System.Drawing.Point(50, 87);
            this.LabelWall.Name = "LabelWall";
            this.LabelWall.Size = new System.Drawing.Size(43, 13);
            this.LabelWall.TabIndex = 6;
            this.LabelWall.Text = "СТЕНА";
            // 
            // LabelType
            // 
            this.LabelType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelType.AutoSize = true;
            this.LabelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelType.ForeColor = System.Drawing.Color.Black;
            this.LabelType.Location = new System.Drawing.Point(55, 61);
            this.LabelType.Name = "LabelType";
            this.LabelType.Size = new System.Drawing.Size(33, 13);
            this.LabelType.TabIndex = 5;
            this.LabelType.Text = "ТИП";
            // 
            // Pic5
            // 
            this.Pic5.BackColor = System.Drawing.Color.Red;
            this.Pic5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic5.Location = new System.Drawing.Point(5, 220);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(30, 30);
            this.Pic5.TabIndex = 4;
            this.Pic5.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // Pic4
            // 
            this.Pic4.BackColor = System.Drawing.Color.White;
            this.Pic4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic4.Location = new System.Drawing.Point(5, 185);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(30, 30);
            this.Pic4.TabIndex = 3;
            this.Pic4.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // Pic3
            // 
            this.Pic3.BackColor = System.Drawing.Color.DarkGreen;
            this.Pic3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic3.Location = new System.Drawing.Point(5, 150);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(30, 30);
            this.Pic3.TabIndex = 2;
            this.Pic3.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // Pic2
            // 
            this.Pic2.BackColor = System.Drawing.Color.LimeGreen;
            this.Pic2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic2.Location = new System.Drawing.Point(5, 115);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(30, 30);
            this.Pic2.TabIndex = 1;
            this.Pic2.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // Pic1
            // 
            this.Pic1.BackColor = System.Drawing.Color.Navy;
            this.Pic1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pic1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pic1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Pic1.Location = new System.Drawing.Point(5, 80);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(30, 30);
            this.Pic1.TabIndex = 0;
            this.Pic1.Click += new System.EventHandler(this.SelectCell_Click);
            // 
            // ButtonRun
            // 
            this.ButtonRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRun.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ButtonRun.Location = new System.Drawing.Point(97, 65);
            this.ButtonRun.Name = "ButtonRun";
            this.ButtonRun.Size = new System.Drawing.Size(83, 40);
            this.ButtonRun.TabIndex = 0;
            this.ButtonRun.Text = "ПУСК";
            this.ButtonRun.UseVisualStyleBackColor = true;
            this.ButtonRun.Click += new System.EventHandler(this.RunPathFind);
            // 
            // ViewResults_btn
            // 
            this.ViewResults_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewResults_btn.Location = new System.Drawing.Point(724, 2);
            this.ViewResults_btn.Name = "ViewResults_btn";
            this.ViewResults_btn.Size = new System.Drawing.Size(123, 21);
            this.ViewResults_btn.TabIndex = 9;
            this.ViewResults_btn.Text = "View results";
            this.ViewResults_btn.UseVisualStyleBackColor = true;
            this.ViewResults_btn.Click += new System.EventHandler(this.ViewResults);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(853, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.mapToolStripMenuItem.Text = "Карта";
            this.mapToolStripMenuItem.Click += new System.EventHandler(this.SetMap);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PaintCellFromType);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(186, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 470);
            this.panel1.TabIndex = 0;
            // 
            // Results_dgv
            // 
            this.Results_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Results_dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Results_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.Results_dgv.Location = new System.Drawing.Point(0, 0);
            this.Results_dgv.Name = "Results_dgv";
            this.Results_dgv.Size = new System.Drawing.Size(136, 468);
            this.Results_dgv.TabIndex = 0;
            // 
            // X
            // 
            this.X.FillWeight = 98.92473F;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.FillWeight = 101.0753F;
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // Algorithms
            // 
            this.Algorithms.Controls.Add(this.AStar);
            this.Algorithms.Controls.Add(this.Dijkstra);
            this.Algorithms.Controls.Add(this.BestFirst);
            this.Algorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Algorithms.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Algorithms.Location = new System.Drawing.Point(10, 33);
            this.Algorithms.Name = "Algorithms";
            this.Algorithms.Size = new System.Drawing.Size(83, 98);
            this.Algorithms.TabIndex = 1;
            this.Algorithms.TabStop = false;
            this.Algorithms.Text = "АЛГОРИТМЫ";
            // 
            // Results_pnl
            // 
            this.Results_pnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Results_pnl.AutoScroll = true;
            this.Results_pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Results_pnl.Controls.Add(this.Results_dgv);
            this.Results_pnl.Location = new System.Drawing.Point(710, 31);
            this.Results_pnl.Name = "Results_pnl";
            this.Results_pnl.Size = new System.Drawing.Size(137, 470);
            this.Results_pnl.TabIndex = 1;
            this.Results_pnl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 513);
            this.Controls.Add(this.Results_pnl);
            this.Controls.Add(this.ViewResults_btn);
            this.Controls.Add(this.ButtonRun);
            this.Controls.Add(this.MenuCell);
            this.Controls.Add(this.Algorithms);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(400, 552);
            this.Name = "Form1";
            this.Text = "Кратчайшие пути на клеточном поле";
            this.MenuCell.ResumeLayout(false);
            this.MenuCell.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericLava)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericRoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTaiga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericForest)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Results_dgv)).EndInit();
            this.Algorithms.ResumeLayout(false);
            this.Algorithms.PerformLayout();
            this.Results_pnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton Dijkstra;
        private System.Windows.Forms.RadioButton BestFirst;
        private System.Windows.Forms.GroupBox MenuCell;
        private System.Windows.Forms.Label LabelSand;
        private System.Windows.Forms.Label Pic6;
        private System.Windows.Forms.Label LabelLava;
        private System.Windows.Forms.Label LabelRoad;
        private System.Windows.Forms.Label LabelForest;
        private System.Windows.Forms.Label LabelTaiga;
        private System.Windows.Forms.Label LabelWall;
        private System.Windows.Forms.Label LabelType;
        private System.Windows.Forms.Label Pic5;
        private System.Windows.Forms.Label Pic4;
        private System.Windows.Forms.Label Pic3;
        private System.Windows.Forms.Label Pic2;
        private System.Windows.Forms.Label Pic1;
        private System.Windows.Forms.NumericUpDown NumericSand;
        private System.Windows.Forms.NumericUpDown NumericLava;
        private System.Windows.Forms.NumericUpDown NumericRoad;
        private System.Windows.Forms.NumericUpDown NumericTaiga;
        private System.Windows.Forms.NumericUpDown NumericForest;
        private System.Windows.Forms.Label LabelCost;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.Label LabelBesckonechnost;
        private System.Windows.Forms.Label LabelSelect;
        private System.Windows.Forms.Label PicSelectType;
        private System.Windows.Forms.Button ButtonClearMap;
        private System.Windows.Forms.Button ButtonEndCell;
        private System.Windows.Forms.Button ButtonStartCell;
        private System.Windows.Forms.Button ButtonRun;
        private System.Windows.Forms.RadioButton AStar;
        private System.Windows.Forms.Button ViewResults_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView Results_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.GroupBox Algorithms;
        private System.Windows.Forms.Panel Results_pnl;
    }
}


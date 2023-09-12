namespace XenoStars_Battle
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            alliesGroup = new GroupBox();
            alliesLayout = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            allies1 = new ComboBox();
            tableLayoutPanel13 = new TableLayoutPanel();
            player1Arts = new GroupBox();
            tableLayoutPanel14 = new TableLayoutPanel();
            player1Art1 = new Label();
            player1Art2 = new Label();
            player1Art1Cost = new Label();
            player1Art2Cost = new Label();
            player1Art3 = new Label();
            player1Art3Cost = new Label();
            player1Art4 = new Label();
            player1Art4Cost = new Label();
            tableLayoutPanel15 = new TableLayoutPanel();
            player1Player = new Label();
            player1MaxHP = new Label();
            player1MaxAP = new Label();
            player1Damage = new Label();
            player1PlayerDynamic = new Label();
            player1MaxHPDynamic = new Label();
            player1MaxAPDynamic = new Label();
            player1DamageDynamic = new Label();
            player1HP = new Label();
            player1AP = new Label();
            player1APDynamic = new NumericUpDown();
            player1HPDynamic = new NumericUpDown();
            player1Equipment = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            player1Weapon = new Label();
            player1HeadGear = new Label();
            player1TorsoGear = new Label();
            player1LegsGear = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            groupTension = new GroupBox();
            tableLayoutPanel11 = new TableLayoutPanel();
            tableLayoutPanel12 = new TableLayoutPanel();
            partyMeter = new ProgressBar();
            partyOverflow = new ProgressBar();
            numericParty = new NumericUpDown();
            tableLayoutPanel10 = new TableLayoutPanel();
            groupEnemies = new GroupBox();
            groupInventory = new GroupBox();
            listInventory = new ListBox();
            groupStats = new GroupBox();
            statisticsLayout = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            openFileButton = new Button();
            fileReload = new Button();
            tableLayoutPanel8 = new TableLayoutPanel();
            labelLevel = new Label();
            labelEXP = new Label();
            labelNext = new Label();
            labelLevelDynamic = new Label();
            labelEXPDynamic = new Label();
            labelNextDynamic = new Label();
            labelChapter = new Label();
            labelChapterDynamic = new Label();
            labelLocation = new Label();
            labelLocationDynamic = new Label();
            labelMoney = new Label();
            labelMoneyDynamic = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            tableLayoutPanel16 = new TableLayoutPanel();
            turnCounter = new NumericUpDown();
            labelTurn = new Label();
            openFileDialog = new OpenFileDialog();
            tableLayoutPanel4 = new TableLayoutPanel();
            comboBox1 = new ComboBox();
            tableLayoutPanel1.SuspendLayout();
            alliesGroup.SuspendLayout();
            alliesLayout.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel13.SuspendLayout();
            player1Arts.SuspendLayout();
            tableLayoutPanel14.SuspendLayout();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)player1APDynamic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1HPDynamic).BeginInit();
            player1Equipment.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupTension.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericParty).BeginInit();
            tableLayoutPanel10.SuspendLayout();
            groupInventory.SuspendLayout();
            groupStats.SuspendLayout();
            statisticsLayout.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)turnCounter).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(alliesGroup, 0, 1);
            tableLayoutPanel1.Controls.Add(groupTension, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 1, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(884, 561);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // alliesGroup
            // 
            alliesGroup.Controls.Add(alliesLayout);
            alliesGroup.Dock = DockStyle.Fill;
            alliesGroup.Location = new Point(3, 58);
            alliesGroup.Name = "alliesGroup";
            alliesGroup.Size = new Size(436, 500);
            alliesGroup.TabIndex = 0;
            alliesGroup.TabStop = false;
            alliesGroup.Text = "Allies";
            // 
            // alliesLayout
            // 
            alliesLayout.ColumnCount = 3;
            alliesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            alliesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            alliesLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            alliesLayout.Controls.Add(tableLayoutPanel2, 0, 0);
            alliesLayout.Controls.Add(tableLayoutPanel5, 1, 0);
            alliesLayout.Controls.Add(tableLayoutPanel6, 2, 0);
            alliesLayout.Dock = DockStyle.Fill;
            alliesLayout.Location = new Point(3, 19);
            alliesLayout.Name = "alliesLayout";
            alliesLayout.RowCount = 1;
            alliesLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            alliesLayout.Size = new Size(430, 478);
            alliesLayout.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(allies1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel13, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(137, 472);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // allies1
            // 
            allies1.Dock = DockStyle.Top;
            allies1.FormattingEnabled = true;
            allies1.Items.AddRange(new object[] { "None", "Virent" });
            allies1.Location = new Point(3, 3);
            allies1.Name = "allies1";
            allies1.Size = new Size(131, 23);
            allies1.TabIndex = 0;
            allies1.SelectedIndexChanged += Allies1_SelectedIndexChanged;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 1;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(player1Arts, 0, 1);
            tableLayoutPanel13.Controls.Add(tableLayoutPanel15, 0, 0);
            tableLayoutPanel13.Controls.Add(player1Equipment, 0, 2);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(3, 32);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 3;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006237F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006275F));
            tableLayoutPanel13.Size = new Size(131, 437);
            tableLayoutPanel13.TabIndex = 1;
            // 
            // player1Arts
            // 
            player1Arts.Controls.Add(tableLayoutPanel14);
            player1Arts.Dock = DockStyle.Fill;
            player1Arts.Location = new Point(3, 148);
            player1Arts.Name = "player1Arts";
            player1Arts.Size = new Size(125, 139);
            player1Arts.TabIndex = 0;
            player1Arts.TabStop = false;
            player1Arts.Text = "Arts";
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
            tableLayoutPanel14.Controls.Add(player1Art1, 0, 0);
            tableLayoutPanel14.Controls.Add(player1Art2, 0, 1);
            tableLayoutPanel14.Controls.Add(player1Art1Cost, 1, 0);
            tableLayoutPanel14.Controls.Add(player1Art2Cost, 1, 1);
            tableLayoutPanel14.Controls.Add(player1Art3, 0, 2);
            tableLayoutPanel14.Controls.Add(player1Art3Cost, 1, 2);
            tableLayoutPanel14.Controls.Add(player1Art4, 0, 3);
            tableLayoutPanel14.Controls.Add(player1Art4Cost, 1, 3);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(3, 19);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 4;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel14.Size = new Size(119, 117);
            tableLayoutPanel14.TabIndex = 0;
            // 
            // player1Art1
            // 
            player1Art1.AutoEllipsis = true;
            player1Art1.AutoSize = true;
            player1Art1.Dock = DockStyle.Fill;
            player1Art1.Location = new Point(3, 0);
            player1Art1.Name = "player1Art1";
            player1Art1.Size = new Size(88, 29);
            player1Art1.TabIndex = 0;
            player1Art1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art2
            // 
            player1Art2.AutoEllipsis = true;
            player1Art2.AutoSize = true;
            player1Art2.Dock = DockStyle.Fill;
            player1Art2.Location = new Point(3, 29);
            player1Art2.Name = "player1Art2";
            player1Art2.Size = new Size(88, 29);
            player1Art2.TabIndex = 1;
            player1Art2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art1Cost
            // 
            player1Art1Cost.AutoSize = true;
            player1Art1Cost.Dock = DockStyle.Fill;
            player1Art1Cost.Location = new Point(97, 0);
            player1Art1Cost.Name = "player1Art1Cost";
            player1Art1Cost.Size = new Size(19, 29);
            player1Art1Cost.TabIndex = 2;
            player1Art1Cost.Text = "0";
            player1Art1Cost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art2Cost
            // 
            player1Art2Cost.AutoSize = true;
            player1Art2Cost.Dock = DockStyle.Fill;
            player1Art2Cost.Location = new Point(97, 29);
            player1Art2Cost.Name = "player1Art2Cost";
            player1Art2Cost.Size = new Size(19, 29);
            player1Art2Cost.TabIndex = 3;
            player1Art2Cost.Text = "0";
            player1Art2Cost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art3
            // 
            player1Art3.AutoEllipsis = true;
            player1Art3.AutoSize = true;
            player1Art3.Dock = DockStyle.Fill;
            player1Art3.Location = new Point(3, 58);
            player1Art3.Name = "player1Art3";
            player1Art3.Size = new Size(88, 29);
            player1Art3.TabIndex = 4;
            player1Art3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art3Cost
            // 
            player1Art3Cost.AutoSize = true;
            player1Art3Cost.Dock = DockStyle.Fill;
            player1Art3Cost.Location = new Point(97, 58);
            player1Art3Cost.Name = "player1Art3Cost";
            player1Art3Cost.Size = new Size(19, 29);
            player1Art3Cost.TabIndex = 5;
            player1Art3Cost.Text = "0";
            player1Art3Cost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art4
            // 
            player1Art4.AutoEllipsis = true;
            player1Art4.AutoSize = true;
            player1Art4.Dock = DockStyle.Fill;
            player1Art4.Location = new Point(3, 87);
            player1Art4.Name = "player1Art4";
            player1Art4.Size = new Size(88, 30);
            player1Art4.TabIndex = 6;
            player1Art4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Art4Cost
            // 
            player1Art4Cost.AutoSize = true;
            player1Art4Cost.Dock = DockStyle.Fill;
            player1Art4Cost.Location = new Point(97, 87);
            player1Art4Cost.Name = "player1Art4Cost";
            player1Art4Cost.Size = new Size(19, 30);
            player1Art4Cost.TabIndex = 7;
            player1Art4Cost.Text = "0";
            player1Art4Cost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel15.Controls.Add(player1Player, 0, 0);
            tableLayoutPanel15.Controls.Add(player1MaxHP, 0, 2);
            tableLayoutPanel15.Controls.Add(player1MaxAP, 0, 4);
            tableLayoutPanel15.Controls.Add(player1Damage, 0, 5);
            tableLayoutPanel15.Controls.Add(player1PlayerDynamic, 1, 0);
            tableLayoutPanel15.Controls.Add(player1MaxHPDynamic, 1, 2);
            tableLayoutPanel15.Controls.Add(player1MaxAPDynamic, 1, 4);
            tableLayoutPanel15.Controls.Add(player1DamageDynamic, 1, 5);
            tableLayoutPanel15.Controls.Add(player1HP, 0, 1);
            tableLayoutPanel15.Controls.Add(player1AP, 0, 3);
            tableLayoutPanel15.Controls.Add(player1APDynamic, 1, 3);
            tableLayoutPanel15.Controls.Add(player1HPDynamic, 1, 1);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(3, 3);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 6;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel15.Size = new Size(125, 139);
            tableLayoutPanel15.TabIndex = 1;
            // 
            // player1Player
            // 
            player1Player.AutoSize = true;
            player1Player.Dock = DockStyle.Fill;
            player1Player.Location = new Point(3, 0);
            player1Player.Name = "player1Player";
            player1Player.Size = new Size(56, 23);
            player1Player.TabIndex = 0;
            player1Player.Text = "Player";
            player1Player.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1MaxHP
            // 
            player1MaxHP.AutoSize = true;
            player1MaxHP.Dock = DockStyle.Fill;
            player1MaxHP.Location = new Point(3, 46);
            player1MaxHP.Name = "player1MaxHP";
            player1MaxHP.Size = new Size(56, 23);
            player1MaxHP.TabIndex = 1;
            player1MaxHP.Text = "Max HP";
            player1MaxHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1MaxAP
            // 
            player1MaxAP.AutoSize = true;
            player1MaxAP.Dock = DockStyle.Fill;
            player1MaxAP.Location = new Point(3, 92);
            player1MaxAP.Name = "player1MaxAP";
            player1MaxAP.Size = new Size(56, 23);
            player1MaxAP.TabIndex = 2;
            player1MaxAP.Text = "Max AP";
            player1MaxAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1Damage
            // 
            player1Damage.AutoSize = true;
            player1Damage.Dock = DockStyle.Fill;
            player1Damage.Location = new Point(3, 115);
            player1Damage.Name = "player1Damage";
            player1Damage.Size = new Size(56, 24);
            player1Damage.TabIndex = 3;
            player1Damage.Text = "Damage";
            player1Damage.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1PlayerDynamic
            // 
            player1PlayerDynamic.AutoSize = true;
            player1PlayerDynamic.Dock = DockStyle.Fill;
            player1PlayerDynamic.Location = new Point(65, 0);
            player1PlayerDynamic.Name = "player1PlayerDynamic";
            player1PlayerDynamic.Size = new Size(57, 23);
            player1PlayerDynamic.TabIndex = 4;
            player1PlayerDynamic.Text = "None";
            player1PlayerDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1MaxHPDynamic
            // 
            player1MaxHPDynamic.AutoSize = true;
            player1MaxHPDynamic.Dock = DockStyle.Fill;
            player1MaxHPDynamic.Location = new Point(65, 46);
            player1MaxHPDynamic.Name = "player1MaxHPDynamic";
            player1MaxHPDynamic.Size = new Size(57, 23);
            player1MaxHPDynamic.TabIndex = 5;
            player1MaxHPDynamic.Text = "0";
            player1MaxHPDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1MaxAPDynamic
            // 
            player1MaxAPDynamic.AutoSize = true;
            player1MaxAPDynamic.Dock = DockStyle.Fill;
            player1MaxAPDynamic.Location = new Point(65, 92);
            player1MaxAPDynamic.Name = "player1MaxAPDynamic";
            player1MaxAPDynamic.Size = new Size(57, 23);
            player1MaxAPDynamic.TabIndex = 6;
            player1MaxAPDynamic.Text = "0";
            player1MaxAPDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1DamageDynamic
            // 
            player1DamageDynamic.AutoSize = true;
            player1DamageDynamic.Dock = DockStyle.Fill;
            player1DamageDynamic.Location = new Point(65, 115);
            player1DamageDynamic.Name = "player1DamageDynamic";
            player1DamageDynamic.Size = new Size(57, 24);
            player1DamageDynamic.TabIndex = 7;
            player1DamageDynamic.Text = "1";
            player1DamageDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1HP
            // 
            player1HP.AutoSize = true;
            player1HP.Dock = DockStyle.Fill;
            player1HP.Location = new Point(3, 23);
            player1HP.Name = "player1HP";
            player1HP.Size = new Size(56, 23);
            player1HP.TabIndex = 8;
            player1HP.Text = "HP";
            player1HP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1AP
            // 
            player1AP.AutoSize = true;
            player1AP.Dock = DockStyle.Fill;
            player1AP.Location = new Point(3, 69);
            player1AP.Name = "player1AP";
            player1AP.Size = new Size(56, 23);
            player1AP.TabIndex = 9;
            player1AP.Text = "AP";
            player1AP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // player1APDynamic
            // 
            player1APDynamic.Dock = DockStyle.Fill;
            player1APDynamic.Location = new Point(65, 72);
            player1APDynamic.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            player1APDynamic.Name = "player1APDynamic";
            player1APDynamic.Size = new Size(57, 23);
            player1APDynamic.TabIndex = 10;
            // 
            // player1HPDynamic
            // 
            player1HPDynamic.Dock = DockStyle.Fill;
            player1HPDynamic.Location = new Point(65, 26);
            player1HPDynamic.Maximum = new decimal(new int[] { 0, 0, 0, 0 });
            player1HPDynamic.Name = "player1HPDynamic";
            player1HPDynamic.Size = new Size(57, 23);
            player1HPDynamic.TabIndex = 11;
            // 
            // player1Equipment
            // 
            player1Equipment.Controls.Add(tableLayoutPanel3);
            player1Equipment.Dock = DockStyle.Fill;
            player1Equipment.Location = new Point(3, 293);
            player1Equipment.Name = "player1Equipment";
            player1Equipment.Size = new Size(125, 141);
            player1Equipment.TabIndex = 2;
            player1Equipment.TabStop = false;
            player1Equipment.Text = "Equipment";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(player1Weapon, 0, 0);
            tableLayoutPanel3.Controls.Add(player1HeadGear, 0, 1);
            tableLayoutPanel3.Controls.Add(player1TorsoGear, 0, 2);
            tableLayoutPanel3.Controls.Add(player1LegsGear, 0, 3);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 4;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Size = new Size(119, 119);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // player1Weapon
            // 
            player1Weapon.AutoEllipsis = true;
            player1Weapon.AutoSize = true;
            player1Weapon.Dock = DockStyle.Fill;
            player1Weapon.Location = new Point(3, 0);
            player1Weapon.Name = "player1Weapon";
            player1Weapon.Size = new Size(113, 29);
            player1Weapon.TabIndex = 0;
            player1Weapon.Text = "None";
            player1Weapon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1HeadGear
            // 
            player1HeadGear.AutoEllipsis = true;
            player1HeadGear.AutoSize = true;
            player1HeadGear.Dock = DockStyle.Fill;
            player1HeadGear.Location = new Point(3, 29);
            player1HeadGear.Name = "player1HeadGear";
            player1HeadGear.Size = new Size(113, 29);
            player1HeadGear.TabIndex = 1;
            player1HeadGear.Text = "None";
            player1HeadGear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1TorsoGear
            // 
            player1TorsoGear.AutoSize = true;
            player1TorsoGear.Dock = DockStyle.Fill;
            player1TorsoGear.Location = new Point(3, 58);
            player1TorsoGear.Name = "player1TorsoGear";
            player1TorsoGear.Size = new Size(113, 29);
            player1TorsoGear.TabIndex = 2;
            player1TorsoGear.Text = "None";
            player1TorsoGear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // player1LegsGear
            // 
            player1LegsGear.AutoSize = true;
            player1LegsGear.Dock = DockStyle.Fill;
            player1LegsGear.Location = new Point(3, 87);
            player1LegsGear.Name = "player1LegsGear";
            player1LegsGear.Size = new Size(113, 32);
            player1LegsGear.TabIndex = 3;
            player1LegsGear.Text = "None";
            player1LegsGear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(146, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(137, 472);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(289, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(138, 472);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // groupTension
            // 
            groupTension.Controls.Add(tableLayoutPanel11);
            groupTension.Dock = DockStyle.Fill;
            groupTension.Location = new Point(3, 3);
            groupTension.Name = "groupTension";
            groupTension.Size = new Size(436, 49);
            groupTension.TabIndex = 6;
            groupTension.TabStop = false;
            groupTension.Text = "Party Meter";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel11.Controls.Add(tableLayoutPanel12, 0, 0);
            tableLayoutPanel11.Controls.Add(numericParty, 1, 0);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 19);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new Size(430, 27);
            tableLayoutPanel11.TabIndex = 1;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel12.Controls.Add(partyMeter, 0, 0);
            tableLayoutPanel12.Controls.Add(partyOverflow, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(3, 3);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(374, 21);
            tableLayoutPanel12.TabIndex = 0;
            // 
            // partyMeter
            // 
            partyMeter.Dock = DockStyle.Fill;
            partyMeter.Location = new Point(0, 0);
            partyMeter.Margin = new Padding(0);
            partyMeter.Maximum = 12;
            partyMeter.Name = "partyMeter";
            partyMeter.Size = new Size(205, 21);
            partyMeter.Step = 1;
            partyMeter.Style = ProgressBarStyle.Continuous;
            partyMeter.TabIndex = 0;
            // 
            // partyOverflow
            // 
            partyOverflow.Dock = DockStyle.Fill;
            partyOverflow.Location = new Point(205, 0);
            partyOverflow.Margin = new Padding(0);
            partyOverflow.Maximum = 10;
            partyOverflow.Name = "partyOverflow";
            partyOverflow.Size = new Size(169, 21);
            partyOverflow.Step = 1;
            partyOverflow.Style = ProgressBarStyle.Continuous;
            partyOverflow.TabIndex = 1;
            // 
            // numericParty
            // 
            numericParty.Dock = DockStyle.Fill;
            numericParty.Location = new Point(383, 3);
            numericParty.Maximum = new decimal(new int[] { 22, 0, 0, 0 });
            numericParty.Name = "numericParty";
            numericParty.Size = new Size(44, 23);
            numericParty.TabIndex = 1;
            numericParty.ValueChanged += NumericParty_ValueChanged;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.Controls.Add(groupEnemies, 0, 0);
            tableLayoutPanel10.Controls.Add(groupInventory, 0, 1);
            tableLayoutPanel10.Controls.Add(groupStats, 0, 2);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(445, 58);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 3;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel10.Size = new Size(436, 500);
            tableLayoutPanel10.TabIndex = 5;
            // 
            // groupEnemies
            // 
            groupEnemies.Dock = DockStyle.Fill;
            groupEnemies.Location = new Point(3, 3);
            groupEnemies.Name = "groupEnemies";
            groupEnemies.Size = new Size(430, 194);
            groupEnemies.TabIndex = 1;
            groupEnemies.TabStop = false;
            groupEnemies.Text = "Enemies";
            // 
            // groupInventory
            // 
            groupInventory.Controls.Add(listInventory);
            groupInventory.Dock = DockStyle.Fill;
            groupInventory.Location = new Point(3, 203);
            groupInventory.Name = "groupInventory";
            groupInventory.Size = new Size(430, 144);
            groupInventory.TabIndex = 3;
            groupInventory.TabStop = false;
            groupInventory.Text = "Inventory";
            // 
            // listInventory
            // 
            listInventory.Dock = DockStyle.Fill;
            listInventory.FormattingEnabled = true;
            listInventory.ItemHeight = 15;
            listInventory.Location = new Point(3, 19);
            listInventory.MultiColumn = true;
            listInventory.Name = "listInventory";
            listInventory.Size = new Size(424, 122);
            listInventory.TabIndex = 1;
            // 
            // groupStats
            // 
            groupStats.Controls.Add(statisticsLayout);
            groupStats.Dock = DockStyle.Fill;
            groupStats.Location = new Point(3, 353);
            groupStats.Name = "groupStats";
            groupStats.Size = new Size(430, 144);
            groupStats.TabIndex = 2;
            groupStats.TabStop = false;
            groupStats.Text = "Statistics";
            // 
            // statisticsLayout
            // 
            statisticsLayout.ColumnCount = 1;
            statisticsLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            statisticsLayout.Controls.Add(tableLayoutPanel7, 0, 1);
            statisticsLayout.Controls.Add(tableLayoutPanel8, 0, 0);
            statisticsLayout.Dock = DockStyle.Fill;
            statisticsLayout.Location = new Point(3, 19);
            statisticsLayout.Name = "statisticsLayout";
            statisticsLayout.RowCount = 2;
            statisticsLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            statisticsLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            statisticsLayout.Size = new Size(424, 122);
            statisticsLayout.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel7.Controls.Add(openFileButton, 0, 0);
            tableLayoutPanel7.Controls.Add(fileReload, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 93);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(424, 29);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // openFileButton
            // 
            openFileButton.Dock = DockStyle.Fill;
            openFileButton.Location = new Point(3, 3);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(206, 23);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Open File...";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += OpenFileButton_Click;
            // 
            // fileReload
            // 
            fileReload.AutoEllipsis = true;
            fileReload.Dock = DockStyle.Fill;
            fileReload.Location = new Point(215, 3);
            fileReload.Name = "fileReload";
            fileReload.Size = new Size(206, 23);
            fileReload.TabIndex = 2;
            fileReload.Text = "Reload";
            fileReload.UseVisualStyleBackColor = true;
            fileReload.Click += FileReload_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Controls.Add(labelLevel, 0, 0);
            tableLayoutPanel8.Controls.Add(labelEXP, 0, 1);
            tableLayoutPanel8.Controls.Add(labelNext, 0, 2);
            tableLayoutPanel8.Controls.Add(labelLevelDynamic, 1, 0);
            tableLayoutPanel8.Controls.Add(labelEXPDynamic, 1, 1);
            tableLayoutPanel8.Controls.Add(labelNextDynamic, 1, 2);
            tableLayoutPanel8.Controls.Add(labelChapter, 2, 0);
            tableLayoutPanel8.Controls.Add(labelChapterDynamic, 3, 0);
            tableLayoutPanel8.Controls.Add(labelLocation, 2, 1);
            tableLayoutPanel8.Controls.Add(labelLocationDynamic, 3, 1);
            tableLayoutPanel8.Controls.Add(labelMoney, 2, 2);
            tableLayoutPanel8.Controls.Add(labelMoneyDynamic, 3, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25.00062F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006256F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 25.0006256F));
            tableLayoutPanel8.Size = new Size(418, 87);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // labelLevel
            // 
            labelLevel.AutoSize = true;
            labelLevel.Dock = DockStyle.Fill;
            labelLevel.Location = new Point(3, 0);
            labelLevel.Name = "labelLevel";
            labelLevel.Size = new Size(74, 28);
            labelLevel.TabIndex = 0;
            labelLevel.Text = "Level";
            labelLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEXP
            // 
            labelEXP.AutoSize = true;
            labelEXP.Dock = DockStyle.Fill;
            labelEXP.Location = new Point(3, 28);
            labelEXP.Name = "labelEXP";
            labelEXP.Size = new Size(74, 29);
            labelEXP.TabIndex = 1;
            labelEXP.Text = "Total EXP";
            labelEXP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNext
            // 
            labelNext.AutoSize = true;
            labelNext.Dock = DockStyle.Fill;
            labelNext.Location = new Point(3, 57);
            labelNext.Name = "labelNext";
            labelNext.Size = new Size(74, 30);
            labelNext.TabIndex = 2;
            labelNext.Text = "EXP to next";
            labelNext.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLevelDynamic
            // 
            labelLevelDynamic.AutoSize = true;
            labelLevelDynamic.Dock = DockStyle.Fill;
            labelLevelDynamic.Location = new Point(83, 0);
            labelLevelDynamic.Name = "labelLevelDynamic";
            labelLevelDynamic.Size = new Size(106, 28);
            labelLevelDynamic.TabIndex = 9;
            labelLevelDynamic.Text = "1";
            labelLevelDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEXPDynamic
            // 
            labelEXPDynamic.AutoSize = true;
            labelEXPDynamic.Dock = DockStyle.Fill;
            labelEXPDynamic.Location = new Point(83, 28);
            labelEXPDynamic.Name = "labelEXPDynamic";
            labelEXPDynamic.Size = new Size(106, 29);
            labelEXPDynamic.TabIndex = 10;
            labelEXPDynamic.Text = "6";
            labelEXPDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelNextDynamic
            // 
            labelNextDynamic.AutoSize = true;
            labelNextDynamic.Dock = DockStyle.Fill;
            labelNextDynamic.Location = new Point(83, 57);
            labelNextDynamic.Name = "labelNextDynamic";
            labelNextDynamic.Size = new Size(106, 30);
            labelNextDynamic.TabIndex = 13;
            labelNextDynamic.Text = "15";
            labelNextDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelChapter
            // 
            labelChapter.AutoSize = true;
            labelChapter.Dock = DockStyle.Fill;
            labelChapter.Location = new Point(195, 0);
            labelChapter.Name = "labelChapter";
            labelChapter.Size = new Size(106, 28);
            labelChapter.TabIndex = 3;
            labelChapter.Text = "Chapter";
            labelChapter.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelChapterDynamic
            // 
            labelChapterDynamic.AutoSize = true;
            labelChapterDynamic.Dock = DockStyle.Fill;
            labelChapterDynamic.Location = new Point(307, 0);
            labelChapterDynamic.Name = "labelChapterDynamic";
            labelChapterDynamic.Size = new Size(108, 28);
            labelChapterDynamic.TabIndex = 8;
            labelChapterDynamic.Text = "1";
            labelChapterDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Dock = DockStyle.Fill;
            labelLocation.Location = new Point(195, 28);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(106, 29);
            labelLocation.TabIndex = 14;
            labelLocation.Text = "Location";
            labelLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelLocationDynamic
            // 
            labelLocationDynamic.AutoSize = true;
            labelLocationDynamic.Dock = DockStyle.Fill;
            labelLocationDynamic.Location = new Point(307, 28);
            labelLocationDynamic.Name = "labelLocationDynamic";
            labelLocationDynamic.Size = new Size(108, 29);
            labelLocationDynamic.TabIndex = 15;
            labelLocationDynamic.Text = "Colony A";
            labelLocationDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMoney
            // 
            labelMoney.AutoSize = true;
            labelMoney.Dock = DockStyle.Fill;
            labelMoney.Location = new Point(195, 57);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new Size(106, 30);
            labelMoney.TabIndex = 16;
            labelMoney.Text = "Money";
            labelMoney.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelMoneyDynamic
            // 
            labelMoneyDynamic.AutoSize = true;
            labelMoneyDynamic.Dock = DockStyle.Fill;
            labelMoneyDynamic.Location = new Point(307, 57);
            labelMoneyDynamic.Name = "labelMoneyDynamic";
            labelMoneyDynamic.Size = new Size(108, 30);
            labelMoneyDynamic.TabIndex = 17;
            labelMoneyDynamic.Text = "0 G";
            labelMoneyDynamic.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(tableLayoutPanel16, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(445, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(436, 49);
            tableLayoutPanel9.TabIndex = 7;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
            tableLayoutPanel16.Controls.Add(turnCounter, 1, 0);
            tableLayoutPanel16.Controls.Add(labelTurn, 0, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(3, 3);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(114, 43);
            tableLayoutPanel16.TabIndex = 0;
            // 
            // turnCounter
            // 
            turnCounter.Dock = DockStyle.Fill;
            turnCounter.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            turnCounter.Location = new Point(64, 3);
            turnCounter.Margin = new Padding(0, 3, 3, 3);
            turnCounter.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            turnCounter.Name = "turnCounter";
            turnCounter.Size = new Size(47, 36);
            turnCounter.TabIndex = 0;
            // 
            // labelTurn
            // 
            labelTurn.AutoSize = true;
            labelTurn.Dock = DockStyle.Fill;
            labelTurn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            labelTurn.Location = new Point(0, 0);
            labelTurn.Margin = new Padding(0);
            labelTurn.Name = "labelTurn";
            labelTurn.Size = new Size(64, 43);
            labelTurn.TabIndex = 1;
            labelTurn.Text = "Turn";
            labelTurn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // openFileDialog
            // 
            openFileDialog.DefaultExt = "json";
            openFileDialog.FileName = "openFileDialog";
            openFileDialog.Filter = "JavaScript Object Notation|*.json|All files|*.*";
            openFileDialog.FileOk += OpenFileDialog_FileOk;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(200, 100);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Top;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(194, 23);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "XenoStars Battle Calculator";
            tableLayoutPanel1.ResumeLayout(false);
            alliesGroup.ResumeLayout(false);
            alliesLayout.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel13.ResumeLayout(false);
            player1Arts.ResumeLayout(false);
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)player1APDynamic).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1HPDynamic).EndInit();
            player1Equipment.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupTension.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericParty).EndInit();
            tableLayoutPanel10.ResumeLayout(false);
            groupInventory.ResumeLayout(false);
            groupStats.ResumeLayout(false);
            statisticsLayout.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)turnCounter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox alliesGroup;
        private GroupBox groupEnemies;
        private GroupBox groupStats;
        private GroupBox groupInventory;
        private OpenFileDialog openFileDialog;
        private ListBox listInventory;
        private TableLayoutPanel alliesLayout;
        private ComboBox allies1;
        private TableLayoutPanel statisticsLayout;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBox1;
        private TableLayoutPanel tableLayoutPanel7;
        private Button openFileButton;
        private TableLayoutPanel tableLayoutPanel8;
        private Label labelLevel;
        private Label labelEXP;
        private Label labelNext;
        private Label labelChapter;
        private Label labelChapterDynamic;
        private Label labelLevelDynamic;
        private Label labelEXPDynamic;
        private Label labelNextDynamic;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel12;
        private ProgressBar partyMeter;
        private ProgressBar partyOverflow;
        private NumericUpDown numericParty;
        private TableLayoutPanel tableLayoutPanel13;
        private GroupBox player1Arts;
        private TableLayoutPanel tableLayoutPanel14;
        private TableLayoutPanel tableLayoutPanel15;
        private Label player1Player;
        private Label player1MaxHP;
        private Label player1MaxAP;
        private Label player1Damage;
        private Label player1PlayerDynamic;
        private Label player1MaxHPDynamic;
        private Label player1MaxAPDynamic;
        private Button fileReload;
        private Label player1DamageDynamic;
        private Label labelLocation;
        private GroupBox groupTension;
        private Label labelLocationDynamic;
        private Label labelMoney;
        private Label labelMoneyDynamic;
        private GroupBox player1Equipment;
        private TableLayoutPanel tableLayoutPanel3;
        private Label player1Art1;
        private Label player1Art2;
        private Label player1Art1Cost;
        private Label player1Art2Cost;
        private Label player1Art3;
        private Label player1Art3Cost;
        private Label player1HP;
        private Label player1AP;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel16;
        private NumericUpDown turnCounter;
        private Label labelTurn;
        private Label player1Art4;
        private Label player1Art4Cost;
        private NumericUpDown player1APDynamic;
        private NumericUpDown player1HPDynamic;
        private Label player1Weapon;
        private Label player1HeadGear;
        private Label player1TorsoGear;
        private Label player1LegsGear;
    }
}
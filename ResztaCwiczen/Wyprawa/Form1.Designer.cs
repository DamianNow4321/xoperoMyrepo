
namespace Wyprawa
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayerSprite = new System.Windows.Forms.PictureBox();
            this.SwordSprite = new System.Windows.Forms.PictureBox();
            this.BatSprite = new System.Windows.Forms.PictureBox();
            this.GhoulSprite = new System.Windows.Forms.PictureBox();
            this.GhostSprite = new System.Windows.Forms.PictureBox();
            this.BowSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionSprite = new System.Windows.Forms.PictureBox();
            this.MaceSprite = new System.Windows.Forms.PictureBox();
            this.SwordInvSprite = new System.Windows.Forms.PictureBox();
            this.RedPotionInvSprite = new System.Windows.Forms.PictureBox();
            this.BluePotionInvSprite = new System.Windows.Forms.PictureBox();
            this.BowInvSprite = new System.Windows.Forms.PictureBox();
            this.MaceInvSprite = new System.Windows.Forms.PictureBox();
            this.HitPointPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerHitPointsCaption = new System.Windows.Forms.Label();
            this.BatHitPointsCaption = new System.Windows.Forms.Label();
            this.GhostHitPointsCaption = new System.Windows.Forms.Label();
            this.GhoulHitPointsCaption = new System.Windows.Forms.Label();
            this.PlayerHitPoints = new System.Windows.Forms.Label();
            this.BatHitPoints = new System.Windows.Forms.Label();
            this.GhostHitPoints = new System.Windows.Forms.Label();
            this.GhoulHitPoints = new System.Windows.Forms.Label();
            this.MovePanel = new System.Windows.Forms.TableLayoutPanel();
            this.MPanelCaption = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.MoveRight = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.AttackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.APanelCaption = new System.Windows.Forms.Label();
            this.AttackUp = new System.Windows.Forms.Button();
            this.AttackLeft = new System.Windows.Forms.Button();
            this.AttackRight = new System.Windows.Forms.Button();
            this.AttackDown = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).BeginInit();
            this.HitPointPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.AttackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerSprite
            // 
            this.PlayerSprite.BackColor = System.Drawing.Color.Transparent;
            this.PlayerSprite.Image = global::Wyprawa.Properties.Resources.player;
            this.PlayerSprite.Location = new System.Drawing.Point(76, 57);
            this.PlayerSprite.Name = "PlayerSprite";
            this.PlayerSprite.Size = new System.Drawing.Size(30, 30);
            this.PlayerSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerSprite.TabIndex = 0;
            this.PlayerSprite.TabStop = false;
            // 
            // SwordSprite
            // 
            this.SwordSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordSprite.Image = global::Wyprawa.Properties.Resources.sword;
            this.SwordSprite.Location = new System.Drawing.Point(112, 57);
            this.SwordSprite.Name = "SwordSprite";
            this.SwordSprite.Size = new System.Drawing.Size(30, 30);
            this.SwordSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordSprite.TabIndex = 1;
            this.SwordSprite.TabStop = false;
            this.SwordSprite.Visible = false;
            // 
            // BatSprite
            // 
            this.BatSprite.BackColor = System.Drawing.Color.Transparent;
            this.BatSprite.Image = global::Wyprawa.Properties.Resources.bat;
            this.BatSprite.Location = new System.Drawing.Point(148, 57);
            this.BatSprite.Name = "BatSprite";
            this.BatSprite.Size = new System.Drawing.Size(30, 30);
            this.BatSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BatSprite.TabIndex = 2;
            this.BatSprite.TabStop = false;
            this.BatSprite.Visible = false;
            // 
            // GhoulSprite
            // 
            this.GhoulSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhoulSprite.Image = global::Wyprawa.Properties.Resources.ghoul;
            this.GhoulSprite.Location = new System.Drawing.Point(184, 57);
            this.GhoulSprite.Name = "GhoulSprite";
            this.GhoulSprite.Size = new System.Drawing.Size(30, 30);
            this.GhoulSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhoulSprite.TabIndex = 3;
            this.GhoulSprite.TabStop = false;
            this.GhoulSprite.Visible = false;
            // 
            // GhostSprite
            // 
            this.GhostSprite.BackColor = System.Drawing.Color.Transparent;
            this.GhostSprite.Image = global::Wyprawa.Properties.Resources.ghost;
            this.GhostSprite.Location = new System.Drawing.Point(220, 57);
            this.GhostSprite.Name = "GhostSprite";
            this.GhostSprite.Size = new System.Drawing.Size(30, 30);
            this.GhostSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GhostSprite.TabIndex = 4;
            this.GhostSprite.TabStop = false;
            this.GhostSprite.Visible = false;
            // 
            // BowSprite
            // 
            this.BowSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowSprite.Image = global::Wyprawa.Properties.Resources.bow;
            this.BowSprite.Location = new System.Drawing.Point(256, 57);
            this.BowSprite.Name = "BowSprite";
            this.BowSprite.Size = new System.Drawing.Size(30, 30);
            this.BowSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowSprite.TabIndex = 5;
            this.BowSprite.TabStop = false;
            this.BowSprite.Visible = false;
            // 
            // RedPotionSprite
            // 
            this.RedPotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionSprite.Image = global::Wyprawa.Properties.Resources.potion_red;
            this.RedPotionSprite.Location = new System.Drawing.Point(292, 57);
            this.RedPotionSprite.Name = "RedPotionSprite";
            this.RedPotionSprite.Size = new System.Drawing.Size(30, 30);
            this.RedPotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionSprite.TabIndex = 6;
            this.RedPotionSprite.TabStop = false;
            this.RedPotionSprite.Visible = false;
            // 
            // BluePotionSprite
            // 
            this.BluePotionSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionSprite.Image = global::Wyprawa.Properties.Resources.potion_blue;
            this.BluePotionSprite.Location = new System.Drawing.Point(328, 57);
            this.BluePotionSprite.Name = "BluePotionSprite";
            this.BluePotionSprite.Size = new System.Drawing.Size(30, 30);
            this.BluePotionSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BluePotionSprite.TabIndex = 7;
            this.BluePotionSprite.TabStop = false;
            this.BluePotionSprite.Visible = false;
            // 
            // MaceSprite
            // 
            this.MaceSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceSprite.Image = global::Wyprawa.Properties.Resources.mace;
            this.MaceSprite.Location = new System.Drawing.Point(364, 57);
            this.MaceSprite.Name = "MaceSprite";
            this.MaceSprite.Size = new System.Drawing.Size(30, 30);
            this.MaceSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MaceSprite.TabIndex = 8;
            this.MaceSprite.TabStop = false;
            this.MaceSprite.Visible = false;
            // 
            // SwordInvSprite
            // 
            this.SwordInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.SwordInvSprite.Image = global::Wyprawa.Properties.Resources.sword;
            this.SwordInvSprite.Location = new System.Drawing.Point(94, 321);
            this.SwordInvSprite.Name = "SwordInvSprite";
            this.SwordInvSprite.Size = new System.Drawing.Size(50, 50);
            this.SwordInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SwordInvSprite.TabIndex = 9;
            this.SwordInvSprite.TabStop = false;
            this.SwordInvSprite.Visible = false;
            this.SwordInvSprite.Click += new System.EventHandler(this.SwordInvSprite_Click);
            // 
            // RedPotionInvSprite
            // 
            this.RedPotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.RedPotionInvSprite.Image = global::Wyprawa.Properties.Resources.potion_red;
            this.RedPotionInvSprite.Location = new System.Drawing.Point(156, 321);
            this.RedPotionInvSprite.Name = "RedPotionInvSprite";
            this.RedPotionInvSprite.Size = new System.Drawing.Size(50, 50);
            this.RedPotionInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RedPotionInvSprite.TabIndex = 10;
            this.RedPotionInvSprite.TabStop = false;
            this.RedPotionInvSprite.Visible = false;
            this.RedPotionInvSprite.Click += new System.EventHandler(this.RedPotionInvSprite_Click);
            // 
            // BluePotionInvSprite
            // 
            this.BluePotionInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BluePotionInvSprite.Image = global::Wyprawa.Properties.Resources.potion_blue;
            this.BluePotionInvSprite.Location = new System.Drawing.Point(280, 321);
            this.BluePotionInvSprite.Name = "BluePotionInvSprite";
            this.BluePotionInvSprite.Size = new System.Drawing.Size(50, 50);
            this.BluePotionInvSprite.TabIndex = 11;
            this.BluePotionInvSprite.TabStop = false;
            this.BluePotionInvSprite.Visible = false;
            this.BluePotionInvSprite.Click += new System.EventHandler(this.BluePotionInvSprite_Click);
            // 
            // BowInvSprite
            // 
            this.BowInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.BowInvSprite.Image = global::Wyprawa.Properties.Resources.bow;
            this.BowInvSprite.Location = new System.Drawing.Point(218, 321);
            this.BowInvSprite.Name = "BowInvSprite";
            this.BowInvSprite.Size = new System.Drawing.Size(50, 50);
            this.BowInvSprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BowInvSprite.TabIndex = 12;
            this.BowInvSprite.TabStop = false;
            this.BowInvSprite.Visible = false;
            this.BowInvSprite.Click += new System.EventHandler(this.BowInvSprite_Click);
            // 
            // MaceInvSprite
            // 
            this.MaceInvSprite.BackColor = System.Drawing.Color.Transparent;
            this.MaceInvSprite.Image = global::Wyprawa.Properties.Resources.mace;
            this.MaceInvSprite.Location = new System.Drawing.Point(342, 321);
            this.MaceInvSprite.Name = "MaceInvSprite";
            this.MaceInvSprite.Size = new System.Drawing.Size(50, 50);
            this.MaceInvSprite.TabIndex = 13;
            this.MaceInvSprite.TabStop = false;
            this.MaceInvSprite.Visible = false;
            this.MaceInvSprite.Click += new System.EventHandler(this.MaceInvSprite_Click);
            // 
            // HitPointPanel
            // 
            this.HitPointPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.HitPointPanel.ColumnCount = 2;
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.30769F));
            this.HitPointPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.69231F));
            this.HitPointPanel.Controls.Add(this.PlayerHitPointsCaption, 0, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPointsCaption, 0, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPointsCaption, 0, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPointsCaption, 0, 3);
            this.HitPointPanel.Controls.Add(this.PlayerHitPoints, 1, 0);
            this.HitPointPanel.Controls.Add(this.BatHitPoints, 1, 1);
            this.HitPointPanel.Controls.Add(this.GhostHitPoints, 1, 2);
            this.HitPointPanel.Controls.Add(this.GhoulHitPoints, 1, 3);
            this.HitPointPanel.Location = new System.Drawing.Point(619, 286);
            this.HitPointPanel.Name = "HitPointPanel";
            this.HitPointPanel.RowCount = 4;
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.HitPointPanel.Size = new System.Drawing.Size(196, 118);
            this.HitPointPanel.TabIndex = 14;
            // 
            // PlayerHitPointsCaption
            // 
            this.PlayerHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPointsCaption.AutoSize = true;
            this.PlayerHitPointsCaption.Location = new System.Drawing.Point(4, 8);
            this.PlayerHitPointsCaption.Name = "PlayerHitPointsCaption";
            this.PlayerHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.PlayerHitPointsCaption.TabIndex = 0;
            this.PlayerHitPointsCaption.Text = "Gracz";
            // 
            // BatHitPointsCaption
            // 
            this.BatHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPointsCaption.AutoSize = true;
            this.BatHitPointsCaption.Location = new System.Drawing.Point(4, 37);
            this.BatHitPointsCaption.Name = "BatHitPointsCaption";
            this.BatHitPointsCaption.Size = new System.Drawing.Size(52, 13);
            this.BatHitPointsCaption.TabIndex = 1;
            this.BatHitPointsCaption.Text = "Nietoperz";
            // 
            // GhostHitPointsCaption
            // 
            this.GhostHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPointsCaption.AutoSize = true;
            this.GhostHitPointsCaption.Location = new System.Drawing.Point(4, 66);
            this.GhostHitPointsCaption.Name = "GhostHitPointsCaption";
            this.GhostHitPointsCaption.Size = new System.Drawing.Size(33, 13);
            this.GhostHitPointsCaption.TabIndex = 2;
            this.GhostHitPointsCaption.Text = "Duch";
            // 
            // GhoulHitPointsCaption
            // 
            this.GhoulHitPointsCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPointsCaption.AutoSize = true;
            this.GhoulHitPointsCaption.Location = new System.Drawing.Point(4, 96);
            this.GhoulHitPointsCaption.Name = "GhoulHitPointsCaption";
            this.GhoulHitPointsCaption.Size = new System.Drawing.Size(35, 13);
            this.GhoulHitPointsCaption.TabIndex = 3;
            this.GhoulHitPointsCaption.Text = "Ghoul";
            // 
            // PlayerHitPoints
            // 
            this.PlayerHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PlayerHitPoints.AutoSize = true;
            this.PlayerHitPoints.Location = new System.Drawing.Point(105, 8);
            this.PlayerHitPoints.Name = "PlayerHitPoints";
            this.PlayerHitPoints.Size = new System.Drawing.Size(50, 13);
            this.PlayerHitPoints.TabIndex = 4;
            this.PlayerHitPoints.Text = "GraczHP";
            // 
            // BatHitPoints
            // 
            this.BatHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BatHitPoints.AutoSize = true;
            this.BatHitPoints.Location = new System.Drawing.Point(105, 37);
            this.BatHitPoints.Name = "BatHitPoints";
            this.BatHitPoints.Size = new System.Drawing.Size(67, 13);
            this.BatHitPoints.TabIndex = 5;
            this.BatHitPoints.Text = "NietoperzHP";
            // 
            // GhostHitPoints
            // 
            this.GhostHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhostHitPoints.AutoSize = true;
            this.GhostHitPoints.Location = new System.Drawing.Point(105, 66);
            this.GhostHitPoints.Name = "GhostHitPoints";
            this.GhostHitPoints.Size = new System.Drawing.Size(48, 13);
            this.GhostHitPoints.TabIndex = 6;
            this.GhostHitPoints.Text = "DuchHP";
            // 
            // GhoulHitPoints
            // 
            this.GhoulHitPoints.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GhoulHitPoints.AutoSize = true;
            this.GhoulHitPoints.Location = new System.Drawing.Point(105, 96);
            this.GhoulHitPoints.Name = "GhoulHitPoints";
            this.GhoulHitPoints.Size = new System.Drawing.Size(50, 13);
            this.GhoulHitPoints.TabIndex = 7;
            this.GhoulHitPoints.Text = "GhoulHP";
            // 
            // MovePanel
            // 
            this.MovePanel.ColumnCount = 2;
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.04082F));
            this.MovePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.95918F));
            this.MovePanel.Controls.Add(this.MPanelCaption, 0, 0);
            this.MovePanel.Controls.Add(this.MoveUp, 0, 1);
            this.MovePanel.Controls.Add(this.MoveLeft, 0, 2);
            this.MovePanel.Controls.Add(this.MoveRight, 1, 2);
            this.MovePanel.Controls.Add(this.MoveDown, 0, 3);
            this.MovePanel.Location = new System.Drawing.Point(619, 12);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.RowCount = 4;
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.MovePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MovePanel.Size = new System.Drawing.Size(196, 131);
            this.MovePanel.TabIndex = 15;
            // 
            // MPanelCaption
            // 
            this.MPanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MPanelCaption.AutoSize = true;
            this.MPanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MPanelCaption.Location = new System.Drawing.Point(3, 5);
            this.MPanelCaption.Name = "MPanelCaption";
            this.MPanelCaption.Size = new System.Drawing.Size(93, 18);
            this.MPanelCaption.TabIndex = 4;
            this.MPanelCaption.Text = "Poruszanie";
            // 
            // MoveUp
            // 
            this.MoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveUp, 2);
            this.MoveUp.Location = new System.Drawing.Point(67, 33);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(61, 24);
            this.MoveUp.TabIndex = 0;
            this.MoveUp.Text = "Góra";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveLeft
            // 
            this.MoveLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveLeft.Location = new System.Drawing.Point(20, 67);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(61, 24);
            this.MoveLeft.TabIndex = 1;
            this.MoveLeft.Text = "Lewo";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // MoveRight
            // 
            this.MoveRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MoveRight.Location = new System.Drawing.Point(118, 67);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(61, 24);
            this.MoveRight.TabIndex = 2;
            this.MoveRight.Text = "Prawo";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovePanel.SetColumnSpan(this.MoveDown, 2);
            this.MoveDown.Location = new System.Drawing.Point(67, 101);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(61, 24);
            this.MoveDown.TabIndex = 3;
            this.MoveDown.Text = "Dół";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // AttackPanel
            // 
            this.AttackPanel.ColumnCount = 2;
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.53061F));
            this.AttackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.46939F));
            this.AttackPanel.Controls.Add(this.APanelCaption, 0, 0);
            this.AttackPanel.Controls.Add(this.AttackUp, 0, 1);
            this.AttackPanel.Controls.Add(this.AttackLeft, 0, 2);
            this.AttackPanel.Controls.Add(this.AttackRight, 1, 2);
            this.AttackPanel.Controls.Add(this.AttackDown, 0, 3);
            this.AttackPanel.Location = new System.Drawing.Point(619, 149);
            this.AttackPanel.Name = "AttackPanel";
            this.AttackPanel.RowCount = 4;
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.AttackPanel.Size = new System.Drawing.Size(196, 131);
            this.AttackPanel.TabIndex = 16;
            // 
            // APanelCaption
            // 
            this.APanelCaption.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.APanelCaption.AutoSize = true;
            this.APanelCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APanelCaption.Location = new System.Drawing.Point(3, 5);
            this.APanelCaption.Name = "APanelCaption";
            this.APanelCaption.Size = new System.Drawing.Size(41, 18);
            this.APanelCaption.TabIndex = 0;
            this.APanelCaption.Text = "Atak";
            // 
            // AttackUp
            // 
            this.AttackUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackUp, 2);
            this.AttackUp.Location = new System.Drawing.Point(67, 33);
            this.AttackUp.Name = "AttackUp";
            this.AttackUp.Size = new System.Drawing.Size(61, 24);
            this.AttackUp.TabIndex = 1;
            this.AttackUp.Text = "Góra";
            this.AttackUp.UseVisualStyleBackColor = true;
            this.AttackUp.Click += new System.EventHandler(this.AttackUp_Click);
            // 
            // AttackLeft
            // 
            this.AttackLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackLeft.Location = new System.Drawing.Point(19, 67);
            this.AttackLeft.Name = "AttackLeft";
            this.AttackLeft.Size = new System.Drawing.Size(61, 24);
            this.AttackLeft.TabIndex = 2;
            this.AttackLeft.Text = "Lewo";
            this.AttackLeft.UseVisualStyleBackColor = true;
            this.AttackLeft.Click += new System.EventHandler(this.AttackLeft_Click);
            // 
            // AttackRight
            // 
            this.AttackRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackRight.Location = new System.Drawing.Point(117, 67);
            this.AttackRight.Name = "AttackRight";
            this.AttackRight.Size = new System.Drawing.Size(61, 24);
            this.AttackRight.TabIndex = 3;
            this.AttackRight.Text = "Prawo";
            this.AttackRight.UseVisualStyleBackColor = true;
            this.AttackRight.Click += new System.EventHandler(this.AttackRight_Click);
            // 
            // AttackDown
            // 
            this.AttackDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttackPanel.SetColumnSpan(this.AttackDown, 2);
            this.AttackDown.Location = new System.Drawing.Point(67, 101);
            this.AttackDown.Name = "AttackDown";
            this.AttackDown.Size = new System.Drawing.Size(61, 24);
            this.AttackDown.TabIndex = 4;
            this.AttackDown.Text = "Dół";
            this.AttackDown.UseVisualStyleBackColor = true;
            this.AttackDown.Click += new System.EventHandler(this.AttackDown_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wyprawa.Properties.Resources.dungeon600x400;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(827, 431);
            this.Controls.Add(this.AttackPanel);
            this.Controls.Add(this.HitPointPanel);
            this.Controls.Add(this.MaceInvSprite);
            this.Controls.Add(this.BowInvSprite);
            this.Controls.Add(this.BluePotionInvSprite);
            this.Controls.Add(this.RedPotionInvSprite);
            this.Controls.Add(this.SwordInvSprite);
            this.Controls.Add(this.PlayerSprite);
            this.Controls.Add(this.GhostSprite);
            this.Controls.Add(this.GhoulSprite);
            this.Controls.Add(this.BatSprite);
            this.Controls.Add(this.MaceSprite);
            this.Controls.Add(this.BluePotionSprite);
            this.Controls.Add(this.RedPotionSprite);
            this.Controls.Add(this.BowSprite);
            this.Controls.Add(this.SwordSprite);
            this.Controls.Add(this.MovePanel);
            this.Name = "Form1";
            this.Text = "Wyprawa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayerSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BatSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhoulSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GhostSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SwordInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RedPotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BluePotionInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BowInvSprite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaceInvSprite)).EndInit();
            this.HitPointPanel.ResumeLayout(false);
            this.HitPointPanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            this.AttackPanel.ResumeLayout(false);
            this.AttackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerSprite;
        private System.Windows.Forms.PictureBox SwordSprite;
        private System.Windows.Forms.PictureBox BatSprite;
        private System.Windows.Forms.PictureBox GhoulSprite;
        private System.Windows.Forms.PictureBox GhostSprite;
        private System.Windows.Forms.PictureBox BowSprite;
        private System.Windows.Forms.PictureBox RedPotionSprite;
        private System.Windows.Forms.PictureBox BluePotionSprite;
        private System.Windows.Forms.PictureBox MaceSprite;
        private System.Windows.Forms.PictureBox SwordInvSprite;
        private System.Windows.Forms.PictureBox RedPotionInvSprite;
        private System.Windows.Forms.PictureBox BluePotionInvSprite;
        private System.Windows.Forms.PictureBox BowInvSprite;
        private System.Windows.Forms.PictureBox MaceInvSprite;
        private System.Windows.Forms.TableLayoutPanel HitPointPanel;
        private System.Windows.Forms.Label PlayerHitPointsCaption;
        private System.Windows.Forms.Label BatHitPointsCaption;
        private System.Windows.Forms.Label GhostHitPointsCaption;
        private System.Windows.Forms.Label GhoulHitPointsCaption;
        private System.Windows.Forms.Label PlayerHitPoints;
        private System.Windows.Forms.Label BatHitPoints;
        private System.Windows.Forms.Label GhostHitPoints;
        private System.Windows.Forms.Label GhoulHitPoints;
        private System.Windows.Forms.TableLayoutPanel MovePanel;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.Label MPanelCaption;
        private System.Windows.Forms.TableLayoutPanel AttackPanel;
        private System.Windows.Forms.Label APanelCaption;
        private System.Windows.Forms.Button AttackUp;
        private System.Windows.Forms.Button AttackLeft;
        private System.Windows.Forms.Button AttackRight;
        private System.Windows.Forms.Button AttackDown;
    }
}


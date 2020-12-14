using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyprawa
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random = new Random();
        Control weaponControl = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }
        private void SwordInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(SwordInvSprite, "Miecz", "weapon");
        }
        private void RedPotionInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(RedPotionInvSprite, "Czerwony Potion", "potion");
        }
        private void BowInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(BowInvSprite, "Łuk", "weapon");
        }
        private void BluePotionInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(BluePotionInvSprite, "Niebieski Potion", "potion");
        }
        private void MaceInvSprite_Click(object sender, EventArgs e)
        {
            SelectInventoryItem(MaceInvSprite, "Maczuga", "weapon");
        }
        private void SelectInventoryItem(PictureBox itemSprite, string itemName, string weaponType)
        {
            if (game.CheckPlayerInventory(itemName))
            {
                game.Equip(itemName);
                RemoveInventorySpriteBorders();
                itemSprite.BorderStyle = BorderStyle.FixedSingle;
                SetupAttackButtons(weaponType);
            }
        }
        private void RemoveInventorySpriteBorders()
        {
            SwordInvSprite.BorderStyle = BorderStyle.None;
            RedPotionInvSprite.BorderStyle = BorderStyle.None;
            BowInvSprite.BorderStyle = BorderStyle.None;
            BluePotionInvSprite.BorderStyle = BorderStyle.None;
            MaceInvSprite.BorderStyle = BorderStyle.None;
        }
        private void SetupAttackButtons(string weaponType)
        {
            switch (weaponType.ToLower())
            {
                case "weapon":
                    AttackUp.Text = "Góra";
                    AttackRight.Visible = true;
                    AttackDown.Visible = true;
                    AttackLeft.Visible = true;
                    break;
                case "potion":
                    AttackUp.Text = "Pij";
                    AttackRight.Visible = false;
                    AttackDown.Visible = false;
                    AttackLeft.Visible = false;
                    break;
            }
        }
        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }
        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }
        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }
        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }
        private void AttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
        }
        private void AttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }
        private void AttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();
        }
        private void AttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();
        }
        public bool UpdateEnemySprite(Enemy enemy, PictureBox enemySprite, Label enemyHitPoints)
        {
            bool enemySpriteUpdated = false;

            enemyHitPoints.Text = enemy.HitPoints.ToString();

            if (enemy.HitPoints > 0)
            {
                enemySprite.Location = enemy.Location;
                enemySprite.Visible = true;
                enemySpriteUpdated = true;
            }
            else
            {
                enemySprite.Visible = false;
            }

            return enemySpriteUpdated;
        }
        public void UpdateCharacters()
        {
            PlayerSprite.Location = game.PlayerLocation;
            PlayerHitPoints.Text = game.PlayerHitPoints.ToString();
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    if (UpdateEnemySprite(enemy, BatSprite, BatHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    if (UpdateEnemySprite(enemy, GhostSprite, GhostHitPoints))
                    {
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    if (UpdateEnemySprite(enemy, GhoulSprite, GhoulHitPoints))
                    {
                        enemiesShown++;
                    }
                }
            }
            SwordSprite.Visible = false;
            BowSprite.Visible = false;
            MaceSprite.Visible = false;
            RedPotionSprite.Visible = false;
            BluePotionSprite.Visible = false;
            if (game.WeaponInRoom != null)
            {
                Control weaponControl = null;
                switch (game.WeaponInRoom.Name)
                {
                    case "Miecz":
                        weaponControl = SwordSprite;
                        break;
                    case "Łuk":
                        weaponControl = BowSprite;
                        break;
                    case "Maczuga":
                        weaponControl = MaceSprite;
                        break;
                    case "Czerwony Potion":
                        weaponControl = RedPotionSprite;
                        break;
                    case "Niebieski Potion":
                        weaponControl = BluePotionSprite;
                        break;
                }
                if (game.WeaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;
                }
                else
                {
                    weaponControl.Visible = true;
                    weaponControl.Location = game.WeaponInRoom.Location;
                }
            }
            SwordInvSprite.Visible = false;
            BowInvSprite.Visible = false;
            MaceInvSprite.Visible = false;
            RedPotionInvSprite.Visible = false;
            BluePotionInvSprite.Visible = false;
            if (game.CheckPlayerInventory("Miecz"))
            {
                SwordInvSprite.Visible = true;
            }
            if (game.CheckPlayerInventory("Łuk"))
            {
                BowInvSprite.Visible = true;
            }
            if (game.CheckPlayerInventory("Maczuga"))
            {
                MaceInvSprite.Visible = true;
            }
            if (game.CheckPlayerInventory("Czerwony Potion"))
            {
                if (!game.CheckPotionUsed("Czerwony Potion"))
                {
                    RedPotionInvSprite.Visible = true;
                }
            }
            if (game.CheckPlayerInventory("Niebieski Potion"))
            {
                if (!game.CheckPotionUsed("Niebieski Potion"))
                {
                    BluePotionInvSprite.Visible = true;
                }
            }
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("Nie żyjesz");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("Pokonałeś wszytkich przeciwników na tym poziomie");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }
    }
}

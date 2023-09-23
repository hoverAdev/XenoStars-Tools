using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using Windows.Media.Playback;

namespace XenoStars_Battle
{
    public partial class Form1 : Form
    {
        public SaveFile mainSave = new();
        public SaveFile enemySave = new();

        public Form1()
        {
            InitializeComponent();
        }

        public double GetAPMultiplier()
        {
            var level = mainSave.Level;
            if (level < 10) { return 1.0; }
            else if (level < 20) { return 1.1; }
            else if (level < 30) { return 1.3; }
            else if (level < 40) { return 1.6; }
            else if (level < 50) { return 2.0; }
            else if (level < 60) { return 2.5; }
            else if (level < 70) { return 3.1; }
            else if (level < 80) { return 3.8; }
            else if (level < 90) { return 4.6; }
            else if (level < 100) { return 5.5; }
            else { return 6.5; }
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string friendlyName = openFileDialog.FileName.Split("\\")[^1];
            fileReload.Text = $"Reload {friendlyName}";

            var raw = File.ReadAllText(openFileDialog.FileName);
            var deserialize = JsonSerializer.Deserialize<SaveFile>(raw);

            mainSave.Level = Convert.ToByte(deserialize.Level);
            labelLevelDynamic.Text = deserialize.Level.ToString();

            mainSave.Experience = deserialize.Experience;
            labelEXPDynamic.Text = deserialize.Experience.ToString();

            var level = Convert.ToDouble(mainSave.Level) + 1;
            var nextExp = Math.Ceiling(((10 * Math.Pow(level, 2)) + Math.Floor(Math.Pow(2, (level / 6)))) / 2);
            labelNextDynamic.Text = Convert.ToString(nextExp - mainSave.Experience);

            mainSave.Chapter = Convert.ToByte(deserialize.Chapter);
            labelChapterDynamic.Text = deserialize.Chapter.ToString();

            mainSave.Location = deserialize.Location;
            labelLocationDynamic.Text = deserialize.Location;

            mainSave.Money = deserialize.Money;
            labelMoneyDynamic.Text = Convert.ToString(deserialize.Money) + " G";

            mainSave.Inventory.Clear();
            foreach (String item in deserialize.Inventory)
            {
                mainSave.Inventory.Add(item);
            }

            listInventory.BeginUpdate();
            listInventory.Items.Clear();
            foreach (String item in deserialize.Inventory)
            {
                listInventory.Items.Add(item);
            }
            listInventory.EndUpdate();

            allies1.BeginUpdate();
            allies2.BeginUpdate();
            allies3.BeginUpdate();

            var a1Index = allies1.SelectedIndex;
            var a2Index = allies2.SelectedIndex;
            var a3Index = allies3.SelectedIndex;

            allies1.SelectedIndex = 0;
            allies2.SelectedIndex = 0;
            allies3.SelectedIndex = 0;

            allies1.Items.Clear();
            allies2.Items.Clear();
            allies3.Items.Clear();
            mainSave.Characters.Clear();

            foreach (Character character in deserialize.Characters)
            {
                mainSave.Characters.Add(character);
                allies1.Items.Add(character.Name);
                allies2.Items.Add(character.Name);
                allies3.Items.Add(character.Name);
            }

            if (a1Index < allies1.Items.Count)
            {
                allies1.SelectedIndex = a1Index;
            }
            if (a2Index < allies2.Items.Count)
            {
                allies2.SelectedIndex = a2Index;
            }
            if (a3Index < allies3.Items.Count)
            {
                allies3.SelectedIndex = a3Index;
            }

            allies1.EndUpdate();
            allies2.EndUpdate();
            allies3.EndUpdate();
        }

        private void FileReload_Click(object sender, EventArgs e)
        {
            if (File.Exists(openFileDialog.FileName))
            {
                var cancelEvent = new CancelEventArgs()
                {
                    Cancel = false
                };
                OpenFileDialog_FileOk(sender, cancelEvent);
            }
            else
            {
                openFileDialog.ShowDialog();
            }
        }

        private void NumericParty_ValueChanged(object sender, EventArgs e)
        {
            if (numericParty.Value > 12)
            {
                partyMeter1.Value = 4;
                partyMeter2.Value = 4;
                partyMeter3.Value = 4;
                partyOverflow.Value = Convert.ToUInt16(numericParty.Value) - 12;
            }
            else if (numericParty.Value > 8)
            {
                partyMeter1.Value = 4;
                partyMeter2.Value = 4;
                partyMeter3.Value = Convert.ToUInt16(numericParty.Value) - 8;
                partyOverflow.Value = 0;
            }
            else if (numericParty.Value > 4)
            {
                partyMeter1.Value = 4;
                partyMeter2.Value = Convert.ToUInt16(numericParty.Value) - 4;
                partyMeter3.Value = 0;
                partyOverflow.Value = 0;
            }
            else
            {
                partyMeter1.Value = Convert.ToUInt16(numericParty.Value);
                partyMeter2.Value = 0;
                partyMeter3.Value = 0;
                partyOverflow.Value = 0;
            }
        }

        private void Allies1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (allies1.SelectedIndex < 0)
            {
                return;
            }
            var currentPlayer = mainSave.Characters[allies1.SelectedIndex];
            var levelDouble = Convert.ToDouble(mainSave.Level);
            double multiplier = Math.Ceiling(((Math.Log10(levelDouble)) + (Math.Pow((levelDouble * 0.1), 2)) + 1) * 4) / 4;

            player1PlayerDynamic.Text = currentPlayer.Player;

            player1MaxHPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player1HPDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player1HPDynamic.Value = player1HPDynamic.Maximum;

            if (currentPlayer.EtherType)
            {
                player1MaxAP.Text = "Max EP";
                player1AP.Text = "EP";
            }
            else
            {
                player1MaxAP.Text = "Max AP";
                player1AP.Text = "AP";
            }
            player1MaxAPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player1APDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player1APDynamic.Value = player1APDynamic.Maximum;

            player1DefenseDynamic.Text = Convert.ToString(currentPlayer.Defense);

            if (currentPlayer.WeaponLinearScaling)
            {
                player1DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier * mainSave.Level));
            }
            else
            {
                player1DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier));
            }

            if (currentPlayer.Arts.Count > 0)
            {
                player1Art1.Text = currentPlayer.Arts[0].Name;
                player1Art1Cost.Text = Convert.ToString(currentPlayer.Arts[0].Cost);
            }
            else
            {
                player1Art1.Text = "";
                player1Art1Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 1)
            {
                player1Art2.Text = currentPlayer.Arts[1].Name;
                player1Art2Cost.Text = Convert.ToString(currentPlayer.Arts[1].Cost);
            }
            else
            {
                player1Art2.Text = "";
                player1Art2Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 2)
            {
                player1Art3.Text = currentPlayer.Arts[2].Name;
                player1Art3Cost.Text = Convert.ToString(currentPlayer.Arts[2].Cost);
            }
            else
            {
                player1Art3.Text = "";
                player1Art3Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 3)
            {
                player1Art4.Text = currentPlayer.Arts[3].Name;
                player1Art4Cost.Text = Convert.ToString(currentPlayer.Arts[3].Cost);
            }
            else
            {
                player1Art4.Text = "";
                player1Art4Cost.Text = "0";
            }

            player1Weapon.Text = currentPlayer.Weapon;
            player1HeadGear.Text = currentPlayer.HeadGear;
            player1TorsoGear.Text = currentPlayer.TorsoGear;
            player1LegsGear.Text = currentPlayer.LegsGear;
        }

        private void Allies2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPlayer = mainSave.Characters[allies2.SelectedIndex];
            var levelDouble = Convert.ToDouble(mainSave.Level);
            double multiplier = Math.Ceiling(((Math.Log10(levelDouble)) + (Math.Pow((levelDouble * 0.1), 2)) + 1) * 4) / 4;

            player2PlayerDynamic.Text = currentPlayer.Player;

            player2MaxHPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player2HPDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player2HPDynamic.Value = player2HPDynamic.Maximum;

            if (currentPlayer.EtherType)
            {
                player2MaxAP.Text = "Max EP";
                player2AP.Text = "EP";
            }
            else
            {
                player2MaxAP.Text = "Max AP";
                player2AP.Text = "AP";
            }
            player2MaxAPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player2APDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player2APDynamic.Value = player2APDynamic.Maximum;

            player2DefenseDynamic.Text = Convert.ToString(currentPlayer.Defense);

            if (currentPlayer.WeaponLinearScaling)
            {
                player2DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier * mainSave.Level));
            }
            else
            {
                player2DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier));
            }

            if (currentPlayer.Arts.Count > 0)
            {
                player2Art1.Text = currentPlayer.Arts[0].Name;
                player2Art1Cost.Text = Convert.ToString(currentPlayer.Arts[0].Cost);
            }
            else
            {
                player2Art1.Text = "";
                player2Art1Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 1)
            {
                player2Art2.Text = currentPlayer.Arts[1].Name;
                player2Art2Cost.Text = Convert.ToString(currentPlayer.Arts[1].Cost);
            }
            else
            {
                player2Art2.Text = "";
                player2Art2Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 2)
            {
                player2Art3.Text = currentPlayer.Arts[2].Name;
                player2Art3Cost.Text = Convert.ToString(currentPlayer.Arts[2].Cost);
            }
            else
            {
                player2Art3.Text = "";
                player2Art3Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 3)
            {
                player2Art4.Text = currentPlayer.Arts[3].Name;
                player2Art4Cost.Text = Convert.ToString(currentPlayer.Arts[3].Cost);
            }
            else
            {
                player2Art4.Text = "";
                player2Art4Cost.Text = "0";
            }

            player2Weapon.Text = currentPlayer.Weapon;
            player2HeadGear.Text = currentPlayer.HeadGear;
            player2TorsoGear.Text = currentPlayer.TorsoGear;
            player2LegsGear.Text = currentPlayer.LegsGear;
        }

        private void Allies3_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPlayer = mainSave.Characters[allies3.SelectedIndex];
            var levelDouble = Convert.ToDouble(mainSave.Level);
            double multiplier = Math.Ceiling(((Math.Log10(levelDouble)) + (Math.Pow((levelDouble * 0.1), 2)) + 1) * 4) / 4;

            player3PlayerDynamic.Text = currentPlayer.Player;

            player3MaxHPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player3HPDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player3HPDynamic.Value = player3HPDynamic.Maximum;

            if (currentPlayer.EtherType)
            {
                player3MaxAP.Text = "Max EP";
                player3AP.Text = "EP";
            }
            else
            {
                player3MaxAP.Text = "Max AP";
                player3AP.Text = "AP";
            }
            player3MaxAPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player3APDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseAP * GetAPMultiplier()));
            player3APDynamic.Value = player3APDynamic.Maximum;

            player3DefenseDynamic.Text = Convert.ToString(currentPlayer.Defense);

            if (currentPlayer.WeaponLinearScaling)
            {
                player3DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier * mainSave.Level));
            }
            else
            {
                player3DamageDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseDMG * multiplier));
            }

            if (currentPlayer.Arts.Count > 0)
            {
                player3Art1.Text = currentPlayer.Arts[0].Name;
                player3Art1Cost.Text = Convert.ToString(currentPlayer.Arts[0].Cost);
            }
            else
            {
                player3Art1.Text = "";
                player3Art1Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 1)
            {
                player3Art2.Text = currentPlayer.Arts[1].Name;
                player3Art2Cost.Text = Convert.ToString(currentPlayer.Arts[1].Cost);
            }
            else
            {
                player3Art2.Text = "";
                player3Art2Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 2)
            {
                player3Art3.Text = currentPlayer.Arts[2].Name;
                player3Art3Cost.Text = Convert.ToString(currentPlayer.Arts[2].Cost);
            }
            else
            {
                player3Art3.Text = "";
                player3Art3Cost.Text = "0";
            }
            if (currentPlayer.Arts.Count > 3)
            {
                player3Art4.Text = currentPlayer.Arts[3].Name;
                player3Art4Cost.Text = Convert.ToString(currentPlayer.Arts[3].Cost);
            }
            else
            {
                player3Art4.Text = "";
                player3Art4Cost.Text = "0";
            }

            player3Weapon.Text = currentPlayer.Weapon;
            player3HeadGear.Text = currentPlayer.HeadGear;
            player3TorsoGear.Text = currentPlayer.TorsoGear;
            player3LegsGear.Text = currentPlayer.LegsGear;
        }

        private void MonadoArtNumber_ValueChanged(object sender, EventArgs e)
        {
            monadoArtBar.Value = Convert.ToByte(monadoArtNumber.Value);
        }

        private void LoadEnemy_Click(object sender, EventArgs e)
        {
            openEnemyDialog.ShowDialog();
        }

        private void OpenEnemyDialog_FileOk(object sender, CancelEventArgs e)
        {
            var raw = File.ReadAllText(openEnemyDialog.FileName);
            enemySave = JsonSerializer.Deserialize<SaveFile>(raw);

            var enemies = enemySave.Characters;

            if (enemies.Count > 1)
            {
                enemy1NameDynamic.Text = enemies[1].Name;
                enemy1LevelDynamic.Text = enemies[1].Player;
                enemy1HPDynamic.Maximum = enemies[1].BaseHP;
                enemy1HPDynamic.Value = enemy1HPDynamic.Maximum;
                enemy1MaxHPDynamic.Text = Convert.ToString(enemies[1].BaseHP);
                enemy1AttackDynamic.Text = Convert.ToString(enemies[1].BaseDMG);
                enemy1DefenseDynamic.Text = Convert.ToString(enemies[1].Defense);
            }
            else
            {
                enemy1NameDynamic.Text = "";
                enemy1LevelDynamic.Text = "1";
                enemy1HPDynamic.Maximum = 0;
                enemy1HPDynamic.Value = enemy1HPDynamic.Maximum;
                enemy1MaxHPDynamic.Text = "0";
                enemy1AttackDynamic.Text = "0";
                enemy1DefenseDynamic.Text = "0";
            }

            if (enemies.Count > 2)
            {
                enemy2NameDynamic.Text = enemies[2].Name;
                enemy2LevelDynamic.Text = enemies[2].Player;
                enemy2HPDynamic.Maximum = enemies[2].BaseHP;
                enemy2HPDynamic.Value = enemy2HPDynamic.Maximum;
                enemy2MaxHPDynamic.Text = Convert.ToString(enemies[2].BaseHP);
                enemy2AttackDynamic.Text = Convert.ToString(enemies[2].BaseDMG);
                enemy2DefenseDynamic.Text = Convert.ToString(enemies[2].Defense);
            }
            else
            {
                enemy2NameDynamic.Text = "";
                enemy2LevelDynamic.Text = "1";
                enemy2HPDynamic.Maximum = 0;
                enemy2HPDynamic.Value = enemy2HPDynamic.Maximum;
                enemy2MaxHPDynamic.Text = "0";
                enemy2AttackDynamic.Text = "0";
                enemy2DefenseDynamic.Text = "0";
            }
            if (enemies.Count > 3)
            {
                enemy3NameDynamic.Text = enemies[3].Name;
                enemy3LevelDynamic.Text = enemies[3].Player;
                enemy3HPDynamic.Maximum = enemies[3].BaseHP;
                enemy3HPDynamic.Value = enemy3HPDynamic.Maximum;
                enemy3MaxHPDynamic.Text = Convert.ToString(enemies[3].BaseHP);
                enemy3AttackDynamic.Text = Convert.ToString(enemies[3].BaseDMG);
                enemy3DefenseDynamic.Text = Convert.ToString(enemies[3].Defense);
            }
            else
            {
                enemy3NameDynamic.Text = "";
                enemy3LevelDynamic.Text = "1";
                enemy3HPDynamic.Maximum = 0;
                enemy3HPDynamic.Value = enemy3HPDynamic.Maximum;
                enemy3MaxHPDynamic.Text = "0";
                enemy3AttackDynamic.Text = "0";
                enemy3DefenseDynamic.Text = "0";
            }
        }

        private void DamageCalculate_Click(object sender, EventArgs e)
        {
            Random random = new();

            var attack = damageAttackDynamic.Value;
            var multiplier = damageMultiplierDynamic.Value;
            var defense = damageDefenseDynamic.Value;
            var evasion = damageEvasionDynamic.Value;


            if (random.Next(1, 21) > evasion)
            {
                var variance = Convert.ToDouble(random.Next(1, 21));

                variance -= 10;

                if (variance > 0)
                {
                    variance *= 0.01;
                    variance += 1;

                    attack = Convert.ToDecimal(Math.Ceiling(Convert.ToDouble(attack) * variance));
                }
                else
                {
                    variance -= 1;
                    variance *= 0.01;
                    variance += 1;

                    attack = Convert.ToDecimal(Math.Ceiling(Convert.ToDouble(attack) * variance));
                }

                attack *= multiplier;

                if (random.Next(1, 7) == 1)
                {
                    attack *= 3;
                }

                attack -= defense;

                if (attack < 0) { attack = 0; }

                damageDamageDynamic.Text = Convert.ToString(attack);
            }
            else
            {
                damageDamageDynamic.Text = "Miss!";
            }
        }

        private void TurnsShuffle_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var characters = mainSave.Characters;
            var playersList = new List<String>();
            var players = "";

            var enemiesList = new List<String>();
            var enemies = "";

            if (allies1.SelectedIndex > 0)
            {
                playersList.Add(characters[allies1.SelectedIndex].Name);
            }
            if (allies2.SelectedIndex > 0)
            {
                playersList.Add(characters[allies2.SelectedIndex].Name);
            }
            if (allies3.SelectedIndex > 0)
            {
                playersList.Add(characters[allies3.SelectedIndex].Name);
            }

            while (playersList.Count > 1)
            {
                var index = random.Next(0, playersList.Count);
                players += playersList[index] + ", ";
                playersList.RemoveAt(index);
            }
            if (playersList.Count == 1)
            {
                players += playersList[0];
                playersList.RemoveAt(0);
            }

            if (players.Trim() == "")
            {
                turnsPlayers.Text = "No players selected";
            }
            else
            {
                turnsPlayers.Text = players;
            }

            if (enemy1NameDynamic.Text.Trim() != "")
            {
                enemiesList.Add(enemy1NameDynamic.Text);
            }
            if (enemy2NameDynamic.Text.Trim() != "")
            {
                enemiesList.Add(enemy2NameDynamic.Text);
            }
            if (enemy3NameDynamic.Text.Trim() != "")
            {
                enemiesList.Add(enemy3NameDynamic.Text);
            }

            while (enemiesList.Count > 1)
            {
                var index = random.Next(0, enemiesList.Count);
                enemies += enemiesList[index] + ", ";
                enemiesList.RemoveAt(index);
            }
            if (enemiesList.Count == 1)
            {
                enemies += enemiesList[0];
                enemiesList.RemoveAt(0);
            }

            if (enemies.Trim() == "")
            {
                turnsEnemies.Text = "No enemies selected";
            }
            else
            {
                turnsEnemies.Text = enemies;
            }


            if (turnCounter.Value < 99)
            {
                turnCounter.Value++;
            }

            if (player1APDynamic.Value < player1APDynamic.Maximum)
            {
                player1APDynamic.Value++;
            }
            if (player2APDynamic.Value < player2APDynamic.Maximum)
            {
                player2APDynamic.Value++;
            }
            if (player3APDynamic.Value < player3APDynamic.Maximum)
            {
                player3APDynamic.Value++;
            }
        }

        private void UnloadEnemy_Click(object sender, EventArgs e)
        {
            enemySave = new();

            enemy1NameDynamic.Text = "";
            enemy1LevelDynamic.Text = "1";
            enemy1HPDynamic.Maximum = 0;
            enemy1HPDynamic.Value = enemy1HPDynamic.Maximum;
            enemy1MaxHPDynamic.Text = "0";
            enemy1AttackDynamic.Text = "0";
            enemy1DefenseDynamic.Text = "0";

            enemy2NameDynamic.Text = "";
            enemy2LevelDynamic.Text = "1";
            enemy2HPDynamic.Maximum = 0;
            enemy2HPDynamic.Value = enemy2HPDynamic.Maximum;
            enemy2MaxHPDynamic.Text = "0";
            enemy2AttackDynamic.Text = "0";
            enemy2DefenseDynamic.Text = "0";

            enemy3NameDynamic.Text = "";
            enemy3LevelDynamic.Text = "1";
            enemy3HPDynamic.Maximum = 0;
            enemy3HPDynamic.Value = enemy3HPDynamic.Maximum;
            enemy3MaxHPDynamic.Text = "0";
            enemy3AttackDynamic.Text = "0";
            enemy3DefenseDynamic.Text = "0";
        }

        private short ArtClick(int index, int artIndex)
        {
            if (index > 0 && index < mainSave.Characters.Count)
            {
                if (artIndex < mainSave.Characters[index].Arts.Count)
                {
                    if (numericParty.Value < numericParty.Maximum)
                    {
                        numericParty.Value++;
                    }
                    return mainSave.Characters[index].Arts[artIndex].Cost;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        private void Player1Art1_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies1.SelectedIndex, 0);
            if (player1APDynamic.Value >= artCost)
            {
                player1APDynamic.Value -= artCost;
            }
        }

        private void Player1Art2_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies1.SelectedIndex, 1);
            if (player1APDynamic.Value >= artCost)
            {
                player1APDynamic.Value -= artCost;
            }
        }

        private void Player1Art3_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies1.SelectedIndex, 2);
            if (player1APDynamic.Value >= artCost)
            {
                player1APDynamic.Value -= artCost;
            }
        }

        private void Player1Art4_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies1.SelectedIndex, 3);
            if (player1APDynamic.Value >= artCost)
            {
                player1APDynamic.Value -= artCost;
            }
        }

        private void Player2Art1_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies2.SelectedIndex, 0);
            if (player2APDynamic.Value >= artCost)
            {
                player2APDynamic.Value -= artCost;
            }
        }

        private void Player2Art2_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies2.SelectedIndex, 1);
            if (player2APDynamic.Value >= artCost)
            {
                player2APDynamic.Value -= artCost;
            }
        }

        private void Player2Art3_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies2.SelectedIndex, 2);
            if (player2APDynamic.Value >= artCost)
            {
                player2APDynamic.Value -= artCost;
            }
        }

        private void Player2Art4_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies2.SelectedIndex, 3);
            if (player2APDynamic.Value >= artCost)
            {
                player2APDynamic.Value -= artCost;
            }
        }

        private void Player3Art1_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies3.SelectedIndex, 0);
            if (player3APDynamic.Value >= artCost)
            {
                player3APDynamic.Value -= artCost;
            }
        }

        private void Player3Art2_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies3.SelectedIndex, 1);
            if (player3APDynamic.Value >= artCost)
            {
                player3APDynamic.Value -= artCost;
            }
        }

        private void Player3Art3_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies3.SelectedIndex, 2);
            if (player3APDynamic.Value >= artCost)
            {
                player3APDynamic.Value -= artCost;
            }
        }

        private void Player3Art4_Click(object sender, EventArgs e)
        {
            var artCost = ArtClick(allies3.SelectedIndex, 3);
            if (player3APDynamic.Value >= artCost)
            {
                player3APDynamic.Value -= artCost;
            }
        }
    }

    public class SaveFile
    {
        public Byte Level { get; set; }
        public UInt32 Experience { get; set; }
        public Byte Chapter { get; set; }
        public String Location { get; set; }
        public UInt16 Money { get; set; }
        public List<Character> Characters { get; set; }
        public List<String> Inventory { get; set; }

        public SaveFile()
        {
            Level = 1;
            Experience = 6;
            Chapter = 1;
            Location = "Colony A";
            Characters = new()
            {
                new Character()
                {
                    Name = "None",
                    Player = "None",
                    EtherType = false,
                    BaseHP = 0,
                    BaseAP = 0,
                    BaseDMG = 0,
                    Weapon = "None",
                    HeadGear = "None",
                    TorsoGear = "None",
                    LegsGear = "None",
                    Arts = new() {
                    }
                },
                new Character()
            };
            Inventory = new();
            Money = 0;
        }

    }
    public class Character
    {
        public String Name { get; set; }
        public String Player { get; set; } // Player is also used for enemy levels
        public Boolean EtherType { get; set; }
        public UInt32 BaseHP { get; set; }
        public Byte BaseAP { get; set; }
        public UInt16 BaseDMG { get; set; }
        public UInt16 Defense { get; set; }
        public String Weapon { get; set; }
        public Boolean WeaponLinearScaling { get; set; }
        public String HeadGear { get; set; }
        public String TorsoGear { get; set; }
        public String LegsGear { get; set; }
        public List<Art> Arts { get; set; }

        public Character()
        {
            Name = "Virent";
            Player = "Satou";
            EtherType = true;
            BaseHP = 50;
            BaseAP = 10;
            BaseDMG = 1;
            Defense = 0;
            Weapon = "Iron Blade";
            WeaponLinearScaling = false;
            HeadGear = "None";
            TorsoGear = "Worn Dress";
            LegsGear = "None";
            Arts = new() {
                new Art()
            };
        }
    }
    public class Art
    {
        public String Name { get; set; }
        public Byte Cost { get; set; }

        public Art()
        {
            Name = "Divine Slash";
            Cost = 5;
        }
    }
}
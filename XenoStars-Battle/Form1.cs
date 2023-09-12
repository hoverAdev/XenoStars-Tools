using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

namespace XenoStars_Battle
{
    public partial class Form1 : Form
    {
        public SaveFile mainSave = new();

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
            allies1.Items.Clear();
            mainSave.Characters.Clear();
            foreach (Character character in deserialize.Characters)
            {
                mainSave.Characters.Add(character);
                allies1.Items.Add(character.Name);
            }
            allies1.EndUpdate();
        }

        private void NumericParty_ValueChanged(object sender, EventArgs e)
        {
            if (numericParty.Value > 12)
            {
                partyMeter.Value = 12;
                partyOverflow.Value = Convert.ToUInt16(numericParty.Value) - 12;
            }
            else
            {
                partyMeter.Value = Convert.ToUInt16(numericParty.Value);
                partyOverflow.Value = 0;
            }
        }

        private void Allies1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPlayer = mainSave.Characters[allies1.SelectedIndex];
            var levelDouble = Convert.ToDouble(mainSave.Level);
            double multiplier = Math.Ceiling(((Math.Log10(levelDouble)) + (Math.Pow((levelDouble * 0.1), 2)) + 1) * 4) / 4;

            player1PlayerDynamic.Text = currentPlayer.Player;

            player1MaxHPDynamic.Text = Convert.ToString(Math.Ceiling(currentPlayer.BaseHP * multiplier));
            player1HPDynamic.Maximum = Convert.ToDecimal(Math.Ceiling(currentPlayer.BaseHP * multiplier));

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
            player1MaxAPDynamic.Text = Convert.ToString(currentPlayer.BaseAP * GetAPMultiplier());
            player1APDynamic.Maximum = Convert.ToDecimal(currentPlayer.BaseAP * GetAPMultiplier());
            player1APDynamic.Value = player1APDynamic.Maximum;

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
                MessageBox.Show($"File {openFileDialog.FileName} doesn't exist!", "Error", MessageBoxButtons.OK);
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
        public String Player { get; set; }
        public Boolean EtherType { get; set; }
        public Byte BaseHP { get; set; }
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
            HeadGear = "Nothing";
            TorsoGear = "Worn Dress";
            LegsGear = "Nothing";
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
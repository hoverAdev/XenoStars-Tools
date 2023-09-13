using System.ComponentModel;
using System.Text.Json;
using Windows.ApplicationModel.Calls;

namespace XenoStars_Editor
{
    public partial class Form1 : Form
    {
        const uint MaxEXP = 102016;
        public SaveFile mainSave = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void SaveFileAs_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string friendlyName = saveFileDialog.FileName.Split("\\")[^1];
            saveFile.Text = $"Save {friendlyName}";

            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var serialize = JsonSerializer.Serialize(mainSave, options);
            File.WriteAllText(saveFileDialog.FileName, serialize);
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(saveFileDialog.FileName))
            {
                var cancelEvent = new CancelEventArgs()
                {
                    Cancel = false
                };
                SaveFileDialog_FileOk(sender, cancelEvent);
            }
            else
            {
                saveFileDialog.ShowDialog();
            }
        }

        private void OpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            string friendlyName = openFileDialog.FileName.Split("\\")[^1];
            reloadFile.Text = $"Reload {friendlyName}";

            var raw = File.ReadAllText(openFileDialog.FileName);
            var deserialize = JsonSerializer.Deserialize<SaveFile>(raw);

            mainSave.Level = deserialize.Level;
            textLevel.Value = deserialize.Level;

            mainSave.Experience = deserialize.Experience;
            textExp.Text = Convert.ToString(mainSave.Experience);

            mainSave.Chapter = deserialize.Chapter;
            textChapter.Value = deserialize.Chapter;

            mainSave.Location = deserialize.Location;
            textLocation.Text = deserialize.Location;

            mainSave.Money = deserialize.Money;
            textMoney.Value = deserialize.Money;

            charactersList.BeginUpdate();
            charactersList.Items.Clear();
            mainSave.Characters.Clear();
            foreach (Character character in deserialize.Characters)
            {
                mainSave.Characters.Add(character);
                charactersList.Items.Add(character.Name);
            }
            charactersList.SelectedIndex = 0;
            charactersList.EndUpdate();

            inventoryList.BeginUpdate();
            mainSave.Inventory.Clear();
            inventoryList.Items.Clear();
            foreach (String item in deserialize.Inventory)
            {
                mainSave.Inventory.Add(item);
                inventoryList.Items.Add(item);
            }
            inventoryList.EndUpdate();
        }

        private void ReloadFile_Click(object sender, EventArgs e)
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

        private void CharNew_Click(object sender, EventArgs e)
        {
            mainSave.Characters.Add(new Character());
            charactersList.Items.Add("Virent");
        }

        private void CharDel_Click(object sender, EventArgs e)
        {
            if (charactersList.SelectedIndex > 0)
            {
                mainSave.Characters.RemoveAt(charactersList.SelectedIndex);
                charactersList.Items.RemoveAt(charactersList.SelectedIndex);
            }
        }

        private void SetName_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].Name = textName.Text;
                charactersList.Items[index] = textName.Text;
            }
        }

        private void SetPlayer_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].Player = textPlayer.Text;
            }
        }

        private void SetType_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                if (checkType.Checked)
                {
                    mainSave.Characters[index].EtherType = true;
                    label5.Text = "Base EP";
                    setAP.Text = "Set Base EP";
                }
                else
                {
                    mainSave.Characters[index].EtherType = false;
                    label5.Text = "Base AP";
                    setAP.Text = "Set Base AP";
                }
            }
        }

        private void SetHP_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].BaseHP = Convert.ToByte(textHP.Value);
            }
        }

        private void SetAP_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].BaseAP = Convert.ToByte(textAP.Value);
            }
        }

        private void SetDamage_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].BaseDMG = Convert.ToByte(textDamage.Value);
            }
        }

        private void SetLinear_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].WeaponLinearScaling = checkLinear.Checked;
            }
        }

        private void CharactersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > -1)
            {
                var currentChar = mainSave.Characters[index];
                textName.Text = currentChar.Name;
                textPlayer.Text = currentChar.Player;
                checkType.Checked = currentChar.EtherType;
                textHP.Value = currentChar.BaseHP;
                textAP.Value = currentChar.BaseAP;
                textDamage.Value = currentChar.BaseDMG;
                checkLinear.Checked = currentChar.WeaponLinearScaling;

                if (currentChar.EtherType)
                {
                    label5.Text = "Base EP";
                    setAP.Text = "Set Base EP";
                }
                else
                {
                    label5.Text = "Base AP";
                    setAP.Text = "Set Base AP";
                }

                textWeapon.Text = currentChar.Weapon;
                textHead.Text = currentChar.HeadGear;
                textTorso.Text = currentChar.TorsoGear;
                textLegs.Text = currentChar.LegsGear;

                if (currentChar.Arts.Count > 0)
                {
                    art1.Text = currentChar.Arts[0].Name;
                    art1Cost.Value = currentChar.Arts[0].Cost;
                    if (currentChar.Arts.Count > 1)
                    {
                        art2.Text = currentChar.Arts[1].Name;
                        art2Cost.Value = currentChar.Arts[1].Cost;
                        if (currentChar.Arts.Count > 2)
                        {
                            art3.Text = currentChar.Arts[2].Name;
                            art3Cost.Value = currentChar.Arts[2].Cost;

                            if (currentChar.Arts.Count > 3)
                            {
                                art4.Text = currentChar.Arts[3].Name;
                                art4Cost.Value = currentChar.Arts[3].Cost;

                            }
                            else
                            {
                                art4.Text = "";
                                art4Cost.Value = 0;
                            }
                        }
                        else
                        {
                            art3.Text = "";
                            art3Cost.Value = 0;
                        }
                    }
                    else
                    {
                        art2.Text = "";
                        art2Cost.Value = 0;
                    }
                }
                else
                {
                    art1.Text = "";
                    art1Cost.Value = 0;
                }
            }
        }

        private void SetEquip_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].Weapon = textWeapon.Text;
                mainSave.Characters[index].HeadGear = textHead.Text;
                mainSave.Characters[index].TorsoGear = textTorso.Text;
                mainSave.Characters[index].LegsGear = textLegs.Text;
            }
        }

        private void SetArts_Click(object sender, EventArgs e)
        {
            var index = charactersList.SelectedIndex;
            if (index > 0)
            {
                mainSave.Characters[index].Arts.Clear();
                mainSave.Characters[index].Arts.Add(new Art() { Name = art1.Text, Cost = Convert.ToByte(art1Cost.Value) });
                mainSave.Characters[index].Arts.Add(new Art() { Name = art2.Text, Cost = Convert.ToByte(art2Cost.Value) });
                mainSave.Characters[index].Arts.Add(new Art() { Name = art3.Text, Cost = Convert.ToByte(art3Cost.Value) });
                mainSave.Characters[index].Arts.Add(new Art() { Name = art4.Text, Cost = Convert.ToByte(art4Cost.Value) });
            }
        }

        private void SetLevel_Click(object sender, EventArgs e)
        {
            double level = Convert.ToDouble(textLevel.Value);
            mainSave.Level = Convert.ToByte(textLevel.Value);
            mainSave.Experience = Convert.ToUInt32(Math.Ceiling(((10 * Math.Pow(level, 2)) + Math.Floor(Math.Pow(2, (level / 6)))) / 2));
            textExp.Text = Convert.ToString(Math.Ceiling(((10 * Math.Pow(level, 2)) + Math.Floor(Math.Pow(2, (level / 6)))) / 2));
        }

        private void SetExperience_Click(object sender, EventArgs e)
        {
            mainSave.Experience += Convert.ToUInt32(textExperience.Value);
            if (mainSave.Experience > MaxEXP)
            {
                mainSave.Experience = MaxEXP;
                mainSave.Level = 100;
            }
            textExp.Text = Convert.ToString(mainSave.Experience);

            var retry = true;
            var levelDouble = Convert.ToDouble(Convert.ToUInt16(mainSave.Level) + 1);
            var compare = Convert.ToUInt32(Math.Ceiling(((10 * Math.Pow(levelDouble, 2)) + Math.Floor(Math.Pow(2, (levelDouble / 6)))) / 2));
            while (retry)
            {

                if (mainSave.Experience < compare)
                {
                    retry = false;
                }
                else
                {
                    mainSave.Level = Convert.ToByte(mainSave.Level + 1);

                    levelDouble = Convert.ToDouble(Convert.ToUInt16(mainSave.Level) + 1);
                    compare = Convert.ToUInt32(Math.Ceiling(((10 * Math.Pow(levelDouble, 2)) + Math.Floor(Math.Pow(2, (levelDouble / 6)))) / 2));
                }
            }
            textLevel.Value = mainSave.Level;
        }

        private void SetChapter_Click(object sender, EventArgs e)
        {
            mainSave.Chapter = Convert.ToByte(textChapter.Value);
        }

        private void SetLocation_Click(object sender, EventArgs e)
        {
            mainSave.Location = textLocation.Text;
        }

        private void SetMoney_Click(object sender, EventArgs e)
        {
            mainSave.Money = Convert.ToUInt16(textMoney.Value);
        }

        private void InventoryAdd_Click(object sender, EventArgs e)
        {
            mainSave.Inventory.Add(textInventory.Text);
            inventoryList.Items.Add(textInventory.Text);
            textInventory.Text = "";
        }

        private void InventoryRemove_Click(object sender, EventArgs e)
        {
            if (inventoryList.SelectedIndex > -1)
            {
                mainSave.Inventory.RemoveAt(inventoryList.SelectedIndex);
                inventoryList.Items.RemoveAt(inventoryList.SelectedIndex);
            }
        }

        private void SetDefense_Click(object sender, EventArgs e)
        {
            mainSave.Characters[charactersList.SelectedIndex].Defense = Convert.ToUInt16(textDefense.Value);
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
            HeadGear = "None";
            TorsoGear = "Worn Dress";
            LegsGear = "None";
            Arts = new() {
                new Art(),
                new Art() { Name="", Cost= 0 },
                new Art() { Name="", Cost= 0 },
                new Art() { Name="", Cost= 0 }
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
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DungeonsAndDragons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public enum Class
        {
            Barbarian = 1,
            Bard = 2,
            Cleric = 3,
            Druid = 4,
            Fighter = 5,
            Monk = 6,
            Paladin = 7,
            Ranger = 8,
            Rough = 9,
            Sorcerer = 10,
            Warlock = 11,
            Wizard = 12
        }
        [Flags]
        public enum Savings : uint // Saving Throws
        {
            Strength = 1,
            Dexterity = 2,
            Constitution = 4,
            Intelligence = 8,
            Wisdom = 16,
            Charisma = 32
        }
        [Flags]
        public enum SkillProfs : uint
        {
            Acrobatics = 1, // DEX
            AnimalHandling = 2, // WIS
            Arcana = 4, // INT
            Athletics = 8, // STR
            Deception = 16, // CHA
            History = 32, // INT
            Insight = 64, // WIS
            Intimidation = 128, // CHA
            Investigation = 256, // INT
            Medicine = 512, // WIS
            Nature = 1024, // CHA
            Perception = 2048, // INT 
            Performance = 4096, // WIS
            Persuation = 8192, // CHA
            Religion = 16384, // INT
            SleightOfHand = 32768, // DEX
            Stealth = 65536, // DEX
            Survival = 131072 // WIS
        }
        public int StatStr { get; set; }
        public int StatDex { get; set; }
        public int StatCon { get; set; }
        public int StatInt { get; set; }
        public int StatWis { get; set; }
        public int StatCha { get; set; }
        public int ProfBonus { get; set; }
        public int Level { get; set; }
        public int Xp { get; set; }
        public int PassivWis { get; set; }
        public int AC { get; set; }































































































































































































































































































        public int Init { get; set; }
        public int Speed { get; set; }
        public int HpMax { get; set; }
        public int HpCurrent { get; set; }
        public int HpTemp { get; set; }
        public string HitDice { get; set; }
        public string Race { get; set; }
        public string CharBackground { get; set; }
        public string PlayerName { get; set; }
        public string CharName { get; set; }
        public string Alignment { get; set; }
        public int Inspiration { get; set; }
        public SkillProfs Skills { get; set; }
        public Savings SavingThrows { get; set; }

    }

}

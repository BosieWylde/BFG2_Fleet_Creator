using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFG2_Fleet_Creator
{
    public partial class Form1 : Form
    {
        public int fleetcost;
        public decimal pointsLeft;
        public decimal total;

        public Form1()
        {
            InitializeComponent();                                 
            listBox1.Items.Add("Imperial Navy");
            listBox1.Items.Add("Chaos");
            listBox1.Items.Add("Space Marines");
            listBox1.Items.Add("Adeptus Mechanicus");
            listBox1.Items.Add("Corsair");
            listBox1.Items.Add("Asuryani");
            listBox1.Items.Add("Drukhari");
            listBox1.Items.Add("Orks");
            listBox1.Items.Add("Necron");
            listBox1.Items.Add("Tyranids");
            listBox1.Items.Add("Tau Protector Fleet");
            listBox1.Items.Add("Tau Merchant Fleet");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            //Selects faction and sets fleet cost
            pointsLeft = 1200;
            total = 0;
            textBox2.Text = String.Format("{0}", pointsLeft);
            textBox1.Text = String.Format("{0}", total);
            listView1.Items.Clear();
            listView2.Items.Clear();
            pictureBoxImperial.Visible = false;
            pictureBoxMarines.Visible = false;
            pictureBoxAdMech.Visible = false;
            pictureBoxChaos.Visible = false;
            pictureBoxCorsair.Visible = false;
            pictureBoxCraftworld.Visible = false;
            pictureBoxDruk.Visible = false;
            pictureBoxOrk.Visible = false;
            pictureBoxNecron.Visible = false;
            pictureBoxTauM.Visible = false;
            if (listBox1.Text == "Chaos")
            { ChaosFaction(); }
            if (listBox1.Text == "Imperial Navy")
            { ImperialNavy(); }
            if (listBox1.Text == "Space Marines")
            { SpaceMarines(); }
            if (listBox1.Text == "Adeptus Mechanicus")
            { AdeptusMechanicus(); }
            if (listBox1.Text == "Corsair")
            { Corsair(); }
            if (listBox1.Text == "Asuryani")
            { Corsair(); }
            if (listBox1.Text == "Drukhari")
            { Drukhari(); }
            if (listBox1.Text == "Orks")
            { Orks(); }
            if (listBox1.Text == "Necron")
            { Necron(); }
            if (listBox1.Text == "Tyranids")
            { Tyranids(); }
            if (listBox1.Text == "Tau Protector Fleet")
            { TauProtectorFleet(); }
            if (listBox1.Text == "Tau Merchant Fleet")
            { TauMerchantFleet(); }

        }
        private void ImperialNavy()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Cobra", "34", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Cobra Widowmaker", "37", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Firestorm", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Sword", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Falchion", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dauntless", "128", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dauntless MK II", "116", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Endeavour", "107", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Endurance", "105", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Defiant", "153", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dictator", "206", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gothic", "162", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dominator", "188", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Tyrant", "178", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Lunar", "165", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Overloard", "216", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Mars", "260", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Armageddon", "210", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Vengeance", "260", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Avenger", "199", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Exorcist", "308", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Retribution", "306", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Emperor", "367", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Apocalypse", "284", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Oberon", "334", "BS" }));
            pictureBoxImperial.Visible = true;
        }
        private void SpaceMarines()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Hunter", "47", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gladius", "59", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Nova", "64", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Vanguard MK I", "171", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Vanguard MK II", "184", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Vanguard MK III", "172", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Strike Cruiser MK I", "242", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Strike Cruiser MK II", "188", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Strike Cruiser MK III", "194", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Battle Barge MK I", "500", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Battle Barge MK II", "535", "BS" }));
            pictureBoxMarines.Visible = true;

        }
        private void AdeptusMechanicus()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Cobra", "32", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Cobra Widowmaker", "35", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hunter", "37", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Firestorm", "39", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Sword", "39", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Falchion", "39", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gladius", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Nova", "45", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Defiant", "139", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Endurance", "108", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Endeavour", "104", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gothic", "218", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Lunar", "215", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Tyrant", "221", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dictator", "229", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Ark Mechanicus", "368", "BS" }));
            pictureBoxAdMech.Visible = true;
        }       
        private void ChaosFaction()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Iconoclast", "39", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Infidel", "40", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Idolator", "42", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hellbringer", "169", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hellbringer Mk2", "143", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Slaughter", "178", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Carnage", "183", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Murder", "173", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Devestation", "218", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Acheron", "224", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hades", "200", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Styx", "279", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Repulsive", "230", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Retaliator", "300", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Executor", "197", "GC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Desolator", "278", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Despoiler", "379", "BS" }));
            pictureBoxChaos.Visible = true;
        }
        private void Corsair()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Hemlock", "74", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Nightshade", "58", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Aconit", "69", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hellebore", "74", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Aurora", "141", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Solaris", "166", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Shadow", "171", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Kurnous", "232", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Eclipse", "293", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Vaul", "232", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Voidstalker", "472", "BS" }));
            pictureBoxCorsair.Visible = true;
        }
        private void Asuryani()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Shadowhunter", "79", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Shard Shadowhunter", "85", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Prismatic Wraithship", "172", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Ghost Wraithship", "206", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Firestorm Wraithship", "176", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Moonray Wraithship", "209", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Starfall Dragonship", "228", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Ghost Dragonship", "292", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Firestrom Dragnoship", "219", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Moonray Dragonship", "284", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Phoenix Ship", "419", "BC" }));
            pictureBoxCraftworld.Visible = true;
        }
        private void Drukhari()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Sigil", "57", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Immortality Denied", "68", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Venom Blade", "70", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Talon Cyriix", "62", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Lost Hatred", "74", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dark Mirror", "161", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Buirning Scale", "193", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Baleful Gaze", "155", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bladed Lotus", "152", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Flayed Skull", "229", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Fiend Ascendant", "293", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bleak Soul", "235", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bloodied Claw", "207", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Obsidian Rose", "352", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Iron Thorn", "448", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Dying Sun", "332", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Falling Moon", "350", "BS" }));
            pictureBoxDruk.Visible = true;

        }
        private void Orks()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Brute", "32", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Ravager", "29", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Savage", "28", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Onslaught", "29", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Basha Ordzdaka", "102", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Basha Ordzgargdaka", "100", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Basha Urd Unki", "146", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Roks", "177", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Killa", "138", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Killa Stompa", "138", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Terror", "186", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Terror Stompa", "186", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Big Roks", "297", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hammer", "173", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hammer Stompa", "173", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hammer Smaka", "153", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Deadnot", "210", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Deadnot Urd Unki", "321", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Deadnot Ordzgargdaka", "210", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Mega Roks", "454", "BS" }));
            pictureBoxOrk.Visible = true;
        }
        private void Necron()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Dirge", "54", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Jackal", "59", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Cartouche", "155", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Shroud", "189", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Khopesh", "194", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Scyth Harvester", "291", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Scyth Reaper", "357", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Carin", "492", "BS" }));
            pictureBoxNecron.Visible = true;
        }
        private void Tyranids()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Causetic Drone", "36", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Strangler Drone", "34", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Plasma Drone", "36", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Vanguard", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Stranger Vanguard", "42", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Kraken", "55", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Clutch Kraken", "42", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Strangler Kraken", "48", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Projectile Kraken", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Acid Voidprowler", "133", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Projectile Voidprowler", "117", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Strangler Voidprowler", "121", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Clutch Voidprowler", "115", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Clutch Voidprowler", "114", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Strangler Voidprowler", "122", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Acid Voidprowler", "132", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Projectile Voidprowler", "118", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Razorfiend", "186", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Corrosive Razorfiend", "185", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Projectile Razorfiend", "171", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Acid Projectile Razorfiend", "172", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Acid Razorfiend", "184", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrsive Projectile Razorfiend", "173", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Infestation Razorfiend", "174", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Ingfestation Razofiend", "187", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Devourer", "201", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrosive Clutch Devourer", "203", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Tentacles Devourer", "218", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Infestation Devourer", "220", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Corrisive Tentacles Devourer", "216", "BC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Hiveship", "344", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Tentacles Devourer Hiveship", "309", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Acid Infestation Hiveship", "359", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bio Acid Hiveship", "340", "BS" }));
        }
        private void TauProtectorFleet()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Castellan", "41", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Warden", "37", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Nicassar Dhow", "59", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Emisasry Dal'Yth", "235", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Emisasry Bork'An", "193", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Emisasry Sa'Cea", "112", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Protector T'Olku", "199", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Protector Vior'la", "197", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bastion", "231", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Custodian", "502", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Koot Warsphere", "240", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Stronghold", "347", "BS" }));
        }
        private void TauMerchantFleet()
        {
            listView1.Items.Add(new ListViewItem(new string[] { "Orca", "32", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Messenger", "32", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Defender", "35", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Nicassar Dhow", "59", "ES" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Il'Fannor Ke'Lshan", "153", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Il'Fannor Dal'Yth", "107", "LC" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Lar'Shi Vash'Ya", "205", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Lar'Shi Tolku", "202", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Bastion", "231", "C" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gal'Leath Vash'Ya", "294", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Gal'Leath Bor'Kan", "281", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Kroot Warsphere", "240", "BS" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Stronghold", "347", "BS" }));
            pictureBoxTauM.Visible = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {

            //Adds a ship to the fleet
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView2.Items.Add((ListViewItem)item.Clone());
            }
            pointsLeft = 1200;
            total = 0;
            //Total current fleet cost after adding a ship              

            foreach (ListViewItem item in listView2.Items)
            {
                total += Convert.ToDecimal(item.SubItems[1].Text);
            }
            pointsLeft = 1200 - total;
            textBox2.Text = String.Format("{0}", pointsLeft);
            textBox1.Text = String.Format("{0}", total);
            

        }
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            pointsLeft = 1200;
            total = 0;
            foreach (ListViewItem item in listView2.Items)
            {
                total += Convert.ToDecimal(item.SubItems[1].Text);
            }
            pointsLeft = 1200 - total;
            textBox2.Text = String.Format("{0}", pointsLeft);
            textBox1.Text = String.Format("{0}", total);
        }

        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {

            //Removes a ship from the fleet
            listView2.SelectedItems[0].Remove();
            pointsLeft = 1200;
            total = 0;
            foreach (ListViewItem item in listView2.Items)
            {
                total += Convert.ToDecimal(item.SubItems[1].Text);
            }
            pointsLeft = 1200 - total;
            textBox2.Text = String.Format("{0}", pointsLeft);
            textBox1.Text = String.Format("{0}", total);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.Sorting = SortOrder.Ascending;
        }

        private void pictureBoxAdMech_Click(object sender, EventArgs e)
        {

        }
    }
}

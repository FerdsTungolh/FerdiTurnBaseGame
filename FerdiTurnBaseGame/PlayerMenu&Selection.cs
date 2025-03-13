using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FerdiTurnBaseGame
{
    public partial class PlayerMenu_Selection : Form
    {
        public int choosedplayer = 1;
        public PlayerMenu_Selection()
        {
            InitializeComponent();
            playerload();
        }
        public void playerload()
        {
            
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Player_and_Enemies_Stats player = new Player_and_Enemies_Stats();
            player.Selectedplayer = comboBox1.SelectedIndex;
            //PlayerMenu_Selection.ActiveForm.Hide();
            PlayerMenu_Selection.ActiveForm.Enabled = false;
            Map map = new Map();
            map.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player_and_Enemies_Stats player = new Player_and_Enemies_Stats();
            player.Selectedplayer = 1;
            listBox1.Items.Clear();
            Player_and_Enemies_Stats stats = new Player_and_Enemies_Stats();
            pictureBox1.Image = Image.FromFile($"{stats.Entity()[comboBox1.SelectedIndex].PlayerImageRight}");
            listBox1.Items.Add($"Name : {stats.Entity()[comboBox1.SelectedIndex].Name}");
            listBox1.Items.Add($"HP : {stats.Entity()[comboBox1.SelectedIndex].Hp}");
            listBox1.Items.Add($"Defense : {stats.Entity()[comboBox1.SelectedIndex].Defense}");
            listBox1.Items.Add($"Crit Chance : {stats.Entity()[comboBox1.SelectedIndex].Crit}");
            listBox1.Items.Add($"Mana Regen : {stats.Entity()[comboBox1.SelectedIndex].Manaregenrate}");
            listBox2.Items.Clear();
            listBox2.Items.Add($"Skills");
            listBox2.Items.Add($"Name|Damage|Manacost|Acccuracy|Heal");
            foreach (var item in stats.EntitySkills())
            {
                if (item.SkillEntity == stats.Entity()[comboBox1.SelectedIndex].Name)
                {
                    listBox2.Items.Add($"{item.SkillName} | {item.SkillDamage} | {item.SkillCost} | {item.SkillAccuracy} | {item.SkillHeal}");
                }
            }
        }
    }
}

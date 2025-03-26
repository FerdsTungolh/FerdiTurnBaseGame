using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FerdiTurnBaseGame
{
    public partial class Menu: Form
    {
        public int choosedplayer = 1;
        public string opponentname;
        public Menu()
        {
            InitializeComponent();
            Playerload();
        }
        public void Playerload()
        {
            
            string[] playernames = { "Naruto", "Sasuke" };
            comboBox1.Items.AddRange(playernames);
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a player");
                return;
            }
            Stats player = new Stats();
            SelectPoly.selected.AddPlayer(new Selected(textBox1.Text, comboBox1.SelectedIndex));
            player.EditName(comboBox1.SelectedIndex);
            Menu.ActiveForm.Enabled = false;
            Map map = new Map();
            map.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { 
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Naruto";
                }
                if (textBox1.Text == "Sasuke")
                {
                    textBox1.Text = "Naruto";
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Sasuke";
                }
                if (textBox1.Text == "Naruto")
                {
                    textBox1.Text = "Sasuke";
                }
            }
            listBox1.Items.Clear();
            Stats stats = new Stats();
            pictureBox1.Image = Image.FromFile($"{stats.Entity()[comboBox1.SelectedIndex].PlayerImageRight}");
            listBox1.Items.Add($"Name : {stats.Entity()[comboBox1.SelectedIndex].Name}");
            listBox1.Items.Add($"HP : {stats.Entity()[comboBox1.SelectedIndex].Hp}");
            listBox1.Items.Add($"Defense : {stats.Entity()[comboBox1.SelectedIndex].Defense}");
            listBox1.Items.Add($"Crit Chance : {stats.Entity()[comboBox1.SelectedIndex].Crit}");
            listBox1.Items.Add($"Mana Regen : {stats.Entity()[comboBox1.SelectedIndex].Manaregenrate}");
            listBox2.Items.Clear();
            listBox2.Items.Add($"Skills");
            listBox2.Items.Add($"Skill Name |Damage | Manacost | Acccuracy|Heal");
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

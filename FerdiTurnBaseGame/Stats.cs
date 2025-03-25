using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerdiTurnBaseGame
{
    public class Stats : Skills_Stats
    {
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Crit { get; set; }
        public int Defense { get; set; }
        public int Mana { get; set; }
        public int Manaregenrate { get; set; }
        public string PlayerImageRight { get; set; }
        public string PlayerImageLeft { get; set; }
        public string EntityName { get; set; }

        public Stats(string name, int hp, int defense, int crit, int mana, int manaregenrate, string playerimageright, string playerimageleft)
        {
            Name = name;
            Hp = hp;
            Defense = defense;
            Crit = crit;
            Mana = mana;
            Manaregenrate = manaregenrate;
            PlayerImageRight = playerimageright;
            PlayerImageLeft = playerimageleft;


        }
        public Stats(string skillname, int skilldamage, int skillaccuracy, int skillcost, int skillheal, string skilltype, string skillentity)
        {
            SkillName = skillname;
            SkillDamage = skilldamage;
            SkillAccuracy = skillaccuracy;
            SkillCost = skillcost;
            SkillHeal = skillheal;
            SkillType = skilltype;
            SkillEntity = skillentity;
        }
        public Stats()
        {
            
            //Nothing here
        }
        public List<Stats> Entity()
        {
            List<Stats> EntityStats = new List<Stats>();
            //Player Health and Stats (Name, Hp, Defense, Critrate, Mana, Mana regen)
            EntityStats.Add(new Stats("Naruto", 100, 10, 50, 100, 5, "assets\\Naruto_Movement\\Naruto_Mov_00.png", "assets\\Naruto_Movement\\Naruto_Mov_07.png"));
            EntityStats.Add(new Stats("Sasuke", 100, 5, 50, 100, 5, "assets\\Sasuke_Movement\\Sasuke_Mov_00.png", "assets\\Sasuke_Movement\\Sasuke_Mov_07.png"));

            return EntityStats;
        }
    
        public List<Stats> EntitySkills()
        {
            List<Stats> EntitySkillStats = new List<Stats>();
            //Naruto Skills
            EntitySkillStats.Add(new Stats("Basic Attack", 7, 95, 0, 0, "Attack", Entity()[0].Name));
            EntitySkillStats.Add(new Stats("Shuriken", 15, 80, 10, 0, "Attack", Entity()[0].Name));
            EntitySkillStats.Add(new Stats("Rasengan", 40, 50, 50, 0, "Attack", Entity()[0].Name));
            EntitySkillStats.Add(new Stats("Rasen Shuriken", 25, 50, 20, 10, "Lifesteal", Entity()[0].Name));
            EntitySkillStats.Add(new Stats("Healing Jutsu", 0, 100, 25, 20, "Heal", Entity()[0].Name));
            //Sasuke Skills
            EntitySkillStats.Add(new Stats("Basic Attack", 9, 95, 0, 0, "Attack", Entity()[1].Name));
            EntitySkillStats.Add(new Stats("Chidori", 20, 80, 10, 0, "Attack", Entity()[1].Name));
            EntitySkillStats.Add(new Stats("Raikiri", 25, 50, 20, 0, "Attack", Entity()[1].Name));
            EntitySkillStats.Add(new Stats("Amaterasu", 45, 30, 50, 0, "Attack", Entity()[1].Name));
            EntitySkillStats.Add(new Stats("Healing Jutsu", 0, 100, 25, 20, "Heal", Entity()[1].Name));
            return EntitySkillStats;
        }
        public void EditName(int p)
        {
            if (p == 0)
            {
                foreach (var item in EntitySkills())
                {
                    if (item.Name == "Naruto")
                    {
                        item.Name = SelecyPoly.selected.GetPlayer()[0].Name;
                    }
                }
            }
            else if (p == 1)
            {
                foreach (var item in EntitySkills())
                {
                    if (item.Name == "Sasuke")
                    {
                        item.Name = SelecyPoly.selected.GetPlayer()[0].Name;
                    }
                }
            }

        }
    }
}
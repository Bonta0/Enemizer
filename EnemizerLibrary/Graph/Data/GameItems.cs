﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnemizerLibrary.Data
{
    public static class GameItems
    {
        public static string GetLogicalId(int id)
        {
            var item = Items.Values.Where(x => x.Id == id).FirstOrDefault();
            if(item == null)
            {
                // throw??
                return "";
            }
            return item.LogicalId;
        }

        public static Dictionary<int, Item> Items { get; private set; } = new Dictionary<int, Item>()
        {
            { Fighters_Sword_and_Shield, new Item(Fighters_Sword_and_Shield, "Fighters Sword and Shield", "Fighters Sword and Shield") },
            { Master_Sword_1, new Item(Master_Sword_1, "Master Sword 1", "Master Sword") },
            { Tempered_Sword, new Item(Tempered_Sword, "Tempered Sword", "Tempered Sword") },
            { Golden_Sword, new Item(Golden_Sword, "Golden Sword", "Golden Sword") },
            { Fighters_Shield, new Item(Fighters_Shield, "Fighters Shield", "Fighters Shield") },
            { Fire_Shield, new Item(Fire_Shield, "Fire Shield", "Fire Shield") },
            { Mirror_Shield, new Item(Mirror_Shield, "Mirror Shield", "Mirror Shield") },
            { Fire_Rod, new Item(Fire_Rod, "Fire Rod", "Fire Rod") },
            { Ice_Rod, new Item(Ice_Rod, "Ice Rod", "Ice Rod") },
            { Hammer, new Item(Hammer, "Hammer", "Hammer") },
            { Hookshot, new Item(Hookshot, "Hookshot", "Hookshot") },
            { Bow, new Item(Bow, "Bow", "Bow") },
            { Boomerang, new Item(Boomerang, "Boomerang", "Boomerang") },
            { Powder, new Item(Powder, "Powder", "Magic Powder") },
            { Bee, new Item(Bee, "Bee", "Bee") },
            { Bombos, new Item(Bombos, "Bombos", "Bombos") },
            { Ether, new Item(Ether, "Ether", "Ether") },
            { Quake, new Item(Quake, "Quake", "Quake") },
            { Lamp, new Item(Lamp, "Lamp", "Lamp") },
            { Shovel, new Item(Shovel, "Shovel", "Shovel") },
            { Flute, new Item(Flute, "Flute", "Flute") },
            { Somaria, new Item(Somaria, "Somaria", "Cane of Somaria") },
            { Bottle, new BottleItem(Bottle, "Bottle", "Bottle") },
            { Piece_of_Heart, new Item(Piece_of_Heart, "Piece of Heart", "Piece of Heart") },
            { Byrna, new Item(Byrna, "Byrna", "Cane of Byrna") },
            { Cape, new Item(Cape, "Cape", "Magic Cape") },
            { Mirror, new Item(Mirror, "Mirror", "Magic Mirror") },
            { L1_Gloves, new ProgressiveItem(L1_Gloves, "L1 Gloves", "Power Gloves") },
            { L2_Gloves, new ProgressiveItem(L2_Gloves, "L2 Gloves", "Titan Mitts") },
            { Book, new Item(Book, "Book", "Book of Mudora") },
            { Flippers, new Item(Flippers, "Flippers", "Zora's Flippers") },
            { Moon_Pearl, new Item(Moon_Pearl, "Moon Pearl", "Moon Pearl") },
            { Crystal, new SpecialItem(Crystal, "Crystal", "Crystal") },
            { Bug_Catching_Net, new Item(Bug_Catching_Net, "Bug Catching Net", "Bug Catching Net") },
            { Blue_Mail, new Item(Blue_Mail, "Blue Mail", "Blue Mail") },
            { Red_Mail, new Item(Red_Mail, "Red Mail", "Red Mail") },
            { Key, new ConsumableItem(Key, "Key", "Key") },
            { Compass, new SpecialItem(Compass, "Compass", "Compass") },
            { Heart_Container_No_Animation, new Item(Heart_Container_No_Animation, "Heart Container No Animation", "Heart Container (no animation)") },
            { Bomb, new Item(Bomb, "Bomb", "Bomb") },
            { Three_Bombs, new Item(Three_Bombs, "3 Bombs", "3 Bombs") },
            { Mushroom, new ConsumableItem(Mushroom, "Mushroom", "Mushroom") },
            { Magical_Boomerang, new Item(Magical_Boomerang, "Magical Boomerang", "Magical Boomerang") },
            { Bottle_Red_Potion, new BottleItem(Bottle_Red_Potion, "Bottle Red Potion", "Bottle (Red Potion)") },
            { Bottle_Green_Potion, new BottleItem(Bottle_Green_Potion, "Bottle Green Potion", "Bottle (Green Potion)") },
            { Bottle_Blue_Potion, new BottleItem(Bottle_Blue_Potion, "Bottle Blue Potion", "Bottle (Blue Potion)") },
            { Red_Potion, new SpecialItem(Red_Potion, "Red Potion", "Red Potion") },
            { Green_Potion, new SpecialItem(Green_Potion, "Green Potion", "Green Potion") },
            { Blue_Potion, new SpecialItem(Blue_Potion, "Blue Potion", "Blue Potion") },
            { Ten_Bombs, new Item(Ten_Bombs, "10 Bombs", "Ten Bombs") },
            { Big_Key, new SpecialItem(Big_Key, "Big Key", "Big Key") },
            { Dungeon_Map, new SpecialItem(Dungeon_Map, "Dungeon Map", "Dungeon Map") },
            { Green_Rupee, new Item(Green_Rupee, "Green Rupee", "Green Rupee") },
            { Blue_Rupee, new Item(Blue_Rupee, "Blue Rupee", "Blue Rupee") },
            { Red_Rupee, new Item(Red_Rupee, "Red Rupee", "Red Rupee") },
            { _Pendant_Green_, new SpecialItem(_Pendant_Green_, "<Pendant Green>", "Pendant of Courage") },
            { _Pendant_Red_, new SpecialItem(_Pendant_Red_, "<Pendant Red>", "Pendant of Wisdom") },
            { _Pendant_Blue_, new SpecialItem(_Pendant_Blue_, "<Pendant Blue>", "Pendent of Power") },
            { Bow_And_Arrows, new SpecialItem(Bow_And_Arrows, "Bow And Arrows", "Bow And Arrows") },
            { Bow_And_Silver_Arrows, new SpecialItem(Bow_And_Silver_Arrows, "Bow And Silver Arrows", "Bow And Silver Arrows") },
            { Bottle_Bee, new BottleItem(Bottle_Bee, "Bottle Bee", "Bottle (Bee)") },
            { Bottle_Fairy, new BottleItem(Bottle_Fairy, "Bottle Fairy", "Bottle (Fairy)") },
            { Heart_Container, new Item(Heart_Container, "Heart Container", "Heart Container") },
            { Heart_Container_Refill, new Item(Heart_Container_Refill, "Heart Container Refill", "Heart Container (refill)") },
            { OneHundered_Rupees, new Item(OneHundered_Rupees, "100 Rupees", "100 Rupees") },
            { Fifty_Rupees, new Item(Fifty_Rupees, "50 Rupees", "50 Rupees") },
            { Heart, new Item(Heart, "Heart", "Heart") },
            { Single_Arrow, new Item(Single_Arrow, "Single Arrow", "Single Arrow") },
            { Ten_Arrows, new Item(Ten_Arrows, "10 Arrows", "10 Arrows") },
            { Small_Magic, new Item(Small_Magic, "Small Magic", "Small Magic Refill") },
            { ThreeHundered_Rupees, new Item(ThreeHundered_Rupees, "300 Rupees", "300 Rupees") },
            { Red_Rupee_2, new Item(Red_Rupee_2, "Red Rupee 2", "Red Rupee") },
            { Bottle_Golden_Bee, new BottleItem(Bottle_Golden_Bee, "Bottle Golden Bee", "Bottle (Golden Bee)") },
            { Fighters_Sword, new Item(Fighters_Sword, "Fighters Sword", "Fighters Sword") },
            { Flute_Active, new SpecialItem(Flute_Active, "Flute Active", "Flute (Activated)") },
            { Boots, new Item(Boots, "Boots", "Pegasus Boots") },
            { Max_Bombs, new Item(Max_Bombs, "Max Bombs", "Max Bomb Upgrade (50)") },
            { Max_Arrows, new Item(Max_Arrows, "Max Arrows", "Max Arrow Upgrade (70)") },
            { Half_Magic, new Item(Half_Magic, "Half Magic", "Half Magic") },
            { Quarter_Magic, new Item(Quarter_Magic, "Quarter Magic", "Quarter Magic") },
            { Master_Sword_2, new Item(Master_Sword_2, "Master Sword 2", "Master Sword") },
            { Bomb_Upgrade_5, new Item(Bomb_Upgrade_5, "Bomb Upgrade 5", "Bomb Upgrade (5)") },
            { Bomb_Upgrade_10, new Item(Bomb_Upgrade_10, "Bomb Upgrade 10", "Bomb Upgrade (10)") },
            { Arrow_Upgrade_5, new Item(Arrow_Upgrade_5, "Arrow Upgrade 5", "Arrow Upgrade (5)") },
            { Arrow_Upgrade_10, new Item(Arrow_Upgrade_10, "Arrow Upgrade 10", "Arrow Upgrade (10)") },
            { Programmable_1, new Item(Programmable_1, "Programmable 1", "Programmable 1") },
            { Programmable_2, new Item(Programmable_2, "Programmable 2", "Programmable 2") },
            { Programmable_3, new Item(Programmable_3, "Programmable 3", "Programmable 3") },
            { Silver_Arrows, new Item(Silver_Arrows, "Silver Arrows", "Silver Arrows") },
            { Rupoor, new Item(Rupoor, "Rupoor", "Rupoor") },
            { Nothing, new Item(Nothing, "Nothing", "Nothing (Null Item)") },
            { Red_Clock, new ConsumableItem(Red_Clock, "Red Clock", "Red Clock") },
            { Blue_Clock, new ConsumableItem(Blue_Clock, "Blue Clock", "Blue Clock") },
            { Green_Glock, new ConsumableItem(Green_Glock, "Green Glock", "Green Clock") },
            { Progressive_Sword, new ProgressiveItem(Progressive_Sword, "Progressive Sword", "Progressive Sword") },
            { Progressive_Shield, new ProgressiveItem(Progressive_Shield, "Progressive Shield", "Progressive Shield") },
            { Progressive_Armor, new ProgressiveItem(Progressive_Armor, "Progressive Armor", "Progressive Armor") },
            { Progressive_Gloves, new ProgressiveItem(Progressive_Gloves, "Progressive Gloves", "Progressive Gloves") },
            { Unique_RNG_Item, new SpecialItem(Unique_RNG_Item, "Unique RNG Item", "Unique RNG Item (RNG Pool Single)") },
            { Non_Unique_RNG_Item, new SpecialItem(Non_Unique_RNG_Item, "Non-Unique RNG Item", "Non-Unique RNG Item (RNG Pool Multi)") },
            { Progressive_Bow, new Item(Progressive_Bow, "Progressive Bow", "Progressive Bow") },
            { Progressive_Bow2, new Item(Progressive_Bow2, "Progressive Bow2", "Progressive Bow2") },
            { Triforce, new SpecialItem(Triforce, "Triforce", "Goal Item (Single/Triforce)") },
            { Power_Star, new SpecialItem(Power_Star, "Power Star", "Goal Item (Multi/Power Star)") },
            { Triforce_Piece, new SpecialItem(Triforce_Piece, "Triforce Piece", "Triforce Piece") },
            { Light_World_Map, new SpecialItem(Light_World_Map, "Light World Map", "Light World Map") },
            { Dark_World_Map, new SpecialItem(Dark_World_Map, "Dark World Map", "Dark World Map") },
            { _GT_Map_, new SpecialItem(_GT_Map_, "<GT Map>", "GT Map") },
            { _Turtle_Map_, new SpecialItem(_Turtle_Map_, "<Turtle Map>", "Turtle Rock Map") },
            { _Thieves_Map_, new SpecialItem(_Thieves_Map_, "<Thieves Map>", "Thieves' Town Map") },
            { _Hera_Map_, new SpecialItem(_Hera_Map_, "<Hera Map>", "Tower of Hera Map") },
            { _Ice_Map_, new SpecialItem(_Ice_Map_, "<Ice Map>", "Ice Palace Map") },
            { _Skull_Map_, new SpecialItem(_Skull_Map_, "<Skull Map>", "Skull Woods Map") },
            { _Mire_Map_, new SpecialItem(_Mire_Map_, "<Mire Map>", "Misery Mire Map") },
            { _PoD_Map_, new SpecialItem(_PoD_Map_, "<PoD Map>", "Palace of Darkness Map") },
            { _Swamp_Map_, new SpecialItem(_Swamp_Map_, "<Swamp Map>", "Swamp Palace Map") },
            { _Aga_Map_, new SpecialItem(_Aga_Map_, "<Aga Map>", "Agahnims Tower Map") },
            { _Desert_Map_, new SpecialItem(_Desert_Map_, "<Desert Map>", "Desert Palace Map") },
            { _Eastern_Map_, new SpecialItem(_Eastern_Map_, "<Eastern Map>", "Eastern Palace Map") },
            { _Hyrule_Map_, new SpecialItem(_Hyrule_Map_, "<Hyrule Map>", "Hyrule Castle Map") },
            { _Sewers_Map_, new SpecialItem(_Sewers_Map_, "<Sewers Map>", "Sewers Map") },
            { _GT_Compass_, new SpecialItem(_GT_Compass_, "<GT Compass>", "GT Compass") },
            { _Turtle_Compass_, new SpecialItem(_Turtle_Compass_, "<Turtle Compass>", "Turtle Rock Compass") },
            { _Thieves_Compass_, new SpecialItem(_Thieves_Compass_, "<Thieves Compass>", "Thieves' Town Compass") },
            { _Hera_Compass_, new SpecialItem(_Hera_Compass_, "<Hera Compass>", "Tower of Hera Compass") },
            { _Ice_Compass_, new SpecialItem(_Ice_Compass_, "<Ice Compass>", "Ice Palace Compass") },
            { _Skull_Compass_, new SpecialItem(_Skull_Compass_, "<Skull Compass>", "Skull Woods Compass") },
            { _Mire_Compass_, new SpecialItem(_Mire_Compass_, "<Mire Compass>", "Misery Mire Compass") },
            { _PoD_Compass_, new SpecialItem(_PoD_Compass_, "<PoD Compass>", "Palace of Darkness Compass") },
            { _Swamp_Compass_, new SpecialItem(_Swamp_Compass_, "<Swamp Compass>", "Swamp Palace Compass") },
            { _Aga_Compass_, new SpecialItem(_Aga_Compass_, "<Aga Compass>", "Agahnims Tower Compass") },
            { _Desert_Compass_, new SpecialItem(_Desert_Compass_, "<Desert Compass>", "Desert Palace Compass") },
            { _Eastern_Compass_, new SpecialItem(_Eastern_Compass_, "<Eastern Compass>", "Eastern Palace Compass") },
            { _Hyrule_Compass_, new SpecialItem(_Hyrule_Compass_, "<Hyrule Compass>", "Hyrule Castle Compass") },
            { _Sewers_Compass_, new SpecialItem(_Sewers_Compass_, "<Sewers Compass>", "Sewers Compass") },
            { _Skeleton_Key_, new SpecialItem(_Skeleton_Key_, "<Skeleton Key>", "Skeleton Key") },
            { _Reserved_0x91_, new SpecialItem(_Reserved_0x91_, "<Reserved 0x91>", "<Reserved 0x91>") },
            { _GT_Big_Key_, new SpecialItem(_GT_Big_Key_, "<GT Big Key>", "GT Big Key") },
            { _Turtle_Big_Key_, new SpecialItem(_Turtle_Big_Key_, "<Turtle Big Key>", "Turtle Rock Big Key") },
            { _Thieves_Big_Key_, new SpecialItem(_Thieves_Big_Key_, "<Thieves Big Key>", "Thieves' Town Big Key") },
            { _Hera_Big_Key_, new SpecialItem(_Hera_Big_Key_, "<Hera Big Key>", "Tower of Hera Big Key") },
            { _Ice_Big_Key_, new SpecialItem(_Ice_Big_Key_, "<Ice Big Key>", "Ice Palace Big Key") },
            { _Skull_Big_Key_, new SpecialItem(_Skull_Big_Key_, "<Skull Big Key>", "Skull Woods Big Key") },
            { _Mire_Big_Key_, new SpecialItem(_Mire_Big_Key_, "<Mire Big Key>", "Misery Mire Big Key") },
            { _PoD_Big_Key_, new SpecialItem(_PoD_Big_Key_, "<PoD Big Key>", "Palace of Darkness Big Key") },
            { _Swamp_Big_Key_, new SpecialItem(_Swamp_Big_Key_, "<Swamp Big Key>", "Swamp Palace Big Key") },
            { _Aga_Big_Key_, new SpecialItem(_Aga_Big_Key_, "<Aga Big Key>", "Agahnims Tower Big Key") },
            { _Desert_Big_Key_, new SpecialItem(_Desert_Big_Key_, "<Desert Big Key>", "Desert Palace Big Key") },
            { _Eastern_Big_Key_, new SpecialItem(_Eastern_Big_Key_, "<Eastern Big Key>", "Eastern Palace Big Key") },
            { _Hyrule_Big_Key_, new SpecialItem(_Hyrule_Big_Key_, "<Hyrule Big Key>", "Hyrule Castle Big Key") },
            { _Sewer_Big_Key_, new SpecialItem(_Sewer_Big_Key_, "<Sewer Big Key>", "Sewers Big Key") },
            { _Sewer_Key_, new ConsumableItem(_Sewer_Key_, "<Sewer Key>", "Sewers Key") },
            { _Hyrule_Key_, new ConsumableItem(_Hyrule_Key_, "<Hyrule Key>", "Hyrule Castle Key") },
            { _Eastern_Key_, new ConsumableItem(_Eastern_Key_, "<Eastern Key>", "Eastern Palace Key") },
            { _Desert_Key_, new ConsumableItem(_Desert_Key_, "<Desert Key>", "Desert Palace Key") },
            { _Aga_Key_, new ConsumableItem(_Aga_Key_, "<Aga Key>", "Tower of Agahnim Key") },
            { _Swamp_Key_, new ConsumableItem(_Swamp_Key_, "<Swamp Key>", "Swamp Palace Key") },
            { _PoD_Key_, new ConsumableItem(_PoD_Key_, "<PoD Key>", "Palace of Darkness Key") },
            { _Mire_Key_, new ConsumableItem(_Mire_Key_, "<Mire Key>", "Misery Mire Key") },
            { _Skull_Key_, new ConsumableItem(_Skull_Key_, "<Skull Key>", "Skull Woods Key") },
            { _Ice_Key_, new ConsumableItem(_Ice_Key_, "<Ice Key>", "Ice Palace Key") },
            { _Hera_Key_, new ConsumableItem(_Hera_Key_, "<Hera Key>", "Tower of Hera Key") },
            { _Thieves_Key_, new ConsumableItem(_Thieves_Key_, "<Thieves Key>", "Thieves' Town Key") },
            { _Turtle_Key_, new ConsumableItem(_Turtle_Key_, "<Turtle Key>", "Turtle Rock Key") },
            { _GT_Key_, new ConsumableItem(_GT_Key_, "<GT Key>", "GT Key") },
            { _Reserved_0xAE_, new SpecialItem(_Reserved_0xAE_, "<Reserved 0xAE>", "<Reserved 0xAE>") },
            { _Reserved_0xAF_, new SpecialItem(_Reserved_0xAF_, "<Reserved 0xAF>", "<Reserved 0xAF>") },
            { _Agahnim_1_, new SpecialItem(_Agahnim_1_, "<Agahnim 1>", "Agahnim 1 Defeated") },
            { _Agahnim_2_Boss_, new SpecialItem(_Agahnim_2_Boss_, "[Agahnim 2 Boss]", "Agahnim 2 Boss") },
            { _Agahnim_2_, new SpecialItem(_Agahnim_2_, "<Agahnim 2>", "Agahnim 2 Defeated") },
            { _Agahnim_Boss_, new SpecialItem(_Agahnim_Boss_, "[Agahnim Boss]", "Agahnim Boss") },
            { _Big_Bomb_, new SpecialItem(_Big_Bomb_, "<Big Bomb>", "Big Bomb") },
            { _Crystal_1_, new SpecialItem(_Crystal_1_, "<Crystal 1>", "Crystal 1") },
            { _Crystal_2_, new SpecialItem(_Crystal_2_, "<Crystal 2>", "Crystal 2") },
            { _Crystal_3_, new SpecialItem(_Crystal_3_, "<Crystal 3>", "Crystal 3") },
            { _Crystal_4_, new SpecialItem(_Crystal_4_, "<Crystal 4>", "Crystal 4") },
            { _Crystal_5_, new SpecialItem(_Crystal_5_, "<Crystal 5>", "Crystal 5") },
            { _Crystal_6_, new SpecialItem(_Crystal_6_, "<Crystal 6>", "Crystal 6") },
            { _Crystal_7_, new SpecialItem(_Crystal_7_, "<Crystal 7>", "Crystal 7") },
            { _Desert_Boss_, new SpecialItem(_Desert_Boss_, "[Desert Boss]", "Desert Boss") },
            { _Eastern_Boss_, new SpecialItem(_Eastern_Boss_, "[Eastern Boss]", "Eastern Boss") },
            { _Smith_, new SpecialItem(_Smith_, "<Smith>", "Frog Smith") },
            { _Ganon_, new SpecialItem(_Ganon_, "[Ganon]", "Ganon") },
            { _GT_Armos_Boss_, new SpecialItem(_GT_Armos_Boss_, "[GT Armos Boss]", "GT Armos Boss") },
            { _GT_Lanmolas_Boss_, new SpecialItem(_GT_Lanmolas_Boss_, "[GT Lanmolas Boss]", "GT Lanmolas Boss") },
            { _GT_Moldorm_Boss_, new SpecialItem(_GT_Moldorm_Boss_, "[GT Moldorm Boss]", "GT Moldorm Boss") },
            { _Hera_Boss_, new SpecialItem(_Hera_Boss_, "[Hera Boss]", "Hera Boss") },
            { _Ice_Boss_, new SpecialItem(_Ice_Boss_, "[Ice Boss]", "Ice Boss") },
            { _Ice_Block_, new SpecialItem(_Ice_Block_, "<Ice Block>", "Ice Palace Block*") },
            { L1_Shield, new ProgressiveItem(L1_Shield, "L1 Shield", "L1 Shield") },
            { L1_Sword, new ProgressiveItem(L1_Sword, "L1 Sword", "L1 Sword") },
            { L2_Shield, new ProgressiveItem(L2_Shield, "L2 Shield", "L2 Shield") },
            { L2_Sword, new ProgressiveItem(L2_Sword, "L2 Sword", "L2 Sword") },
            { L3_Shield, new ProgressiveItem(L3_Shield, "L3 Shield", "L3 Shield") },
            { L3_Sword, new ProgressiveItem(L3_Sword, "L3 Sword", "L3 Sword") },
            { L4_Sword, new ProgressiveItem(L4_Sword, "L4 Sword", "L4 Sword") },
            { _Mire_Boss_, new SpecialItem(_Mire_Boss_, "[Mire Boss]", "Mire Boss") },
            { _Misery_Mire_Token_, new SpecialItem(_Misery_Mire_Token_, "<Misery Mire Token>", "Misery Mire Entrance Token") },
            { _Mire_Switch_, new SpecialItem(_Mire_Switch_, "<Mire Switch>", "Misery Mire Switch") },
            { _PoD_Boss_, new SpecialItem(_PoD_Boss_, "[PoD Boss]", "PoD Boss") },
            { _Purple_Chest_, new SpecialItem(_Purple_Chest_, "<Purple Chest>", "Purple Chest") },
            { _Skull_Boss_, new SpecialItem(_Skull_Boss_, "[Skull Boss]", "Skull Boss") },
            { _Swamp_Boss_, new SpecialItem(_Swamp_Boss_, "[Swamp Boss]", "Swamp Boss") },
            { _Thieves_Boss_, new SpecialItem(_Thieves_Boss_, "[Thieves Boss]", "Thieves Boss") },
            { _Turtle_Boss_, new SpecialItem(_Turtle_Boss_, "[Turtle Boss]", "Turtle Boss") },
            { _Turtle_Rock_Token_, new SpecialItem(_Turtle_Rock_Token_, "<Turtle Rock Token>", "Turtle Rock Entrance Token") },
            { Progressive_Magic, new SpecialItem(Progressive_Magic, "Progressive Magic", "Progressive Magic") },
        };

        public const int
            Fighters_Sword_and_Shield = 0x00,
            Master_Sword_1 = 0x01,
            Tempered_Sword = 0x02,
            Golden_Sword = 0x03,
            Fighters_Shield = 0x04,
            Fire_Shield = 0x05,
            Mirror_Shield = 0x06,
            Fire_Rod = 0x07,
            Ice_Rod = 0x08,
            Hammer = 0x09,
            Hookshot = 0x0A,
            Bow = 0x0B,
            Boomerang = 0x0C,
            Powder = 0x0D,
            Bee = 0x0E,
            Bombos = 0x0F,
            Ether = 0x10,
            Quake = 0x11,
            Lamp = 0x12,
            Shovel = 0x13,
            Flute = 0x14,
            Somaria = 0x15,
            Bottle = 0x16,
            Piece_of_Heart = 0x17,
            Byrna = 0x18,
            Cape = 0x19,
            Mirror = 0x1A,
            L1_Gloves = 0x1B,
            L2_Gloves = 0x1C,
            Book = 0x1D,
            Flippers = 0x1E,
            Moon_Pearl = 0x1F,
            Crystal = 0x20,
            Bug_Catching_Net = 0x21,
            Blue_Mail = 0x22,
            Red_Mail = 0x23,
            Key = 0x24,
            Compass = 0x25,
            Heart_Container_No_Animation = 0x26,
            Bomb = 0x27,
            Three_Bombs = 0x28,
            Mushroom = 0x29,
            Magical_Boomerang = 0x2A,
            Bottle_Red_Potion = 0x2B,
            Bottle_Green_Potion = 0x2C,
            Bottle_Blue_Potion = 0x2D,
            Red_Potion = 0x2E,
            Green_Potion = 0x2F,
            Blue_Potion = 0x30,
            Ten_Bombs = 0x31,
            Big_Key = 0x32,
            Dungeon_Map = 0x33,
            Green_Rupee = 0x34,
            Blue_Rupee = 0x35,
            Red_Rupee = 0x36,
            _Pendant_Green_ = 0x37,
            _Pendant_Red_ = 0x38,
            _Pendant_Blue_ = 0x39,
            Bow_And_Arrows = 0x3A,
            Bow_And_Silver_Arrows = 0x3B,
            Bottle_Bee = 0x3C,
            Bottle_Fairy = 0x3D,
            Heart_Container = 0x3E,
            Heart_Container_Refill = 0x3F,
            OneHundered_Rupees = 0x40,
            Fifty_Rupees = 0x41,
            Heart = 0x42,
            Single_Arrow = 0x43,
            Ten_Arrows = 0x44,
            Small_Magic = 0x45,
            ThreeHundered_Rupees = 0x46,
            Red_Rupee_2 = 0x47,
            Bottle_Golden_Bee = 0x48,
            Fighters_Sword = 0x49,
            Flute_Active = 0x4A,
            Boots = 0x4B,
            Max_Bombs = 0x4C,
            Max_Arrows = 0x4D,
            Half_Magic = 0x4E,
            Quarter_Magic = 0x4F,
            Master_Sword_2 = 0x50,
            Bomb_Upgrade_5 = 0x51,
            Bomb_Upgrade_10 = 0x52,
            Arrow_Upgrade_5 = 0x53,
            Arrow_Upgrade_10 = 0x54,
            Programmable_1 = 0x55,
            Programmable_2 = 0x56,
            Programmable_3 = 0x57,
            Silver_Arrows = 0x58,
            Rupoor = 0x59,
            Nothing = 0x5A,
            Red_Clock = 0x5B,
            Blue_Clock = 0x5C,
            Green_Glock = 0x5D,
            Progressive_Sword = 0x5E,
            Progressive_Shield = 0x5F,
            Progressive_Armor = 0x60,
            Progressive_Gloves = 0x61,
            Unique_RNG_Item = 0x62,
            Non_Unique_RNG_Item = 0x63,
            Progressive_Bow = 0x64,
            Progressive_Bow2 = 0x65,
            Triforce = 0x6A,
            Power_Star = 0x6B,
            Triforce_Piece = 0x6C,
            Light_World_Map = 0x70,
            Dark_World_Map = 0x71,
            _GT_Map_ = 0x72,
            _Turtle_Map_ = 0x73,
            _Thieves_Map_ = 0x74,
            _Hera_Map_ = 0x75,
            _Ice_Map_ = 0x76,
            _Skull_Map_ = 0x77,
            _Mire_Map_ = 0x78,
            _PoD_Map_ = 0x79,
            _Swamp_Map_ = 0x7A,
            _Aga_Map_ = 0x7B,
            _Desert_Map_ = 0x7C,
            _Eastern_Map_ = 0x7D,
            _Hyrule_Map_ = 0x7E,
            _Sewers_Map_ = 0x7F,
            _GT_Compass_ = 0x82,
            _Turtle_Compass_ = 0x83,
            _Thieves_Compass_ = 0x84,
            _Hera_Compass_ = 0x85,
            _Ice_Compass_ = 0x86,
            _Skull_Compass_ = 0x87,
            _Mire_Compass_ = 0x88,
            _PoD_Compass_ = 0x89,
            _Swamp_Compass_ = 0x8A,
            _Aga_Compass_ = 0x8B,
            _Desert_Compass_ = 0x8C,
            _Eastern_Compass_ = 0x8D,
            _Hyrule_Compass_ = 0x8E,
            _Sewers_Compass_ = 0x8F,
            _Skeleton_Key_ = 0x90,
            _Reserved_0x91_ = 0x91,
            _GT_Big_Key_ = 0x92,
            _Turtle_Big_Key_ = 0x93,
            _Thieves_Big_Key_ = 0x94,
            _Hera_Big_Key_ = 0x95,
            _Ice_Big_Key_ = 0x96,
            _Skull_Big_Key_ = 0x97,
            _Mire_Big_Key_ = 0x98,
            _PoD_Big_Key_ = 0x99,
            _Swamp_Big_Key_ = 0x9A,
            _Aga_Big_Key_ = 0x9B,
            _Desert_Big_Key_ = 0x9C,
            _Eastern_Big_Key_ = 0x9D,
            _Hyrule_Big_Key_ = 0x9E,
            _Sewer_Big_Key_ = 0x9F,
            _Sewer_Key_ = 0xA0,
            _Hyrule_Key_ = 0xA1,
            _Eastern_Key_ = 0xA2,
            _Desert_Key_ = 0xA3,
            _Aga_Key_ = 0xA4,
            _Swamp_Key_ = 0xA5,
            _PoD_Key_ = 0xA6,
            _Mire_Key_ = 0xA7,
            _Skull_Key_ = 0xA8,
            _Ice_Key_ = 0xA9,
            _Hera_Key_ = 0xAA,
            _Thieves_Key_ = 0xAB,
            _Turtle_Key_ = 0xAC,
            _GT_Key_ = 0xAD,
            _Reserved_0xAE_ = 0xAE,
            _Reserved_0xAF_ = 0xAF,
            _Agahnim_1_ = 0x01FF,
            _Agahnim_2_Boss_ = 0x02FF,
            _Agahnim_2_ = 0x03FF,
            _Agahnim_Boss_ = 0x04FF,
            _Big_Bomb_ = 0x05FF,
            _Crystal_1_ = 0x06FF,
            _Crystal_2_ = 0x07FF,
            _Crystal_3_ = 0x08FF,
            _Crystal_4_ = 0x09FF,
            _Crystal_5_ = 0x0AFF,
            _Crystal_6_ = 0x0BFF,
            _Crystal_7_ = 0x0CFF,
            _Desert_Boss_ = 0x0DFF,
            _Eastern_Boss_ = 0x0EFF,
            _Smith_ = 0x0FFF,
            _Ganon_ = 0x10FF,
            _GT_Armos_Boss_ = 0x11FF,
            _GT_Lanmolas_Boss_ = 0x12FF,
            _GT_Moldorm_Boss_ = 0x13FF,
            _Hera_Boss_ = 0x14FF,
            _Ice_Boss_ = 0x15FF,
            _Ice_Block_ = 0x16FF,
            L1_Shield = 0x17FF,
            L1_Sword = 0x18FF,
            L2_Shield = 0x19FF,
            L2_Sword = 0x1AFF,
            L3_Shield = 0x1BFF,
            L3_Sword = 0x1CFF,
            L4_Sword = 0x1DFF,
            _Mire_Boss_ = 0x1EFF,
            _Misery_Mire_Token_ = 0x1FFF,
            _Mire_Switch_ = 0x20FF,
            _PoD_Boss_ = 0x21FF,
            _Purple_Chest_ = 0x22FF,
            _Skull_Boss_ = 0x23FF,
            _Swamp_Boss_ = 0x24FF,
            _Thieves_Boss_ = 0x25FF,
            _Turtle_Boss_ = 0x26FF,
            _Turtle_Rock_Token_ = 0x27FF,
            Progressive_Magic = 0x28FF;
    }
}

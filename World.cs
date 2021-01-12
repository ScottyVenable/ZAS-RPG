using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZASRPG
{
  public static class World
{
  public static readonly List<Item> Items = new List<Item>();
  public static readonly List<Enemy> Enemies = new List<Enemy>();
  public static readonly List<Quest> Quests = new List<Quest>();
  public static readonly List<Location> Locations = new List<Location>();
  
  
  public const int ITEM_ID_PISTOL = 1;
  public const int ITEM_ID_PISTOL_AMMO = 2;
  
  public const int ENEMY_ID_ZOMBIE_COMMON = 1;
  
  public const int LOCATION_ID_SAFEHOUSE = 1;
  
  public const int QUEST_ID_FIND_WEAPON = 1;
  
  static World()
  {
    PopulateItems();
    PopulateEnemies();
    PopulateLocations();
    PopulateQuests();
    
  }
  
  private static void PopulateItems()
  {
Items.Add(new Item());
  }
  
}
}


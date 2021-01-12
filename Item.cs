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
  public class Item
  {
    public int ID {get; set;}
    public string Name {get; set;}
    public string Description {get; set;}
    public int Weight {get; set;}
    public string Type {get; set;}
   
    public double BuyPrice {get; set;}
    public double SellPrice {get; set;}
    
    public Item(int id, string name, string description, int weight, string type, double buyprice, double sellprice)
    {
      ID = id;
      Name = name;
      Description = description;
      Weight = weight;
      Type = type;
      BuyPrice = buyprice;
      SellPrice = sellprice;
    }
  }
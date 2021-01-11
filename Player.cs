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
  public class Player
  {
    public string Name { get; set;}
    
    public int HP {get; set;}
    public int Hunger {get; set;}
    public int Thirst {get; set;}
    public int Stamina {get; set;}
    
  }
}
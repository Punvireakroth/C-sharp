using System;

namespace BasicClasses
{
  class Forest
  {
    // field
    public string name;
    public string biome;
    public int trees;
    public int age;

    public int Trees
    {
        get { return trees; }
        set { trees = value; }
    }

    public string Name
    {
        get { return name; }
        set 
        { if (value == "vireakroth" || value == "nuth" || value == "Hongly" || value == "Khom")
        {
            name = value;
        }else 
        {
            name = "Unknown";
        }
        }
    } 
    public int Age
    {
      get { return age; }
      private set { age = value; }
      
    }
  }

}

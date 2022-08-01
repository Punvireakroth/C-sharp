using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {
        // Create a object and acess then change the field data
      Forest f = new Forest();
      f.name = "Kirirom";
      f.biome = "vireakroth";
      f.trees = 1200;
      f.age = 70;
    //   After change the field data I print those data to the console
      Console.WriteLine(f.name);
      Console.WriteLine(f.biome);
      Console.WriteLine(f.trees);
      Console.WriteLine(f.age);

    }
  }
}

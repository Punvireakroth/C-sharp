# C-sharp

# OOP C#

## Why OOP

Procedural programming គឺជារបៀបដែលកូដដំណើរការពីលើចុះក្រោមហើយបើមាន function វាក៏ចូលទៅក្នុង function ហើយវាមាន several primitive data types ដែល buid-in ប៉ុន្តែនៅពេលដែលយើងសរសេរកូដកម្មវិធីយើងស្មុគស្មាញយើងត្រូវការបង្កើតនូវ costum datatype ។

ឩទាហរណ៍ ថាប្រសិនជាយើងបង្កើតក្រុមបាល់ទាត់មួយយើងមិនអាចធ្វើជាអ្នកចាំទី ជាខ្សែរការពារ ជាខ្សែបម្រើ និង ជាខ្សែរប្រយុទ្ធតែម្នាក់ឯងទេ ដូចច្នេះយើងត្រូវការ role របស់កីឡាករនីមួយៗដើម្បីបង្កើតបានជាក្រុមបាល់ទាត់ពេញលេញមួយ ។ បើយើងលើកយកខ្សែរប្រយុទ្ធមកនិយាយយើងឃើញថា គាត់មានចំណុចពីរធំៗ គឺ អត្តសញ្ញាណនិងតួនាទីរបស់គាត់ ដូច្នេះខ្សែរប្រយុទ្ធនោះប្រៀបបានដូចជា Object ដែល Object មាននូវ Attribute និង Method ។ ចឹង Attribute របស់ខ្សែរប្រយុទ្ធមានដូចជា លេខអាវគាត់, គាត់រត់នៅទីតាំងណា, ល្បឿនគាត់រត់ប៉ុន្មាន,​ គាត់ពាក់ស្បែកជើងម៉ាកអីជាដើម ។ ចំណែកឯ Method របស់ខ្សែរប្រយុទ្ធវិញនោះមានដូចជា រត់, សុតបាល់, តែតបាល់, ញាក់ ... ។ ចឹងសរុបមកវិញ Object គឺត្រូវការ Method និង Attribute ។ ប៉ុន្តែយើងត្រូវចាំថាក្នុងក្រុមបាល់ទាត់មិនមែនមានខ្សែរប្រយុទ្ធតែម្នាក់ទេយ៉ាងហោចណាស់ក៏ពីរឬបីនាក់ដែរ ដូចជា ខ្សែរប្រយុទ្ធ_Ronaldo, ខ្សែរប្រយុទ្ធ_Messi ជាដើម ដូច្នេះប្រសិនជាខ្សែរប្រយុទ្ធ មាន ខ្សែរប្រយុទ្ធ_Ronaldo , ខ្សែរប្រយុទ្ធ_Messi នោះខ្សែរប្រយុទ្ធតែឯងគេហៅថា Class ក្នុង OOP ហើយ ខ្សែរប្រយុទ្ធ_Ronaldo , ខ្សែរប្រយុទ្ធ_Messi គឺជា Object នោះឯងនៅក្នុង OOP ។

## Making Classes

បើយើងមើល build-in data type string យើងឃើញថាវាមានទាំង values (attribute) និង​ Functionality (method)

```c#
string phrase = "VireakRoth";
Console.WriteLine(phrase.Length);
Console.WriteLine(phrase.IndexOf("R"));
```

កូដខាងលើ phrase គឺជា `instance` នៃ string ហើយ string មាន property `length` និង method `indexOf()`

class គឺជាការបង្កើត data type ដែលខុសពី primative datatype ដែលវាមាននូវ attribute និង method នៅក្នុងនោះ បន្ទាប់ពីយើងបង្កើត class មួយបានយើងអាចបង្កើត instance ឬយើងហៅថា object ចេញពី class នោះ ។

This is how we create a class

```C#
class Car {
    ...
}
```

យើងគួរតែបង្កើត Class មួយនៅក្នុង file ដាច់ពីគេដើម្បីឱ្យកូដយើងស្រួលមើលនិង debug

ហើយនៅក្នុង `main()` យើងអាចប្រើ class ដែលយើងបង្កើតនោះដោយយើងធ្វើការបង្កើតជា object ឬ instance ដោយប្រើប្រាស់ keyword `new`

```c#
Car c = new Car();
```

ដំណើរការនៃការបង្កើត object ឬ instance ពី class មួយយើងហៅថា `instantiated`

## Fields

យើងប្រាកដជាត្រូវការទិន្នន័យផ្សេងៗដើម្បីភ្ជាប់ទៅនិង Class របស់យើងហើយ ។ រាល់ pieces​ of data ត្រូវបានគេហៅថា fields ។

```c#
class Car {
  public string type;
  public int model;
}
```

យើងអាចយក fields ទាំងនោះហើយប្តូរតម្លៃវាដោយប្រើ .

```c#
Car f = new Car();
f.type = "SportCar";
Console.WriteLine(f.type); // Prints "SportCar"

Car f2 = new Car();
f2.type = "Pick-up Car";
Console.WriteLine(f2.type); // Prints "Pick-up Car"
```

## Properties

មកដល់ត្រឹមនេះ យើងអាចដាក់តម្លៃអ្វីក៏បាននៅក្នុង `Car` field ចុះឩទាហរណ៍ថាយើងមាន field មួយដែលទាក់ទងនិង speed (ល្បឿន) ហើយយើងឱ្យតម្លៃវា -10 តើមានល្បឿនឡានជាតម្លៃអវិជ្ជមានដែរឬទេ ចម្លើយគឺអត់ទេ ដូច្នេះយើងត្រូវការប្រើប្រាស់ C# property ដើម្បីឆែកលក្ខណទាំងនេះ (property​​ គឺជាប្រភេទមួយទៀតនៃ class member របស់ C#) ។

យើងអាចគិតថា properties ថាជាអ្នកមើលការខុសត្រូវរបស់ feild យើងអាចប្រើវាដើម្បីវាយតម្លៃថាអាតម្លៃមួយនិងវាគួរតែដាក់នៅក្នុង field ឬក៏អត់ ។

This is the syntax

យើងអាចឱ្យវាពិនិត្យលក្ខណបានដូចនេះ

```c#
public int Speed
{
  get { return speed; }
  set
  {
    if (value < 0) { speed = 0; }
    else { speed = value; }
  }
}
```

```c#
Car f = new Car();
// set() is called
f.Speed = -1;
// get() is called; prints 0
Console.WriteLine(f.Speed);
```

ចឹងកូដខាងលើប្រសិនបើ speed field របស់យើងវាតូចជា 0 យើងនិងឱ្យតម្លៃ speed របស់យើងស្មើសូន្យនៅក្នុង field

## Short-hand

យើងអាចសរសេរ getter and setter ខ្លីបែបនេះក៏បាន ។ នៅពេលដែលយើងសរសេរបែបនេះយើងក៏ពុំចាំបាច់កំណត់ field ដែរ​ ។

```c#
public string Size
{ get; set; }
```

## public and private

```c#
f.Speed = 100; // Using property
f.speed = -10; // using field
```

ជួរទី២នៃកូដខាងលើបានជៀសវាងមិនប្រើប្រាស់នូវ Property ដោយវាព្យាយាមចូលទៅក្នុង Field ផ្ទាល់តែម្តងតែយើងអត់ចង់បានចឹងទេ បើចឹងដដែលយើងបង្កើត proterties មកធ្វើអ្វី ។
ដើម្បីដោះស្រាយនូវបញ្ហានេះយើងប្រើប្រាស់ `access modifiers` ( public and private )

យើងគួតែឱ្យ field ជា private ហើយ properties ជា public

ហេតុផលគឺព្រោះពេលយើងដាក់ field ទៅជា Private main() method មិនអាច access class member មួយនិងបានទេ ។

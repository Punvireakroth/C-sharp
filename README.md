# C-sharp

# OOP C#

## Why OOP

procedural programming has several primitive data types but in real-world problems, we need to create a custom data type that call class that consist of attribute and method

-> for example car has attribute of brand, color, type... and method such as move, drift...

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

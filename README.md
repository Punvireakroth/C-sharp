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

using Aula7;

var myservice = new MyService<bool>();

var dog = new Dog();
var cat = new Cat();
myservice.Execute(cat);
myservice.Execute(dog);

Console.ReadKey();
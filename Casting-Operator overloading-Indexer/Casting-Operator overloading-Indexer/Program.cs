using Casting_Operator_overloading_Indexer;
using Casting_Operator_overloading_Indexer.Controllers;

EmployeeController employeeController = new EmployeeController();
//employeeController.GetAll();
//employeeController.Search();

//boxing-unboxing

//int a = 5;
////object b = a;

//int a = 6;
//object b = a;
//int c = (int)b;
//Console.WriteLine(b);

//byte num = 50;
//int num2 = num;

//int a = 10;
//byte b = (byte)a;
//Console.WriteLine(b);

//Animal animal = new Animal();
Fish fish = new Fish();
Animal animal1 = fish;
//Animal animal2=new Animal();
//Fish fish1 = (Fish)animal2 ;
Animal animal3 = new Dog();
Animal animal4 = new Fish();
Animal animal = new();
//Fish fish1 = (Fish)animal; 

Dog dog = new Dog();
//object[] datas = { 1, 2, true, "salam" };

object[] animals = { animal1, animal3, animal4,dog };
foreach (var item in animals)
{
    Animal data=item as Animal;
    if (data != null)
    {
        data.Name = "Akula";
        //Console.WriteLine(data.Name);
    }
    //if(item is Animal )
    //{
    //   animal.Name = "Toplan";
    //}
    //Console.WriteLine(animal.Name);
}

//DataList dataList = new DataList();
//dataList[0] = "salam";
//dataList[1] = "Sagol";
//Console.WriteLine(dataList);

User user1 = new ();
user1.Id = 1;
user1.Age = 25;

User user2 = new ();
user2.Id = 2;
user2.Age = 30;
Console.WriteLine(user1>user2);
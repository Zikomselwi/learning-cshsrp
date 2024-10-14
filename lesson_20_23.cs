public class Animal1 {
    public int id;
    public string name;
    public int Age;
    // public Animal1(int _id,string _name,int _age) {
    //     this.id = _id; 
    //     this.name = _name;
    //         this.Age = _age;

    // }
    public void printinfo(int id) {
Console.WriteLine("The desription About Rama{0}",id);
    }
    }
public class Animal2 : Animal1{

// public Animal2():base(1,"lama",50){
// this.Age = 23;
// this.id = 2;
// this.name = "rama";
// }
public void printinfo(int i){
    //هنا طبعنا المعرف حق الكلاس الاب
    Console.WriteLine("",base.id);
            base.printinfo(1);

Console.WriteLine("The desription About Lama"+i);
// Console.WriteLine("The desription About Rama{0},{1},{2}",id,Age,name);
    }
    }
    

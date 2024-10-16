using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Text;
using static lesson23_25E;


// Using alias for namespaces
using PA_A = projectA.teamA;
using PA_B = projectA.teamB;

// Define the delegate
public delegate bool neeupdate(EmployeesD employees);
public class Employee{
string Name;
public void PrintInfo( string _Name){
    Console.WriteLine(""+_Name);
}
}
public class emp{
    public int Num;
    public string Name;
    
}
//كيفية البحث عن طريق idexer
public class Indexr:emp{
    private List<emp> st;
    public Indexr(){

    st=new List<emp>{
        //method 1
        new emp{
        Name="IdexerZiko",
        Num=3},
        new emp{
        Name="IdexerZiko",
        Num=7}};
        //method 2
        
        st.Add(new emp{Name="Z",Num=1});
        st.Add(new emp{Name="K",Num=2});
        st.Add(new emp{Name="A",Num=3});
        st.Add(new emp{Name="R",Num=5});
        }
 public string this[int i]
    {
        get
        {
            // method 1
            foreach (emp e in st)
            {
                if (e.Num == i)
                {
                    return e.Name;
                }
            }
            return null; // Return null if no match is found
        }
       set
        {
            var emp = st.FirstOrDefault(j => j.Num == i);
            if (emp != null)
            {
                emp.Name = value;
            }
        }

    }
    //method2
        //     return std.FirstOrDefault(d => d.Nme == i)?.Name;
         }
    
    
/*
in partail class  لايمكن ان تكون abstract or saled if class type static you must proprety is static 
*/

public partial class Employees2{
    public string Name;
    partial void privateMethod();
}

public partial class Employees2{
    // دالة البارشال تستخدم مرة واحدة وتكون private دائما
        partial void privateMethod(){
Console.WriteLine("HI");
        }

    public void printName(string name){
        Console.WriteLine(name);
    }

    
}
public class implements
{
    public static list<CustomerService> getinfo(list<CustomerService> _List,string Name){
        List<CustomerService> list = new CustomerService();
        foreach(var item in _List){
            if(item.Name == Name){
                list.Add(item);
            }
            return list;

        }
    }
}
public class EmployeesD
{
    public int EmployeeID;
    public string EmployeeName;
    public int EmployeeAge;

    // Method to print employees based on delegate criteria
    public static void PrintEmployee(EmployeesD[] emp, neeupdate update)
    {
        foreach (EmployeesD employee in emp)
        {
            if (update(employee))
            {
                Console.WriteLine(employee.EmployeeName);
            }
        }
    }
}

public delegate int multidelegat1();

class Program
{
    // Static update method for employee age check
    public static bool Update(EmployeesD employees)
    {
        return employees.EmployeeAge > 4;
    }

    // Enum for Gender
    public enum Gender : short
    {
        Female = 2,
        Male = 1,
    }
public class customr{
    public string FirstName {set;get;}
    public string LastName{set;get;}
    public override string ToString(){
        return FirstName+""+LastName;


    } 
    // لو اردنا نوع الاستقبال يكون genaric
    public static int Addnumber(object num1, object num2){
        return Convert.ToInt16(num1)+Convert.ToInt16(num2);

    }
    public override bool Equals(object obj)
    {
        if(obj==null) return false;
        if(!(obj is customr)) return false;
        return this.FirstName==((customr)obj).FirstName && this.LastName==((customr)obj).LastName;
    }
    
    // override object.GetHashCode
    public override int GetHashCode()
    {
        // TODO: write your implementation of GetHashCode() here
        throw new System.NotImplementedException();
        return base.GetHashCode();
    }

/**************************************************************/
/**************************************************************/
/**************************************************************/
/**************************************************************/
/**************************************************************/
}
    public static void Main()

    {
        // lesson Linq in C# 
var  im=implements.getinfo()
foreach(var i in im){
    Console.WriteLine(i.Name);
}   
        // هذا  ه مبدا متعددة الاشكال يعني كل كلاس تطبع الدالة تبعها وكلاهم وارثن من كلاس واحد
        lesson23_25 [] lesson23_25s =new lesson23_25[5];
        lesson23_25s[0]=new lesson23_25A();
        lesson23_25s[1]=new lesson23_25B();
        lesson23_25s[2]=new lesson23_25C();
        lesson23_25s[3]=new lesson23_25D();
        lesson23_25s[4]=new lesson23_25F();
        foreach (lesson23_25 el in lesson23_25s)
        {
            el.PrintInfo();
            
        }

        // في هذا المثال بيطبع دالة الاب
        // لكن اذا كان الدالة فيها override سيطبع الابن

        Animal2 animal2= new Animal2();
        //casting in C # mehod1
        ((Animal1)animal2).printinfo(2);
        // casting method 2
        Animal1 animal1 =new Animal2();
         animal1.printinfo(3);
       Indexr s= new Indexr();
       Console.WriteLine(s[7]);
    
    // indexer in C# 
        DataTable dataTable= new DataTable("mytable");
        dataTable.Columns.Add("Column1");
        dataTable.Columns.Add("Column2");
        DataRow dataRow= dataTable.NewRow();
        dataRow["Column1"]="muhammad";
        dataRow["Column2"]="Zikom";
        Console.WriteLine(dataRow["Column1"]);
        // في البارشل كلاس يمكن ان نسمي اكتر من كلاس نفس الاسم 
        // بس يلزمنا كتابة كلمة بارشل قبل الكلاس
        Employees2 employees= new Employees2();
        employees.printName("zakaria");
       var h= employees.Name="Ziko";
 Console.WriteLine(h);
        student student1 = new(){Nme=1};
        student student2 = new(){Nme=1};  
        Console.WriteLine(lesson_46_50.Equals<int>(4, 4 ));
        
        string N1="Zakaria Mansour Mujahid ";
        N1+="Alselwie";
        N1+="&&";
StringBuilder f=new StringBuilder("Can you Help Mi");
    
f.Append("Please!❤");
Console.WriteLine(s);

        // StringBuilder نبدا اول شئ نظمن المكتبة   using System.Text

        Console.WriteLine(customr.Addnumber("3",3));
    /*
    الانعكاس في 
    C# هو ميزة قوية تتيح لك فحص والتفاعل مع البيانات الوصفية للأنواع، الكائنات، والتجميعات في وقت التشغيل. يشمل ذلك:

فحص الأنواع: يمكنك فحص الأنواع المعرفة في تجميع، بما في ذلك طرقها، خصائصها، حقولها، وأحداثها.
إنشاء الكائنات: يمكنك إنشاء كائنات من الأنواع ديناميكيًا.
استدعاء الطرق: يمكنك استدعاء الطرق على الكائنات ديناميكيًا.
الوصول إلى الحقول والخصائص: يمكنك الحصول على أو تعيين قيم الحقول والخصائص.
    */
  
    //كما يستخدم اذا كان هناك دالة قديمة ولن تعمل مع الاصدار الجديد
    // بعض خصائثص الاوبجكت
    int Numer =8;

    customr c=new customr();
    c.FirstName = "Zakarya";
    c.LastName = "Alselwi";
    Console.WriteLine(c.Equals(c));
    Console.WriteLine(Numer);
    Console.WriteLine(Convert.ToString(Numer));
    Console.WriteLine(c.ToString());
   // Console.WriteLine(Convert.ToString(c));
    Employee employee1= new Employee();
    Type t= employee1.GetType();
    object obj = Activator.CreateInstance(t);
    MethodInfo mi=t.GetMethod("PrintInfo") ;
    string [] prams =new string [] { "ziko Alelwi"};
   string Name =(string ) mi.Invoke(obj,prams);
   Console.WriteLine("The First Name {0}",Name);
    { //43 الربط المتأخر باستخدام الانعكاس Late binding using reflection

        // Create an instance of lesson17_18
        lession17_18 lesson = new lession17_18();
        lesson.Name = "hk";
        Console.WriteLine(lesson.ToString());

        // Get type information
        Type type = Type.GetType("Lesson32_40");
        Console.WriteLine(type.Name);
        PropertyInfo[] propertyInfos = type.GetProperties();
        foreach (PropertyInfo pi in propertyInfos)
        {
            Console.WriteLine(pi.Name + " " + pi.PropertyType.FullName);
        }

        // Get method information
        MethodInfo[] methodInfos = type.GetMethods();
        foreach (MethodInfo m in methodInfos)
        {
            Console.WriteLine(m.Name + " " + m.ReturnType.FullName);
        }

        // Create employees
        EmployeesD[] employee = new EmployeesD[4]
        {
            new EmployeesD() { EmployeeID = 1, EmployeeName = "Muhammad", EmployeeAge = 3 },
            new EmployeesD() { EmployeeID = 2, EmployeeName = "Zakaria", EmployeeAge = 32 },
            new EmployeesD() { EmployeeID = 3, EmployeeName = "Ali", EmployeeAge = 25 },
            new EmployeesD() { EmployeeID = 4, EmployeeName = "Sara", EmployeeAge = 22 }
        };

        // Delegate instance
        neeupdate updateDelegate = new neeupdate(Update);
        EmployeesD.PrintEmployee(employee, updateDelegate);

        // Reading from a file
        string filePath = @"E:\Asp.Net Core\C# Learning\ConsoleApp1\gfhs.txt";
        try
        {
            using (StreamReader streamReader = new StreamReader(filePath))
            {
                Console.WriteLine(streamReader.ReadToEnd());
            }
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.FileName);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.StackTrace);
        }

        // Delegate example
        multidelegat1 n = new multidelegat1(Method1);
        n += Method2;
        n += Method3;
        Console.WriteLine(n());

        // Simple calculator
        double result = 0;
        Console.WriteLine("Enter number 1:");
        int number1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2:");
        int number2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter operation (+, -, *, /):");
        char operation = char.Parse(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = number1 + number2;
                break;
            case '-':
                result = number1 - number2;
                break;
            case '*':
                result = number1 * number2;
                break;
            case '/':
                result = number1 / number2;
                break;
            default:
                Console.WriteLine("ERROR in calculation");
                break;
        }

        Console.WriteLine("The result of the operation: " + result);

        // Enum values
        int[] enumValues = (int[])Enum.GetValues(typeof(Gender));
        foreach (int v in enumValues)
        {
            Console.WriteLine(v);
        }

        // Validate student input
        Validate();
    }}

    public static int Method1() => 1;
    public static int Method2() => 2;
    public static int Method3() => 3;

    public static void Validate()
    {
        Console.WriteLine("Are you a student? (1 for Yes, 0 for No):");
        int result = int.Parse(Console.ReadLine());
        bool isValid = result == 1;
        Console.WriteLine("Are you a student: " + isValid);
    }
}

// Namespace definitions
namespace projectA
{
    namespace teamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello from Class A");
            }
        }
    }

    namespace teamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Hello from Class B");
            }
        }
    }
}
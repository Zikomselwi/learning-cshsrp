public class opetator{
    int n1=30;
    int n2=10;
   /// <summary>
   /// هدا التاج عبارة عن اشارة توظيحية للكود الي كتبتة
   /// </summary>
   //  | يتحقق من الشرط الاول اذا كان صواب والا خطا راح ينتقل للشرط الثاني
   //  || يتحقق من الشرط الاول اذا كان صواب يعدي الشرط الثاني امااذا كان الشرط الاول غلط  ينتقل للشرط الثاني
    public opetator()
    {
 int modual=n1 % n2;
 bool m=n1==30;
 int ?f= null;
 bool istrue=((modual==2)|| (m));
 //??  يعني اذاكانت القيمة فارغة نحط لها قيمة
 float output=f??2;
  int cast=(int)output;
  string parse="4332";
  //يتعامل مع string كانة list
  Console.WriteLine(parse[0]);
  string[] arrs= new string[]{
"Zakaria","Mansoor","Mujahid"
  };
  int defaultvalue=0;
  //pars تحويل الداتا الي اي نوع تريدة
  int pars=int.Parse(parse)+1;
  bool tryparse=int.TryParse(parse,out defaultvalue);
  //arrays اذا اردنا نطبع اول حرف في المصفوفة
 Console.Write(arrs[1][0] );
 Console.Write(istrue );
 Console.Write(defaultvalue);
    }
public void switch1(){
    double result2 = 0; // Initialize result2
    string res;
    do {
        Console.WriteLine("Enter number 1");
        int input1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number 2");
        int input2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter operation \n1->+ \n2->- \n3->* \n4->/");
        int Opration = int.Parse(Console.ReadLine());

        switch(Opration){
            case 1:
                result2 = input1 + input2;
                break;
            case 2:
                result2 = input1 - input2;
                break;
            case 3:
                result2 = input1 * input2;
                break;
            case 4:
                result2 = input1 / input2;
                break;
            default:
                Console.WriteLine("Invalid Operation");
                break;
        }
        Console.WriteLine("The Result is: " + result2);
        Console.WriteLine("Do you want to perform another operation? (y/n)");
        res = Console.ReadLine();
    } while(res == "y");
}

 
}



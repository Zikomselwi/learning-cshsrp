/* المتتغير الذي نوعه static 
لايتغير يظل محفوظ في الذاكرة 
واذا تغير تتغير على كل الكلاسات
*/
public class lession17_18{
    public string Name ;
    //passing by value using key out
    public lession17_18(){
int div=0;
int mult=0;
int div1;
int mult1;

Console.WriteLine(calculater(12,10,ref div,ref mult));    
Console.WriteLine(mult); 

Console.WriteLine(calculater1(12,10,out div1,out mult1));    
Console.WriteLine(mult); 
//arrMethod(1,2,3,4,5,5,6);  
//هنا بعثنا arrr for pramas
// another method define arr
// int []arr=new int[3]{6,3,3
// };
// arrMethod(arr);
// arrMethod(new int []{1,2,3,4,5,6});   
arrMethod("ziko 1",new int []{1,2,3,4,5,6});   
    } 
    /*ref
تُستخدم لتمرير المعاملات بالمرجع، مما يعني أن أي تغيير يُجرى على المعاملات داخل الدالة سينعكس على المتغير الأصلي خارج الدالة.
يجب تهيئة المتغير قبل تمريره إلى الدالة باستخدام ref
*/  
      public static int calculater(int n1,int n2,ref int div,ref int mult)

    {
       
        div=n1/n2;
        mult=n2*n1; 
        return n1+n2;
    }
    /*out 
تُستخدم أيضًا لتمرير المعاملات بالمرجع، ولكن يجب أن يتم تعيين قيمة للمعامل داخل الدالة قبل استخدامها.
لا يجب تهيئة المتغير قبل تمريره إلى الدالة باستخدام out*/
     public static int calculater1(int n1,int n2,out int div,out int mult)
    {
       
        div=n1/n2;
        mult=n2*n1; 
        return n1+n2;
    }
    //لواردنا تمرير قيم كثيره تستخدم paramsمثل ارجاع بيانات من عدة جداول
    public static void arrMethod(params int[]e)
    {
        foreach (var item in e)
        {
            Console.WriteLine(item);
        }
    }
    //pramas   لايمكن اضافتة الامرة واحدة

    //pramas   ولواردنا اضافة باراميتر ثاني لازم نخلية بالاخير

    public static void arrMethod( string a,params int[]e)
    {
        foreach (var item in e)
        {
            Console.WriteLine(a+" "+item);
        }
    }
}
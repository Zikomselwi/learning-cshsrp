public class lesson32_40{
    //هذا التوع يمكن ان وصله من كلاس ثاني الا اذا ورثناه
    public string Name { get; set; }    
        protected int ID ;
//هذا لايكن الوصول الية الا في نفس الكلاس
    private int _ID; 
    #region 
    // هنا تستخدم Obsolte لكي اذا كان هناك تحديث للدالة والذي هو بمثابة منع استخدام الدالة 
// لان صار لها نسخة حديثة
[Obsolete("This Function Become new Version", true)]
public  void add(int n1,int n2){
int sum=0;
sum=n1=+n2;

Console.WriteLine("Sum of tow Number:"+sum); 
}
public  void add(int n1,int n2,params int[] p){
 int sum=n1+n2;   
 for(int i=0;i<p.Length;i++){
    sum+=p[i];
 }
Console.WriteLine("Sum of tow Number:"+sum); 
}}
#endregion

public class lesson_protected:lesson32_40{
    public lesson_protected(){
        this.ID = 0;
    }

}

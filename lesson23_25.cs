public class lesson23_25{
    public virtual void PrintInfo(){
        Console.WriteLine("Perant");
    }
    
}
public class lesson23_25A:lesson23_25{
    public override void PrintInfo(){
        Console.WriteLine("A");
    }
}
public class lesson23_25B:lesson23_25{
    public override void PrintInfo(){
        Console.WriteLine("B");
    }
}
public class lesson23_25C:lesson23_25{
    public override void PrintInfo(){
        Console.WriteLine("C");
    }
}
public class lesson23_25D:lesson23_25{
    public override void PrintInfo(){
        Console.WriteLine("D");
    }
}
public class lesson23_25E:lesson23_25{
    public override void PrintInfo(){
        Console.WriteLine("E");
    }

//new تفعل hidding من الاب
//هنا اذافعلنا casting سيطبع دالة الاب الانة لانه override غير موجودة التي تعمل على تعدد الاسكال 
public class lesson23_25F:lesson23_25{
    public new void PrintInfo(){
        Console.WriteLine("F");
    }
   
}}
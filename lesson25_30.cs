//في الاستركت لازم في البارامتر تبع الكونستركتور يحتوي على كل المتغيرات حق الاسترك
// عند الاتصال بقاعدة البيانات لازم نستخدم الكلاس لان الاستاك لايظل لفترة وجيزه ينتهي سريع
public struct lesson25_30{
    int id;
    string name;
    public lesson25_30(int id, string name) {
        this.id = id;
        this.name = name;
    }
    //properties 
    //  لو  اردنا فقط للقراءة
    public string Name{
        get{return name;}
        // set{name=value;}
    }
}

// الميزه في الانترفيس انه تقد نورث لاكثر من انترفيس اما في الكلاس ما نقدر نورث الا لكلاس واحد
interface Ilesson25_30{
    void Print();
    int getId();
    string getName();

}
interface Ilesson25_30a{
    
    string getName1();

}
public class Lesson25_30d : Ilesson25_30, Ilesson25_30a
{
    public int getId()
    {
        throw new NotImplementedException();
    }

    public string getName()
    {
        throw new NotImplementedException();
    }

    public string getName1()
    {
        throw new NotImplementedException();
    }

    public void Print()
    {
        throw new NotImplementedException();
    }
}
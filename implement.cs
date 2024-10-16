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

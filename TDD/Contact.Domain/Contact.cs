namespace Contact.Domain
{
    public class ContactUser
    {
       public string Name { get; set; }
       public int Age { get; set; }
       public string User { get; set; }
       public string Email { get; set; }
    
    public ContactUser(string name, int age, string user, string email){
        this.Name = name;
        this.Age = age;
        this.User = user;
        this.Email = email;
    }
}
}
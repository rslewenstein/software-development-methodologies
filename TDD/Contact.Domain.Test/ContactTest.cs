using Xunit;
using Contact.Domain;

namespace Contact.Domain.Test
{
    public class ContactTest
    {
        //Create a contact with the datas:
        //Name, Age, User, Email

        [Fact]
        public void Create_Contact_Test(){
            var ContactExpeted = new {
                Name = "Mariah",
                Age = 30,
                User = "mariah_",
                Email = "mariah@aaa.xw"
            };

            var contact = new ContactUser(
                ContactExpeted.Name, 
                ContactExpeted.Age, 
                ContactExpeted.User, 
                ContactExpeted.Email);

            Assert.Equal(ContactExpeted.Name, contact.Name);    
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Models
{
    public class Data
    {
        public static IEnumerable<Contact> GetContacts()
        {
            yield return new Contact
            {
                FirstName = "Hai",
                LastName = "Nguyen Quang",
                Email = "quanghai.ng1512@gmail.com",
                JobTitle = "Software Architect",
                PhotoUrl = @"https://scontent.fsgn4-1.fna.fbcdn.net/v/t1.0-9/fr/cp0/e15/q65/15895340_930327490437607_7963573283964259230_n.jpg?efg=eyJpIjoiYiJ9&oh=81de667973a2c212dcd0442561dc80d5&oe=5975CB80",
                Company = "Microsoft",
                City = "San Francisco",
                State = "CA",
                Street = "2030 Judah St"
            };
            yield return new Contact
            {
                FirstName = "Huy",
                LastName = "Dao Duc",
                Email = "emailchoigamecuahuy@gmail.com",
                JobTitle = "Project Manager",
                PhotoUrl = @"https://scontent.fsgn5-1.fna.fbcdn.net/v/t31.0-8/fr/cp0/e15/q65/13568989_583569401803973_2695584588012122123_o.jpg?efg=eyJpIjoiYiJ9&oh=d03a891dd45611988f61c86d857cfa51&oe=5985760D",
                Company = "Microsoft",
                City = "San Francisco",
                State = "CA",
                Street = "2030 Judah St"
            };
            yield return new Contact
            {
                FirstName = "Thinh",
                LastName = "Dinh Canh",
                Email = "ariesarsenal@gmail.com",
                JobTitle = "Vice Director",
                PhotoUrl = @"https://scontent.fsgn5-1.fna.fbcdn.net/v/t1.0-9/fr/cp0/e15/q65/17799249_265009357293302_3600466238718282395_n.jpg?efg=eyJpIjoiYiJ9&oh=511053acb168fdd319ebe828acb92c58&oe=598D6C89",
                Company = "DCT Company",
                City = "San Francisco",
                State = "CA",
                Street = "2030 Judah St"
            };
            yield return new Contact
            {
                FirstName = "Khuong",
                LastName = "Nguyen",
                Email = "ksharp@gmail.com",
                JobTitle = "Director",
                PhotoUrl = @"https://scontent.fsgn5-1.fna.fbcdn.net/v/t31.0-8/fr/cp0/e15/q65/17097542_1575056205857682_304377491630127090_o.jpg?efg=eyJpIjoiYiJ9&oh=fa1fa4c5ca4fb5deec122a5bb564605b&oe=598494D7",
                Company = "Microsoft",
                City = "San Francisco",
                State = "CA",
                Street = "2030 Judah St"
            };
        }
    }
}

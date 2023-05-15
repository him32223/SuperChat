using SuperChat.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChat.MVVM.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel()
            {
                Username = "Kvern",
                UsernamColor = "#409aff",
                ImageSource = "https://i.ytimg.com/vi/tQgInNU-9sc/maxresdefault.jpg",
                Message = "a4 alot things to do gg liao",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true,
            });
            for (int i = 0; i < 3; i++)
            {
                Messages.Add(new MessageModel()
                {
                    Username = "Jia EN",
                    UsernamColor = "#409aff",
                    ImageSource = "https://i.ytimg.com/vi/tQgInNU-9sc/maxresdefault.jpg",
                    Message = "LALALLAALALAL",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
                    FirstMessage = false,
                });
            }

            for (int i = 0; i < 4; i++)
            {
                Messages.Add(new MessageModel()
                {
                    Username = "Jia Hong",
                    UsernamColor = "#409aff",
                    ImageSource = "https://i.ytimg.com/vi/tQgInNU-9sc/maxresdefault.jpg",
                    Message = "U Enro",
                    Time = DateTime.Now,
                    IsNativeOrigin = false,
   
                });
            }
            Messages.Add(new MessageModel()
            {
                Username = "Jia Hong",
                UsernamColor = "#409aff",
                ImageSource = "https://i.ytimg.com/vi/tQgInNU-9sc/maxresdefault.jpg",
                Message = "I Enroll",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                
            });

            for (int i = 0; i < 5; i++)
            {
                Contacts.Add(new ContactModel{
                    Username = $"Yi Hong {i}",
                    ImageSource  = "https://i.pinimg.com/originals/10/3f/94/103f94e3ac344fffb634b362c7ddde3a.png",
                    Messages = Messages
                });
            }
        }
    }
}

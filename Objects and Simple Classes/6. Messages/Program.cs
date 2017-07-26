using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();
            string input = Console.ReadLine();
            while (input!="exit")
            {
                string[] curentInput = input.Split(' ').ToArray();
                if (curentInput[0]== "register")
                {
                    userList.Add(CreatUser(curentInput[1]));
                }
                else
                {   
                    for (int i = 0; i < userList.Count; i++)
                    {
                        if (userList[i].Name==curentInput[2]&&ChekName(curentInput[0], userList))
                        {
                            userList[i].listMessages.Add(CrateMessage(curentInput[0], curentInput[3]));
                        }
                    }
                }
                input = Console.ReadLine();
            }
            string[] twoUsers = Console.ReadLine().Split(' ');
            List<Message> first =new List<Message>() ;
            List<Message> second = new List<Message>();
            foreach (var item in userList)
            {
                if (item.Name==twoUsers[0])
                {
                    first = item.listMessages.Where(um=>um.Sender== twoUsers[1]).ToList();
                }
                if (item.Name == twoUsers[1])
                {
                    second = item.listMessages.Where(um => um.Sender == twoUsers[0]).ToList();
                }
            }
            if (first.Count==0&&second.Count==0)
            {
                Console.WriteLine("No messages");
            }
            int n = Math.Max(first.Count, second.Count);
            for (int i = 0; i < n; i++)
            {
                if (i<second.Count)
                {
                    Console.WriteLine($"{twoUsers[0]}: {second[i].Content}");
                }
                if (i<first.Count)
                {
                    Console.WriteLine($"{first[i].Content} :{twoUsers[1]}");
                }
            }
        }

        private static bool ChekName(string v, List<User> userList)
        {
            bool result = false;
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i].Name==v)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private static Message CrateMessage(string v1, string v2)
        {
            Message result = new Message
            {
                Sender=v1,
                Content=v2
            };
            return result;
        }

        private static User CreatUser(string v)
        {
            User result=new User
                {
                Name = v,
                listMessages=new List<Message>()
                };
            return result;
        }

        class User
        {
            public string Name { get; set; }
            public List<Message> listMessages{ get; set; }
        }
        class Message
        {
            public string Content { get; set; }
            public string Sender { get; set; }
        }
    }
}

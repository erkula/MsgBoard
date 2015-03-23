using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMsgBAtea
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MsgContext())
            {
                Console.WriteLine("Skriv ett meddelande:");
                string insMsg = Console.ReadLine().ToString();

                //Lägger till och sparar i localDB.
                context.Messages.Add(new Message
                {
                    MsgTxt = insMsg,
                    DatePosted = DateTime.Now
                });
                context.SaveChanges();

                Console.WriteLine("Meddelande sparat\n'"+insMsg.ToString()+"'");
                Console.Read();
            }
        }
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string MsgTxt { get; set; }
        public DateTime DatePosted { get; set; }
    }

    public class MsgContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }
}

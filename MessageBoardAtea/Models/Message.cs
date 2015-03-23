// Erik Toresson, 2015-03-23
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageBoardAtea.Models
{
    /// <summary>
    /// Modell för meddelanden. Genererar automatiskt DateTime när modellen skickas från Controller till View under Create.
    /// e.g. return View(new Message());
    /// </summary>
    public class Message
    {
        private DateTime? datePosted = null;

        public int MessageId { get; set; }
        [DisplayName("Meddelande")]
        public string MsgTxt { get; set; }
        [DisplayName("Datum")]
        public DateTime DatePosted {
            get { return datePosted ?? DateTime.Now; }
            set { datePosted = value; }
        }
    }

    public class MsgContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }
    }


}
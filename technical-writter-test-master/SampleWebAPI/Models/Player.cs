using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebAPI.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public int Score { get; set; }
    }
}

using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TibiaMobileDemo.Models
{
    public class ChatChannel
    {
        public DateTime date { set; get; }
        public string name { set; get; }
        public string message { set; get; }
        public Color color { set; get; }
    }
}

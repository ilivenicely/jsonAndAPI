using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TreeListApp.Models.Enums;

namespace TreeListApp.Models
{
    public class ComboItem
    {
        public string Text { get; set; }
        public DirectionEnum Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}

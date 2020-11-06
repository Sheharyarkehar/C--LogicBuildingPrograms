using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checking
{
    public class Node
    { 
        public string Name { get; private set; }
        public string Id{ get; private set; }
        //public string Column2 { get; private set; }
        //public string Column3 { get; private set; }
        public List<Node> Children { get; private set; }
        public Node(string name, string id)
        {
            this.Name = name;
            this.Id = id;
            //this.Column2 = col2;
            //this.Column3 = col3;
            this.Children = new List<Node>();
        }
    }
}

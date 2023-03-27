using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Player
{
    protected string name;
    protected string number;
    protected string pos;
    public string pname
    {
        get { return name; }
        set { name = value; }
    }
    public string pnum
    {
        get { return number; }
        set { number = value; }
    }
    public string position
    {
        get { return pos; }
        set { pos = value; }
    }
}


class Test {
    public int X {set;get;}
    public int Y {set;get;}
}

var x = new Test();
x.X == 100;
var y = 200;
var z = x + y;

namespace ConsoleApp1.Encapsulation
{
    class Bag
    {
        private string name;
        private string color;
        pen pn;
        Nib nb;
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public string Color
        {
            get { return color; }
            set { color = value; }

        }
        public pen Pn
        {
            get { return pn; }
            set { pn = value; }
        }
        public Nib Nb
        {
            get { return nb; }
            set { nb = value; }
        }


    }
}


class pen
{
    private int length;
    private string color;
    private int price;


    public int Length
    {
        get { return length; }
        set { length = value; }
    }
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    public int Price
    {
        get { return price; }
        set { price = value; }
    }
}


class Nib
{
    private string type;


    public string Type
    {
        get { return type; }
        set { type = value; }
    }
}




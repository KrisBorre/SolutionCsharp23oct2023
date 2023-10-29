namespace ConsoleEnum24oct2023
{
    internal class Person
    {
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Head> heads = new List<Head>();
        private Leg[] legs;
        private Dictionary<string, Hand> hands = new Dictionary<string, Hand>();

        protected Leg[] Legs
        {
            get
            {
                return legs;
            }
        }

        public Person(string name, int age, int numberOfLegs = 2)
        {
            this.name = name;
            this.age = age;
            AddHead();
            legs = new Leg[numberOfLegs];
            for (int i = 0; i < legs.Length; i++)
            {
                legs[i] = new Leg();
                legs[i].HasKnees = true;
                legs[i].Muscle = Muscularity.Very;
            }

            if (legs.Length > 0)
            {
                legs[0].LeftOfRight = Leg.LeftOrRight.Right;
                if (legs.Length > 1)
                {
                    for (int i = 1; i < legs.Length; i++)
                    {
                        legs[i].LeftOfRight = Leg.LeftOrRight.Left;
                    }
                }
            }
            Hand left = new Hand();
            left.IsHoldingWeapon = false;
            left.NumberOfFingers = 10;
            Hand right = new Hand();
            right.IsHoldingWeapon = true;
            right.NumberOfFingers = 10;
            hands.Add("left", left);
            hands.Add("right", right);
        }

        public void AddHead()
        {
            Head head = new Head();
            head.HasHair = true;
            head.Size = 10.0;
            heads.Add(head);
        }

        public int GetNumberOfHeads()
        {
            return heads.Count;
        }

        public int GetNumberOfLegs()
        {
            return legs.Length;
        }

        public virtual void Dance(Dancer.Style style = Dancer.Style.Urban) // optionele parameter
        {
            for (int i = 0; i < legs.Length; i++)
            {
                if (legs[i].HasKnees && legs[i].Muscle != Muscularity.Fat)
                {
                    Console.WriteLine(legs[i].LeftOfRight);
                }
            }
        }

        protected Hand GetLeftHand()
        {
            return hands["left"];
        }

        protected Hand GetRightHand()
        {
            return hands["right"];
        }

        public void Run()
        {
            if (Legs.Length > 0)
            {
                foreach (Leg leg in Legs)
                {
                    if (leg.Muscle == Muscularity.Very)
                    {
                        leg.Running();
                    }
                }
            }

        }
    }
}


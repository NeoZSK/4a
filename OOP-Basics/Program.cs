namespace OOP_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chicken c = new Chicken();
            c.Name = "Czarek";
            c.Weight = new Weight(14, "kg");
            c.Jump();
            c.SetAge(-100);
   
        }
    }

    public class Chicken
    {
        public string Name;
        private int Age;
        public Weight Weight;


        public void SetAge(int age)
        {
            if (age > 0 && age < 100)
            {
                Age = age;
            }
            else
            {
                throw new Exception("Age must be between 0 and 100");
            }

        }
        public void Jump()
        {
            Console.WriteLine($"{Name} jumps");
        }
    }

    public class Weight
    {
        public int Value;
        public string Type;

        public Weight(int value, string type)
        {
            Value = value;
            Type = type;
        }
    }

}

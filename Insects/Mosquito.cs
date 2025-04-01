namespace Zoo.Insects
{
    public class Mosquito : Insect
    {
        public bool IsMalariaCarrier { get; private set; }

        public Mosquito(string name, int age, int weight, bool canFly, bool isMalariaCarrier)
            : base(name, age, weight, canFly)
        {
            IsMalariaCarrier = isMalariaCarrier;
            Status = new HealthStatus(false, "Monitor for disease");
        }

        public override void MakeSound()
        {
            Console.WriteLine("ZzzzzZZZzz...");
        }
    }
}

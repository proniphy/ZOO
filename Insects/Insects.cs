namespace Zoo.Insects
{
    /// <summary>
    /// Base class for all insects
    /// </summary>
    public class Insect : Animal
    {
        private bool canFly;

        public bool CanFly
        {
            get { return canFly; }
            set { canFly = value; }
        }

        /// <summary>
        /// Static counter for all insects
        /// </summary>
        public static int TotalInsects { get; private set; } = 0;

        /// <summary>
        /// Inner class for health status
        /// </summary>
        public class HealthStatus
        {
            public bool IsVaccinated { get; set; }
            public string Notes { get; set; }

            public HealthStatus(bool isVaccinated, string notes)
            {
                IsVaccinated = isVaccinated;
                Notes = notes;
            }
        }

        public HealthStatus Status { get; set; }

        public Insect(string name, int age, int weight, bool canFly)
            : base(name, age, weight)
        {
            this.CanFly = canFly;
            Status = new HealthStatus(false, "No info");
            TotalInsects++;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic insect sound.");
        }

        public static void PrintInsectCount()
        {
            Console.WriteLine($"Total insects: {TotalInsects}");
        }
    }
}

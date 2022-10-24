namespace MoonLander
{
    public class Lander
    {
        public double Height { get; set; }
        public double Velocity { get; set; }
        public double Acceleration { get; set; }
        public double Thrust { get; set; }

        public Lander(double accelerationDueToGravity, double initialHeight)
        {
            Velocity = 0;
            Height = initialHeight;
            Acceleration = -accelerationDueToGravity; // gravity is downwards
            Thrust = 0.875; // Thrust is upwards
        }

        public void Burn(double time)
        {
            Calculate(Thrust, time);
        }

        public void Coast(double time)
        {
            Calculate(Acceleration, time);
        }

        private void Calculate(double acceleration, double duration)
        {
            Height += (acceleration * duration * duration) / 2 + Velocity * duration;
            Velocity += acceleration * duration;
        }
    }
}
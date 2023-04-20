namespace SolarSystem
{
    /// <summary>
    /// Represents detailed information about a planet and it's characteristics.
    /// </summary>
    public class Planet
    {
        /// <summary>
        /// The name of the planet.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description of the planet.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The point in the elliptical orbit of a planet, comet, etc., where it is farthest from the Sun.
        /// </summary>
        public int Aphelion { get; set; }

        /// <summary>
        /// The point in the elliptical orbit of a comet, planet, etc., where it is nearest to the Sun.
        /// </summary>
        public int Perihelion { get; set; }

        /// <summary>
        /// The amount by which its orbit around another body deviates from a perfect circle.
        /// </summary>
        public double Eccentricity { get; set; }

        /// <summary>
        /// The amount of time the planet takes to complete one orbit around the Sun.
        /// </summary>
        public double OrbitalPeroid { get; set; }

        /// <summary>
        /// The speed at which the planet orbits around the Sun.
        /// </summary>
        public double AverageOrbitalSpeed { get; set; }

        /// <summary>
        /// The number of natural satelleties orbiting the planet.
        /// </summary>
        public int Satellites { get; set; }

    }
}
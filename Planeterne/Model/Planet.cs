using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planeterne.Model
{
    public class Planet
    {
        private float _mass;
        private float _diameter;
        private short _density;
        private float _gravity;
        private float _rotationPeriod;
        private float _lenghtDay;
        private float _distanceFromSun;
        private float _orbitalPeriod;
        private float _orbitalVelocity;
        private short _meanTemperature;
        private byte _moons;
        private bool _ringSystem;
        public Planet(float mass, int diameter, short density, float gravity, float rotationPeriod, float lengthOfDay, float distanceFromSun, float orbitalPeriod, float orbitalVelocity, short meanTemperature, byte numberOfMoons, bool ringSystem)
        {
            _mass = mass * 1024;
            _diameter = diameter;
            _density = density;
            _gravity = gravity;
            _rotationPeriod = rotationPeriod;
            _lenghtDay = lengthOfDay;
            _distanceFromSun = distanceFromSun * 106;
            _orbitalPeriod = orbitalPeriod;
            _orbitalVelocity = orbitalVelocity;
            _meanTemperature = meanTemperature;
            _moons = numberOfMoons;
            _ringSystem = ringSystem;
        }
        public override string ToString()
        {
            string planets = "Mass: " + _mass + " (1024kg)\n" +
                "Diameter: " + _diameter + " (km)\n" +
                "Density: " + _density + " (kg/m3)\n" +
                "Gravity: " + _gravity + " (m/s2)\n" +
                "Rotation period: " + _rotationPeriod + " (hours)\n" +
                "Length of day: " + _lenghtDay + " (hours)\n" +
                "Distance from sun: " + _distanceFromSun + " (km)\n" +
                "Orbital period: " + _orbitalPeriod + " (days)\n" +
                "Orbital velocity: " + _orbitalVelocity + " (km/s)\n" +
                "Mean temperature: " + _meanTemperature + " (C)\n" +
                "Number of moons: " + _moons + "\n" +
                "Ring Sytem? " + _ringSystem + "\n";
            return planets;
        }

        public float Mass 
        { 
            get { return _mass; } 
            set {  _mass = value; } 
        }
        public float Diameter
        {
            get { return _diameter; }
            set { _diameter = value; }
        }
        public float Density
        {
            get { return _mass; }
            set { _mass = value; }
        }
        public float Gravity
        {
            get { return _gravity; }
            set { _gravity = value; }
        }
        public float RotationPeriod
        {
            get { return _rotationPeriod; }
            set { _rotationPeriod = value; }
        }
        public float LengthOfDay
        {
            get { return _lenghtDay; }
            set { _lenghtDay = value; }
        }
        public float DistanceFromSun
        {
            get { return _distanceFromSun; }
            set { _distanceFromSun = value; }
        }
        public float OrbitalPeriod
        {
            get { return _orbitalPeriod; }
            set { _orbitalPeriod = value; }
        }
        public float OrbitalVelocity
        {
            get { return _orbitalVelocity; }
            set { _orbitalVelocity = value; }
        }
        public short MeanTemperature
        {
            get { return _meanTemperature; }
            set { _meanTemperature = value; }
        }
        public byte NumberOfMoons
        {
            get { return _moons; }
            set { _moons = value; }
        }
        public bool RingSytem
        {
            get { return _ringSystem; }
            set { _ringSystem = value; }
        }

    }
}

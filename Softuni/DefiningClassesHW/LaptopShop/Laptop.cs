using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    public class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string graphicsCard;
        private Battery battery;
        private float batteryHours;
        private float screenSize;
        private decimal price;

        public Laptop(string model, string manufacturer)
            : this("unknown", "unknown", "unknown", "unknown", new Battery("unknown"))
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public Laptop(string model, string manufacturer, decimal price)
            : this(model, manufacturer)
        {
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, string graphicsCard, Battery battery, float batteryHours = 0, float screenSize = 0, decimal price = 0)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery;
            this.BatteryHours = batteryHours;
            this.ScreenSize = screenSize;
            this.Price = price;

        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (null == value || value.Length < 1) throw new ArgumentNullException("Model can not be null or empty!");
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (null == value || value.Length < 1) throw new ArgumentNullException("Manufacturer can not be null or empty!");
                this.manufacturer = value;

            }
        }
        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (null == value || value.Length < 1) throw new ArgumentNullException("Processor can not be null or empty!");
                this.processor = value;
            }
        }

        public string GraphicsCard
        {
            get { return this.graphicsCard; }
            set
            {
                if (null == value || value.Length < 1) throw new ArgumentNullException("Graphics Card can not be empty!");
                this.graphicsCard = value;
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set
            {
                if (null == value) throw new ArgumentNullException("Battery can not be empty!");

                this.battery = value;
            }
        }

        public float BatteryHours
        {
            get { return this.batteryHours; }
            set
            {
                if (value < 0) throw new ArgumentException("Battery hours can not be negative!");
                this.batteryHours = value;
            }
        }

        public float ScreenSize
        {
            get { return this.screenSize; }
            set
            {
                if (value < 0) throw new ArgumentException("Screen size can not be negative!");
                this.screenSize = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) throw new ArgumentException("Price can not be negative!");
                this.price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Manufacturer: {0}\nModel: {1}\nProcessor: {2}\nGraphics Card: {3}\nBattery: {4}\nBattery hours: {5}\n"+
                "Screen size: {6}\nPrice: {7:0.00}",
                this.Manufacturer, this.Model, this.Processor, this.GraphicsCard, this.Battery, this.BatteryHours, this.ScreenSize, this.Price);
        }
    }
}

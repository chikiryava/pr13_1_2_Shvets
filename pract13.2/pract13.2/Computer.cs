﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract13._2
{
    class Computer
    {
        private string processor;
        private string motherboard;
        private string RAM;
        private string video_card;
        private string power_unit;
        public Computer(string processor,string motherboard,string RAM,string video_card, string power_unit)
        {
            this.processor = processor;
            this.motherboard = motherboard;
            this.RAM = RAM;
            this.video_card = video_card;
            this.power_unit = power_unit;
        }
        public string GetProcessor { get { return processor; } set { processor = value; } }
        public string GetMotherboard { get { return motherboard; } set { motherboard = value; } }
        public string GetRAM { get { return RAM; } set { RAM = value; } }
        public string GetVideoCard { get { return video_card; } set { video_card = value; } }
        public string GetPowerUnit { get { return power_unit; } set { power_unit = value; } }
    }
}

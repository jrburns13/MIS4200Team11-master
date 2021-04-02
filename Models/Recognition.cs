using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Team11.Models
{
    public class Recognition
    {
        public int ID { get; set; }

        public CoreValue award { get; set; }

        public string recognizor { get; set; }

        public string recognized { get; set; }

        public DateTime recognizationDate { get; set; }
        public enum CoreValue
        {
            Excellence = 1,
            Integrity = 2,
            Stewardship = 3,
            Innovate = 4,
            Balance = 5,
            Culture = 6,
            Passion = 7
        }

    }
}
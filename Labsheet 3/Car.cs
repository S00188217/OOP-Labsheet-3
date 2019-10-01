using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet_3
{

    public class Car
        {
            private string make;

            public string Make
            {
                get { return this.make; }
                set { this.make = value; }
            }

            private string _model;

            public string Model
            {
                get { return _model; }
                set { _model = value; }
            }

            private int currentSpeed;

            public int CurrentSpeed
            {
                get { return currentSpeed; }
                set { currentSpeed = value; }
            }

            private double engineSize;

            public double EngineSize
            {
                get { return EngineSize; }
                set { engineSize = value; }
            }
        }
}

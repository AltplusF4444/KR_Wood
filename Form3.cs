using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KR
{
    public partial class Form3 : Form
    {
        private int CountWood, CountConveers;
        public const int SpeedConveer = 375;
        Random random = new Random();
        public int Percentage_of_Marriage;

        public Form3()
        {
            Percentage_of_Marriage = random.Next(1, 11);
            CountWood = random.Next(3000, 50001);
            CountConveers = random.Next(5, 11);
            InitializeComponent();
        }

        public Form3(int CountWood, int CountConveers)
        {
            this.CountWood = CountWood;
            this.CountConveers = CountConveers;
        }

        class Conveer
        {
            virtual public double[] Treatment(int a) { return new double[1]; }
        }

        class WoodConveer : Conveer
        {
            public override double[] Treatment(int Wood)
            {
                int time = 0;
                double Boards = 0;
                while (Wood > 0 || time < 8)
                {
                    for (int i = 0; i < SpeedConveer || Wood == 0; i++)
                    {
                        Wood -= 1;
                        Boards += 0.8;
                    }
                    
                    time += 1;
                }
                double[] ResultWoodConveer = new double[2] { Wood, Boards };
                return ResultWoodConveer;
            }
        }

        class ParquetConveer : Conveer
        {
            public override double[] Treatment(int Boards)
            {
                

                double Parquet = 0;

                double[] ResultWoodConveer = new double[2] { Boards, Parquet };
                return ResultWoodConveer;
            }
        }
    }
}

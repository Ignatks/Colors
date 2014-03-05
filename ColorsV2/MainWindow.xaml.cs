using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ColorsV2
{
    public class RGB
    {
        public byte Red = 0;
        public byte Green = 0;
        public byte Blue = 0;
        public bool Check()
        {
            return true;
        }
    }
    public class CMYK
    {
        public double Cyan = 0.0;
        public double Magenta = 0.0;
        public double Yellow = 0.0;
        public double Black = 1.0;
        public bool Check()
        {
            return Cyan <= 1 && Cyan >= 0 && Magenta <= 1 && Magenta >= 0 && Yellow <= 1 && Yellow >= 0 && Black <= 1 && Black >= 0;
        }
    }
    public class XYZ
    {
        public double X = 0.0;
        public double Y = 0.0;
        public double Z = 0.0;
        public bool Check()
        {
            return X <= 1 && X >= 0 && Y <= 1 && Y >= 0 && Z <= 1 && Z >= 0;
        }
    }
    public class HLS
    {
        int Hue = 0;
        double Saturation = 0;
        double Lightness = 0;
        public bool Check()
        {
            return Hue >= 0 && Hue <= 360 && Saturation >= 0 && Saturation <= 1 && Lightness >= 0 && Lightness <= 1;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}

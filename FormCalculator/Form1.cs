
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCalculator
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            
        }

        private void lblDisplayTotal_Click(object sender, EventArgs e)
        {

        }
    }

    namespace CalculatorApplication
    {
        
        public delegate T Formula<T>(T arg1, T arg2);

        public class CalculatorClass
        {
     
            public Formula<double> CalculationMethod;
            public event Formula<double> CalculateEvent;

          
            public double GetSum(double num1, double num2)
            {
                return num1 + num2;
            }

           
            public double GetDifference(double num1, double num2)
            {
                return num1 - num2;
            }

         
            public double GetProduct(double num1, double num2)
            {
                return num1 * num2;
            }

            public double GetQuotient(double num1, double num2)
            {
                return num2 != 0 ? num1 / num2 : 0; 
            }

           
            public void AddDelegate()
            {
                Console.WriteLine("Added the Delegate");
            }

            public void RemoveDelegate()
            {
                Console.WriteLine("Removed the Delegate");
            }
        }
    }
    }


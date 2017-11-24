using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyInterface
{
    public partial class FrmTestInterface : Form
    {
        public FrmTestInterface()
        {
            InitializeComponent();
        }

        private void FrmTestInterface_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsDog d = new ClsDog();
            d.MakeNoise();
            IToy I  ;
            I = d;
            I.MakeNoise();//介面指向實作的實體
            ClsCat c = new ClsCat();
            c.MakeNoise();
           
            I = c;
            I.MakeNoise();//介面指向實作的實體
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<IToy> toys = new List<IToy>();
            toys.Add(new ClsCat());
            toys.Add(new ClsDog());//itoy位置放入介面實作類性物件

            foreach(IToy i in toys)
            {
                i.MakeNoise();
            }
        }
        interface I1
        {
            void test1();
        }
        interface I2
        {
            void test2();
        }
        class class1 : I1, I2, IDisposable
        {
            public void Dispose()
            {
               
            }

            public void test1()
            {
               
            }

            public void test2()
            {
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            class1 x = new class1();
            x.test1();
            x.test2();
            ///..............
            //x.Dispose();
            using (class1 y =new class1())
            {
                //因為class1有實作IDisposable 所以才能使用using語法糖
            }//auto y.dispose()
        }
    }

}

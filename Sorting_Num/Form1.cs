using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Num
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] Nums = new double[5];  //ตั้ง array ที่มีการจำกัดจำนวนข้อมมูลมา 1 ตัว
            Nums[0] = 0;                    //โดยใช้ตัวแปร Nums เก็บข้อมูลตั้งแต่ Indexที่ 0 ถึง 4
            Nums[1] = 0;
            Nums[2] = 0;
            Nums[3] = 0;
            Nums[4] = 0;
            if (textBox1.Text == "")       //ตั้งเงื่อนไขถ้า Textbox ว่าง จะโชว์ข้อความที่กำหนดไว้
            {
                MessageBox.Show(" Please check your Numbers ");
            }
             if (textBox2.Text == "")     //ตั้งเงื่อนไขถ้า Textbox ว่าง จะโชว์ข้อความที่กำหนดไว้
            {
                MessageBox.Show(" Please check your Numbers ");
            }
             if (textBox3.Text == "")     //ตั้งเงื่อนไขถ้า Textbox ว่าง จะโชว์ข้อความที่กำหนดไว้
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox4.Text == "")     //ตั้งเงื่อนไขถ้า Textbox ว่าง จะโชว์ข้อความที่กำหนดไว้
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox5.Text == "")    //ตั้งเงื่อนไขถ้า Textbox ว่าง จะโชว์ข้อความที่กำหนดไว้
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            else                       //ถ้า textbox ไม่ว่าง จะทำตามเงื่อนไขนี้
            {
                Nums[0] = double.Parse(textBox1.Text);
                Nums[1] = double.Parse(textBox2.Text);
                Nums[2] = double.Parse(textBox3.Text);
                Nums[3] = double.Parse(textBox4.Text);
                Nums[4] = double.Parse(textBox5.Text);
            }
            Array.Sort(Nums); //ทำการเรียงข้อมูลใน Array
            textBox1.Text = Convert.ToString(Nums[0]);
            textBox2.Text = Convert.ToString(Nums[1]);
            textBox3.Text = Convert.ToString(Nums[2]);
            textBox4.Text = Convert.ToString(Nums[3]);
            textBox5.Text = Convert.ToString(Nums[4]);
        }

        private void button2_Click(object sender, EventArgs e)
            //ปุ่มนี้จะเป็นการนำปุ่มแรกนั้น มาReverse หรือกลับค่าข้อมูล
            //โดยเงื่อนไขการทำงานจะคล้ายปุ่มแรกและปุ่มที่สาม
        {
            double[] Nums = new double[5]; 
            Nums[0] = 0;
            Nums[1] = 0;
            Nums[2] = 0;
            Nums[3] = 0;
            Nums[4] = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            else
            {
                Nums[0] = double.Parse(textBox1.Text);
                Nums[1] = double.Parse(textBox2.Text);
                Nums[2] = double.Parse(textBox3.Text);
                Nums[3] = double.Parse(textBox4.Text);
                Nums[4] = double.Parse(textBox5.Text);
            }
            Array.Sort(Nums);
            Array.Reverse(Nums);
            textBox1.Text = Convert.ToString(Nums[0]);
            textBox2.Text = Convert.ToString(Nums[1]);
            textBox3.Text = Convert.ToString(Nums[2]);
            textBox4.Text = Convert.ToString(Nums[3]);
            textBox5.Text = Convert.ToString(Nums[4]);
        }

        private void button3_Click(object sender, EventArgs e)
        //โดยเงื่อนไขการทำงานจะคล้ายปุ่มแรกและปุ่มที่สอง
        //แต่เพิ่มความสามารถในการค้นหามา
        {
            double[] Nums = new double[5];
            Nums[0] = 0;
            Nums[1] = 0;
            Nums[2] = 0;
            Nums[3] = 0;
            Nums[4] = 0;
            if (textBox1.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox2.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox3.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox4.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            if (textBox5.Text == "")
            {
                MessageBox.Show(" Please check your Numbers ");
            }
            else
            {
                Nums[0] = double.Parse(textBox1.Text);
                Nums[1] = double.Parse(textBox2.Text);
                Nums[2] = double.Parse(textBox3.Text);
                Nums[3] = double.Parse(textBox4.Text);
                Nums[4] = double.Parse(textBox5.Text);
            }
            Array.Sort(Nums);
            textBox1.Text = Convert.ToString(Nums[0]);
            textBox2.Text = Convert.ToString(Nums[1]);
            textBox3.Text = Convert.ToString(Nums[2]);
            textBox4.Text = Convert.ToString(Nums[3]);
            textBox5.Text = Convert.ToString(Nums[4]);
            if (textBox6.Text == ""){                    //ตั้งเงื่อนไขเช็คtextbox6  ถ้าว่างให้แสดงข้อความแจ้งเตือนผู้ใช้
            MessageBox.Show(" Please input the data that you ned to find!! "); }
            if (textBox6.Text == textBox1.Text){       //ตั้งเงื่อนไขเช็คtextbox6  ถ้าตรงกับtextboxใด ก็จะเเสดงผลการค้นหา
            textBox7.Text = " At Index: 0 Collum: 1"; }
            else if (textBox6.Text == textBox2.Text) {
            textBox7.Text = " At Index: 1 Collum: 2"; }
            else if (textBox6.Text == textBox3.Text) {
            textBox7.Text = " At Index: 2 Collum: 3"; }
            else if (textBox6.Text == textBox4.Text) {
            textBox7.Text = " At Index: 3 Collum: 4"; }
            else if (textBox6.Text == textBox5.Text) {
            textBox7.Text = " At Index: 4 Collum: 5"; }
            else {                                        //ถ้าไม่เจอจะเเสดงข้อความแจ้งเตือน
            MessageBox.Show(" err 404 Not Found!! "); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();      //ใช้ปิดหน้าต่าง
        }

        private void button5_Click(object sender, EventArgs e)
        {
            About f2 = new About(); //แสดงหน้าต่างที่สองหลังจากกดปุ่ม
            f2.Show();
        }
      }
    }


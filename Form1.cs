using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "주차관리";
            dataGridView1.DataSource = DataManager.Cars;

        }
        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Car car = dataGridView1.CurrentRow.DataBoundItem as Car;
                textBox_pnum.Text = car.ParkingSpot.ToString();
                textBox_carnum.Text = car.CarNumber.ToString();
                textBox_ph.Text = car.DriverName.ToString();
                textBox_name.Text = car.PhoneNumber.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void button_pc_Click(object sender, EventArgs e)
        {
            if(textBox_pnum.Text.Trim() == "")
            {
                MessageBox.Show("공간번호를 입력해주세요.");
            }
            else if (textBox_carnum.Text.Trim() == "")
            {
                MessageBox.Show("차량번호를 입력해주세요.");
            }
            else if (textBox_ph.Text.Trim() == "")
            {
                MessageBox.Show("차주이름를 입력해주세요.");
            }
            else if (textBox_name.Text.Trim() == "")
            {
                MessageBox.Show("전화번호를 입력해주세요.");
            }
            else
            {
                try
                {
                    Car car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_pnum.Text);
                    if (car.CarNumber != "")
                    {
                        MessageBox.Show("해당 공간에는 이미 차가 존재합니다.");
                    }
                    else
                    {
                        car.CarNumber = textBox_carnum.Text;
                        car.DriverName = textBox_ph.Text;
                        car.PhoneNumber = textBox_name.Text;
                        car.ParkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();

                        string contents = $"{car.CarNumber} 이/가 주차되었습니다. ";

                        Log.PrintLog(@"E:\C#\CarM\WindowsFormsApp1", "parkingt.txt", contents);

                        listBox1.Items.Insert(0, contents);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 공간입니다.");
                }
            }
        }

        private void button_ec_Click(object sender, EventArgs e)
        {
            if (textBox_pnum.Text.Trim() == "")
            {
                MessageBox.Show("공간번호를 입력해주세요.");
            }
            else
            {
                try
                {
                    Car car = DataManager.Cars.Single((x) => x.ParkingSpot.ToString() == textBox_pnum.Text);
                    if (car.CarNumber != "")
                    {
                        car.CarNumber = textBox_carnum.Text;
                        car.DriverName = string.Empty;
                        car.PhoneNumber = String.Empty;
                        car.ParkingTime = DateTime.Now;

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Cars;
                        DataManager.Save();

                        MessageBox.Show("\"" + car.CarNumber + "\"이/가 출차되었습니다.");

                        string contents = $"{car.CarNumber} 이/가 출차되었습니다. ";

                        Log.PrintLog(@"E:\C#\CarM\WindowsFormsApp1", "parkingt.txt", contents);

                        listBox1.Items.Insert(0, contents);
                    }
                    else
                    {
                        MessageBox.Show("이미 주차된 차가 없습니다.");
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("존재하지 않는 공간입니다.");
                }
            }
        }

        public static void PrintLog(string directoryname, string filename, string contents)
        {
            DirectoryInfo di = new DirectoryInfo(directoryname);
            if (!di.Exists)
            {
                di.Create();
            }
            using (StreamWriter writer = new StreamWriter(directoryname + "\\" + filename, true))
            {
                writer.WriteLine("[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss" + "]" + contents));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분 ss초");
        }

    }
}

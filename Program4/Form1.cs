using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program4
{
    public partial class Form1 : Form
    {
        double average;
        string Filepath, lowtempstr, hightemstr, averagetempstr, highlblstr, lowlblstr, avglblstr;
        int highest, lowest, sum, one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty, twentyone, twentytwo, twentythree, twentyfour, twentyfive, twentysix, twentyseven, twentyeight, twentynine, thirty, thirtyone;
        string day1str = "1";
        string day2str = "2";
        string day3str = "3";
        string day4str = "4";
        string day5str = "5";
        string day6str = "6";
        string day7str = "7";
        string day8str = "8";
        string day9str = "9";
        string day10str = "10";
        string day11str = "11";
        string day12str = "12";
        string day13str = "13";
        string day14str = "14";
        string day15str = "15";
        string day16str = "16";
        string day17str = "17";
        string day18str = "18";
        string day19str = "19";
        string day20str = "20";
        string day21str = "21";
        string day22str = "22";
        string day23str = "23";
        string day24str = "24";
        string day25str = "25";
        string day26str = "26";
        string day27str = "27";
        string day28str = "28";
        string day29str = "29";
        string day30str = "30";
        string day31str = "31";



        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog TempFile = new OpenFileDialog();
            TempFile.Title = "Open Text File";
            TempFile.Filter = "TXT files|*.txt";
            TempFile.InitialDirectory = @"C:\";
            if (TempFile.ShowDialog() == DialogResult.OK)
            {
                Filepath = TempFile.FileName;
                label1.Text = Filepath;
            }
        }
                

        private void button2_Click(object sender, EventArgs e)
        {
            Stream TempStream = null;
            using (TempStream)
            {
                string monthname = File.ReadAllLines(Filepath).Skip(0).Take(1).First();
                string day1 = File.ReadAllLines(Filepath).Skip(1).Take(1).First();
                string day2 = File.ReadAllLines(Filepath).Skip(2).Take(1).First();
                string day3 = File.ReadAllLines(Filepath).Skip(3).Take(1).First();
                string day4 = File.ReadAllLines(Filepath).Skip(4).Take(1).First();
                string day5 = File.ReadAllLines(Filepath).Skip(5).Take(1).First();
                string day6 = File.ReadAllLines(Filepath).Skip(6).Take(1).First();
                string day7 = File.ReadAllLines(Filepath).Skip(7).Take(1).First();
                string day8 = File.ReadAllLines(Filepath).Skip(8).Take(1).First();
                string day9 = File.ReadAllLines(Filepath).Skip(9).Take(1).First();
                string day10 = File.ReadAllLines(Filepath).Skip(10).Take(1).First();
                string day11 = File.ReadAllLines(Filepath).Skip(11).Take(1).First();
                string day12 = File.ReadAllLines(Filepath).Skip(12).Take(1).First();
                string day13 = File.ReadAllLines(Filepath).Skip(13).Take(1).First();
                string day14 = File.ReadAllLines(Filepath).Skip(14).Take(1).First();
                string day15 = File.ReadAllLines(Filepath).Skip(15).Take(1).First();
                string day16 = File.ReadAllLines(Filepath).Skip(16).Take(1).First();
                string day17 = File.ReadAllLines(Filepath).Skip(17).Take(1).First();
                string day18 = File.ReadAllLines(Filepath).Skip(18).Take(1).First();
                string day19 = File.ReadAllLines(Filepath).Skip(19).Take(1).First();
                string day20 = File.ReadAllLines(Filepath).Skip(20).Take(1).First();
                string day21 = File.ReadAllLines(Filepath).Skip(21).Take(1).First();
                string day22 = File.ReadAllLines(Filepath).Skip(22).Take(1).First();
                string day23 = File.ReadAllLines(Filepath).Skip(23).Take(1).First();
                string day24 = File.ReadAllLines(Filepath).Skip(24).Take(1).First();
                string day25 = File.ReadAllLines(Filepath).Skip(25).Take(1).First();
                string day26 = File.ReadAllLines(Filepath).Skip(26).Take(1).First();
                string day27 = File.ReadAllLines(Filepath).Skip(27).Take(1).First();
                string day28 = File.ReadAllLines(Filepath).Skip(28).Take(1).First();
                string day29 = File.ReadAllLines(Filepath).Skip(29).Take(1).First();
                string day30 = File.ReadAllLines(Filepath).Skip(30).Take(1).First();
                string day31 = File.ReadAllLines(Filepath).Skip(31).Take(1).First();

                
                //I was trying check if line is null, but could not get this to work. Was throwing errors.
                /*
                string day29, day30, day31;

                if (File.ReadAllLines(Filepath).Skip(29).Take(1).First() != null)
                {
                     day29 = "";
                }
                else {
                     day29 = File.ReadAllLines(Filepath).Skip(29).Take(1).First();
                }

                if (File.ReadAllLines(Filepath).Skip(30).Take(1).First() != null)
                {
                     day30 = "";
                }
                else
                {
                     day30 = File.ReadAllLines(Filepath).Skip(30).Take(1).First();
                }

                if (File.ReadAllLines(Filepath).Skip(31).Take(1).First() != null)
                {
                     day31 = "";
                }
                else
                {
                     day31 = File.ReadAllLines(Filepath).Skip(31).Take(1).First();
                }
                */


                //Parse Temps of days to Ints
                int one = Int32.Parse(day1);
                int two = Int32.Parse(day2);
                int three = Int32.Parse(day3);
                int four = Int32.Parse(day4);
                int five = Int32.Parse(day5);
                int six = Int32.Parse(day6);
                int seven = Int32.Parse(day7);
                int eight = Int32.Parse(day8);
                int nine = Int32.Parse(day9);
                int ten = Int32.Parse(day10);
                int eleven = Int32.Parse(day11);
                int twelve = Int32.Parse(day12);
                int thirteen = Int32.Parse(day13);
                int fourteen = Int32.Parse(day14);
                int fifteen = Int32.Parse(day15);
                int sixteen = Int32.Parse(day16);
                int seventeen = Int32.Parse(day17);
                int eighteen = Int32.Parse(day18);
                int nineteen = Int32.Parse(day19);
                int twenty = Int32.Parse(day20);
                int twentyone = Int32.Parse(day21);
                int twentytwo = Int32.Parse(day22);
                int twentythree = Int32.Parse(day23);
                int twentyfour = Int32.Parse(day24);
                int twentyfive = Int32.Parse(day25);
                int twentysix = Int32.Parse(day26);
                int twentyseven = Int32.Parse(day27);
                int twentyeight = Int32.Parse(day28);
                int twentynine = Int32.Parse(day29);
                int thirty = Int32.Parse(day30);
                int thirtyone = Int32.Parse(day31);

                int[] array = {one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen, twenty, twentyone, twentytwo, twentythree, twentyfour, twentyfive, twentysix, twentyseven, twentyeight, twentynine, thirty, thirtyone};

                lowest = array.Min();
                highest = array.Max();

                //Start of Lowest Nested
                if (lowest == one) {
                    lowtempstr = day1str;
                }

                else if (lowest == two)
                {
                    lowtempstr = day3str;
                }

                else if (lowest == three)
                {
                    lowtempstr = day3str;
                }

                else if (lowest == four)
                {
                    lowtempstr = day4str;
                }

                else if (lowest == five)
                {
                    lowtempstr = day6str;
                }

                else if (lowest == seven)
                {
                    lowtempstr = day7str;
                }

                else if (lowest == eight)
                {
                    lowtempstr = day8str;
                }
                else if (lowest == nine)
                {
                    lowtempstr = day9str;
                }

                else if (lowest == ten)
                {
                    lowtempstr = day11str;
                }

                else if (lowest == eleven)
                {
                    lowtempstr = day11str;
                }

                else if (lowest == twelve)
                {
                    lowtempstr = day12str;
                }

                else if (lowest == thirteen)
                {
                    lowtempstr = day13str;
                }

                else if (lowest == fourteen)
                {
                    lowtempstr = day14str;
                }
                else if (lowest == fifteen)
                {
                    lowtempstr = day15str;
                }
                else if (lowest == sixteen)
                {
                    lowtempstr = day16str;
                }

                else if (lowest == seventeen)
                {
                    lowtempstr = day17str;
                }

                else if (lowest == eighteen)
                {
                    lowtempstr = day18str;
                }

                else if (lowest == nineteen)
                {
                    lowtempstr = day19str;
                }

                else if (lowest == twenty)
                {
                    lowtempstr = day20str;
                }

                else if (lowest == twentyone)
                {
                    lowtempstr = day21str;
                }
                else if (lowest == twentytwo)
                {
                    lowtempstr = day21str;
                }

                else if (lowest == twentythree)
                {
                    lowtempstr = day23str;
                }

                else if (lowest == twentyfour)
                {
                    lowtempstr = day24str;
                }

                else if (lowest == twentyfive)
                {
                    lowtempstr = day25str;
                }

                else if (lowest == twentysix)
                {
                    lowtempstr = day26str;
                }

                else if (lowest == twentyseven)
                {
                    lowtempstr = day27str;
                }
                else if (lowest == twentyeight)
                {
                    lowtempstr = day28str;
                }

                else if (lowest == twentynine)
                {
                    lowtempstr = day29str;
                }

                else if (lowest == thirty)
                {
                    lowtempstr = day30str;
                }

                else if (lowest == thirtyone)
                {
                    lowtempstr = day31str;
                }

                else if (lowest == twenty)
                {
                    lowtempstr = day20str;
                }

                else if (lowest == twentyone)
                {
                    lowtempstr = day21str;
                }
                //End of Lowest Nested
                //Start of Highest Nested
                if (highest == one)
                {
                    hightemstr = day1str;
                }

                else if (highest == two)
                {
                    hightemstr = day3str;
                }

                else if (highest == three)
                {
                    hightemstr = day3str;
                }

                else if (highest == four)
                {
                    hightemstr = day4str;
                }

                else if (highest == five)
                {
                    hightemstr = day6str;
                }

                else if (highest == seven)
                {
                    hightemstr = day7str;
                }

                else if (highest == eight)
                {
                    hightemstr = day8str;
                }
                else if (highest == nine)
                {
                    hightemstr = day9str;
                }

                else if (highest == ten)
                {
                    hightemstr = day11str;
                }

                else if (highest == eleven)
                {
                    hightemstr = day11str;
                }

                else if (highest == twelve)
                {
                    hightemstr = day12str;
                }

                else if (highest == thirteen)
                {
                    hightemstr = day13str;
                }

                else if (highest == fourteen)
                {
                    hightemstr = day14str;
                }
                else if (highest == fifteen)
                {
                    hightemstr = day15str;
                }
                else if (highest == sixteen)
                {
                    hightemstr = day16str;
                }

                else if (highest == seventeen)
                {
                    hightemstr = day17str;
                }

                else if (highest == eighteen)
                {
                    hightemstr = day18str;
                }

                else if (highest == nineteen)
                {
                    hightemstr = day19str;
                }

                else if (highest == twenty)
                {
                    hightemstr = day20str;
                }

                else if (highest == twentyone)
                {
                    hightemstr = day21str;
                }
                else if (highest == twentytwo)
                {
                    hightemstr = day21str;
                }

                else if (highest == twentythree)
                {
                    hightemstr = day23str;
                }

                else if (highest == twentyfour)
                {
                    hightemstr = day24str;
                }

                else if (highest == twentyfive)
                {
                    hightemstr = day25str;
                }

                else if (highest == twentysix)
                {
                    hightemstr = day26str;
                }

                else if (highest == twentyseven)
                {
                    hightemstr = day27str;
                }
                else if (highest == twentyeight)
                {
                    hightemstr = day28str;
                }

                else if (highest == twentynine)
                {
                    hightemstr = day29str;
                }

                else if (highest == thirty)
                {
                    hightemstr = day30str;
                }

                else if (highest == thirtyone)
                {
                    hightemstr = day31str;
                }

                else if (highest == twenty)
                {
                    hightemstr = day20str;
                }

                else if (highest == twentyone)
                {
                    hightemstr = day21str;
                }
                //End of Highest Nested

                sum = array.Sum();

                average = sum / 31;

                label3.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                label3.Text = monthname + "'s low temperature was " + lowest + " on day " + lowtempstr;
                label5.Text = monthname + "'s high temperature was " + highest + " on day " + hightemstr;
                label6.Text = "Average temperature was " + average;
            }
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class global
        {
            public static double potok2, potok3, potok4, potok5, potok6, potok7,potok8;
            public static Random R = new Random();
            public static int down, up;
            public static double mass1, mass2;
            public static char m;
            public static string pp2,pp3,pp4,pp5,pp6,pp7,pp8;
            
        }
 

        
        private void Form1_Load(object sender, EventArgs e)
        {
            Weight.Text = "100";
            Height.Text = "100";
            U_limit.Text = "100";
            D_limit.Text = "-100";
            Plus.Checked = true;
            Minus.Checked = false;
            Mult.Checked = false;
            Rex.Checked = false;
            All_cpu.Checked = true;
            size_array.Text = "";
            randomize.Text = "";
            operation.Text = "";
            timer.Text = "";
             
            First.BackColor = Color.White;
            Second.BackColor = Color.White;
            Third.BackColor = Color.White;
            Fourth.BackColor = Color.White;
            Fiveth.BackColor = Color.White;
            Sixth.BackColor = Color.White;
            Sevnth.BackColor = Color.White;
            Eight.BackColor = Color.White;
            
        }


        public void Restart ()
        {
            System.Windows.Forms.MessageBox.Show("введите корректные данные");
            Form1_Load(null, null);
        }

        
     

/////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////

    
        public static void CPUoperations2()
        {
            while (global.pp2 == "now")
            { global.potok2 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations3()
        {
            while (global.pp3 == "now")
            { global.potok3 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations4()
        {
            while (global.pp4 == "now")
            { global.potok4 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations5()
        {
            while (global.pp5 == "now")
            { global.potok5 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations6()
        {
            while (global.pp6 == "now")
            { global.potok2 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations7()
        {
            while (global.pp7 == "now")
            { global.potok7 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUoperations8()
        {
            while (global.pp8 == "now")
            { global.potok8 = global.R.NextDouble() + global.R.Next(global.down, global.up); }
        }
        public static void CPUmult2()
        {
            while (global.pp2 == "now")
            {
                if (global.m == '+') global.potok2 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok2 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok2 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok2 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult3()
        {
            while (global.pp3 == "now")
            {
                if (global.m == '+') global.potok3 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok3 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok3 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok3 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult4()
        {
            while (global.pp4 == "now")
            {
                if (global.m == '+') global.potok4 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok4 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok4 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok4 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult5()
        {
            while (global.pp5 == "now")
            {
                if (global.m == '+') global.potok5 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok5 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok5 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok5 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult6()
        {
            while (global.pp6 == "now")
            {
                if (global.m == '+') global.potok6 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok6 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok6 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok6 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult7()
        {
            while (global.pp7 == "now")
            {
                if (global.m == '+') global.potok7 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok7 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok7 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok7 = global.mass1 / global.mass2;
            }
        }
        public static void CPUmult8()
        {
            while (global.pp8 == "now")
            {
                if (global.m == '+') global.potok8 = global.mass1 + global.mass2;
                if (global.m == '-') global.potok8 = global.mass1 - global.mass2;
                if (global.m == '*') global.potok8 = global.mass1 * global.mass2;
                if (global.m == '/') global.potok8 = global.mass1 / global.mass2;
            }
        }

/////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            First.BackColor = Color.White;
            Second.BackColor = Color.White;
            Third.BackColor = Color.White;
            Fourth.BackColor = Color.White;
            Fiveth.BackColor = Color.White;
            Sixth.BackColor = Color.White;
            Sevnth.BackColor = Color.White;
            Eight.BackColor = Color.White;
              string mode = "not";
            
            string op="+";
              string D_lim="100", U_lim="100";
             string record= "clear";
              UInt64 M=1, N=1;
             double Rand_down=1, Rand_up=1;
          
         
          
        
              
            int[] oper = new int[4];
            try
            {       
                M = Convert.ToUInt64(Weight.Text);
                N = Convert.ToUInt64(Height.Text);
                
                U_lim = Convert.ToString(U_limit.Text);
                D_lim = Convert.ToString(D_limit.Text);
                randomize.Text = "генерация чисел \n" + D_lim + "  x " + U_lim;
///////////////////////////////////////////////////////////////////////////////////
                if (U_lim[0] == '-') { U_lim = U_lim.Substring(1); Rand_up = Convert.ToDouble(U_lim); Rand_up *= (-1); }
                else if (U_lim[0] == '+') { U_lim = U_lim.Substring(1); Rand_up = Convert.ToDouble(U_lim); }
                else { Rand_up = Convert.ToDouble(U_lim); }
///////////////////////////////////////////////////////////////////////////////////          
                if (D_lim[0] == '-') { D_lim = D_lim.Substring(1); Rand_down = Convert.ToDouble(D_lim); Rand_down *= (-1); }
                else if (D_lim[0] == '+') { D_lim = D_lim.Substring(1); Rand_down = Convert.ToDouble(D_lim); }
                else { Rand_down = Convert.ToDouble(D_lim); }
/////////////////////////////////////////////////////////////////////////////////// 
if ( Rand_up<Rand_down) {Double temp = Rand_up; Rand_up = Rand_down; Rand_down = temp;}
if (Rand_down == Rand_up) { record = "messy"; Restart(); }
///////////////////////////////////////////////////////////////////////////////////                
randomize.Text = "генерация чисел \n" + Rand_down + "  x " + Rand_up;
                oper[0] = (Plus.Checked == true ? 1 : 0);
                oper[1] = (Minus.Checked == true ? 1 : 0);
                oper[2] = (Mult.Checked == true ? 1 : 0);
                oper[3] = (Rex.Checked == true ? 1 : 0);
                mode = (All_cpu.Checked == true ? "all" : (cpu1.Checked == true ? "1cpu" : (cpu2.Checked == true ? "2cpu" : (cpu3.Checked == true ? "3cpu" : (cpu4.Checked == true ? "4cpu" : (cpu5.Checked == true ? "5cpu" : (cpu6.Checked ? "6cpu" : (cpu7.Checked == true ? "7cpu" : (cpu8.Checked == true ? "8cpu" : "not")))))))));
                 
            }

///////////////////////////////////////////////////////////////////////////////////
            catch (FormatException)
            {

                record = "messy";
                Restart();
            }
            catch (OverflowException)
            {
                 
                record = "messy";
                Restart();
                
            }
///////////////////////////////////////////////////////////////////////////////////
            if (record == "clear")
            {
                double[,] massiv_1 = new double[M, N];
                double[,] massiv_2 = new double[M, N];
                op = "";              
                if (oper[0] == 1) { op += '+'; }
                if (oper[1] == 1) { op += '-'; }
                if (oper[2] == 1) { op += '*'; }
                if (oper[3] == 1) { op += '/'; }
                oper = null;
                if (Plus.Checked == false && Minus.Checked == false && Mult.Checked == false && Rex.Checked == false)
                { op = "+"; Plus.Checked = true; System.Windows.Forms.MessageBox.Show("по умолчанию установлен режим суммирования"); }

                ///////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////
                size_array.Text = "размер Массива \n" + M + "  x " + N;
                operation.Text = "операции\n " + op;
                ///////////////////////////////////////////////////////////////////////////////////
                ///////////////////////////////////////////////////////////////////////////////////
                UInt64 i, j; 
                Random Rang = new Random();
                DateTime[] mydate = new DateTime[2];
                TimeSpan span;
                DateTime relative;
                int Down =(int)Rand_down;
                int Up = (int)Rand_up;
                

/////////////////////////////////////////////////////////////////
                Thread dual = new Thread(CPUoperations2);
                Thread trial = new Thread(CPUoperations3);
                Thread foal = new Thread(CPUoperations4);
                Thread fifal = new Thread(CPUoperations5);
                Thread sixal = new Thread(CPUoperations6);
                Thread seval = new Thread(CPUoperations7); 
                Thread lst = new Thread(CPUoperations8); 
                dual.Priority = ThreadPriority.Highest;
                trial.Priority = ThreadPriority.Highest;
                foal.Priority = ThreadPriority.Highest;
                fifal.Priority = ThreadPriority.Highest;
                sixal.Priority = ThreadPriority.Highest;
                seval.Priority = ThreadPriority.Highest; 
                lst.Priority = ThreadPriority.Highest;
                
                global.up = Up;
                global.down = Down;
/////////////////////////////////////////////////////////////////
                byte f = 0;
                if (mode == "all") { f = 1; mode = "1cpu"; }
           /* if (f == 2) mode = "2cpu";
            if (f == 3) mode = "3cpu";
            if (f == 4) mode = "4cpu";
            if (f == 5) mode = "5cpu";
            if (f == 6) mode = "6cpu";
            if (f == 7) mode = "7cpu";
            if (f == 8) mode = "8cpu";
            if (f == 9) mode = "not";*/
                switch (mode)
                {    
                    ///////////////////////////////////////////////////////////////////////////////////
                    
                    case "not":
                        break;

                    case "1cpu":
                        mydate[0] = DateTime.Now;

                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {
                                massiv_1[i, j] = Rang.NextDouble()+Rang.Next(Down,Up);
                                massiv_2[i, j] =  Rang.NextDouble()+Rang.Next(Down,Up);
                            }
                        }
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                if (op[Rang.Next(0, op.Length)] == '+') massiv_1[i, j] +=massiv_2[i,j];
                                if (op[Rang.Next(0, op.Length)] == '-')massiv_1[i, j] -=massiv_2[i,j];
                                if (op[Rang.Next(0, op.Length)] == '*') massiv_1[i, j] *=massiv_2[i,j];
                                if (op[Rang.Next(0, op.Length)] == '/')massiv_1[i, j] /=massiv_2[i,j];
                                 
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                         span = mydate[1] - mydate[0];
                        relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1)  f++; 
                       listBox1.Items.Add("1CPU         " + result.Text);
                       First.BackColor = Color.Thistle;
                        break;
///////////////////////////////////////////////////////////////////////////////////

                    case "2cpu":
                        global.pp2 = "now";
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {
                                if(j<N && i<M) massiv_1[i, j] = global.potok2;
                            }
                        }
                        dual = new Thread(CPUmult2);
                        dual.Start();
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                global.mass1 = massiv_1[i, j];
                                global.mass2 = massiv_2[i, j];
                                global.m = op[Rang.Next(0, op.Length)];
                                massiv_1[i, j] = global.potok2;
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                        if (f == 1) {  f++; }
                        listBox1.Items.Add("2CPU         " + result.Text);
                       Second.BackColor = Color.Thistle;
                       global.pp2 = "not";
                        break;


                    ///////////////////////////////////////////////////////////////////////////////////
                    case "3cpu":
                       
                        global.pp2 = "now";
                        global.pp3 = "now";
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {
                                if (j < N && i < M) massiv_1[i, j] = global.potok2;
                                if (j < N && i < M) massiv_2[i, j] = global.potok3;
                                
                            }
                        }
                        dual = new Thread(CPUmult2);
                        trial = new Thread(CPUmult3);
                        dual.Start();
                        trial.Start();
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                global.mass1 = massiv_1[i, j];
                                global.mass2 = massiv_2[i, j];
                                global.m = op[Rang.Next(0, op.Length)];
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) {massiv_1[i, j] = global.potok3; j++; }
                                
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) {  f++; }
                       listBox1.Items.Add("3CPU         " + result.Text);
                       Third.BackColor = Color.Thistle;
                       global.pp2 = "not";
                       global.pp3 = "not";
                      
                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
                    case "4cpu":

                        global.pp2 = "now";
                        global.pp3 = "now";
                        global.pp4 = "now";
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        foal.Start();
                        //////
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {   if (j < N && i < M) {massiv_1[i, j] = global.potok2;j++;}
                                if (j < N && i < M) {massiv_2[i, j] = global.potok3;j++;}
                                if (j < N && i < M) {massiv_1[i, j] = global.potok4;j++;}
                                if (j < N && i < M) {massiv_2[i, j] = global.potok2;j++;}
                                if (j < N && i < M) {massiv_1[i, j] = global.potok3; j++;}
                                if (j < N && i < M) { massiv_2[i, j] = global.potok4;j++;}
                                
                            }
                        }
                        dual = new Thread(CPUmult2);
                        trial = new Thread(CPUmult3);
                        foal = new Thread(CPUmult4);
                        dual.Start();
                        trial.Start();
                        foal.Start();
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                global.mass1 = massiv_1[i, j];
                                global.mass2 = massiv_2[i, j];
                                global.m = op[Rang.Next(0, op.Length)];
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; } 
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) {  f++; }
                       Fourth.BackColor = Color.Thistle;
                       listBox1.Items.Add("4CPU         " + result.Text);
                       global.pp2 = "not";
                       global.pp3 = "not";
                       global.pp4 = "not";

                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
                    case "5cpu":
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        foal.Start(); 
                        fifal.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {

                                if (j < N && i < M) {massiv_1[i, j] = global.potok2;j++;}
                                if (j < N && i < M) { massiv_2[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok5; j++; }
                                
                            }
                        }
                        dual = new Thread(CPUmult2);
                        trial =  new Thread(CPUmult3);
                        foal= new Thread(CPUmult4);
                        fifal = new Thread(CPUmult5);
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                global.mass1 = massiv_1[i, j];
                                global.mass2 = massiv_2[i, j];
                                global.m = op[Rang.Next(0, op.Length)];
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                        relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) {  f++; }
                       listBox1.Items.Add("5CPU         " + result.Text);
                        Fiveth.BackColor = Color.Thistle;
                       global.pp2 = "not";
                       global.pp3 = "not";
                       global.pp4 = "not";
                       global.pp5 = "not";
                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
                    case "6cpu":
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        foal.Start(); 
                        fifal.Start();
                        sixal.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {

                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok6; j++; }
                                
                            }
                        }
                        dual = new Thread(CPUmult2);
                        trial = new Thread(CPUmult2);
                        foal = new Thread(CPUmult2);
                        fifal = new Thread(CPUmult2);
                        sixal = new Thread(CPUmult2); 
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                global.mass1 = massiv_1[i, j];
                                global.mass2 = massiv_2[i, j];
                                global.m = op[Rang.Next(0, op.Length)];
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) {  f++; }
                       listBox1.Items.Add("6CPU         " + result.Text);
                       Sixth.BackColor = Color.Thistle;
                         global.pp2 = "not";
                       global.pp3 = "not";
                       global.pp4 = "not";
                       global.pp5 = "not";
                       global.pp6 = "not";
                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
                    case "7cpu":
                         mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        foal.Start(); 
                        fifal.Start();
                        sixal.Start();
                        seval.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {

                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok7; j++; }
                            }
                        }
                        dual = new Thread(CPUmult2);
                         trial = new Thread(CPUmult3);
                        foal = new Thread(CPUmult4);
                        fifal = new Thread(CPUmult5);
                        sixal = new Thread(CPUmult6);
                        seval = new Thread(CPUmult7);
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok7; j++; }
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) { f++; }
                       listBox1.Items.Add("7CPU         " + result.Text); 
                        Sevnth.BackColor = Color.Thistle;
                        global.pp2 = "not";
                       global.pp3 = "not";
                       global.pp4 = "not";
                       global.pp5 = "not";
                       global.pp6 = "not";
                       global.pp7 = "not";
                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
                    case "8cpu":
                        mydate[0] = DateTime.Now;
                        dual.Start();
                        trial.Start();
                        foal.Start();
                        fifal.Start();
                        sixal.Start();
                        seval.Start();
                        lst.Start();
                        for (i = 0; i < M;i++)
                        {
                            for(j=0;j<N;j++)
                            {

                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok7; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok8; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_2[i, j] = global.potok7; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok8; j++; }
                            }
                        }
                        dual = new Thread(CPUmult2);
                         trial = new Thread(CPUmult3);
                        foal = new Thread(CPUmult4);
                        fifal = new Thread(CPUmult5);
                        sixal = new Thread(CPUmult6);
                        seval = new Thread(CPUmult7);
                        lst = new Thread(CPUmult8);
                        for (i = 0; i < M; i++)
                        {
                            for (j = 0; j < N; j++)
                            {
                                if (j < N && i < M) { massiv_1[i, j] = global.potok2; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok3; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok4; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok5; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok6; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok7; j++; }
                                if (j < N && i < M) { massiv_1[i, j] = global.potok8; j++; }
                            }
                        }
                        mydate[1] = DateTime.Now;
                        timer.Text = mydate[0].TimeOfDay + "\n" + mydate[1].TimeOfDay;
                        span = mydate[1] - mydate[0];
                         relative = new DateTime(span.Ticks);
                       result.Text = relative.TimeOfDay.ToString();
                       if (f == 1) { f++; }
                       listBox1.Items.Add("8CPU         " + result.Text);
                        Eight.BackColor = Color.Thistle;
                       global.pp2 = "not";
                       global.pp3 = "not";
                       global.pp4 = "not";
                       global.pp5 = "not";
                       global.pp6 = "not";
                       global.pp7 = "not";
                       global.pp8 = "not";
                        break;
                    ///////////////////////////////////////////////////////////////////////////////////
 
                    ///////////////////////////////////////////////////////////////////////////////////
                }

            }
        }

       
    }


  //////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////

   
//////////////////////////////////////////////////////////////////////////
//////////////////////////////////////////////////////////////////////////
}
  

 
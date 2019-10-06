using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;                 // DllImport
using System;
using System.IO;
using System.Xml;

namespace TSC_BarcodePrinter
{

    public partial class Form1 : DBForm.DBForm
    {
        private string strConn = "";  // AWS db

        enum engMap         // 년도를 알파벳 코드로 변한하기 위한 열거형
        {
            A, B, C, D, E, F, G, H, I, J
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds;
            check_type.Checked = true;
            nud_numberPage.Value = 1;
            tb_model.Text = "";
            tb_model.Select();
            nud_year.Value = int.Parse(DateTime.Now.ToString("yyyy"));
            

            // db에서 마지막으로 저장된 serial을 가져온다. 
            
            string strQuory = "SELECT serial FROM LogHistory ORDER BY datetime DESC LIMIT 1";
            ds = new DataSet();
            if (this.SelectQuory(strConn, strQuory, ref ds))
            {
                foreach (DataRow r in ds.Tables[0].Rows)
                {
                    string lastSerial = r[0].ToString().Substring(4, 6);
                    
                    if (int.Parse(lastSerial) == 999999)
                    {
                        tb_serial.Text = "000001";
                    }
                    else {
                        // serial을 증가시키고 공백이 있을 경우 앞 자리를 0으로 채운다. 
                        string cntSerial = (int.Parse(lastSerial) + 1).ToString();
                        string empty_to_zero = "";
                        for (int i = 0; i < 6 - cntSerial.Length; i++) {
                            empty_to_zero += "0";
                        }
                        tb_serial.Text = empty_to_zero + cntSerial;
                    }
                     
                }
            }

            string year = nud_year.Value.ToString();
            lb_converted.Text = convertAlpha(year) +tb_serial.Text;       // 년도를 알파벳으로 바꿔주는 메소드 


            string filePath = Application.StartupPath + @"\\configure.xml";
            string file = filePath;
            if (!File.Exists(file))
            {
                // Config 파일이 존재하지 않을 경우 파일을 생성해준다. 

                using (XmlWriter wr = XmlWriter.Create(filePath))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("Info");

                    wr.WriteStartElement("Configure1");
                    wr.WriteElementString("Width", "50");  // attribute 쓰기
                    wr.WriteElementString("Height", "25");   // Element 쓰기
                    wr.WriteElementString("Gap", "2");
                    wr.WriteElementString("Concentration", "1");
                    wr.WriteEndElement();

                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                }
            }

            // config 파일을 읽어 컴포넌트에 값을 넣어줌. 
            using (XmlReader rd = XmlReader.Create(filePath))
            {
                while (rd.Read())
                {
                    if (rd.IsStartElement())
                    {
                        if (rd.Name == "Configure1")
                        {
                            rd.Read();
                            nud_width.Value = int.Parse(rd.ReadElementContentAsString("Width", ""));
                            nud_height.Value = int.Parse(rd.ReadElementContentAsString("Height", ""));
                            nud_gap.Value = int.Parse(rd.ReadElementContentAsString("Gap", ""));
                            nud_concentration.Value = int.Parse(rd.ReadElementContentAsString("Concentration", ""));
                        }
                    }
                }
            }
        }

        private string convertAlpha(string year)
        {
            string convertedString = "";
            for (int i = 0; i < year.Length; i++)           // 년도 변환 0:A, 1:B, 2:C ...
            {
                int x = int.Parse(year[i].ToString());
                convertedString += (engMap)x;
            }
            return convertedString;
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

            //Open specified printer driver : 프린터 name
            //Setup the media size and sensor type info : 용지 너비, 용지 높이, gap, 속도,농도,센서타입, gap높이,?
            // 출력 형식 : DIRECTION 1 or DIRECTION 2 등
            //Clear image buffer
            //Drawing barcode   : x축, y축, 바코드형식, 높이, 텍스트 출력여부, 출력방향, bar비율, bar비율, 데이터
            //Drawing printer font : x좌표,y좌표,폰트id,출력방향,x비율,y비율,text
            //Print labels
            // 인쇄 라벨수량, 복사 수량(반복)        


            string width = nud_width.Value.ToString();
            string height = nud_height.Value.ToString();
            string gap = nud_gap.Value.ToString();
            string concentration = nud_concentration.Value.ToString();
            string repeatPrint = nud_numberPage.Value.ToString();
            string printText = lb_converted.Text;

            TSCLIB_DLL.openport("TSC TTP-345");
            TSCLIB_DLL.setup(width, height, gap, concentration, "0", gap, "0");
            TSCLIB_DLL.sendcommand("DIRECTION 1");
            TSCLIB_DLL.clearbuffer();

            if (check_type.Checked == true)
                TSCLIB_DLL.barcode("130", "100", "128", "100", "1", "0", "2", "2", printText);
            else
                TSCLIB_DLL.printerfont("180", "200", "3", "0", "1", "1", printText);

            TSCLIB_DLL.printlabel("1", repeatPrint);
            TSCLIB_DLL.closeport();

            

            // 바코드를 출력할 때 db에 로그정보를 insert 

            string dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string strQuory = string.Format("INSERT INTO LogHistory VALUES ('{0}', '{1}');", dt, printText);
            DataSet ds;
            ds = new DataSet();
            this.SelectQuory(strConn, strQuory, ref ds);
            
            // Form refresh
            Form1_Load(sender, e);
        }

        private void btn_config_Click(object sender, System.EventArgs e)
        {
            // Config 파일 저장 

            string width = nud_width.Value.ToString();
            string height = nud_height.Value.ToString();
            string concentrations = nud_concentration.Value.ToString();
            string gap = nud_gap.Value.ToString();

            try
            {
                string filePath = Application.StartupPath + @"\\configure.xml";

                using (XmlWriter wr = XmlWriter.Create(filePath))
                {
                    wr.WriteStartDocument();
                    wr.WriteStartElement("Info");

                    wr.WriteStartElement("Configure1");
                    wr.WriteElementString("Width", width);
                    wr.WriteElementString("Height", height);
                    wr.WriteElementString("Gap", gap);
                    wr.WriteElementString("Concentration", concentrations);
                    wr.WriteEndElement();

                    wr.WriteEndElement();
                    wr.WriteEndDocument();
                    MessageBox.Show("설정이 적용되었습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void nud_width_KeyUp(object sender, KeyEventArgs e)
        {
            ConfigurePage(e);
        }

        private void nud_height_KeyUp(object sender, KeyEventArgs e)
        {
            ConfigurePage(e);
        }

        private void nud_gap_KeyUp(object sender, KeyEventArgs e)
        {
            ConfigurePage(e);
        }

        private void nud_concentration_KeyUp(object sender, KeyEventArgs e)
        {
            ConfigurePage(e);
        }

        private void ConfigurePage(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_config.PerformClick();
            }
        }

        private void tb_model_KeyUp(object sender, KeyEventArgs e)
        {
            string year = nud_year.Value.ToString();
            lb_converted.Text = convertAlpha(year) + tb_serial.Text + tb_model.Text.ToUpper(); // 변환된 알파벳, 시리얼, 모델명을 더해서 최종 출력문자열 생성

            if (e.KeyCode == Keys.Enter)
            {
                btn_print.PerformClick();
            }
        }

        private void tb_serial_KeyUp(object sender, KeyEventArgs e)
        {
            tb_model_KeyUp(sender, e);
        }

        private void nud_year_ValueChanged(object sender, System.EventArgs e)
        {
            string year = nud_year.Value.ToString();
            lb_converted.Text = convertAlpha(year) + lb_converted.Text.Substring(4);
        }

        private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tb_model.Select();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btn_config.Select();
            }
        }
    }

    public class TSCLIB_DLL
    {
        [DllImport("TSCLIB.dll", EntryPoint = "about")]
        public static extern int about();

        [DllImport("TSCLIB.dll", EntryPoint = "openport")]
        public static extern int openport(string printername);

        [DllImport("TSCLIB.dll", EntryPoint = "barcode")]
        public static extern int barcode(string x, string y, string type,
                    string height, string readable, string rotation,
                    string narrow, string wide, string code);

        [DllImport("TSCLIB.dll", EntryPoint = "clearbuffer")]
        public static extern int clearbuffer();

        [DllImport("TSCLIB.dll", EntryPoint = "closeport")]
        public static extern int closeport();

        [DllImport("TSCLIB.dll", EntryPoint = "downloadpcx")]
        public static extern int downloadpcx(string filename, string image_name);

        [DllImport("TSCLIB.dll", EntryPoint = "formfeed")]
        public static extern int formfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "nobackfeed")]
        public static extern int nobackfeed();

        [DllImport("TSCLIB.dll", EntryPoint = "printerfont")]
        public static extern int printerfont(string x, string y, string fonttype,
                        string rotation, string xmul, string ymul,
                        string text);

        [DllImport("TSCLIB.dll", EntryPoint = "printlabel")]
        public static extern int printlabel(string set, string copy);

        [DllImport("TSCLIB.dll", EntryPoint = "sendcommand")]
        public static extern int sendcommand(string printercommand);

        [DllImport("TSCLIB.dll", EntryPoint = "setup")]
        public static extern int setup(string width, string height,
                  string speed, string density,
                  string sensor, string vertical,
                  string offset);

        [DllImport("TSCLIB.dll", EntryPoint = "windowsfont")]
        public static extern int windowsfont(int x, int y, int fontheight,
                        int rotation, int fontstyle, int fontunderline,
                        string szFaceName, string content);
    }
}

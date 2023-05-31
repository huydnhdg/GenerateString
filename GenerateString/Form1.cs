using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseContext = System.ComponentModel.LicenseContext;

namespace GenerateString
{
    public partial class Form1 : Form
    {
        public static Hashtable CodeNameALLs = new Hashtable();
        public static int NUMBER_OF_SERIAL = 1;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lengthOfCode">Chiều dài của Mã cào</param>
        /// <param name="NumberOfCode">Số lượng mã cần tạo</param>
        private void button_Generate_Click(object sender, EventArgs e)
        {
            // Chiều dài của chuỗi ký tự
            CodeNameALLs = new Hashtable();
            int NumberOfCode = 0;
            string sNumber = "0";
            int lengthOfCode = 0;
            try
            {
                lengthOfCode = (int)numericUpDown1.Value;
                sNumber = textBox_NumberCode.Text;
                NumberOfCode = Int32.Parse(sNumber);
            }
            catch (Exception ex)
            {
                string message = "Chú ý nhập Số lượng mã cào";
                string title = "Thông báo";
                MessageBox.Show(message, title);
                return;
            }

            string PathFolder = textBox_PathFolder.Text;
            string textboxFileName = textBox_FileName.Text;

            // Đọc thông tin file
            string prefixCode = textBox_Prefix.Text;


            // Get số lượng Hashtable ALL
            string returSSS = getHashtable(PathFolder);

            //
            string[] prefixCodes = prefixCode.Split(',');

            // Tạo mã mới và lưu vào Hashtable New

            for (int i = 0; i < prefixCodes.Length; i++)
            {
                Hashtable CodeNames = new Hashtable();
                // Tạo bảng hash chứa các mã
                CodeNames = generateCodes(NumberOfCode, lengthOfCode, prefixCodes[i], InputString());

                if (checkBox_Txt.Checked)
                {
                    saveFileAsync(CodeNames, PathFolder, textboxFileName, prefixCodes[i]);
                }

                if (checkBox_Excel.Checked)
                {
                    saveFileExcel(CodeNames, PathFolder, textboxFileName, prefixCodes[i], i);
                }
            }
            string message1 = "Đã tạo xong mã cào\nSố lượng Trước: " + returSSS + "\nSố lượng Sau: " + CodeNameALLs.Count;
            string title1 = "Thông báo";
            MessageBox.Show(message1, title1);
        }

        private static string getHashtable(string PathFolder)
        {
            string returnSSS = "";
            // Đọc các file và add vào Hashtable ALL
            string[] files = Directory.GetFiles(PathFolder, "*.txt");
            String line;
            foreach (var file in files)
            {
                StreamReader sr = new StreamReader(file);
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    try {
                        if (!CodeNameALLs.ContainsKey(line))
                        {
                            CodeNameALLs.Add(line, line);
                        }
                    }
                    catch
                    {
                        Console.WriteLine(file.ToString() +  line);
                    }

                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
            }
            returnSSS += "Số lượng: " + CodeNameALLs.Count;
            return returnSSS;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="NumberOfCode">Số lượng mã</param>
        /// <param name="lengthOfCode">Chiều dài mã</param>
        /// <param name="prefixCode">Tiền tố trước mã</param>
        /// <param name="inputString">String Input</param>
        /// <returns></returns>
        private Hashtable generateCodes(int NumberOfCode, int lengthOfCode, string prefixCode, string inputString)
        {
            Hashtable CodeNames = new Hashtable();

            // Số lượng chữ cái trong chuỗi
            int lengthOfKey = (int)numericUpDown3.Value;

            // 
            if (lengthOfKey > 0)
            {
                if (radioButton3.Checked) // Đầu tiên
                {
                    // Boolean gr
                    while (CodeNames.Count < NumberOfCode)
                    {
                        string NewCode = RandomString(lengthOfKey, InputStringOnlyChars()) + RandomString(lengthOfCode - lengthOfKey, InputStringOnlyNumbers());
                        if (checkBox_Prefix.Checked)
                        {
                            // NewCode = Regex.Replace(prefixCode, @"[0-9]", "") + NewCode;
                            NewCode = prefixCode + NewCode;
                        }
                        if (!CodeNames.ContainsKey(NewCode) && !CodeNameALLs.ContainsKey(NewCode))
                        {
                            CodeNames.Add(NewCode, NewCode);
                            CodeNameALLs.Add(NewCode, NewCode);
                        }
                    }
                }
                else if (radioButton4.Checked) // Cuối
                {
                    // Boolean gr
                    while (CodeNames.Count < NumberOfCode)
                    {
                        string NewCode = RandomString(lengthOfCode - lengthOfKey, InputStringOnlyNumbers()) + RandomString(lengthOfKey, InputStringOnlyChars());
                        if (checkBox_Prefix.Checked)
                        {
                            // NewCode = Regex.Replace(prefixCode, @"[0-9]", "") + NewCode;
                            NewCode = prefixCode + NewCode;
                        }
                        if (!CodeNames.ContainsKey(NewCode) && !CodeNameALLs.ContainsKey(NewCode))
                        {
                            CodeNames.Add(NewCode, NewCode);
                            CodeNameALLs.Add(NewCode, NewCode);
                        }
                    }

                }
                else // Ngẫu nhiên
                {
                    // Console.WriteLine("Nhảy vào đây:");
                    while (CodeNames.Count < NumberOfCode)
                    {
                        string NewCodeOfRandom = RandomString(lengthOfCode - lengthOfKey, InputStringOnlyNumbers())
                            + RandomString(lengthOfKey, InputStringOnlyChars());

                        // Trộn lẫn các thông tin này với nhau:
                        string NewCode = RandomStringAdvance(lengthOfCode, NewCodeOfRandom);

                        if (checkBox_Prefix.Checked)
                        {
                            // NewCode = Regex.Replace(prefixCode, @"[0-9]", "") + NewCode;
                            NewCode = prefixCode + NewCode;
                        }
                        if (!CodeNames.ContainsKey(NewCode) && !CodeNameALLs.ContainsKey(NewCode))
                        {
                            CodeNames.Add(NewCode, NewCode);
                            CodeNameALLs.Add(NewCode, NewCode);
                        }
                    }
                }
            }
            else
            {
                while (CodeNames.Count < NumberOfCode)
                {
                    string NewCode = RandomString(lengthOfCode, inputString);
                    if (checkBox_Prefix.Checked)
                    {
                        // NewCode = Regex.Replace(prefixCode, @"[0-9]", "") + NewCode;
                        NewCode = prefixCode + NewCode;
                    }
                    if (!CodeNames.ContainsKey(NewCode) && !CodeNameALLs.ContainsKey(NewCode))
                    {
                        CodeNames.Add(NewCode, NewCode);
                        CodeNameALLs.Add(NewCode, NewCode);
                    }
                }
            }
            return CodeNames;
        }

        private static async Task saveFileAsync(Hashtable CodeNames, string PathFolder, string textboxFileName, string fileName)
        {
            FileStream fParameter = new FileStream(PathFolder + "\\" + textboxFileName + "_"
                + Regex.Replace(fileName, @"[^0-9A-Z]", "") + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter m_WriterParameter = new StreamWriter(fParameter);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            foreach (string key in CodeNames.Keys)
            {
                await m_WriterParameter.WriteLineAsync((string)CodeNames[key]);
            }
            // m_WriterParameter.Write(Msg);
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }

        private void saveFileExcel(Hashtable CodeNames, string PathFolder, string textboxFileName, string fileName, int Start)
        {
            string path = PathFolder + "\\Excel\\" + textboxFileName + "_" +
                Regex.Replace(fileName, @"[^0-9A-Z]", "") + "_" + DateTime.Now.ToString("yyyyMMddHHmm") + ".xlsx";

            using (var excelPackage = new ExcelPackage(new FileInfo(path)))
            {
                excelPackage.Workbook.Properties.Author = fileName;
                excelPackage.Workbook.Properties.Company = fileName;
                excelPackage.Workbook.Properties.Title = fileName;
                excelPackage.Workbook.Worksheets.Add(fileName);
                ExcelWorksheet workSheet = excelPackage.Workbook.Worksheets[0];

                BindingFormatForExcelDetail(workSheet, CodeNames, fileName, Start);
                // FileInfo fi = new FileInfo(path);
                excelPackage.Save();
                // excelPackage.Save(path);
            }

        }

        private void BindingFormatForExcelDetail(ExcelWorksheet worksheet, Hashtable CodeNames, string fileName, int Start)
        {
            // Set default width cho tất cả column
            worksheet.DefaultColWidth = 50;
            // Tự động xuống hàng khi text quá dài
            worksheet.Cells.Style.WrapText = false;
            // Tạo header
            worksheet.Cells[1, 1].Value = "STT";
            worksheet.Cells[1, 1].AutoFitColumns(6);
            worksheet.Cells[1, 2].Value = "Serial";
            worksheet.Cells[1, 2].AutoFitColumns(20);
            worksheet.Cells[1, 3].Value = "Code";
            worksheet.Cells[1, 3].AutoFitColumns(20);

            if (checkBox_QRCode.Checked)
            {
                worksheet.Cells[1, 4].Value = "Link QR";
                worksheet.Cells[1, 4].AutoFitColumns();
            }

            string cellString = "A1:C1";
            if (checkBox_QRCode.Checked)
            {
                cellString = "A1:D1";
            }

            int lengthOfSerial = (int)numericUpDown2.Value;

            // Lấy range vào tạo format cho range đó ở đây là từ A1 tới I1
            using (var range = worksheet.Cells[cellString])
            {
                // Set PatternType
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                // Set Màu cho Background
                // range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(0xc6d9f1));
                range.Style.Fill.BackgroundColor.SetColor(Color.Black);
                // Canh giữa cho các text
                range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
                //// Set Font cho text  trong Range hiện tại
                //range.Style.Font.SetFromFont(new Font("Arial", 10));
                //// Set Border
                //range.Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                //// Set màu cho Border
                //range.Style.Border.Bottom.Color.SetColor(Color.DarkBlue);

                //range.AutoFilter = true;
                range.Style.Font.Bold = true;
                range.Style.Font.Size = 10;
                range.Style.Font.Color.SetColor(Color.White);
            }

            // Đỗ dữ liệu từ list vào 
            int i = 1;
            if (radioButton_Continue.Checked) // Liên tiếp bắt đầu từ Số bắt đầu cho đến hết các file
            {
                // Serial bắt đầu mặc định từ 1
                if (Start == 0)
                {
                    NUMBER_OF_SERIAL = Int32.Parse(textBox1.Text);
                }
            }
            else if (radioButton_NotContinue.Checked) // Không liên tiếp, tạo file thì reset lại giá trị SERIAL
            {
                try
                {
                    NUMBER_OF_SERIAL = Int32.Parse(textBox1.Text);
                }
                catch (Exception ex)
                {
                    NUMBER_OF_SERIAL = i;
                }
            }
            foreach (string key in CodeNames.Keys)
            {

                // var item = CodeNames[key];
                var rowCur = i + 1;
                string headerRange = "A" + rowCur + ":C" + rowCur;
                if (checkBox_QRCode.Checked)
                {
                    headerRange = "A" + rowCur + ":D" + rowCur;
                }
                worksheet.Cells[headerRange].Style.Font.Bold = false;
                worksheet.Cells[headerRange].Style.Font.Size = 11;
                worksheet.Cells[headerRange].Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;


                worksheet.Cells[rowCur, 1].Value = i;

                if (textBox_Serial.Text.Length == 0)
                {
                    worksheet.Cells[rowCur, 2].Style.Numberformat.Format = "@";
                    worksheet.Cells[rowCur, 2].Value = Regex.Replace(fileName, @"[^0-9.A-Z]", "") + CreateSerial(NUMBER_OF_SERIAL, lengthOfSerial); // Serial
                }
                else
                {
                    worksheet.Cells[rowCur, 2].Style.Numberformat.Format = "@";
                    worksheet.Cells[rowCur, 2].Value = textBox_Serial.Text + CreateSerial(NUMBER_OF_SERIAL, lengthOfSerial); // Serial
                }
                // Code - Mã cào
                worksheet.Cells[rowCur, 3].Style.Numberformat.Format = "@";
                worksheet.Cells[rowCur, 3].Value = key;
                // Link QR Code nếu có
                if (checkBox_QRCode.Checked)
                {
                    worksheet.Cells[rowCur, 4].Style.Numberformat.Format = "@";
                    worksheet.Cells[rowCur, 4].Value = textBox_QRCode.Text + key;
                }
                i++;
                NUMBER_OF_SERIAL++;
            }
        }

        public static String CreateSerial(int i, int lengthSerial)
        {
            String Serial = "0" + i;
            while (Serial.Length < lengthSerial)
            {
                Serial = "0" + Serial;
            }
            return Serial;
        }

        private static Random random = new Random();
        public static string RandomString(int length, string chars)
        {
            // const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            // int lengthOfSerial = (int)numericUpDown3.Value;

            //return new string(Enumerable.Repeat(chars, length)
            //  .Select(s => s[random.Next(s.Length)]).ToArray());
            char[] NewCode = new char[length];
            int i = 0;
            while (i < length)
            {
                int rad = random.Next(0, chars.Length);
                NewCode[i] = chars[rad];
                // chars = chars.Remove(rad, 1);
                i++;
            }
            return new string(NewCode);
        }

        public static string RandomStringAdvance(int length, string chars)
        {
            char[] NewCode = new char[length];
            int i = 0;
            while (i < length)
            {
                int rad = random.Next(0, chars.Length);
                NewCode[i] = chars[rad];
                chars = chars.Remove(rad, 1);
                i++;
            }
            return new string(NewCode);
        }

        public string InputString()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            if (!checkBox_Char.Checked)
            {
                chars = Regex.Replace(chars, @"[A-Z]", "");
            }

            if (!checkBox_Number.Checked)
            {
                chars = Regex.Replace(chars, @"[0-9]", "");
            }

            if (checkBox_NotContain_O0.Checked)
            {
                chars = Regex.Replace(chars, @"[0OQVU]", "");
            }

            if (checkBox_NotContain_I1.Checked)
            {
                chars = Regex.Replace(chars, @"[1I]", "");
            }
            return chars;
        }

        public string InputStringOnlyChars()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (!checkBox_Char.Checked)
            {
                chars = Regex.Replace(chars, @"[A-Z]", "");
            }

            if (!checkBox_Number.Checked)
            {
                chars = Regex.Replace(chars, @"[0-9]", "");
            }

            if (checkBox_NotContain_O0.Checked)
            {
                chars = Regex.Replace(chars, @"[0OQVU]", "");
            }

            if (checkBox_NotContain_I1.Checked)
            {
                chars = Regex.Replace(chars, @"[1I]", "");
            }
            return chars;
        }

        public string InputStringOnlyNumbers()
        {
            string chars = "0123456789";

            if (!checkBox_Char.Checked)
            {
                chars = Regex.Replace(chars, @"[A-Z]", "");
            }

            if (!checkBox_Number.Checked)
            {
                chars = Regex.Replace(chars, @"[0-9]", "");
            }

            if (checkBox_NotContain_O0.Checked)
            {
                chars = Regex.Replace(chars, @"[0OQVU]", "");
            }

            if (checkBox_NotContain_I1.Checked)
            {
                chars = Regex.Replace(chars, @"[1I]", "");
            }
            return chars;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_PathFolder.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}

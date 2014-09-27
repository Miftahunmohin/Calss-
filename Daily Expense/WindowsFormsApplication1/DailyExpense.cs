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
using CSVLib;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string filePath = "dailyEntry.csv";

        List<string> infoList=new List<string>();
        List<string> getInfoList=new List<string>();
     
       
        private void buttonForSave_Click(object sender, EventArgs e)
        {
            FileStream aFileStream=new FileStream(filePath,FileMode.Append);
            CsvFileWriter afiCsvFileWriter=new CsvFileWriter(aFileStream);

            infoList.Add(textBoxForInputAmount.Text);
            infoList.Add(comboBoxForInputCategory.Text);
            infoList.Add(textBoxForInputParticular.Text);
            if (textBoxForInputAmount.Text == "")
            {
                MessageBox.Show("do  not Amount");
            }
            else if (comboBoxForInputCategory.Text == "")
            {
                MessageBox.Show("do  not Category");
            }
            else if (textBoxForInputParticular.Text == "")
            {
                MessageBox.Show("do  not Particular");
            }
           
            else
            {
                afiCsvFileWriter.WriteRow(infoList);
                MessageBox.Show("save succesfully");
            }

            aFileStream.Close();
            //string data = textBoxForInputAmount.Text;
            //double date2 = Convert.ToDouble(data);
            //MessageBox.Show(date2.ToString());
            textBoxForInputAmount.Text = "";
            textBoxForInputParticular.Text = "";
            comboBoxForInputCategory.Text = "";

        }

        private void buttonForShowViewSummary_Click(object sender, EventArgs e)
        {
            List<double> amountList=new List<double>();
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            while (aCsvFileReader.ReadRow(getInfoList))
            {
                amountList.Add( Convert.ToDouble(getInfoList[0]));
               // Amount = Amount + Amount;
              
            }
            aFileStream.Close();
            double result=0;
            foreach (var d in amountList)
            {
                result = result + d;

            }
           textBoxForTotalExpense.Text = result.ToString();
           textBoxForMaximumExpense.Text = amountList.Max().ToString();
        }

        private void buttonForViewCategoryWiseExpense_Click(object sender, EventArgs e)
        {
            List<string> categoryList = new List<string>();
            List<string> categoryList2 = new List<string>();
            string name = comboBoxForInputCategory2.Text;
            List<double> result =new List<double>();
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            listView1.Items.Clear();
            while (aCsvFileReader.ReadRow(getInfoList))
            {
                if (getInfoList[1] == name)
                {
                    ListViewItem lk = new ListViewItem(getInfoList[1]);
                    lk.SubItems.Add(getInfoList[0]);
                    listView1.Items.Add(lk);

                    result.Add(Convert.ToDouble(getInfoList[0]));
                    

                } 
            }

            double sum = 0;
            foreach (var d in result)
            {
                sum = sum + d;
            }
            textBoxForTotal.Text = sum.ToString();
            //foreach (var VARIABLE in getInfoList)
            //{
            //    if (VARIABLE==textBox1.Text)
            //    {
            //      ListViewItem lk=new ListViewItem(VARIABLE);
            //        listView1.Items.Add(lk);

            //    }
            //}
            aFileStream.Close();
        }

        private void comboBoxForInputCategory2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxForTotalExpense_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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


namespace GradeDemoturn
{
    public partial class MainForm : Form
    {
        List<Examinee> listExam = new List<Examinee>();
        List<StudentAugust>  listAugust= new List<StudentAugust>();
        List<StudentMay> listMay = new List<StudentMay>();
        int recordNumber = 0;
        char[] gcDelimeter = new char[] { '\t' };


        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFile();
        }

        public void AddMessage(String psMessage)
        {
            listBoxMessage.Items.Add(psMessage);
            listBoxMessage.SelectedIndex = listBoxMessage.Items.Count - 1; //items表示一行 count -1到信息最後處
        }

        private void LoadFile()
        {
            //Open File
            FileInfo fiFile = new FileInfo("exam.txt");
            if(!fiFile.Exists)
            {
                AddMessage("檔案開啟錯誤");
                return;
            }

            TextReader trFile = new StreamReader("exam.txt", System.Text.Encoding.Default);
            string sLine = "";

            try	{
				while((sLine = trFile.ReadLine()) != null)
				{
					string[] data = sLine.Split(gcDelimeter);

					if(data[2].CompareTo("學測") == 0)
					{
						Examinee w = new Examinee(data[0], data[1], data[2], data[3]);  
						listExam.Add(w);
                        StudentMay m = new StudentMay(data[0], data[1], data[2], data[3], Convert.ToInt32(data[4]));
                        listMay.Add(m);

					}
					else
					{          
                        Examinee w = new Examinee(data[0], data[1], data[2], data[3]);
                        listExam.Add(w); 
						StudentAugust a= new StudentAugust(data[0], data[1], data[2], data[3], Convert.ToDouble(data[5]), Convert.ToDouble(data[6]), Convert.ToDouble(data[7]));
						listAugust.Add(a);
              
					}
				}
				AddMessage("此檔案之資料瀏覽紀錄：\n");
                trFile.Close();
                Chooser();
		    }
            catch(IOException e)
            {
				 AddMessage("檔案讀取錯誤: " + e.Message);
			}
        }
	
        public void Sorting()
	    {
		   
		   
            listMay.Sort();
            listAugust.Sort();

            int index = 0;
            for (int i = listMay.Count-1; i >= 0; i--)
		    {
			    String iSort = "";
			    if(index+1 < 15)
				    iSort = "正取第" + (index + 1);
                else if (index + 1 < 35)
				    iSort = "備取第" + (index-13);
			    else
				    iSort = "未錄取";
                listMay[i].setSort(iSort);
                index++;
		    }

            index = 0;
            for (int i = listAugust.Count - 1; i >= 0; i--)
		    {
			    String iSort = "";
			    if(index+1 < 16)
				    iSort = "正取第" + (index + 1);
			    else if(index+1 < 36)
				    iSort = "備取第" + (index-14);
			    else
				    iSort = "未錄取";
                listAugust[i].setSort(iSort);
                index++;
		    }	
	    }

	    public void Chooser()
	    {
		    if(listExam[recordNumber].getGroup().CompareTo("學測") == 0) //學測
		    {
			    StudentMay s1 = listMay.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0);
					
			    type.SelectedIndex = 0;
			    jtfCode.Text = s1.getCode();
			    jtfName.Text = s1.getName();
			    jtfSort.Text = s1.getSort();
			    jtfGrade0.Text = "" + s1.getGrade();
                jtfGrade0.Enabled = true;
			    jtfGrade1.Text = "";
                jtfGrade1.Enabled = false;
			    jtfGrade2.Text = "";
                jtfGrade2.Enabled = false;
			    jtfGrade3.Text = "";
                jtfGrade3.Enabled = false;
			    AddMessage(s1.ToString());

		    }
		    else
		    {
                StudentAugust s2 = listAugust.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0); 
				
			    type.SelectedIndex = 1;
			    jtfCode.Text = s2.getCode();
			    jtfName.Text = s2.getName();
			    jtfSort.Text = s2.getSort();
			    jtfGrade0.Text = "";
                jtfGrade0.Enabled = false;
			    jtfGrade1.Text = "" + s2.getMath();
                jtfGrade1.Enabled = true;
			    jtfGrade2.Text = "" + s2.getChinese();
                jtfGrade2.Enabled = true;
			    jtfGrade3.Text = "" + s2.getEnglish();
                jtfGrade3.Enabled = true;
			    AddMessage(s2.ToString());
					
		    }
	    }

        private void clrButton_Click(object sender, EventArgs e)
        {
            jtfCode.Text = "";
            jtfName.Text = "";
            jtfSort.Text = "";
            jtfGrade0.Text = "";
            jtfGrade1.Text = "";
            jtfGrade2.Text = "";
            jtfGrade3.Text = "";
        }

        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void jbFirst_Click(object sender, EventArgs e)
        {
            recordNumber = 0;
            Chooser();
            jbForward.Enabled = false;
            jbBack.Enabled = true;
        }

        private void jbLast_Click(object sender, EventArgs e)
        {
            recordNumber = (listExam.Count - 1);
            Chooser();
            jbForward.Enabled = true;
            jbBack.Enabled = false;
        }

        private void jbSort_Click(object sender, EventArgs e)
        {
            Sorting();
        }

        private void jbBack_Click(object sender, EventArgs e)
        {
            recordNumber++;

            if (recordNumber >= listExam.Count) //表示搜索的數字大於清單長度
            {
                MessageBox.Show("You have reached end of search results");

                /*if user has reached the end of results, disable forward button*/
                jbForward.Enabled = true;
                jbBack.Enabled = false;
 
                // dec by one to counter last inc
                recordNumber--;
            }
            else
            {
                jbBack.Enabled = true;
                jbForward.Enabled = true;
                Chooser();
            }
        }

        private void jbSearch_Click(object sender, EventArgs e)
        { 
             String code = jtfCode.Text;
			int check = 0;
			if(code.CompareTo ("") == 0)
				MessageBox.Show("請輸入准考證號碼以查詢");
			else
			{
                for(int i = 0;i < listExam.Count; i++)
				{
                    if(listExam[i].getGroup().CompareTo("學測") == 0)
					{
                        StudentMay s1 = listMay.Find(x => x.getCode().CompareTo(listExam[i].getCode()) == 0);
                        if(jtfCode.Text.CompareTo(s1.getCode()) == 0) 
						{
                            AddMessage("查詢結果:\n" + s1.ToString()+"\n"); 
                            type.SelectedIndex = 0; 										 
                            jtfCode.Text = s1.getCode();
							jtfName.Text = s1.getName();
							jtfSort.Text = s1.getSort();
							jtfGrade0.Text = " " + s1.getGrade();
							jtfGrade1.Text = "";
							jtfGrade2.Text = "";
							jtfGrade3.Text = "";
							recordNumber = i;
							check = 1;
							break;
 						}
					}
					
                    else
					{
                        StudentAugust s2 = listAugust.Find(x => x.getCode().CompareTo(listExam[i].getCode()) == 0); 
                        if(jtfCode.Text.CompareTo(s2.getCode()) == 0)
						{
							AddMessage("查詢結果:\n" + s2.ToString() + "\n"); 
                            type.SelectedIndex = 1;
							jtfCode.Text = s2.getCode();
							jtfName.Text = s2.getName();
							jtfSort.Text = s2.getSort();
							jtfGrade0.Text = "";
							jtfGrade1.Text = "" + s2.getMath();
							jtfGrade2.Text = "" + s2.getChinese();
							jtfGrade3.Text = "" + s2.getEnglish();
							recordNumber = i;
							check = 1;
							break;
						}
					}
				}
				if(check == 0)
					MessageBox.Show("查無此考生");
			}
        }

        private void jbForward_Click(object sender, EventArgs e)
        {
            recordNumber--;

            if (recordNumber < 0)
            {
                MessageBox.Show("You have reached begining of search results");

                /*if user has reached the begining of results, disable back button*/
                jbForward.Enabled = false;
                jbBack.Enabled = true;

                // inc by one to counter last dec
                recordNumber++;
            }
            else
            {
                jbForward.Enabled = true;
                jbBack.Enabled = true;
                Chooser();

            }
        }

        private void jbUpdate_Click(object sender, EventArgs e)
        { 
            String n = jtfName.Text;
			String gp;
			String s = jtfSort.Text;  
			try
			{
				
				if(listExam[recordNumber].getGroup().CompareTo("學測") == 0)
				{					
					gp = "學測";
					int g0 = Convert.ToInt32(jtfGrade0.Text);
					
					StudentMay s1 = listMay.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0);
					s1.setName(n);
					s1.setGroup(gp);
					s1.setSort(s);
					s1.setGrade(g0);		  
					AddMessage("修改完成↓↓↓\n");
					Sorting();
					AddMessage(s1.ToString()+ "\n");
				}      
				else
				{
					gp = "指考";
					double g1 = Convert.ToDouble(jtfGrade1.Text);
					double g2 = Convert.ToDouble(jtfGrade2.Text);
					double g3 = Convert.ToDouble(jtfGrade3.Text);

                    StudentAugust s2 = listAugust.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0);
					s2.setName(n);
					s2.setGroup(gp);
					s2.setSort(s);
					s2.setMath(g1);
					s2.setChinese(g2);
					s2.setEnglish(g3);
					AddMessage("修改完成↓↓↓\n");
					Sorting();
					AddMessage(s2.ToString() + "\n");
				}
				
			} 	catch(Exception ex)
				{
					MessageBox.Show( "入學方式選擇錯誤!!" + ex.Message);
					jtfGrade0.Text = "";
					jtfGrade1.Text = "";
					jtfGrade2.Text = "";
					jtfGrade3.Text = "";
				}
        }

        private void jbDelete_Click(object sender, EventArgs e)
        {
			var choice = MessageBox.Show("確定刪除此筆資料??","刪除確認",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                listExam.RemoveAt(recordNumber);
                AddMessage("刪除完成\n");

                jtfCode.Text = "";
                jtfName.Text = "";
                jtfGrade0.Text = "";
                jtfGrade1.Text = "";
                jtfGrade2.Text = "";
                jtfGrade3.Text = "";
                jtfSort.Text = "";
                recordNumber--;
                
            }

        }
        private void jbAdd_Click(object sender, EventArgs e)
        {
            String c = jtfCode.Text;
            String n = jtfName.Text;
            String gp;
            String s = jtfSort.Text;
            try
            {
                if (type.SelectedIndex == 0) //選學測
                {
                    gp = "學測";
                    int g0 = Convert.ToInt32(jtfGrade0.Text);
                    jtfGrade1.Text = "-1";
                    jtfGrade2.Text = "-1";
                    jtfGrade3.Text = "-1";
                    Examinee w = new Examinee(c, n, gp, s);
                    StudentMay sm = new StudentMay(c, n, gp, s, g0);
                    listExam.Add(w);
                    listMay.Add(sm);
                    AddMessage("新增完成\n");
                    jbBack.Enabled = true;
                }
                else
                {
                    gp = "指考";
                    double g1 = Convert.ToDouble(jtfGrade1.Text);
                    double g2 = Convert.ToDouble(jtfGrade2.Text);
                    double g3 = Convert.ToDouble(jtfGrade3.Text);
                    jtfGrade0.Text = "-1";
                    Examinee w = new Examinee(c, n, gp, s);
                    StudentAugust sa = new StudentAugust(c, n, gp, s, g1, g2, g3);
                    listExam.Add(w);
                    listAugust.Add(sa);
                    AddMessage("新增完成\n");
                    jbBack.Enabled = true;

                }
                Sorting();

            }
            catch (Exception ex)
            {
                MessageBox.Show("若想更改此考生資料，\n請輸入完整後按「修改」鍵，謝謝!!" + ex.Message);
            }
        }

        private void jbOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //當按鈕案OK則
            {

                TextReader trFile = new StreamReader(openFileDialog1.FileName, System.Text.Encoding.Default);
                string sLine = "";

                var choice = MessageBox.Show("是否要跳轉至此檔案瀏覽??", "跳轉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.No)
                {
                    try
                    {
                        while ((sLine = trFile.ReadLine()) != null)
                        {
                            AddMessage(sLine);
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("資料讀取錯誤" + ex.Message);
                        return;
                    }
                    AddMessage("\t\t=====開啟檔案=====\n");
                    AddMessage("准考證號碼\t姓名\t入學方式\t排名\t學測總級分\t指考(數)\t指考(國)\t指考(英)\n");
                    AddMessage("(p.s.為讀檔需求，-1表示無此資料)\n\t\t=================\n下面為上次最後的瀏覽紀錄:\n");
                    Chooser();
                }
                else
                {

                    try
                    {
                        while ((sLine = trFile.ReadLine()) != null)
                        {
                            string[] data = sLine.Split(gcDelimeter);

                            if (data[2].CompareTo("學測") == 0)
                            {
                                Examinee w = new Examinee(data[0], data[1], data[2], data[3]);
                                listExam.Add(w);
                                StudentMay m = new StudentMay(data[0], data[1], data[2], data[3], Convert.ToInt32(data[4]));
                                listMay.Add(m);

                            }
                            else
                            {
                                Examinee w = new Examinee(data[0], data[1], data[2], data[3]);
                                listExam.Add(w);
                                StudentAugust a = new StudentAugust(data[0], data[1], data[2], data[3], Convert.ToDouble(data[5]), Convert.ToDouble(data[6]), Convert.ToDouble(data[7]));
                                listAugust.Add(a);

                            }
                        }
                        AddMessage("此檔案之資料瀏覽紀錄：\n");
                        trFile.Close();
                        AddMessage("已跳轉至檔案:" + openFileDialog1.FileName + "\n");
                        AddMessage("此檔案之資料瀏覽紀錄：\n");
                        Chooser();

                    }
                    catch (Exception EX)
                    {
                        AddMessage("exception:" + EX.Message);
                    }

                }
            }
        }

        private void jbWriteout_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //當按鈕案OK則
            {

                TextWriter twFile = new StreamWriter(saveFileDialog1.FileName);
                string sLine = "";
				TextWriter p = File.CreateText("exam.txt");

                string[] data = sLine.Split(gcDelimeter);
				for(int i = 0;i < listExam.Count; i++)
				{
					if(data[2].CompareTo("學測") == 0)
					{
                        StudentMay s1 = listMay.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0);
						p.WriteLine(s1.getCode()+ "\t" +s1.getName()+"\t學測\t" + s1.getSort() + "\t" + s1.getGrade() + "\t -1 \t -1 \t -1");
					}
					else
					{
                        StudentAugust s2 = listAugust.Find(x => x.getCode().CompareTo(listExam[recordNumber].getCode()) == 0);
						p.WriteLine(s2.getCode()+ "\t" +s2.getName()+"\t指考\t" + s2.getSort() + "\t -1 \t" + s2.getMath() + "\t" + s2.getChinese() + "\t" + s2.getEnglish());
			   
					}			
				}
				p.Close();
            }
        }

        
    }
}

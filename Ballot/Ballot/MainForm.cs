using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Ballot
{
    public partial class MainForm : Form
    {
        private int giyoungGirlNum = 0;
        private int gioldGirlNum = 0;
        private int maxNum = 36;
        private int giCount = 0;
        private int giCount2 = 0;
        private int timeCount = 0;
        private int imageIndex = 0;
        private int giClickNext = 0;
        private int[] Number = null;
        private int[] Number2 = null;

        private string[] gender1 = new string[100];
        private string[] gender2 = new string[100];
        private string[] pic1 = new string[100];
        private string[] pic2 = new string[100];
        private string[] sOldname = new string [100];
        private string[] sYoungname = new string[100];
        char[] gcDelimeter = new char[] { '\t' };

        private Random r = new Random();
        List<Student> listOldStudent = new List<Student>();
        List<Student> listYoungStudent = new List<Student>();
        List<Family> listFamily = new List<Family>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFile();
            initNum();
            GetNameAndImageAndGender();

           listBoxMessage.Visible = false;

            button1.Cursor = new Cursor("hand.cur");
            button2.Cursor = new Cursor("hand.cur");
            button3.Cursor = new Cursor("hand.cur");
            button4.Cursor = new Cursor("hand.cur");
            button5.Cursor = new Cursor("hand.cur");
            button6.Cursor = new Cursor("hand.cur");
            button7.Cursor = new Cursor("hand.cur");
            buttonNext.Cursor = new Cursor("hand.cur");

            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;
            pictureBoxResult.Visible = false;
            pictureBoxYoung.Visible = false;
            GenerateListViewResult();
            //ShowFamilyList();
        }

        public void AddMessage(String psMessage)
        {
            listBoxMessage.Items.Add(psMessage);
            listBoxMessage.SelectedIndex = listBoxMessage.Items.Count - 1; //items表示一行 count -1到信息最後處
        }

        private void GenerateListViewResult()
        {
            string sValue = "";
            for(int i = 0; i < maxNum; i++)
            {
                ListViewItem lvItem = new ListViewItem((i+1).ToString());

                lvItem.SubItems.Add(sValue);
                lvItem.SubItems.Add("");
                lvItem.SubItems.Add("");

                listViewResult.Items.Add(lvItem);
            }

        }

        private void LoadFile()
        {
            //Open File
            FileInfo fiFile = new FileInfo("student.txt");
            FileInfo fiFile2 = new FileInfo("kids.txt");
            if (!fiFile.Exists)
            {
                AddMessage("檔案開啟錯誤");
                return;
            }

            if (!fiFile2.Exists)
            {
                AddMessage("E_2");
                return;
            }

            TextReader trFile = new StreamReader("student.txt", System.Text.Encoding.Default);
            TextReader trFile2 = new StreamReader("kids.txt", System.Text.Encoding.Default);
            string sLine = "";

            try
            {
                while ((sLine = trFile.ReadLine()) != null)
                {
                    string[] data = sLine.Split(gcDelimeter);
                                       
                    Student s = new Student(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), data[2], data[3], data[4]);
                    Family family = getFamily(Convert.ToInt32(data[0]));
                    
                    if (family == null)
                    {
                        family = new Family(Convert.ToInt32(data[0]));
                        listFamily.Add(family);
                    }

                    family.AddMember(s);
                    listOldStudent.Add(s);
                }
                trFile.Close();

                sLine = "";
                while ((sLine = trFile2.ReadLine()) != null)
                {
                    string[] data = sLine.Split(gcDelimeter);

                    Student s = new Student(Convert.ToInt32(data[0]), Convert.ToInt32(data[1]), data[2], data[3], data[4]);
                  
                    listYoungStudent.Add(s);
                }
                trFile2.Close();
            }
            catch (IOException e)
            {
                AddMessage("檔案讀取錯誤: " + e.Message);
            }
        }

        private Family getFamily(int piCode)
        { 
            for(int i = 0; i < listFamily.Count; i++)
            {
                if(listFamily[i].getFamilyCode() == piCode)
                {
                    return listFamily[i];
                }                
            }
            return null;         
        }

        //Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("請記得先選出下一位遊戲王喔~ (ˊ● ω ●ˋ)");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic1.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("下次請記得先選出下一位遊戲王喔~ (ˊ● ω ●ˋ)");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("下次請記得先選出下一位遊戲王喔~ (￣0 ￣)y");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic3.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("下次請記得先選出下一位遊戲王喔~ 　(≖‿ゝ≖)✧");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic4.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("（づ¯ ³ ¯）づ 下次請記得先選出下一位遊戲王喔~ ");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic5.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (giClickNext == 0)
            {
                MessageBox.Show("下次請記得先選出下一位遊戲王喔~ (◕‿◕)");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic6.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(giClickNext == 0)
            {
                MessageBox.Show("下次請記得先選出下一位遊戲王喔~ (ˊ● ω ●ˋ)");
                buttonNext.PerformClick();
            }
            else
            {
                timeCount = 0;
                timerpic7.Enabled = true;
            }
        }

        //Timers
        private void timerpic1_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = true;

            pictureBoxAnimation1.Image = imageListpic1.Images[imageIndex++];
            if (imageIndex >= imageListpic1.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic1.Images.Count))//讓他停
            {
                timerpic1.Enabled = false;
                pictureBoxAnimation1.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();               
            }
        }

        private void timerpic2_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = true;
            pictureBoxAnimation1.Visible = false;

            pictureBoxAnimation2.Image = imageListpic2.Images[imageIndex++];
            if (imageIndex >= imageListpic2.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic2.Images.Count))//讓他停
            {
                timerpic2.Enabled = false;
                pictureBoxAnimation2.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void timerpic3_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = true;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;
            pictureBoxAnimation3.Image = imageListpic3.Images[imageIndex++];
            if (imageIndex >= imageListpic3.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic3.Images.Count))//讓他停
            {
                timerpic3.Enabled = false;
                pictureBoxAnimation3.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void timerpic4_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = true;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;
            pictureBoxAnimation4.Image = imageListpic4.Images[imageIndex++];
            if (imageIndex >= imageListpic4.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic4.Images.Count))//讓他停
            {
                timerpic4.Enabled = false;
                pictureBoxAnimation4.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void timerpic5_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation5.Visible = true;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;

            pictureBoxAnimation5.Image = imageListpic5.Images[imageIndex++];
            if (imageIndex >= imageListpic5.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic5.Images.Count))//讓他停
            {
                timerpic5.Enabled = false;
                pictureBoxAnimation5.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void timerpic6_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation6.Visible = true;
            pictureBoxAnimation7.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;
            pictureBoxAnimation6.Image = imageListpic6.Images[imageIndex++];
            if (imageIndex >= imageListpic6.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic6.Images.Count))//讓他停
            {
                timerpic6.Enabled = false;
                pictureBoxAnimation6.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void timerpic7_Tick(object sender, EventArgs e)
        {
            pictureBoxAnimation7.Visible = true;
            pictureBoxAnimation6.Visible = false;
            pictureBoxAnimation5.Visible = false;
            pictureBoxAnimation4.Visible = false;
            pictureBoxAnimation3.Visible = false;
            pictureBoxAnimation2.Visible = false;
            pictureBoxAnimation1.Visible = false;

            pictureBoxAnimation7.Image = imageListpic7.Images[imageIndex++];
            if (imageIndex >= imageListpic7.Images.Count)
            {
                imageIndex = 0;
            }
            timeCount++;

            pictureBoxResult.Visible = false;
            if (timeCount.Equals(imageListpic7.Images.Count))//讓他停
            {
                timerpic7.Enabled = false;
                pictureBoxAnimation7.Visible = false;
                pictureBoxResult.Visible = true;
                ShowResult();
            }
        }

        private void ShowResult()
        {
            if (maxNum - giCount > 0)
            {
                int newkid = Number2[giCount2-1];

                if(gender2[newkid].CompareTo("女") == 0)
                {
                    giyoungGirlNum++;
                }               
                
                int num = giCount + r.Next(maxNum - giCount);
                int tmp = Number[num];
                //Number[num] = Number[giCount];
                //Number[giCount] = tmp;
                if(giyoungGirlNum < 13 && gioldGirlNum < 7) //girls haven't finish
                {
                    int iCheck = 0;
                    while(iCheck.Equals(0))
                    {
                        if (gender2[newkid].CompareTo(gender1[tmp]) == 0)
                        {  
                            iCheck = 0;
                            num = giCount + r.Next(maxNum - giCount);
                            tmp = Number[num];            
                        }                           
                        else
                        {
                            iCheck = 1;
                            Number[num] = Number[giCount];
                            Number[giCount] = tmp;
                            //顯示結果
                            pictureBoxResult.Image = new Bitmap("d:\\Ballot\\ballotpic\\" + pic1[tmp] + ".png");
                            //找家
                            List<Student> list2Grade = new List<Student>();
                            list2Grade = MatchGrade(listOldStudent);
                            int iMatchFamily = list2Grade[tmp].getFamily();
 
                            //加入新成員
                            Student AddStudent = new Student(iMatchFamily, 1, sYoungname[newkid], pic2[newkid], gender2[newkid]);
                            listFamily[iMatchFamily - 1].AddMember(AddStudent);
                            UpdateListViewResultItem1(sYoungname[newkid], sOldname[tmp], iMatchFamily + "家");

                            giCount++;
                            giClickNext = 0;
                            if (gender1[tmp].CompareTo("女") == 0)
                                gioldGirlNum++;
                            if (gioldGirlNum - 7 == 0)
                                MessageBox.Show("Ψ(‵▽′)Ψ  哇哈哈!! 學姊都被抽光光惹! \n ლ(ﾟдﾟლ) 啥毀??! (╯-_-)╯ ~╩╩ \n後面的學弟沒關係! 學長愛你呦~ （づ¯ ³ ¯）づ ");
                        }
                    }                               
                }
                else
                {
                    Number[num] = Number[giCount];
                    Number[giCount] = tmp;
                    //顯示結果
                    pictureBoxResult.Image = new Bitmap("d:\\ballotpic\\" + pic1[tmp] + ".png");
                    //找家
                    List<Student> list2Grade = new List<Student>();
                    list2Grade = MatchGrade(listOldStudent);
                    int iMatchFamily = list2Grade[tmp].getFamily();

                    //加入新成員
                    Student AddStudent = new Student(iMatchFamily, 1, sYoungname[newkid], pic2[newkid], gender2[newkid]);                 
                    listFamily[iMatchFamily - 1].AddMember(AddStudent);
                    UpdateListViewResultItem1(sYoungname[newkid], sOldname[tmp], iMatchFamily + "家");
                    //timerShowpic.Enabled = true;//停留
                    giCount++;
                    giClickNext = 0;
                }
 
                //string result = sOldname[tmp];              
                //AddMessage(tmp.ToString() + ": " + result);
                //labelResult.Text = result; 

            }
            else
            {
                AddMessage("已抽完");
                Writeout();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (giClickNext == 1)
            {
                MessageBox.Show("不要玩按鈕!!  ╯﹏╰ ");
            }
            else
            {
                pictureBoxYoung.Visible = true;
                if(maxNum - giCount2 >0)
                {
                    int num = giCount2 + r.Next(maxNum - giCount2);
                    int tmp = Number2[num];
                    Number2[num] = Number2[giCount2];
                    Number2[giCount2] = tmp;

                    pictureBoxResult.Visible = false;
                    pictureBoxYoung.Image = new Bitmap("d:\\Ballot\\ballotpicy\\" + pic2[tmp] + ".jpg");
                    UpdateListViewResultItem2(sYoungname[tmp], "", "");
                    giCount2++;
                    giClickNext = 1;
                }
                else
                    Writeout();  
            }
             
        }

        private void UpdateListViewResultItem1(string sYoung, string sOld, string iFamily)
        {
            foreach(ListViewItem lvItem in listViewResult.Items) 
            {
                if(lvItem.SubItems[1].Text.CompareTo(sYoung) == 0)
                {
                    lvItem.SubItems[2].Text = sOld;
                    lvItem.SubItems[3].Text = iFamily;
                    listViewResult.EnsureVisible(giCount); //移動到目前最新位置(int)
                    break;
                }
            }
        }

        private void UpdateListViewResultItem2(string sYoung, string sOld, string iFamily)
        {
            foreach (ListViewItem lvItem in listViewResult.Items) 
            {
                if (lvItem.SubItems[0].Text.CompareTo((giCount2+1) + "") == 0)
                {
                    lvItem.SubItems[1].Text = sYoung;
                    lvItem.SubItems[2].Text = sOld;
                    lvItem.SubItems[3].Text = iFamily;
                    listViewResult.EnsureVisible(giCount2); //移動到目前最新位置(int)
                    break;
                }
            }
        }

        private void ShowFamilyList(int familyCode)
        {
            //for(int i = 0; i < listFamily.Count; i++)
            //{
           //     MessageBox.Show(listFamily[i].ToString() + "\n");
           // }
            MessageBox.Show(listFamily[familyCode - 1].ToString());
            
        }

        private void initNum() 
        {
            giCount = 0;
            Number = new int[maxNum];
            Number2 = new int[maxNum];
            for (int i = 0; i < maxNum; i++)
            {
                Number[i] = i ;
                Number2[i] = i;
            }
        }

        private void GetNameAndImageAndGender()
        {
            List<Student> list2Grade = new List<Student>();
            list2Grade = MatchGrade(listOldStudent); //Find 2 grade student
            for (int i = 0; i < list2Grade.Count; i++)
            {
                sOldname[i] = list2Grade[i].getName();
                pic1[i] = list2Grade[i].getImage();
                gender1[i] = list2Grade[i].getGender();
            }
            
            for (int i =0; i < listYoungStudent.Count; i++)
            {
                sYoungname[i] = listYoungStudent[i].getName();
                pic2[i] = listYoungStudent[i].getImage();
                gender2[i] = listYoungStudent[i].getGender();
            }
        }

        private List <Student> MatchGrade(List <Student> s1)
        {
            List<Student> s2 = new List<Student>();
            for (int i = 0; i < s1.Count; i++)
            {
                int num = s1[i].getGrade();
                if ( num -2 == 0)
                {
                    s2.Add(s1[i]);
                }               
            }
            return s2;
        }
    
        private void Writeout()
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) //當按鈕案OK則
            {

                TextWriter TWFile = new StreamWriter(saveFileDialog1.FileName);
                string sLine = "";
                //TextWriter TWfile = File.CreateText("result.txt");

                string[] data = sLine.Split(gcDelimeter);
                for (int i = 0; i < listFamily.Count; i++)
                {
                    Family Final = listFamily[i];
                    string write = Final.ToString();
                    TWFile.WriteLine(write);
                }
                TWFile.Close();
            }
        }

        private void listViewResult_DoubleClick(object sender, EventArgs e)
        {

            //giCount = listViewResult.SelectedIndices[0];
            //--giCount2;
            //if (gender1[Number[giCount]].CompareTo("女") == 0)
                //--oldgirlNum;
            //pictureBoxResult.Visible = false;
            //pictureBoxYoung.Image = new Bitmap("d:\\ballotpicy\\" + pic2[giCount] + ".jpg");
        }
    }
}

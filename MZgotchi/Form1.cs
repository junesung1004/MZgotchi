using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MZgotchi
{
    public partial class Form1 : Form
    {

        //이미지 생성을 위한 객체생성
        PictureBox item1 = new PictureBox();


        //타이머 생성을 위한 객체생성
        Timer t = new Timer();


        //상태가 준비되었는지에 대한 코드
        public bool isReady = false;


        //소리 초기설정
        SoundPlayer player = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\춤추는강아지.wav");


        //춤추는 고양이 초기설정코드
        SoundPlayer player1 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\춤추는고양이.wav");


        //좋아죽는 고양이 초기설정코드
        SoundPlayer player2 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\좋아죽는고양이.wav");

        //밥먹는 당나귀 초기설정코드
        SoundPlayer player3 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\당나기먹기.wav");



        //아픈고양이 초기설정코드
        SoundPlayer player4 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\아픈고양이.wav");

        //아픈고양이 초기설정코드
        SoundPlayer player5 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\울분토하는고양이.wav");

        //아픈고양이 초기설정코드
        SoundPlayer player6 = new SoundPlayer("C:\\kostafullstack\\과제자료\\C#\\다마고치\\MZgotchi\\MZgotchi\\Resources\\폭력고양이.wav");


        // 각기 다른 버튼을 눌렀을때 출력할 텍스트 저장
        string currentText;


        //다마고치 캐릭터 상태관리를 해줄 초기시간
        int happinessTime = 110; 
        int healthTime = 95; 
        int hungryTime = 85; 


        //시간초가 줄어드는 객체생성
        Timer countdownTime = new Timer();


        public Form1()
        {
            InitializeComponent();


            //다마고치 캐릭처 초기화 코드
            item1.Size = new Size(200,280);
            item1.Location = new Point(20, 170);
            item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\춤추는강아지.gif");
            item1.SizeMode = PictureBoxSizeMode.CenterImage;
            item1.BackColor = Color.Transparent;
            this.Controls.Add(item1);
            item1.BringToFront();


            //카운트다운 초기 설정 및 시작
            countdownTime.Interval = 1000;
            countdownTime.Tick += countdownTime_tick;
            countdownTime.Start();

            //앱이 실행하면 자동으로 초기설정한 음악 및 gif 실행
            initState();

            

            
                
            
        }


        //초기 설정한 음악, gif 함수로 설정한 코드
        private void initState()
        {

            if (hungryTime < 0 || happinessTime < 0 || healthTime < 0)
            {
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\울분토하는고양이.gif");
                player5.PlayLooping();
                MessageBox.Show("망할놈의 집사!!!!!!!!!!");
            }

            else if (hungryTime < 14 || happinessTime < 14 || healthTime < 14)
            {
                player6.PlayLooping();
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\폭력고양이.gif");


            }
            else if (hungryTime < 39 || happinessTime < 39 || healthTime < 39)
            {
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\아픈고양이.gif");
                player4.PlayLooping();
            }
            else
            {
                player.PlayLooping();
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\춤추는강아지.gif");
                lblResult.Text = "주인님 사랑해용~~";
            }
            
        }


        // 모든 버튼 비활성화 메서드
        private void DisableButtons()
        {
            btnEat.Enabled = false;
            btnHealth.Enabled = false;
            btnPlaying.Enabled = false;
        }


        // 모든 버튼 활성화 메서드
        private void EnableButtons()
        {
            btnEat.Enabled = true;
            btnHealth.Enabled = true;
            btnPlaying.Enabled = true;
        }



        //운동하기 버튼 로직
        private async void btnHealth_Click(object sender, EventArgs e)
        {
            DisableButtons();
            healthTime += 10;
            currentText = "운동 이거거덩~🏈";
            lblResult.Text = currentText;
            item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\춤추는고양이.gif");
            player1.Play();

            //player1 음악 시간에 맞춰 끝난 후 초기상태로 복귀하는 로직
            await Task.Delay(13000);
            initState();
            EnableButtons();
        }


        //놀아주기 버튼 로직
        private async void btnPlaying_Click(object sender, EventArgs e)
        {
            DisableButtons();
            currentText = "드가좌~~💘";
            lblResult.Text = currentText;
            happinessTime += 10;
            item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\좋아죽는고양이.gif");
            player2.PlayLooping();

            await Task.Delay(4000);
            lblResult.Text = "나 죽네 주인님...";
            initState();
            EnableButtons();
        }

        //먹이주기 버튼 로직
        private async void btnEat_Click(object sender, EventArgs e)
        {
            DisableButtons();
            currentText = "우마이~~~!!!!❤";
            lblResult.Text = currentText;
            hungryTime += 10;
            item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\당나기먹기.gif");
            player3.PlayLooping();

            await Task.Delay(4000);
            initState();
            EnableButtons();
        }


        //앱이 실행되면 카운트다운 시작
        public void countdownTime_tick(object sender, EventArgs e)
        {
            // 각 상태에 따라 감소
            happinessTime--;
            healthTime--;
            hungryTime--;

            // 각 상태에 따른 레이블 업데이트
            UpdateStatusLabels();


            if (happinessTime <= 0 || healthTime <= 0 || hungryTime <= 0)
            {
                countdownTime.Stop();
                lblResult.Text = "Boom!!!!!";
                lblHappiness.Text = "Boom!!!!!";
                lblHealth.Text = "Boom!!!!!";
                lblHungry.Text = "Boom!!!!!";
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\울분토하는고양이.gif");
                player5.PlayLooping();
                listBox.Items.Clear();
                txtInput.Text = "";
                MessageBox.Show("망할놈의 집사!!!!!!!!!!");
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\춤추는강아지.gif");
                happinessTime = 100;
                healthTime = 95;
                hungryTime = 85;
                lblResult.Text = "주인님~사랑해염";
                lblHappiness.Text = "좋음";
                lblHealth.Text = "좋음";
                lblHungry.Text = "배부름";
                initState();
                
               
                countdownTime.Start();
            }
        }
        private void UpdateStatusLabels()
        {
            if (happinessTime <= 130 && happinessTime > 80)
            {
                lblHappiness.Text = "좋음";
            }
            else if (happinessTime <= 80 && happinessTime > 60)
            {
                lblHappiness.Text = "보통";
            }
            else if (happinessTime <= 60 && happinessTime > 40)
            {
                lblHappiness.Text = "흐음..ㅡㅡ";
            }
            else if (happinessTime <= 40 && happinessTime > 20)
            {
                lblHappiness.Text = "우울해ㅡㅡ";
            }
            else
            {
                lblHappiness.Text = "폭발직전!!";
            }

            if (healthTime <= 125 && healthTime > 45)
            {
                lblHealth.Text = "좋음";
            }
            else if (healthTime <= 45 && healthTime > 30)
            {
                lblHealth.Text = "평범";
            }
            else if (healthTime <= 30 && healthTime > 20)
            {
                lblHealth.Text = "...크흠..";
            }
            else if (healthTime <= 20 && healthTime > 10)
            {
                lblHealth.Text = "근손실ㅡㅡ";
            }
            else
            {
                lblHealth.Text = "나죽네..";
            }

            if (hungryTime <= 100 && hungryTime > 80)
            {
                lblHungry.Text = "배부름";
            }
            else if (hungryTime <= 80 && hungryTime > 60)
            {
                lblHungry.Text = "보통";
            }
            else if (hungryTime <= 60 && hungryTime > 40)
            {
                lblHungry.Text = "배고플랑말랑..";
            }
            else if (hungryTime <= 40 && hungryTime > 39)
            {
                lblResult.Text = "나 죽네 주인님...";
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\아픈고양이.gif");
                player4.PlayLooping();
            }
            else if (hungryTime <= 39 && hungryTime > 15)
            {
                lblHungry.Text = "배고파ㅡㅡ";
 
            }
            else if (hungryTime <= 15 && hungryTime > 14)
            {
                item1.Image = new Bitmap(@"C:\kostafullstack\과제자료\C#\다마고치\MZgotchi\MZgotchi\Resources\폭력고양이.gif");
                player6.PlayLooping();
                lblResult.Text = "나 죽는다고 박집사야 ㅡㅡ!!!!!!!!!";
            }
            else if (hungryTime <= 14 && hungryTime > 10)
            {
                lblHungry.Text = "배고파ㅡㅡ";

            }
            else
            {
                lblHungry.Text = "쓰러지기직전..";
               
            }
        }


        //삭제버튼임
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("삭제할 아이템을 선택하세요.");
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtInput.Text == "준성" || txtInput.Text == "먹이" || txtInput.Text == "놀기" || txtInput.Text == "운동")
            {

                happinessTime += 5;
                healthTime += 5;
                hungryTime += 5;
                listBox.Items.Add("오늘의 할일 : " + txtInput.Text);
                txtInput.Text = "";
                lblResult.Text = "집사 사랑햇";
                await Task.Delay(2000);



                initState();


            }
            else
            {


                listBox.Items.Add("오늘의 할일 : " + txtInput.Text);
                txtInput.Text = "";
            }
            
        }
    }
}

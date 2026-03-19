using System;
using System.Windows.Forms;

namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 버튼 클릭 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // Enter 키 입력 이벤트
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // 삑 소리 방지
            }
        }

        // 메시지 전송 공통 로직
        private void SendMessage()
        {
            string message = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(message))
            {
                listBox1.Items.Add(message); // ListBox에 추가
                textBox1.Clear();            // TextBox 비우기
                textBox1.Focus();            // 커서 다시 TextBox로
                listBox1.TopIndex = listBox1.Items.Count - 1; // 자동 스크롤
            }
        }
    }
}

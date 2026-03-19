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
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        // Enter 키 전송 이벤트
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendMessage();
                e.SuppressKeyPress = true; // Enter 삑 소리 방지
            }
        }

        // 메시지 전송 로직
        private void SendMessage()
        {
            string message = textBoxInput.Text.Trim();

            // 4️⃣ 입력 방어: 빈 메시지나 공백만 있는 경우 전송 금지
            if (string.IsNullOrEmpty(message))
                return;

            // 1️⃣ ListBox에 메시지 추가
            listBoxMessages.Items.Add(message);

            // 2️⃣ 입력창 초기화
            textBoxInput.Clear();

            // 3️⃣ 포커스 유지
            textBoxInput.Focus();

            // ListBox 자동 스크롤
            listBoxMessages.TopIndex = listBoxMessages.Items.Count - 1;
        }
    }
}
namespace EchoMessenger
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Button buttonSend;
        private Label labelTitle;
        private ListBox listBoxMessages;
        private TextBox textBoxInput;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            buttonSend = new Button();
            labelTitle = new Label();
            listBoxMessages = new ListBox();
            textBoxInput = new TextBox();
            SuspendLayout();

            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(623, 357);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(87, 42);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "전송";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;

            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Location = new Point(88, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(110, 15);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Echo Messenger";

            // 
            // listBoxMessages
            // 
            listBoxMessages.FormattingEnabled = true;
            listBoxMessages.ItemHeight = 15;
            listBoxMessages.Location = new Point(88, 59);
            listBoxMessages.Name = "listBoxMessages";
            listBoxMessages.Size = new Size(622, 274);
            listBoxMessages.TabIndex = 2;

            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(88, 368);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(502, 23);
            textBoxInput.TabIndex = 3;
            textBoxInput.KeyDown += textBoxInput_KeyDown;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxInput);
            Controls.Add(listBoxMessages);
            Controls.Add(labelTitle);
            Controls.Add(buttonSend);
            Name = "Form1";
            Text = "EchoMessenger";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
namespace Cs_Assignment_2
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTypeMessageHere = new System.Windows.Forms.TextBox();
            this.gbxTitleTypeMessageHere = new System.Windows.Forms.GroupBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.gbxTitleConversation = new System.Windows.Forms.GroupBox();
            this.txtChatOutputWindow = new System.Windows.Forms.TextBox();
            this.gbxTitleTypeMessageHere.SuspendLayout();
            this.gbxTitleConversation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTypeMessageHere
            // 
            this.txtTypeMessageHere.Location = new System.Drawing.Point(6, 19);
            this.txtTypeMessageHere.Name = "txtTypeMessageHere";
            this.txtTypeMessageHere.Size = new System.Drawing.Size(686, 20);
            this.txtTypeMessageHere.TabIndex = 1;
            // 
            // gbxTitleTypeMessageHere
            // 
            this.gbxTitleTypeMessageHere.Controls.Add(this.btnSendMessage);
            this.gbxTitleTypeMessageHere.Controls.Add(this.txtTypeMessageHere);
            this.gbxTitleTypeMessageHere.Location = new System.Drawing.Point(13, 13);
            this.gbxTitleTypeMessageHere.Name = "gbxTitleTypeMessageHere";
            this.gbxTitleTypeMessageHere.Size = new System.Drawing.Size(779, 49);
            this.gbxTitleTypeMessageHere.TabIndex = 2;
            this.gbxTitleTypeMessageHere.TabStop = false;
            this.gbxTitleTypeMessageHere.Text = "Type your message here.";
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(698, 17);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(75, 23);
            this.btnSendMessage.TabIndex = 2;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // gbxTitleConversation
            // 
            this.gbxTitleConversation.Controls.Add(this.txtChatOutputWindow);
            this.gbxTitleConversation.Location = new System.Drawing.Point(13, 68);
            this.gbxTitleConversation.Name = "gbxTitleConversation";
            this.gbxTitleConversation.Size = new System.Drawing.Size(779, 439);
            this.gbxTitleConversation.TabIndex = 3;
            this.gbxTitleConversation.TabStop = false;
            this.gbxTitleConversation.Text = "Conversation";
            // 
            // txtChatOutputWindow
            // 
            this.txtChatOutputWindow.Location = new System.Drawing.Point(6, 20);
            this.txtChatOutputWindow.Multiline = true;
            this.txtChatOutputWindow.Name = "txtChatOutputWindow";
            this.txtChatOutputWindow.Size = new System.Drawing.Size(767, 413);
            this.txtChatOutputWindow.TabIndex = 0;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 519);
            this.Controls.Add(this.gbxTitleConversation);
            this.Controls.Add(this.gbxTitleTypeMessageHere);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.gbxTitleTypeMessageHere.ResumeLayout(false);
            this.gbxTitleTypeMessageHere.PerformLayout();
            this.gbxTitleConversation.ResumeLayout(false);
            this.gbxTitleConversation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTypeMessageHere;
        private System.Windows.Forms.GroupBox gbxTitleTypeMessageHere;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.GroupBox gbxTitleConversation;
        private System.Windows.Forms.TextBox txtChatOutputWindow;
    }
}


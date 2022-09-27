using System;

namespace Lesson11
{
    public class Message
    {
        public string Text { get; set; }
        public Message(string text) => Text = text;
    }
    class EmailMessage : Message
    {
        public EmailMessage(string text) : base(text) { }
    }

    interface IMessager<out T>
    {
        T WriteMessage(string text);
    }
    class EmailMessager : IMessager<EmailMessage>
    {
        public EmailMessage
    }
}
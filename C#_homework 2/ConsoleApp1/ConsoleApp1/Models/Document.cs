using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    public class Document : ISerchable
    {
        public string Text { get; set; }
    public Document (string text)
        {
            Text = text;
        }
        public bool Serch(string word)
        {
            return Text != null && Text.ToLower().Contains(word.ToLower());
        }
    }
}

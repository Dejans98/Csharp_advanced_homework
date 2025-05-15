using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Models
{
    public class WebPage : ISerchable
    {
        public string Content { get; set; }

        public WebPage(string content)
        {
            Content = content;
        }

        public bool Serch(string word)
        {
            return Content != null && Content.ToLower().Contains(word.ToLower());
        }


    }
}

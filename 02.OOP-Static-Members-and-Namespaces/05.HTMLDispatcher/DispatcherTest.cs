namespace _05.HTMLDispatcher
{
    using System;

    public static class Dispatcher
    {
        public static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            string url = HtmlDispatcher.CreateUrl("https://softuni.bg/", "SoftUni", "SoftUni.bg");
            string image = HtmlDispatcher.CreateImage("https://softuni.bg/Companies/Profile/Logo/69", "SoftUni logo", "Medium Logo");
            string input = HtmlDispatcher.CreateInput("text", "username", "user");

            Console.WriteLine(url);
            Console.WriteLine(image);
            Console.WriteLine(input);
        }
    }
}

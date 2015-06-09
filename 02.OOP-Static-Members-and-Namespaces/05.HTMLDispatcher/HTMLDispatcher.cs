namespace _05.HTMLDispatcher
{
    public static class HtmlDispatcher
    {
        public static string CreateImage(string imageSource, string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img");

            image.AddAttribute("src", imageSource);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);

            return image.ToString();
        }

        public static string CreateUrl(string url, string title, string text)
        {
            ElementBuilder urlElement = new ElementBuilder("a");

            urlElement.AddAttribute("href", url);
            urlElement.AddAttribute("title", title);
            urlElement.AddContent(text);

            return urlElement.ToString();
        }

        public static string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder input = new ElementBuilder("input");

            input.AddAttribute("type", inputType);
            input.AddAttribute("alt", name);
            input.AddAttribute("value", value);

            return input.ToString();
        }
    }
}

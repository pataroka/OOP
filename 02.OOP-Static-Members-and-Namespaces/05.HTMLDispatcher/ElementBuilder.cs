namespace _05.HTMLDispatcher
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ElementBuilder
    {
        private string name;

        public ElementBuilder(string name)
        {
            this.Name = name;
            this.Content = string.Empty;
            this.Attributes = new Dictionary<string, string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(string.Format("Value {0} not valid!", value));
                }

                this.name = value;
            }
        }

        public Dictionary<string, string> Attributes { get; set; }

        public string Content { get; set; }

        public static string operator *(ElementBuilder element, int count)
        {
            StringBuilder result = new StringBuilder();

            while (count > 0)
            {
                result.Append(element);
                count--;
            }

            return result.ToString();
        }

        public void AddAttribute(string attribute, string value)
        {
            if (string.IsNullOrEmpty(attribute))
            {
                throw new ArgumentNullException("attribute");
            }

            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("attribute");
            }

            this.Attributes.Add(attribute, value);
        }

        public void AddContent(string content)
        {
            this.Content += content;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("<{0}", this.Name);

            foreach (var pair in this.Attributes)
            {
                result.AppendFormat(" {0}=\"{1}\"", pair.Key, pair.Value);
            }

            result.AppendFormat(">{0}</{1}>", this.Content, this.Name);
            return result.ToString();
        }
    }
}
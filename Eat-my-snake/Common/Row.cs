﻿namespace EatMySnake.Core.Common
{
    public class Row
    {
        public Content Content { get; set; }
        private Except except;
        private AndOrState andOrState;

        public Row()
        {
            this.Content = Content.Empty;
            this.except = Except.No;
            this.andOrState = AndOrState.AndGrey;
        }

        public Row(Content content)
        {
            this.Content = content;
            this.except = Except.No;
            this.andOrState = AndOrState.AndGrey;
        }

        public Row(Content content, Except except, AndOrState andOrState)
        {
            this.Content = content;
            this.except = except;
            this.andOrState = andOrState;
        }

        public override int GetHashCode()
        {
            int a = (int)Content;
            if (except == Except.No)
            {
                return a;
            }
            //36 is a sum of fields in enum Content
            return 36 - a;
        }

        public override bool Equals(object obj)
        {
            Row row = (Row)obj;
            if (except == Except.No)
            {
                return Content == row.Content;
            }
            return Content != row.Content;
        }

        public override string ToString()
        {
            return Content.ToString();
        }
    }
}

namespace Ex01SchoolHierarchy
{
    using System;

    public abstract class SchoolObject
    {
        protected SchoolObject(string name)
        {
            this.Name = name;
        }

        protected SchoolObject(string name, string comments)
            : this(name)
        {
            this.Comments = comments;
        }

        public string Name { get; protected set; }

        public string Comments { get; protected set; }

        public void AddComment(string comment)
        {
            if (comment.Length < 200)
            {
                throw new ArgumentException("Comment must be at least 200 symbols :D"); 
            }

            this.Comments = comment;
        }

        public void RemoveComment()
        {
            this.Comments = string.Empty;
        }

        public override string ToString()
        {
            return this.GetType().Name + " " + this.Name;
        }
    }
}
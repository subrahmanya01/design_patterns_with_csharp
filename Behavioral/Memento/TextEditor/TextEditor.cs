namespace Behavioural.Memento.TextEditor
{
    internal class TextEditor
    {
        private string _content;
        public TextEditor()
        {
            
        }

        public void Type(string text)
        {
            _content += text;
            Console.WriteLine($"New text content written successfully {text}");
        }

        public string GetText()
        {
            return _content;
        }

        public TextEditorMemento Save()
        {
           return new TextEditorMemento(_content);
        }

        public void Restore(TextEditorMemento memento) {
            var text = memento.State();
            _content = text;
        }
    }
}

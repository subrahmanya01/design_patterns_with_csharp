namespace Behavioural.Memento.TextEditor
{
    internal class TextEditorMemento
    {
        private string _state =  string.Empty;

        public TextEditorMemento(string content)
        {
            _state = content;
        }

        public string State()
        {
            return _state;
        }
    }
}

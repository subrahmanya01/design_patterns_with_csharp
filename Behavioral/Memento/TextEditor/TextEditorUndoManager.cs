namespace Behavioural.Memento.TextEditor
{
    internal class TextEditorUndoManager
    {
        private Stack<TextEditorMemento> _texEditorMemento = new Stack<TextEditorMemento>();

        public void Save(TextEditor editor)
        {
            var editorMemento = editor.Save();
            _texEditorMemento.Push(editorMemento);
        }

        public void Undo(TextEditor editor)
        {
            if (_texEditorMemento.Count > 0)
            {
                var memento =  _texEditorMemento.Pop();
                editor.Restore(memento);
                return;
            }

            Console.WriteLine("No more element exist");
        }
    }
}

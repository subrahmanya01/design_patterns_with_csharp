using Behavioural.Memento.TextEditor;

var editor = new TextEditor();
var undoManager = new TextEditorUndoManager();

editor.Type("Hello");
undoManager.Save(editor);
Console.WriteLine($"Current text is : {editor.GetText()}");

editor.Type("Word");
undoManager.Save(editor);

Console.WriteLine($"Current text is : {editor.GetText()}");

undoManager.Undo(editor);
Console.WriteLine($"Current text is : {editor.GetText()}");

undoManager.Undo(editor);
Console.WriteLine($"Current text is : {editor.GetText()}");

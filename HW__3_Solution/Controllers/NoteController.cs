using HW__3_Solution.Entity;
using HW__3_Solution.Handlers;

namespace HW__3_Solution.Controllers
{
    public class NoteController
    {
        private List<Note> notes = new List<Note>();

        public void AddNote(Note note)
        {
            notes.Add(note);
        }

        public void RemoveNote(Note note) 
        { 
            notes.Remove(note);
        }

        public void ClearNotes()
        {
            notes.Clear();
        }

        public void AddListNote(List<Note> list)
        {
            notes.AddRange(list);
        }

        public List<string> GetListNoteNames() 
        { 
            List<string> notesNamelist = new List<string>();

            foreach (Note note in notes) 
            {
                if(!notesNamelist.Contains(note.NoteName)) 
                    notesNamelist.Add(note.NoteName);
            }
            return notesNamelist;
        }

        public void ShowInformation(IOutputHandler handler)
        {
            handler.Show(notes);
        }

        public void ShowInformationNoteNames(IOutputHandler handler)
        {
            handler.Show(this.GetListNoteNames());
        }

        public void SaveInformation(ISavingFileHandler handler) 
        { 
            handler.Save(notes);
        }

        public void LoadInformation(ISavingFileHandler handler)
        {
            notes = handler.Load();
        }

        public int GetCount()
        {
            return notes.Count;
        }
    }


}

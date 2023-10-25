namespace HW__3_Solution.Entity
{
    [Serializable]
    public class Note
    {
        public string NoteName { get; set; } 
        public string NoteText { get; set; }
        public DateTime DateCreation { get; set; }
        public List<string>? Tags { get; set; }

        public override string ToString()
        {
            return $"Название: {NoteName}\n" +
                   $"Текст заметки: {NoteText}\n" +
                   $"Дата: {DateCreation}\n" +
                   $"Теги: {(Tags is null ? string.Empty : string.Join(", ", Tags))}";
        }
    }
}

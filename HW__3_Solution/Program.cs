using HW__3_Solution.Controllers;
using HW__3_Solution.Entity;
using HW__3_Solution.Entitys;
using HW__3_Solution.Handlers;

Console.WriteLine("Задание 1--2\n");

NoteController noteController = new NoteController();

noteController.AddNote(new Note()
{
    NoteName = "Test",
    DateCreation = DateTime.Now,
    NoteText = "Test notes start this",
    Tags = new List<string>()
    {
        "test", "notes for test"
    }
});

noteController.AddNote(new Note()
{
    NoteName = "Test2",
    DateCreation = DateTime.Now,
    NoteText = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
    Tags = new List<string>()
    {
        "test", "New"
    }

});

noteController.AddNote(new Note()
{
    NoteName = "Test21",
    DateCreation = DateTime.Now.AddDays(-1),
    NoteText = "Test21-----1daysy",
    Tags = new List<string>()
    {
        "sadasd"
    }

});

noteController.AddNote(new Note()
{
    NoteName = "11Test21",
    DateCreation = DateTime.Now.AddDays(-12),
    NoteText = "Test12-----12daysy",
});

Console.WriteLine("\tВывод полной информации о всех заметках в консоль и файл Note.txt");
noteController.ShowInformation(new ConsoleOutputHandler());
noteController.ShowInformation(new TxtFileOutputHandler("Note.txt"));

Console.WriteLine("\n\tВывод информации о именах заметок в консоль и файл");
noteController.ShowInformationNoteNames(new ConsoleOutputHandler());
noteController.ShowInformationNoteNames(new TxtFileOutputHandler("NoteName.txt"));

Console.WriteLine("\tСохранение информации в разных форматах (Note.json)");
noteController.SaveInformation(new JsonSavingFileHandler("Note.json"));
noteController.ClearNotes();
Console.WriteLine($"Количество заметок в контроллере: {noteController.GetCount()}");

Console.WriteLine("\n\tЗагрузка информации из разных форматов (Note.json)");
noteController.LoadInformation(new JsonSavingFileHandler("Note.json"));
noteController.ShowInformation(new ConsoleOutputHandler());

Console.WriteLine("\n\tСохранение информации в разных форматах (Note.xml)");
noteController.SaveInformation(new XmlSavingFileHandler("Note.xml"));
noteController.ClearNotes();
Console.WriteLine($"Количество заметок в контроллере: {noteController.GetCount()}");

Console.WriteLine("\n\tЗагрузка информации из разных форматов (Note.xml)");
noteController.LoadInformation(new XmlSavingFileHandler("Note.xml"));
noteController.ShowInformation(new ConsoleOutputHandler());

////-------------------------------------------------------------------------------------------------------
///----------------------------------------Задание 3---4---------------------------------------------------
Console.WriteLine("\n\nДля отображение задание 3-4 нажмите любую клавишу");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Задание 3--4\n");
 
ContactController contactController = new ContactController();

contactController.AddContact(new Contact() { Name = "Василий Петрович", MobilePhone = "+380953337800" });
contactController.AddContact(new Contact() { Name = "George Kush", MobilePhone = "+182953337800", AltMobilePhone = "+1233394213", Email = "Gkush@mg.com", Description = "PR Director MFG" });
contactController.AddContact(new Contact() { Name = "Сергей Иванович", MobilePhone = "+380953337800" });

Console.WriteLine("\tВывод полной информации о всех контактах в консоль и файл Contact.txt");
contactController.ShowInformation(new ConsoleOutputHandler());
contactController.ShowInformation(new TxtFileOutputHandler("Contact.txt"));

Console.WriteLine("\n\tВывод информации о именах контактов в консоль и файл");
contactController.ShowInformationContactsNames(new ConsoleOutputHandler());
contactController.ShowInformationContactsNames(new TxtFileOutputHandler("ContactName.txt"));

Console.WriteLine("\tСохранение информации в разных форматах (Contact.json)");
contactController.SaveInformation(new JsonSavingFileHandler("Contact.json"));
contactController.ClearContacts();
Console.WriteLine($"Количество контактов в контроллере: {contactController.GetCount()}");

Console.WriteLine("\n\tЗагрузка информации из разных форматов (Contact.json)");
contactController.LoadInformation(new JsonSavingFileHandler("Contact.json"));
contactController.ShowInformation(new ConsoleOutputHandler());

Console.WriteLine("\n\tСохранение информации в разных форматах (Contact.xml)");
contactController.SaveInformation(new XmlSavingFileHandler("Contact.xml"));
contactController.ClearContacts();
Console.WriteLine($"Количество контактов в контроллере: {contactController.GetCount()}");

Console.WriteLine("\n\tЗагрузка информации из разных форматов (Contact.xml)");
contactController.LoadInformation(new XmlSavingFileHandler("Contact.xml"));
contactController.ShowInformation(new ConsoleOutputHandler());


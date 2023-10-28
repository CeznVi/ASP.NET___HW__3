using HW__3_Solution.Entity;
using HW__3_Solution.Entitys;
using System.Runtime;
using System.Text;

namespace HW__3_Solution.Handlers
{
    public interface IOutputHandler
    {
        public void Show(List<Note> notes);
        public void Show(List<string> strings);


        public void Show(List<Contact> contactsList);
    }

    public class ConsoleOutputHandler : IOutputHandler
    {
        public void Show(List<Note> notes)
        {
            foreach (var item in notes)
            {
                Console.WriteLine(item);
            }
        }

        public void Show(List<string> strings)
        {
           foreach(var item in strings)
           {
                Console.Write(item + "\n");
           }
           Console.WriteLine();
        }

        public void Show(List<Contact> contactsList)
        {
            foreach (var item in contactsList)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class TxtFileOutputHandler : IOutputHandler
    {
        private string _filePath;
        private string _defaultFilePath = "text.txt";

        public TxtFileOutputHandler()
        {
            _filePath = _defaultFilePath;
        }

        public TxtFileOutputHandler(string filePath)
        {
            _filePath = filePath;
        }

        public void Show(List<Note> notes)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false, Encoding.UTF8))
            {
                foreach (Note n in notes)
                {
                    sw.WriteLine(n);
                    sw.Write("\n");
                }
            }
        }

        public void Show(List<string> strings)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false, Encoding.UTF8))
            {
                foreach (string s in strings)
                {
                    sw.WriteLine(s);
                }
            }
        }

        public void Show(List<Contact> contactsList)
        {
            using (StreamWriter sw = new StreamWriter(_filePath, false, Encoding.UTF8))
            {
                foreach (Contact c in contactsList)
                {
                    sw.WriteLine(c);
                    sw.Write("\n");
                }
            }
        }
    }

}

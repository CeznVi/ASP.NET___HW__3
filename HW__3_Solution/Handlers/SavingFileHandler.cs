using HW__3_Solution.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW__3_Solution.Handlers
{
    public interface ISavingFileHandler
    {
        public void Save(List<Note> notes);
        public List<Note> Load();

    }

    public class JsonSavingFileHandler : ISavingFileHandler
    {
        private string _filePath;

        public JsonSavingFileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public List<Note> Load()
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Note>>(json);
        }

        public void Save(List<Note> objects)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };

            string json = JsonSerializer.Serialize(objects, options);
            File.WriteAllText(_filePath, json);
        }
    }

    public class XmlSavingFileHandler : ISavingFileHandler
    {
        private string _filePath;

        public XmlSavingFileHandler(string filePath)
        {
            _filePath = filePath;
        }

        public List<Note> Load()
        {
            List<Note> objects;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));
            using (FileStream fs = new FileStream(_filePath, FileMode.Open))
            {
                objects = (List<Note>)xmlSerializer.Deserialize(fs);
            }

            return objects;
        }

        public void Save(List<Note> objects)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Note>));
            
            using (FileStream fs = new FileStream(_filePath, FileMode.Create))
            {
                xmlSerializer.Serialize(fs, objects);
            }
        }
    }
}

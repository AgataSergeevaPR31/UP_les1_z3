using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP_lesson1_z3
{
    struct Song
    {
        public string author;
        public string title;
        public string filename;

        //конструктор структуры
        public Song(string author, string title, string filename)
        {
            this.author = author;
            this.title = title;
            this.filename = filename;
        }
    }
    internal class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }

        //Метод для получения текущей аудиозаписи
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException(
                    "Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        //Метод для добавления аудиозаписи
        public void AddSong(Song song)
        {
            list.Add(song);
        }

        // Перегрузка метода для добавления аудиозаписи
        public void AddSong(string author, string title, string filename)
        {
            Song song = new Song(author, title, filename);
            list.Add(song);
        }

        //количество элементов в плэйлисте
        public int Count => list.Count;

        //метод для перехода к следующей песне
        public void NextSong()
        {
            //проверка на то, что индекс не выходит за предел списка
            if (list.Count > 0 && currentIndex+1 < list.Count)
            {
                currentIndex = currentIndex + 1;
            }
        }
        //метод для перехода к предыдущей песне
        public void BeforeSong()
        {
            //проверка на то, что индекс не выходит за предел списка
            if (list.Count > 0 && currentIndex - 1 >= 0)
            {
                currentIndex = currentIndex - 1;
            }
        }

        //переход к песне по индексу
        public string Index(int index)
        {
            //проверяем, чо индекс внутри массива и меняем номер текущей песни на индекс
            if (index >= 0 && index < list.Count)
            {
                currentIndex = index;
                return "Пожалуйста! Слушайте!";
            }
            else return "Нет песни с таким номером!";
        }

        //переход к началу плэйлиста
        public void Start()
        {
            currentIndex = 0;
        }

        //удаление плэйлиста
        public void Clear()
        {
            list.Clear();
            currentIndex = 0;
        }

        //удаление песни №1
        public void RemoveSong(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                //если номер удалённой песни был последним, то меняем его на предыдущий, чтобы не ыбло ошибки 
                if (currentIndex >= list.Count) currentIndex = list.Count - 1;
            }
        }

        //удаление песни №2
        public void RemoveSong(Song song)
        {
            int index = list.IndexOf(song);
            if (index != -1)
            {
                list.RemoveAt(index);
                //если номер удалённой песни был последним, то меняем его на предыдущий, чтобы не ыбло ошибки 
                if (currentIndex >= list.Count) currentIndex = list.Count - 1;
            }
        }


    }
}

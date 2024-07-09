using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Book
    {
        public Book(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public string Name { set; get; }

        public string Author { set; get; }

        public string Genre { set; get; }

        public int Year { set; get; }

        public override string ToString()
        {
            return $"{Name} by {Author}, {Year}, {Genre}";
        }
    }
}

//Создайте приложение для учёта книг. Необходимо хранить следующую информацию:
//*Название книги
//* ФИО автора
//* Жанр книги
//* Год выпуска

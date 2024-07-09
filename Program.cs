using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            BookLinkedList booksForSummer = new BookLinkedList();
            booksForSummer.Add(
                new Book("To Kill a Mockingbird", "Harper Lee", "Fiction", 1960),
                new Book("1984", "George Orwell", "Dystopian", 1949),
                new Book("Pride and Prejudice", "Jane Austen", "Romance", 1813),
                new Book("Moby-Dick", "Herman Melville", "Adventure", 1851),
                new Book("The Catcher in the Rye", "J.D. Salinger", "Fiction", 1951),
                new Book("Brave New World", "Aldous Huxley", "Dystopian", 1932),
                new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy", 1937),
                new Book("War and Peace", "Leo Tolstoy", "Historical", 1869),
                new Book("Crime and Punishment", "Fyodor Dostoevsky", "Psychological Fiction", 1866)
            );
            foreach (var book in booksForSummer)
            {
                Console.WriteLine(book);
            }
            //booksForSummer.Delete(x => x.Author == "George Orwell");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var book in booksForSummer)
            //{
            //    Console.WriteLine(book);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //var temp = booksForSummer.FindBook(x => x.Year == 1851);
            //booksForSummer.Edit(x => x.Year == 1851, new Book("Moby     Dick", temp.Author, temp.Genre, temp.Year));


            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var book in booksForSummer)
            //{
            //    Console.WriteLine(book);
            //}
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            booksForSummer.AddToPosition(1, new Book("The Great Gatsby", "F. Scott Fitzgerald", "Fiction", 1925));

            foreach (var book in booksForSummer)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            booksForSummer.DeleteFromPosition(1);

            foreach (var book in booksForSummer)
            {
                Console.WriteLine(book);
            }
        }
    }
}

//Создайте приложение для учёта книг. Необходимо хранить следующую информацию:
//* Название книги
//* ФИО автора
//* Жанр книги
//* Год выпуска
//Для хранения книг используйте класс LinkedList<T>.
//Приложение должно предоставлять такую функциональность:
//* Добавление книг
//* Удаление книг
//* Изменение информации о книгах
//* Поиск книг по параметрам
//* Вставка книги в начало списка
//* Вставка книги в конец списка
//* Вставка книги в определенную позицию
//* Удаление книги из начала списка
//* Удаление книги из конца списка
//* Удаление книги из определенной позиции
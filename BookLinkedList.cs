using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class BookLinkedList : IEnumerable<Book>
    {
        LinkedList<Book> _books = new LinkedList<Book>();

        public LinkedListNode<Book> FirstNode { private set; get; }

        public BookLinkedList(params Book[] books) => Add(books);

        public Book this[int index]
        {
            get
            {
                if(_books.Count == 0)
                {
                    throw new ArgumentNullException("There are no books");
                }
                int i = 0;
                LinkedListNode<Book> currentNode = _books.First;
                while (i < index)
                {
                    currentNode = currentNode.Next;
                    i++;
                }
                return currentNode.Value;
            }
        }

        public void Add(params Book[] books)
        {
            if(books == null)
            {
                throw new ArgumentNullException("There are no books to add");
            }
            foreach (var book in books)
            {
                _books.AddLast(book);
            }
        }

        public void Delete(Predicate<Book> searchPredicate)
        {
            LinkedListNode<Book> currentNode = _books.First;
            while (currentNode != null)
            {
                if(searchPredicate(currentNode.Value))
                {
                    _books.Remove(currentNode); 
                }    
                currentNode = currentNode.Next;
            }
        }

        public BookLinkedList FindSomeBooks(Predicate<Book> searchPredicate)
        {
            BookLinkedList temp = new BookLinkedList();
            LinkedListNode<Book> currentNode = _books.First;
            while (currentNode != null)
            {
                if (searchPredicate(currentNode.Value))
                {
                    temp.Add(currentNode.Value);
                }
                currentNode = currentNode.Next;
            }
            if (temp._books.Count != 0) return temp;
            throw new ArgumentException("The books are not found");
        }

        public Book FindBook(Predicate<Book> searchPredicate)
        {

            LinkedListNode<Book> currentNode = _books.First;
            while (currentNode != null)
            {
                if (searchPredicate(currentNode.Value))
                {
                    return currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            throw new ArgumentException("The book is not found");
        }

        // можно перегрузить метод для всех полей, или лучше поменять книгу целеком?
        // таким образом при изменении класса книги не будет жесткой привязки к полям этого класса
        // а с одной стороны предикат позволяет нам подобрать параметры для нескольких книг и тогда мы поменяем их всех
        // с другой стороный есть метод Find, который возвращает список книг и оттуда мы можем вытащить одну конкретную,
        // получить доступ к ее полям и перезаписать поверх тоже самое
        public void Edit(Predicate<Book> searchPredicate, Book NewBook)
        {
            LinkedListNode<Book> currentNode = _books.First;
            while (currentNode != null)
            {
                if (searchPredicate(currentNode.Value))
                {
                    currentNode.Value = NewBook;
                }
                currentNode = currentNode.Next;
            }
        }

        public void AddFirst(Book book) => _books.AddFirst(book);

        public void AddLast(Book book) => _books.AddLast(book);

        public void DeleteLast() => _books.RemoveLast();

        public void DeleteFirst() => _books.RemoveFirst();

        public IEnumerator<Book> GetEnumerator() => _books.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public void AddToPosition(int position, Book book)
        {
            if(position > _books.Count || position < 0)
            {
                throw new IndexOutOfRangeException();
            }
            var current = _books.First;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.Next;
            }
            _books.AddAfter(current, book);
        }

        public void DeleteFromPosition(int position)
        {
            if (position > _books.Count || position < 0)
            {
                throw new IndexOutOfRangeException();
            }
            var current = _books.First;
            for (int i = 0; i < position - 1; i++)
            {
                current = current.Next;
            }
            _books.Remove(current);
        }
    }
}

//Приложение должно предоставлять такую функциональность:
//* Добавление книг + 
//* Удаление книг + 
//* Изменение информации о книгах +
//* Поиск книг по параметрам +
//* Вставка книги в начало списка +
//* Вставка книги в конец списка +
//* Вставка книги в определенную позицию
//* Удаление книги из начала списка +
//* Удаление книги из конца списка +
//* Удалениеs книги из определенной позиции 
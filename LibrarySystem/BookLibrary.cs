using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.LibrarySystem
{
    public static class BookLibrary
    {
        public static List<Dictionary<string, string>> ListOfBooks = new List<Dictionary<string, string>>()
        {
            // Romance
                    new Dictionary<string, string>
                    {
                        {"id", "01"},
                        {"title", "Pride and Prejudice"},
                        {"author", "Jane Austen"},
                        {"publicationYear", "1813"},
                        {"genre", "Romance"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "02"},
                        {"title", "Romeo and Juliet"},
                        {"author", "William Shakespeare"},
                        {"publicationYear", "1597"},
                        {"genre", "Romance"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "03"},
                        {"title", "Outlander"},
                        {"author", "Diana Gabaldon"},
                        {"publicationYear", "1991"},
                        {"genre", "Romance"},
                        {"status", "AVAILABLE"}
                    },

                    // Science Fiction
                    new Dictionary<string, string>
                    {
                        {"id", "04"},
                        {"title", "Dune"},
                        {"author", "Frank Herbert"},
                        {"publicationYear", "1965"},
                        {"genre", "Science Fiction"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "05"},
                        {"title", "Ender's Game"},
                        {"author", "Orson Scott Card"},
                        {"publicationYear", "1985"},
                        {"genre", "Science Fiction"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "06"},
                        {"title", "Neuromancer"},
                        {"author", "William Gibson"},
                        {"publicationYear", "1984"},
                        {"genre", "Science Fiction"},
                        {"status", "AVAILABLE"}
                    },

                    // Mystery
                    new Dictionary<string, string>
                    {
                        {"id", "07"},
                        {"title", "The Girl with the Dragon Tattoo"},
                        {"author", "Stieg Larsson"},
                        {"publicationYear", "2005"},
                        {"genre", "Mystery"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "08"},
                        {"title", "Gone Girl"},
                        {"author", "Gillian Flynn"},
                        {"publicationYear", "2012"},
                        {"genre", "Mystery"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "09"},
                        {"title", "The Da Vinci Code"},
                        {"author", "Dan Brown"},
                        {"publicationYear", "2003"},
                        {"genre", "Mystery"},
                        {"status", "AVAILABLE"}
                    },

                    // Fantasy
                    new Dictionary<string, string>
                    {
                        {"id", "10"},
                        {"title", "The Hobbit"},
                        {"author", "J.R.R. Tolkien"},
                        {"publicationYear", "1937"},
                        {"genre", "Fantasy"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "11"},
                        {"title", "Harry Potter and the Sorcerer's Stone"},
                        {"author", "J.K. Rowling"},
                        {"publicationYear", "1997"},
                        {"genre", "Fantasy"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "12"},
                        {"title", "The Name of the Wind"},
                        {"author", "Patrick Rothfuss"},
                        {"publicationYear", "2007"},
                        {"genre", "Fantasy"},
                        {"status", "AVAILABLE"}
                    },

                    // Non-Fiction
                    new Dictionary<string, string>
                    {
                        {"id", "13"},
                        {"title", "Sapiens: A Brief History of Humankind"},
                        {"author", "Yuval Noah Harari"},
                        {"publicationYear", "2014"},
                        {"genre", "Non-Fiction"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "14"},
                        {"title", "The Immortal Life of Henrietta Lacks"},
                        {"author", "Rebecca Skloot"},
                        {"publicationYear", "2010"},
                        {"genre", "Non-Fiction"},
                        {"status", "AVAILABLE"}
                    },
                    new Dictionary<string, string>
                    {
                        {"id", "15"},
                        {"title", "Educated"},
                        {"author", "Tara Westover"},
                        {"publicationYear", "2018"},
                        {"genre", "Non-Fiction"},
                        {"status", "AVAILABLE"}
                    }
         };


        public static List<Dictionary<string, string>> getTotalBookList()
        {
            return ListOfBooks;
        }

        public static List<Dictionary<string, string>> FindBooksByStatus(string status)
        {
            return ListOfBooks.FindAll(book => book.ContainsKey("status") && book["status"] == status);
        }

<<<<<<< HEAD
        public Dictionary<string, string> FindBooksByID(string id)
        {
            return ListOfBooks.Find(book => book["status"] == "RENTED" && book["id"] == id);
        }

        public bool RentBook(string id, List<Dictionary<string, string>> avaiableBooks)
=======
        public static Dictionary<string, string> FindBooksByID(string id)
        {
            return ListOfBooks.Find(book => book["id"] == id);
        }

        public static bool RentBook(string id, List<Dictionary<string, string>> avaiableBooks)
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        {
            Dictionary<string, string> bookToRent = avaiableBooks.Find(book => book.ContainsKey("id") && book["id"] == id);

            if (bookToRent != null && bookToRent["status"] == "AVAILABLE")
            {
                bookToRent["status"] = "RENTED";
                return true;
            }
            return false;

        }

        public static bool ReturnBook(string id, List<Dictionary<string, string>> avaiableBooks)
        {
            Dictionary<string, string> bookToReturn = avaiableBooks.Find(book => book.ContainsKey("id") && book["id"] == id);

            if (bookToReturn != null && bookToReturn["status"] == "RENTED")
            {
                bookToReturn["status"] = "AVAIABLE";
                return true;
            }
            return false;
        }

<<<<<<< HEAD
        public List<Dictionary<string, string>> searchByTitle(string title)
=======
        public static List<Dictionary<string, string>> searchByTitle(string title)
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        {
            var result = ListOfBooks
                .Where(book => book["title"].ToLower().Contains(title.ToLower()))
                .ToList();

<<<<<<< HEAD
            return result;
        }

        public List<Dictionary<string, string>> searchByAuthor(string author)
=======
            if (result.Any())
            {
                return result;
            }

            return null;
            
        }
        

        public static List<Dictionary<string, string>> searchByAuthor(string author)
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        {
            var result = ListOfBooks
                .Where(book => book["author"].ToLower().Contains(author.ToLower()))
                .ToList();

            if (result.Any())
            {
                return result;
            }
<<<<<<< HEAD
            else
            {
                var noResultsBook = new Dictionary<string, string>
            {
                {"id", "N/A"},
                {"title", "No books found"},
                {"author", ""},
                {"publicationYear", ""},
                {"genre", ""},
                {"status", "N/A"}
            };

                return new List<Dictionary<string, string>> { noResultsBook };
            }
        }


        public List<Dictionary<string, string>> searhchByGenre(string genre)
=======
                return null;
        }


        public static List<Dictionary<string, string>> searchByGenre(string genre)
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e
        {
            var result = ListOfBooks
                .Where(book => book.ContainsKey("genre") && book["genre"] == genre)
                .ToList();

<<<<<<< HEAD
            return result;
        }



=======
            if (result.Any())
            {
                return result;
            }
            return null;
        }
>>>>>>> 528215f782b2cde631b02ea4009dd90422dbcf7e

    }

}

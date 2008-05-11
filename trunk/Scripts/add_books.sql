INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Герой нашего времени" FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Герой нашего времени" AND 
	             persons.name = "Михаил" AND 
		        persons.surname = "Лермонтов";
-------------------------------------------------------	  

INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "На краю Ойкумены"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="На краю Ойкумены" AND 
	             persons.name = "Иван" AND 
		        persons.surname = "Ефремов";
-------------------------------------------------------			

INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Евгений Онегин"  FROM books;	
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Евгений Онегин" AND 
	             persons.name = "Александр" AND 
		        persons.surname = "Пушкин";	    
-------------------------------------------------------	
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Капитанская дочка"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Капитанская дочка" AND 
	             persons.name = "Александр" AND 
		        persons.surname = "Пушкин";
-------------------------------------------------------				
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Поколение П"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Поколение П" AND 
	             persons.name = "Виктор" AND 
		        persons.surname = "Пелевин";		
-------------------------------------------------------
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Синий фонарь"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Синий фонарь" AND 
	             persons.name = "Виктор" AND 
		        persons.surname = "Пелевин";					
-------------------------------------------------------
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "Час быка"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="Час быка" AND 
	             persons.name = "Иван" AND 
		        persons.surname = "Ефремов";					
			

	    
	    
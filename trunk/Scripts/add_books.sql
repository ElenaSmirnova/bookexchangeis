INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "����� ������ �������" FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="����� ������ �������" AND 
	             persons.name = "������" AND 
		        persons.surname = "���������";
-------------------------------------------------------	  

INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "�� ���� ��������"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="�� ���� ��������" AND 
	             persons.name = "����" AND 
		        persons.surname = "�������";
-------------------------------------------------------			

INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "������� ������"  FROM books;	
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="������� ������" AND 
	             persons.name = "���������" AND 
		        persons.surname = "������";	    
-------------------------------------------------------	
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "����������� �����"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="����������� �����" AND 
	             persons.name = "���������" AND 
		        persons.surname = "������";
-------------------------------------------------------				
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "��������� �"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="��������� �" AND 
	             persons.name = "������" AND 
		        persons.surname = "�������";		
-------------------------------------------------------
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "����� ������"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="����� ������" AND 
	             persons.name = "������" AND 
		        persons.surname = "�������";					
-------------------------------------------------------
INSERT INTO books  (id_books, id_book_status, name)
            SELECT COUNT(*), 1, "��� ����"  FROM books;
INSERT INTO r_books_authors  (id_books, id_author)
            SELECT id_books, id_persons
	       FROM books, persons
	       WHERE books.name="��� ����" AND 
	             persons.name = "����" AND 
		        persons.surname = "�������";					
			

	    
	    
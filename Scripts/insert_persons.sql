INSERT INTO [persons] (id_persons, name, surname)
            SELECT COUNT(*)+1 , "Иван", "Ефремов" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];
---------------------------------------------------------------------
INSERT INTO [persons] (id_persons, name, surname, middle_name)
            SELECT COUNT(*)+1 , "Александр", "Пушкин", "Сергеевич" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];	    
---------------------------------------------------------------------
INSERT INTO [persons] (id_persons, name, surname, middle_name)
            SELECT COUNT(*)+1 , "Михаил", "Лермонтов", "Юрьевич" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];	
---------------------------------------------------------------------	    
INSERT INTO [persons] (id_persons, name, surname)
               SELECT COUNT(*)+1 , "Анна", "Ахматова" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];		       
---------------------------------------------------------------------	    
INSERT INTO [persons] (id_persons, name, surname)
               SELECT COUNT(*)+1 , "Виктор", "Пелевин" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];		       




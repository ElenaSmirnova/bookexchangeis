INSERT INTO [persons] (id_persons, name, surname)
            SELECT COUNT(*)+1 , "����", "�������" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];
---------------------------------------------------------------------
INSERT INTO [persons] (id_persons, name, surname, middle_name)
            SELECT COUNT(*)+1 , "���������", "������", "���������" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];	    
---------------------------------------------------------------------
INSERT INTO [persons] (id_persons, name, surname, middle_name)
            SELECT COUNT(*)+1 , "������", "���������", "�������" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];	
---------------------------------------------------------------------	    
INSERT INTO [persons] (id_persons, name, surname)
               SELECT COUNT(*)+1 , "����", "��������" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];		       
---------------------------------------------------------------------	    
INSERT INTO [persons] (id_persons, name, surname)
               SELECT COUNT(*)+1 , "������", "�������" FROM persons;
INSERT INTO [authors]  (id_author)
            SELECT COUNT(*) FROM [persons];		       




INSERT INTO [persons] (id_persons, name)
            SELECT COUNT(*)+1 , "Администратор" FROM persons;
INSERT INTO [users] (id_user,id_roles, user_status_id, log, pass)
            SELECT COUNT(*), 1, 1, 'admin', 'admin' FROM persons;



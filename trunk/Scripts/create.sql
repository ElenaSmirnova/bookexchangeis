CREATE TABLE authors (
       id_author            Integer NOT NULL
);

ALTER TABLE authors
       ADD PRIMARY KEY (id_author);


CREATE TABLE book_estimations (
       id_book_estimation   Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE book_estimations
       ADD PRIMARY KEY (id_book_estimation);


CREATE TABLE book_requests (
       id_book_requests     Integer NOT NULL,
       id_request_status    Integer NOT NULL,
       id_books             Integer NOT NULL,
       id_user              Integer NOT NULL,
       id_book_estimation   Integer NULL
);


ALTER TABLE book_requests
       ADD PRIMARY KEY (id_book_requests);


CREATE TABLE book_status (
       id_book_status       Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE book_status
       ADD PRIMARY KEY (id_book_status);


CREATE TABLE books (
       id_books             Integer NOT NULL,
       id_book_status       Integer NOT NULL,
       name                 Text(20) NULL,
       published            Date NULL,
       publishing_house     Text(20) NULL
);


ALTER TABLE books
       ADD PRIMARY KEY (id_books);


CREATE TABLE persons (
       id_persons           Integer NOT NULL,
       name                 Text(20) NULL,
       surname              Text(18) NULL,
       middle_name          Text(18) NULL
);


ALTER TABLE persons
       ADD PRIMARY KEY (id_persons);


CREATE TABLE r_books_authors (
       id_books             Integer NOT NULL,
       id_author            Integer NOT NULL
);


ALTER TABLE r_books_authors
       ADD PRIMARY KEY (id_books, id_author);


CREATE TABLE r_roles_rights (
       id_rights            Integer NOT NULL,
       id_roles             Integer NOT NULL
);


ALTER TABLE r_roles_rights
       ADD PRIMARY KEY (id_rights, id_roles);


CREATE TABLE request_status (
       id_request_status    Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE request_status
       ADD PRIMARY KEY (id_request_status);


CREATE TABLE rights (
       id_rights            Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE rights
       ADD PRIMARY KEY (id_rights);


CREATE TABLE roles (
       id_roles             Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE roles
       ADD PRIMARY KEY (id_roles);


CREATE TABLE user_status (
       user_status_id       Integer NOT NULL,
       name                 Text(20) NULL
);


ALTER TABLE user_status
       ADD PRIMARY KEY (user_status_id);


CREATE TABLE users (
       user_status_id       Integer NOT NULL,
       id_roles             Integer NOT NULL,
       id_user              Integer NOT NULL,
       log                  Text(20) NULL,
       pass                 Text(20) NULL
);


ALTER TABLE users
       ADD PRIMARY KEY (id_user);


ALTER TABLE authors
       ADD FOREIGN KEY (id_author)
                             REFERENCES persons  (id_persons);


ALTER TABLE book_requests
       ADD FOREIGN KEY (id_book_estimation)
                             REFERENCES book_estimations  (
              id_book_estimation)
                             ON DELETE SET NULL;


ALTER TABLE book_requests
       ADD FOREIGN KEY (id_user)
                             REFERENCES users  (id_user);


ALTER TABLE book_requests
       ADD FOREIGN KEY (id_books)
                             REFERENCES books  (id_books);


ALTER TABLE book_requests
       ADD FOREIGN KEY (id_request_status)
                             REFERENCES request_status  (
              id_request_status);


ALTER TABLE books
       ADD FOREIGN KEY (id_book_status)
                             REFERENCES book_status  (id_book_status);


ALTER TABLE r_books_authors
       ADD FOREIGN KEY (id_books)
                             REFERENCES books  (id_books);


ALTER TABLE r_books_authors
       ADD FOREIGN KEY (id_author)
                             REFERENCES authors  (id_author);


ALTER TABLE r_roles_rights
       ADD FOREIGN KEY (id_roles)
                             REFERENCES roles  (id_roles);


ALTER TABLE r_roles_rights
       ADD FOREIGN KEY (id_rights)
                             REFERENCES rights  (id_rights);


ALTER TABLE users
       ADD FOREIGN KEY (id_user)
                             REFERENCES persons  (id_persons);


ALTER TABLE users
       ADD FOREIGN KEY (id_roles)
                             REFERENCES roles  (id_roles);


ALTER TABLE users
       ADD FOREIGN KEY (user_status_id)
                             REFERENCES user_status  (user_status_id);


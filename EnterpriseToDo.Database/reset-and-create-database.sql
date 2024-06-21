DROP DATABASE IF EXISTS "EnterpriseToDo";

CREATE DATABASE "EnterpriseToDo"
    WITH
    OWNER = postgres
	TEMPLATE = template0
    ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.utf8'
    LC_CTYPE = 'en_US.utf8'
    CONNECTION LIMIT = -1;
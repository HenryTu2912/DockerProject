CREATE TABLE IF NOT EXISTS "Items"
(
    "Id" varchar(256) NOT NULL PRIMARY KEY,
    "Name" varchar(256) NOT NULL,
    "Price" real NOT NULL
);
CREATE TABLE IF NOT EXISTS "Users"
(
    "Id" varchar(256) NOT NULL PRIMARY KEY,
    "Username" varchar(256) NOT NULL,
    "Password" varchar(256) NOT NULL
);

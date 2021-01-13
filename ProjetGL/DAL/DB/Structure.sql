drop table if exists `user`;
drop table if exists album;
drop table if exists genre;
drop table if exists category;
drop table if exists author;
drop table if exists series;
drop table if exists user_album;
drop table if exists album_author;
drop table if exists album_genre;
drop table if exists user_like_album;
drop table if exists user_own_album;
drop table if exists user_wish_album;

create table `user` (
    user_id integer not null primary key auto_increment,
    user_last_name varchar(100) not null,
    user_first_name varchar(100) not null,
	user_mail varchar(100) not null,
	user_privilege integer,
	user_hash varchar(100)
);

create table album (
	album_id integer not null primary key auto_increment,
	album_title varchar(200) not null,
	album_isbn varchar(200) not null,
	album_publisher varchar(200) not null,
	album_description text,
	category_id integer not null,
	series_id integer,
	cover blob not null
);

create table genre (
	genre_id integer not null primary key auto_increment,
	genre_name varchar(200) not null
);

create table category (
	category_id integer not null primary key auto_increment,
	category_name varchar(200) not null
);

create table author (
	author_id integer not null primary key auto_increment,
	author_name varchar(200) not null
);

create table series (
	series_id integer not null primary key auto_increment,
	series_name varchar(200) not null
);

create table album_genre (
	id integer not null primary key auto_increment,
	album_id integer not null,
	genre_id integer not null
);

create table album_author (
	id integer not null primary key auto_increment,
	album_id integer not null,
	author_id integer not null
);

create table user_own_album (
	id integer not null primary key auto_increment,
	album_id integer not null,
	user_id integer not null,
);

create table user_wish_album (
	id integer not null primary key auto_increment,
	album_id integer not null,
	user_id integer not null,
);

create table user_like_album (
	id integer not null primary key auto_increment,
	album_id integer not null,
	user_id integer not null,
);
drop table if exists `user`;
drop table if exists album;
drop table if exists genre;
drop table if exists category;
drop table if exists author;
drop table if exists publisher;
drop table if exists series;

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
	album_release_date datetime not null,
	album_title varchar(200) not null,
	album_isbn varchar(200) not null,
	album_publisher varchar(200) not null,
	album_series varchar(200) not null,
	album_cover blob not null,
	category_id integer not null,
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
	album_id integer not null
	genre_id integer not null
);

create table user_album (
	id integer not null primary key auto_increment,
	album_id integer not null,
	user_id integer not null,
	user_own boolean not null,
	user_wish boolean not null,
	user_like boolean not null
);
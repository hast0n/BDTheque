create database if not exists albums character set utf8 collate utf8_unicode_ci;
use albums;

grant all privileges on albums.* to 'albums_user'@'localhost' identified by 'secret';
create database Kutuphane

/* ilk baþta sadece üstteki komutu çalýþtýr, 
yoksa alt satýrda Kutuphane adýnda database bulunamadý diyor*/

use Kutuphane

create table Books(
barcode_id int primary key identity(1,1) not null,
author nvarchar(30) not null,
book_name nvarchar(30) not null,
page_count int,
shelf_no int,
book_count int not null)

create table Members(
member_id int primary key identity(1,1) not null,
name nvarchar(30),
surname nvarchar(30),
email nvarchar(50),
tel nvarchar(15))

create table Deliveries(
delivery_id int primary key identity(1,1) not null,
member_id int not null,
member_name nvarchar(30),
member_tel nvarchar(15),
barcode_id int not null,
book_author nvarchar(30) not null,
book_name nvarchar(30) not null,
delivery_date datetime not null,
return_date datetime not null,
is_returned bit not null)
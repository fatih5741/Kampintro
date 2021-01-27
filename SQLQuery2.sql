--Select (Seç)
--ANSII

select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers -- Kolon adlarına Alias verme

Select * from Customers where City = 'Berlin'

--case insensitive Büyük Küçük harf duyarsız bir dildir SQL
select * from Products where CategoryID = 1 or CategoryID = 3

select * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by UnitPrice asc --ascending
select * from Products where CategoryID=1 order by UnitPrice desc --descending

select count(*) from Products
select count(*) Adet from Products where CategoryID = 2

select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID -- inner join iki tabloyu ilişkilendirir.
where Products.UnitPrice>10

-- DTO - Data Transformation Object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID -- left join ürünler tablosunda olup sipariş detayları tablosunda olmayanlarıda getir

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null 

select * from Products p inner join [Order Details] od on p.ProductID = od.ProductID inner join Orders o on o.OrderID = od.OrderID
--Select
Select ContactName Adi, CompanyName SirketAdi, City Sehir from Customers

Select * from Customers where City = 'London'

--case insensitive
Select * from Products where categoryId = 1 or categoryId = 3

Select * from Products where categoryId = 1 and UnitPrice >= 10

select * from Products where categoryId = 1 order by UnitPrice desc -- ascending, artan demek. descending azalan demek.

Select count(*) from Products where CategoryId = 2 -- Category ID'sinin 2 olan ürünlerin sayısını göster.

Select categoryID, count(*) from products where UnitPrice > 20 group by CategoryID having count(*) < 10 -- bana içerisinden ürün fiyatı 20'den büyük olan, 10 taneden az ürün olan kategorileri ver demek.

Select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

-- inner join, sadece iki adet eşlesen datayı getirir. Eşleşmeyen data varsa onu getirmez.


--DTO Data Transformation Object

Select * from Products p left join [Order Details] od  -- p, Products'ın kısaltması. OD Order details kısaltması. left join, solda olup, sağda olmayanları da getir demek.
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

Select * from Customers c left join Orders o
on c.CustomerId = o.CustomerID
where o.CustomerID is null

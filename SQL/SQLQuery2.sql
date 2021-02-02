--Select
Select ContactName Adi,CompanyName as SireketAdi,City Sehir from Customers

Select * from Customers where City='Berlin'

--SQL case insensiteve -> büyük küçük harf duyarsız
Select * from Products where CategoryID=2 or CategoryID=3

--UnitPrice<>10 sorgusunda '<>' işlemi 10 olmayan demek
Select * from Products where CategoryID=1 and UnitPrice<>18

select * from Products order by ProductName,ProductID asc

select * from Products where CategoryID=3 order by UnitPrice desc

Select count(*) as Adet from Products where CategoryID=1

select CategoryID,count(*) as Adet from Products group by CategoryID

--Kategorisi adet sayısı 10 taneden az olanları getir.
select CategoryID,count(*) as Adet from Products group by CategoryID having count(*)<6

select CategoryID,count(*) as Adet from Products where UnitPrice>20 group by CategoryID having count(*)<6

select * from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10

--left join p de olup od de olmayanlarıda geti demek
select * from Products as p left join [Order Details] as od on p.ProductID=od.ProductID 

--Satılmayan ürünleri bulmak için aşağıdaki gibi işlem yapabiliriz.
select * from Customers c inner join Orders o on c.CustomerID=o.CustomerID
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID

--sisteme kayıt olmuş ama bizden ürün almamış kişileri getir
select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

select * from Customers c inner join Orders o on c.CustomerID=o.CustomerID inner join [Order Details] od on o.OrderID=od.OrderID
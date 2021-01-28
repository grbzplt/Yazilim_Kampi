using System;

namespace Ders06_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
            --Select
Select CompanyName Sirketadi,City Sehir from Customers

Select *from Customers where City = 'London'

Select* from Products where CategoryID = 1 or CategoryID = 3
Select* from Products where CategoryID = 1 and SupplierID = 1
Select* from Products where CategoryID = 1 and UnitPrice>= 10

Select ProductName, CategoryID from Products order by ProductName, CategoryID
Select ProductName, CategoryID from Products order by CategoryID, ProductName
Select ProductName, CategoryID, UnitPrice from Products where CategoryID = 1 order by UnitPrice desc

Select count(*) from Products
--Select count(*),ProductName from Products--HATA
Select count(*) Adet from Products where CategoryID = 7

Select CategoryID, count(*) Adet from Products group by CategoryID
Select categoryID, count(*) Adet from Products group by CategoryID having count(*) < 10
Select categoryID, count(*) Adet from Products where UnitPrice > 20 group by CategoryID having count(*) < 10

select*
from products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID
from products inner join Categories
on Products.CategoryID = Categories.CategoryID

select Products.ProductID,Products.ProductName
from products inner join Categories
on Products.CategoryID = Categories.CategoryID

--DTO Data Transformation Object

select Products.ProductID,Products.ProductName,Products.UnitPrice
from products inner join Categories
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice > 10

select* from products p inner join[Order Details] od
on p.ProductID = od.ProductID

select* from products p left join[Order Details] od
on p.ProductID = od.ProductID

select* from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

select* from Customers c left join Orders o
on c.CustomerID = o.CustomerID

select* from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select* from products p inner join[Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID
             */

            Console.WriteLine("Hello World!");
        }
    }
}

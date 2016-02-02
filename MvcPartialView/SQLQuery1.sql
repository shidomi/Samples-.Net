
alter procedure CustomerCollectionByName
@id int
AS
	select 
		id [ID], 
		name [Name]
	from 
		Customers [Customer]
	where
		id = @id
for xml auto, elements, root('CustomerCollection');
	
select * from OrderedItem

alter procedure OrderedItemCollection
AS
	select 
		ItemName [ItemName], 
		Descriptions [Description],
		Quantity [Quantity]
	from 
		OrderedItem [OrderedItem]
for xml auto, elements, root('OrderedItemCollection');

OrderedItemCollection

insert into OrderedItem (ItemName, Descriptions, Quantity) values ('test', 'test', 1)


alter procedure CustomerCollectionByName
@name varchar(255)
AS
	select 
		id [ID],
		name [Name]
	from 
		Customers [Customer]
	where
		name like '%'+ @name +'%'
		
for xml auto, elements, root('CustomerCollection');
	
	CustomerCollectionByName 'r'
	
	
create procedure AddCustomer
@id int,
@name varchar(255)
as
	insert into Customers (id, name) values (@id, @name)
	
	
select * from Customers

---------------------------------------------------------------------

select * from lab_Orders

create procedure lab_getOrderCollection
as
	select
		OrderName [OrderName],
		OrderDescription [OrderDescription],
		OrderFunction [OrderFunction],
		OrderValue [OrderValue]
	from
		lab_Orders [Order]
for xml auto, elements, root('OrderCollection');

lab_getOrderCollection

----------------------------------------------------------------------

create procedure lab_AddOrder
@OrderName varchar(255),
@OrderDescription varchar(255),
@OrderFunction varchar(255),
@OrderValue int
as
	insert into lab_Orders 
	(
		OrderName, 
		OrderDescription,
		OrderFunction,
		OrderValue
	) 
	values 
	(
		@OrderName,
		@OrderDescription,
		@OrderFunction,
		@OrderValue
	)

update 
	lab_Orders
set OrderName = 'okk',
	OrderDescription = 'okk'
where
	OrderValue = 0


alter procedure lab_UpdateOrder
@OrderName varchar(255),
@OrderDescription varchar(255),
@OrderValue int
as
	update 
		lab_Orders
	set OrderName = @OrderName,
		OrderDescription = @OrderDescription
	where
		OrderValue = @OrderValue
		

select * from lab_Orders

delete from lab_Orders where OrderName = 'ggg'

alter procedure lab_DeleteOrder
@OrderName varchar(255)
as
	delete from 
		lab_Orders
	where
		OrderName = @OrderName
---------------------------------------------------
-----------------------MVC-------------------------


create table mvc_Produto (Nome varchar(255), Quantidade int, Descricao varchar(255), Categoria varchar(255))

create procedure AddProduct
@Nome varchar(255),
@Quantidade int,
@Descricao varchar(255),
@Categoria varchar(255)
as
	insert into mvc_Produto (Nome, Quantidade, Descricao, Categoria) values (@Nome, @Quantidade, @Descricao, @Categoria)


select * from mvc_Produto

alter procedure GetAllProducts
as
	select
		Nome [Nome],
		Quantidade [Quantidade],
		Descricao [Descricao],
		Categoria [Categoria]
	from mvc_Produto [Produto]
for xml auto, elements, root('ProdutoCollection');
	
GetAllProducts
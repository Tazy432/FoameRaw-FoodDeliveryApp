insert into Users (nume,parola) values ('miau' , 'ghiricioaica')
insert into Users (nume,parola) values ('admin','buna')
insert into Users (nume,parola) values ('claudiu','claudiu2000')

select * from Users

select * from Restaurant
INSERT into Restaurant values('Republicii 3' ,'Carabusul Ostenit',50,10,10,10,'05:00','05:30')
insert into Restaurant values ('Crinului 20','Jocu Ielelor',60,10,20,10,'08:00','21:00')

insert into Restaurant values ('Republicii 6','Iepurele saltaret',30,5,10,20,'07:00','22:00')


insert into Restaurant values ('Zambilei 6','Harciogu-nfometat',50,5,15,10,'16:00','04:00')


insert into values ('Branduselor 3','BalaurulAgabaritic',60,10,20,10,'08:00','21:00')

select * from Restaurant
select * from Users

insert into Users (nume,parola) values('123','123')

select * from Foods
insert into Foods values('cartofi prajiti')
insert into Foods values('orez fiert')
insert into Foods values('cartofi la cuptor')
insert into Foods values('piept de pui la gratar')
insert into Foods values('ciorba de legume')
insert into Foods values('ciorba de burta')
insert into Foods values('ceafa de porc')
insert into Foods values('salata de castraveti murati')
insert into Foods values('amandina')
insert into Foods values('snitzel pane')
insert into Foods values('cascaval pane')

select * from PreturiRestaurante
select * from Restaurant
select * from Foods


insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (3,1,12,'Cartofi copti pt minti prajite')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (3,2,10,'Cartofi copti cu atentie')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (3,3,15,'Cartofi copti cu usturoi')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (3,4,6,'Cartofi copti simpli')

insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (4,1,20,'Piept de pui olimpic')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (4,2,15,'Piept de pui de curcan')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (4,3,22,'Piept de pui la gratar cu piper')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (4,4,18,'Piept de pui adevarat')

insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (5,1,10,'Ciorba de legume de post')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (5,2,15,'Ciorba de legume asiatice')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (5,3,8,'Ciorba de legume de mare')
insert into PreturiRestaurante(foodId,restaurantId,pret,descriere) values (5,4,20,'Ciorba de legume fantastice')


select * 
from PreturiRestaurante p 
join Foods f
on p.foodId=f.foodId
where restaurantId=2;

select * from ListaProduse
delete from ListaProduse where listaId=4
delete from ListaProduse where listaId<100
select * from ListaProduse
insert into ListaProduse values(5,2,4)
insert into ListaProduse values(5,3,2)
Select max(listaId) as idMaxim from ListaProduse
select idMaxim from(
Select max(listaId) as idMaxim from ListaProduse
)
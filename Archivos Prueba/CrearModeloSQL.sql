/*-----------------------------------------------------------------------------
- Creator: Jose Sogamoso
- Creation date: 5 Ago 2022
- Project: EERP Project name
- Epic: EP003 Epic text
- UH: UH002 UH text
-------------------------------------------------------------------------------
*/


Create table TypeForm 
(
	IdTypeForm int identity(1,1) PRIMARY KEY,
	DescriptionType Varchar(50) NOT NULL
)

CREATE TABLE Form 
( 


	IdForm int identity(1,1) PRIMARY KEY,
	IdTypeForm Int NOT NULL,
	Title Varchar (50) NOT NULL,
	StateDisabled bit default '0' null,
	StatePublished  bit default '0' null 
	FOREIGN KEY (IdTypeForm) REFERENCES TypeForm (IdTypeForm)

)

insert into TypeForm values ('Case')
insert into Form values (1,'Caso Covid2','','')


select * from TypeForm
select * from Form






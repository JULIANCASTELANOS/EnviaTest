CREATE DATABASE [DB_TEST]

USE [DB_TEST]
GO

/****** Object:  Table [dbo].[tbl_Users]    Script Date: 10/31/2018 10:46:26 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[uname] [varchar](50) NULL,
	[pword] [varchar](50) NULL,
	[firstname] [varchar](50) NULL,
	[lastname] [varchar](50) NULL,
	[email] [varchar](100) NOT NULL,
	[userlevel] [int] NOT NULL,
 CONSTRAINT [PK_tbl_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteUser]    Script Date: 10/31/2018 10:46:53 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteUser]
(
@id INT
)

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DELETE FROM [tbl_Users] WHERE id = @id

END

GO

USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_AddUser2]    Script Date: 10/31/2018 10:46:40 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_AddUser2]
@uname VARCHAR(50),
@pword VARCHAR(50),
@fname VARCHAR(50),
@lname VARCHAR(50),
@email VARCHAR(50),
@ulevel VARCHAR(50)

AS

SET NOCOUNT ON

INSERT INTO [dbo].[tbl_Users]
           (uname
           ,pword
           ,firstname
           ,lastname
           ,email
           ,userlevel)
     VALUES
           (@uname
           ,@pword
           ,@fname
           ,@lname
           ,@email
           ,@ulevel)
GO

USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateUser]    Script Date: 10/31/2018 10:47:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_UpdateUser]
(
@id INT,
@uname VARCHAR(50),
@fname VARCHAR(50),
@lname VARCHAR(50),
@email VARCHAR(50),
@ulevel INT
)

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

UPDATE [tbl_Users] SET uname = @uname, firstname = @fname, 
lastname = @lname, email = @email, userlevel = @ulevel
WHERE id = @id

END
GO

USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 10/31/2018 10:47:08 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Login]
(
	@uname VARCHAR(50),  @pass VARCHAR(50)
)
AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DECLARE @userLevel INT

SET @userLevel = (SELECT userlevel
FROM [dbo].[tbl_Users]
WHERE [uname] = @uname AND [pword] = @pass)

IF @userLevel > 0
BEGIN
SELECT @userLevel
END

ELSE
BEGIN
SELECT 0;
END
END
GO

USE [DB_TEST]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetUsers]    Script Date: 10/31/2018 10:47:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetUsers]

AS
BEGIN

SET NOCOUNT ON; --the count (indicating the number of rows affected by a Transact-SQL statement) is not returned

DECLARE @userLevel INT

SELECT id AS ID, uname AS Username, firstname AS Firstname, lastname AS Lastname, email AS Email, userlevel AS Userlevel FROM [dbo].[tbl_Users]

END
GO

INSERT INTO [tbl_Users] VALUES ('julicas','1234','JULIAN','CASTELLANOS','guitarrajulian@hotmail.com','1')
INSERT INTO [tbl_Users] VALUES ('test','test1','TEST','TEST','test@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('Andrea1234','Andrea1234','Andrea','Rodriguez','andrea.rodriguez@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('Juan456','Juan456','Juan','Perez','juan@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('admin','admin4040','Admin','Envia','admin@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user1','user1','user1','user1','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user2','user2','user2','user2','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user3','user3','user3','user3','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user4','user4','user4','user4','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user5','user5','user5','user5','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user6','user6','user6','user6','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user7','user7','user7','user7','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user8','user8','user8','user8','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user9','user9','user9','user9','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user10','user10','user10','user10','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user11','user11','user11','user11','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user12','user12','user12','user12','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user13','user13','user13','user13','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user14','user14','user14','user14','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user15','user15','user15','user15','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user16','user16','user16','user16','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user17','user17','user17','user17','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user18','user18','user18','user18','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user19','user19','user19','user19','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user20','user20','user20','user20','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user21','user21','user21','user21','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user22','user22','user22','user22','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user23','user23','user23','user23','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user24','user24','user24','user24','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user25','user25','user25','user25','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user26','user26','user26','user26','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user27','user27','user27','user27','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user28','user28','user28','user28','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user29','user29','user29','user29','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user30','user30','user30','user30','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user31','user31','user31','user31','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user32','user32','user32','user32','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user33','user33','user33','user33','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user34','user34','user34','user34','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user35','user35','user35','user35','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user36','user36','user36','user36','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user37','user37','user37','user37','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user38','user38','user38','user38','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user39','user39','user39','user39','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user40','user40','user40','user40','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user41','user41','user41','user41','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user42','user42','user42','user42','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user43','user43','user43','user43','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user44','user44','user44','user44','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user45','user45','user45','user45','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user46','user46','user46','user46','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user47','user47','user47','user47','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user48','user48','user48','user48','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user49','user49','user49','user49','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user50','user50','user50','user50','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user51','user51','user51','user51','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user52','user52','user52','user52','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user53','user53','user53','user53','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user54','user54','user54','user54','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user55','user55','user55','user55','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user56','user56','user56','user56','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user57','user57','user57','user57','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user58','user58','user58','user58','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user59','user59','user59','user59','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user60','user60','user60','user60','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user61','user61','user61','user61','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user62','user62','user62','user62','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user63','user63','user63','user63','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user64','user64','user64','user64','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user65','user65','user65','user65','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user66','user66','user66','user66','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user67','user67','user67','user67','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user68','user68','user68','user68','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user69','user69','user69','user69','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user70','user70','user70','user70','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user71','user71','user71','user71','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user72','user72','user72','user72','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user73','user73','user73','user73','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user74','user74','user74','user74','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user75','user75','user75','user75','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user76','user76','user76','user76','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user77','user77','user77','user77','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user78','user78','user78','user78','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user79','user79','user79','user79','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user80','user80','user80','user80','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user81','user81','user81','user81','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user82','user82','user82','user82','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user83','user83','user83','user83','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user84','user84','user84','user84','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user85','user85','user85','user85','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user86','user86','user86','user86','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user87','user87','user87','user87','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user88','user88','user88','user88','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user89','user89','user89','user89','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user90','user90','user90','user90','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user91','user91','user91','user91','user1@envia.co','1')
INSERT INTO [tbl_Users] VALUES ('user92','user92','user92','user92','user2@envia.co','2')
INSERT INTO [tbl_Users] VALUES ('user93','user93','user93','user93','user3@envia.co','3')
INSERT INTO [tbl_Users] VALUES ('user94','user94','user94','user94','user1@envia.co','1')
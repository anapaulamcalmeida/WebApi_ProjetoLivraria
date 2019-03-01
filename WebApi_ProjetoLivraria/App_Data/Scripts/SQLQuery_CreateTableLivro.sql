CREATE TABLE [dbo].[LIVRO] (
    [Id]             INT             IDENTITY (1, 1) NOT NULL,
    [ISBN]           NVARCHAR (100)  NOT NULL UNIQUE,
    [Autor]          NVARCHAR (100)  NOT NULL,
    [Nome]           NVARCHAR (100)  NOT NULL,
    [Preco]          DECIMAL (18, 2) NOT NULL,
    [DataPublicacao] DATETIME        NULL,
    [ImagemCapa]     IMAGEM          NULL,
    
	CONSTRAINT PK_LIVRO PRIMARY KEY (Id),
);

GO


INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-94318-08-4','Lewis Carrol','Alice no país das maravilhas',24, '07/12/2018' ,
  (SELECT * FROM OPENROWSET(BULK 'C:\Users\bsilv\source\repos\WebApi_ProjetoLivraria\Pictures\AliceNoPaísDasMaravilhas.jpg', SINGLE_BLOB) AS A));

GO
  
INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-94318-00-8','Nicolau Maquiavel','O príncipe',27, '07/12/2018' ,
  (SELECT * FROM OPENROWSET(BULK 'C:\Users\bsilv\source\repos\WebApi_ProjetoLivraria\Pictures\OPríncipe.jpg', SINGLE_BLOB) AS A));

GO
  
INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-94318-07-7','Jane Austen','Razão e sensibilidade',23, '07/12/2012' ,
  (SELECT * FROM OPENROWSET(BULK 'C:\Users\bsilv\source\repos\WebApi_ProjetoLivraria\Pictures\RazãoESensibilidade.jpg', SINGLE_BLOB) AS A));

GO
  
INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-94318-09-1','Franz Kafka','A metamorfose',19, '07/12/2007' ,
  (SELECT * FROM OPENROWSET(BULK 'C:\Users\bsilv\source\repos\WebApi_ProjetoLivraria\Pictures\AMetamorfose.jpg', SINGLE_BLOB) AS A));

GO
  
INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-94318-10-7','Arthur Conan Doyle','Um estudo em vermelho',25, '07/12/2010' ,
  (SELECT * FROM OPENROWSET(BULK 'C:\Users\bsilv\source\repos\WebApi_ProjetoLivraria\Pictures\UmEstudoEmVermelho.jpg', SINGLE_BLOB) AS A));

GO

INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-7520-011-9','Donaldo Buchweitz','O patinho feio',20, '07/12/2001' ,null);

  GO

INSERT INTO [dbo].[LIVRO] VALUES (
  '978-85-7520-013-5','Donaldo Buchweitz','A bela adormecida',20, null ,null);

GO

SELECT * FROM [dbo].[LIVRO];

CREATE TABLE [dbo].[NewStaff] (
    [SID]      INT           IDENTITY (1, 1) NOT NULL,
    [Fname]    VARCHAR (150) NOT NULL,
    [Lname]    VARCHAR (150) NOT NULL,
    [Gender]   VARCHAR (20)  NOT NULL,
    [Dob]      VARCHAR (100) NOT NULL,
    [Mobile]   BIGINT        NOT NULL,
    [Email]    VARCHAR (150) NULL,
    [JoinDate] VARCHAR (100) NOT NULL,
    [State]   VARCHAR (100) NOT NULL,
    [City]     VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([SID] ASC)
);


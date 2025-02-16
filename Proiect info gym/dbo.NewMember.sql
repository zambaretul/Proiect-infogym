CREATE TABLE [dbo].[NewMember] (
    [MID]            INT           IDENTITY (1, 1) NULL,
    [Fname]          VARCHAR (150) NOT NULL,
    [Lname]          VARCHAR (150) NOT NULL,
    [Gender]         VARCHAR (20)  NOT NULL,
    [Dob]            VARCHAR (100) NOT NULL,
    [Mobile]         BIGINT        NOT NULL,
    [Email]          VARCHAR (150) NULL,
    [JoinDate]       VARCHAR (100) NOT NULL,
    [GymTime]        VARCHAR (120) NOT NULL,
    [Maddress]       VARCHAR (250) NOT NULL,
    [MembershipTime] VARCHAR (120) NOT NULL,
    PRIMARY KEY CLUSTERED ([MID] ASC)
);


create table NewMember
(
	MID int NOT NULL IDENTITY (1,1) PRIMARY KEY, 
    Fname VARCHAR(150) Not null,
	Lname VARCHAR(150) Not null,
	Gender VARCHAR(20) Not null,
	Dob VARCHAR(100) Not null,
    Mobile bigint NOT null,
	Email VARCHAR(150) NULL,
	JoinDate VARCHAR(100) NOT null,
	GymTime VARCHAR(120) Not null,
	Maddress VARCHAR(250) Not null,
	MembershipTime VARCHAR(120) Not null,
);


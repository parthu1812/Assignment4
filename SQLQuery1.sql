INSERT INTO [User] (Id, Firstname, Lastname, Email, Password, DateCreated)
VALUES ('01617907', 'Parthu', 'Gade', 'parthu@example.com', 'parthu147', GETDATE());

SELECT Email, Password FROM [User];


select * from [TransactionHistory];
select * from [Account];

INSERT INTO [Account] ( UserId, AccountType, CurrentBalance, DateCreated)
VALUES ('01617907', 'Savings', 1000, GETDATE());
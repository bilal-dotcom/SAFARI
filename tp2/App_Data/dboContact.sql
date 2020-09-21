CREATE TABLE [dbo].[contact] (
    [Id]               INT  NOT NULL,
    [address]          TEXT NOT NULL,
    [address_code]     TEXT NOT NULL,
    [phone]            TEXT NOT NULL,
    [phone_code]       TEXT NOT NULL,
    [email]            TEXT NOT NULL,
    [email_code]       TEXT NOT NULL,
    [information]      TEXT NOT NULL,
    [information_code] TEXT NOT NULL,
    [name1]            TEXT NOT NULL,
    [email1]           TEXT NOT NULL,
    [phone1]           TEXT NOT NULL,
    [message1]         TEXT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


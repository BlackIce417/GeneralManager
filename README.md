# GeneralManager
 An easy password manager made by WinForm.

I use mssql to save data.

This is mssql configration:

```mssql	
use [WinForm-GeneralManager]

if not exists (select 1 from sys.tables WHERE name = 'user')
begin
create table [user] (
	user_id nvarchar(128) primary key,
	user_name nvarchar(128) unique,
	user_passwd nvarchar(128),
	user_regDate nvarchar(128),
	user_type nvarchar(15) check (user_type in ('test', 'normal', 'admin')),
    user_edit_date nvarchar(128),
);
end

if not exists (select 1 from sys.tables WHERE name = 'admin')
begin
create table admin (
	admin_id nvarchar(128) primary key,
	admin_name nvarchar(128),
	foreign key (admin_id) references [user] (user_id)
);
end

if not exists (select 1 from sys.tables WHERE name = 'info')
begin
create table info (
	[info_id] nvarchar(128) primary key,
	[user_id] nvarchar(128),
	[target] nvarchar(128),
	[target_id] nvarchar(128),
	[target_passwd] nvarchar(128),
	foreign key (user_id) references [user] (user_id)
);
end

--insert [user] ([user_id], [user_name], [user_passwd], [user_regDate], [user_type]) values ('1', 'admin', '', '2024-1-30', 'admin');
--insert [info] ([user_id], [target], [target_id], [target_passwd]) values ('1', 'r6', '123@xxx.com', 'xxx');
--insert [info] ([user_id], [target], [target_id], [target_passwd]) values ('1', 'pubg', '12333@xxx.com', 'xxaaax');

CREATE TRIGGER check_admin
ON [user]
AFTER INSERT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM inserted WHERE user_type = 'admin')
    BEGIN
        -- 在admin表中插入相应的admin_id和admin_name
        INSERT INTO [admin] (admin_id, admin_name)
        SELECT user_id, user_name
        FROM inserted
        WHERE user_type = 'admin';
    END
END;

CREATE TRIGGER check_admin2
ON [user]
AFTER UPDATE
AS
BEGIN
    IF UPDATE ([user_type])
    BEGIN
        -- 在admin表中更新相应的admin_id和admin_name
        INSERT INTO [admin] (admin_id, admin_name)
        SELECT user_id, user_name
        FROM inserted
        WHERE user_type = 'admin';
    END
END;
```

mssql user name: sa

default password : 123456

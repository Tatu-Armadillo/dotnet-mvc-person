create database crud_dotnet;
use crud_dotnet;
create table `person`(
	`id` bigint primary key auto_increment,
    `address` varchar(100) not null,
    `first_name` varchar(80) not null,
    `last_name` varchar(80) not null,
    `gender` varchar(6) not null
);

INSERT INTO `crud_dotnet`.`person` (`address`, `first_name`, `last_name`, `gender`) VALUES ('Cuiaba', 'Dedo', 'Dedinho', 'Male');

select * from `person`;
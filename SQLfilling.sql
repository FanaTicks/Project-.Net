use Store
go
BEGIN TRANSACTION
INSERT into Manufacturer
VALUES
('mf1','NOYA GLOBAL SAN. DIS TIC. LTD. STI.','Gayrettepe Mah. Beşiktaş İstanbul TURKEY', '0902345437','Україна'),
('mf2','yotex-apparel', 'NO 5616 Cao`an Road 201805 Shanghai,China', '8618201869','Британія'),
('mf3','lanwo','Shaotali Road, Wuzhong District, Suzhou City','8618151562','Польша'),
('mf4','M-CORP Marcin Wróbel','Orchów 176 M-Corp Marcin Wróbel, 98-100, Польша','4878899691','Фінляндія'),
('mf5','Hawthorn International','International House 24 Holborn Viaduct London','4420363338','Турція'),
('mf6','COTTO','вулиця Кирилівська 102 Київ 02000','0734161043','Китай');
INSERT into Worker
VALUES
('w1','Worker1','1loginGrigorii','Григорій','Пательня','0993044055','Grishapat@gmail.com'),
('w2','Worker2','2loginFedir','Федір','Строківський','0675942357','FedirStrok@gmail.com'),
('w3','Worker3','3loginYulia','Юля','Крачишина','0445434437','yuliastar123@gmail.com'),
('w4','Worker4','4loginFedot','Федот','Анаркамський','0993005544','Fedotdotdot@gmail.com'),
('w5','Worker5','5loginSonya','Софія','Франкбенська','0672359475','Soniafrank@gmail.com'),
('w6','Worker6','6loginNatali','Наталія','Бренковонська','0443445437','NataliBrenkovska@gmail.com');
INSERT into Users
VALUES
('u1','User1','1loginNatalka','Олефтина','Кампотова','0993485723','OleftinaCompotova2003@gmail.com'),
('u2','User2','2loginNatalka','Петро','Гричаківський','0677502594','PetroGrichak2394@gmail.com'),
('u3','User3','3loginNatalka','Олександр','Надземельний','0440175628','Sasha_122343@gmail.com'),
('u4','User4','4loginNatalka','Данііл','Молодцов','0997403841','Daniil_Mol@gmail.com'),
('u5','User5','5loginNatalka','Оля','Пентагон','0678350175','Pentagon_Olia@gmail.com'),
('u6','User6','6loginNatalka','Наталка','Бренська','0447592302','NataliBrenkovska@gmail.com');
INSERT into Product
VALUES
('p1','Джинсова тканина','Для одягу','Джинсова тканина матеріал виготовлений з бавовни.',null,'Джинса','mf1'),
('p2','Віскозна тканина','Для дому','Віскоза-це штучне полотно з природної целюлози.',null,'Віскоза','mf2'),
('p3','Поплінова тканина','Для декору','Поплін-двостороння тканина.',null,'Поплін','mf3'),
('p4','Флісова тканина','Спец. тканини','Фліс—синтетичний нетканий матеріал.', null,'Фліс','mf4'),
('p5','Хутряна тканина','Хутро','Штучне хутро — це ворсовий матеріал.',null,'Хутро','mf5'),
('p6','Джерова тканина','Для виробів','Джерсі - трикотажне полотно з вовняного волокна.',null,'Джерсі','mf6');
INSERT into Selling
VALUES
('s1','230','2022-01-12','23','p5','u1','w4'),
('s2','454','2022-01-11','10','p1','u4','w1'),
('s3','129','2022-03-23','3','p2','u3','w5');
INSERT into Delivery
VALUES
('s1','850','2022-03-12','400','p3','w6'),
('s2','1100','2022-01-27','600','p6','w2'),
('s3','900','2022-02-27','150','p2','w3');
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PCKonfiguratorBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"


INSERT INTO Dimensions (id, width, height, depth) 
VALUES 
('45fd4ca1-ebe2-4adc-aad7-13d97596b21e', 194.0, 321.5, 443.0),
('83380117-8816-487c-bcc4-c19fec2fd0eb', 231.0, 463.0, 450.0),
('6c1a7a55-95c5-4a6a-96b3-7de5d8988b51', 290.0, 471.0, 478.0),
('a63db671-49ff-4e91-bb9b-92de7883d334', 230.0, 500.0, 450.0),
('1b3d6402-58e5-4e02-99c9-cf86a9f0d97b', 215.0, 469.0, 447.0),
('2bb1b35c-9c4d-4bb5-9dc2-1c5e050ab75d', 200.0, 400.0, 380.0),
('ea3a5927-36d3-4931-8c4c-4699efb7dfeb', 210.0, 450.0, 400.0),
('03e0e205-7605-4b9f-8c45-2f327fe080c5', 215.0, 455.0, 400.0),
('f1253425-68f8-42d0-b598-722e36fbc627', 280.0, 600.0, 550.0),
('333a6830-3dd7-4284-8625-11271c540c0a', 220.0, 465.0, 425.0),
('8ea5dfc1-7d36-4fb2-9480-5aceacfbe8c8', 180.0, 375.0, 370.0),
('4b504bb5-5862-47ea-853c-57959859c524', 300.0, 630.0, 600.0),
('b3e9b578-1638-404a-bbe6-395c43db2176', 230.0, 500.0, 490.0),
('c5032095-a4f7-400d-a583-6ca0566db052', 190.0, 420.0, 400.0),
('487a3ee6-a3b9-4e47-88b0-70a72a5158fa', 250.0, 560.0, 460.0);

INSERT INTO TowerCompatibility (id, maxCpuCoolerHeight, maxGpuLenght) 
VALUES 
('fb5e6660-9f69-4646-994d-70617fda14bb', 165.0, 415.0),
('49feed9c-99e6-4fdc-8906-8a9896dd7797', 178.0, 368.0),
('d4e58cd2-5e8f-44d8-84cb-4f1d67d999c4', 167.0, 455.7),
('aa320654-38f7-4e67-bdf3-5e6f2cd8bdfb', 184.0, 415.0),
('b794f5cf-4e78-4e6f-928f-493542ba10bf', 170.0, 355.0),
('5498e031-0e46-4443-8058-2df12a65a502', 160.0, 320.0),
('a509d609-4f42-4823-9efa-713bd4941592', 158.0, 350.0),
('fc924ed9-e5b9-4ca5-8f98-5fc706df6305', 140.0, 300.0),
('a96ab2b7-3bea-425e-a61b-7f38e7be10b8', 185.0, 470.0),
('ddfe2dbf-2f56-4c1d-8774-dbe3bb2f687f', 170.0, 360.0),
('a1ef7f2d-3577-4b86-b072-d2d998c4b4b8', 155.0, 330.0),
('bfec306f-0bc4-4052-a9e8-6c6abe1abc82', 190.0, 450.0),
('df430e5d-c729-4415-a9e5-84a7b497e277', 180.0, 400.0),
('3cda042e-c222-46f2-a23e-580ac7ffc13f', 175.0, 410.0),
('061c7d31-71f1-4b81-9f51-b098c9d1f324', 200.0, 480.0);

INSERT INTO Towers (id, name, manufacturer, price, image, color, towerType, formFactor, dimensionsid, towerCompatibilityid) 
VALUES 
('715e5758-8c2a-447e-bc31-b959bdcc5c8e', 'Lian Li DAN Cases A3-mATX Black Wood Edition (A3-mATX-WD Black)', 'Lian Li', 80.26, 'https://gzhls.at/i/60/05/3326005-n0.jpg', 'Black', 0, 1, '45fd4ca1-ebe2-4adc-aad7-13d97596b21e', 'fb5e6660-9f69-4646-994d-70617fda14bb'),
('cbe79af7-9175-4cfb-ba9b-83bd36e5d188', 'be quiet! Pure Base 501 Airflow Black, schallgedämmt (BG074)', 'be quiet!', 79.34, 'https://gzhls.at/i/07/12/3340712-n0.jpg', 'Black', 1, 0, '83380117-8816-487c-bcc4-c19fec2fd0eb', '49feed9c-99e6-4fdc-8906-8a9896dd7797'),
('5a23d9fb-bae6-4f8a-805b-84744b1f27ea', 'Lian Li O11 Dynamic / O11D EVO RGB, schwarz, Glasfenster (O11DERGBX)', 'Lian Li', 171.90, 'https://gzhls.at/i/45/18/3094518-n0.jpg', 'Black', 1, 0, '6c1a7a55-95c5-4a6a-96b3-7de5d8988b51', 'd4e58cd2-5e8f-44d8-84cb-4f1d67d999c4'),
('8c69d8aa-25b2-4c1e-bd04-97a8b9898e72', 'Phanteks XT Pro Ultra Satin Black, schwarz, Glasfenster (PH-XT523P1_DBK01)', 'Phanteks', 80.57, 'https://gzhls.at/i/72/61/3147261-n0.jpg', 'Black', 1, 0, 'a63db671-49ff-4e91-bb9b-92de7883d334', 'aa320654-38f7-4e67-bdf3-5e6f2cd8bdfb'),
('f2b65862-29c7-47db-89c7-e936f68e843c', 'Fractal Design North Charcoal Black TG Dark, Glasfenster (FD-C-NOR1C-02)', 'Fractal Design', 157.08, 'https://gzhls.at/i/16/82/2861682-n0.jpg', 'Black', 1, 0, '1b3d6402-58e5-4e02-99c9-cf86a9f0d97b', 'b794f5cf-4e78-4e6f-928f-493542ba10bf'),
('12ec29b6-d1ec-48c8-94e2-8c5b2a050c03', 'Cooler Master MasterBox Q300L', 'Cooler Master', 45.99, 'https://gzhls.at/i/54/88/3015488-l0.webp', 'Black', 0, 1, '2bb1b35c-9c4d-4bb5-9dc2-1c5e050ab75d', '5498e031-0e46-4443-8058-2df12a65a502'),
('87c55f66-9905-4b2f-b6c8-d0b130b0da06', 'NZXT H510 Flow', 'NZXT', 89.99, 'https://gzhls.at/i/64/72/2606472-l0.jpg', 'White', 1, 0, 'ea3a5927-36d3-4931-8c4c-4699efb7dfeb', 'a509d609-4f42-4823-9efa-713bd4941592'),
('4ad315ae-f02d-4c9b-9d53-797b88c79895', 'Corsair 275R Airflow', 'Corsair', 79.90, 'https://gzhls.at/i/32/43/2153243-l0.jpg', 'Black', 1, 0, '03e0e205-7605-4b9f-8c45-2f327fe080c5', 'fc924ed9-e5b9-4ca5-8f98-5fc706df6305'),
('7877ac08-5e7b-4ef1-b29d-c6f3f9066a0b', 'Phanteks Enthoo Pro', 'Phanteks', 99.99, 'https://gzhls.at/i/01/85/1110185-l0.jpg', 'Black', 2, 0, 'f1253425-68f8-42d0-b598-722e36fbc627', 'a96ab2b7-3bea-425e-a61b-7f38e7be10b8'),
('5aa49f21-85e0-477f-be6a-b8c6e4b247a0', 'Thermaltake Versa H18', 'Thermaltake', 40.50, 'https://gzhls.at/i/54/64/1755464-l0.jpg', 'Black', 0, 1, '333a6830-3dd7-4284-8625-11271c540c0a', 'ddfe2dbf-2f56-4c1d-8774-dbe3bb2f687f'),
('9dd81804-0158-4ce8-abfc-61a90577e79d', 'Corsair Crystal 280X', 'Corsair', 129.90, 'https://gzhls.at/i/73/83/1827383-l0.jpg', 'White', 0, 1, '8ea5dfc1-7d36-4fb2-9480-5aceacfbe8c8', 'a1ef7f2d-3577-4b86-b072-d2d998c4b4b8'),
('eb2781ce-f3f3-48a7-8f24-96c9a76bbe8f', 'Cooler Master Cosmos C700P', 'Cooler Master', 279.99, 'https://gzhls.at/i/09/53/1700953-l0.jpg', 'Gray', 2, 0, '4b504bb5-5862-47ea-853c-57959859c524', 'bfec306f-0bc4-4052-a9e8-6c6abe1abc82'),
('63c22d34-63b8-49b6-b3d0-65d5ff1f23e4', 'Corsair Obsidian 750D', 'Corsair', 159.99, 'https://gzhls.at/i/15/12/1281512-l0.jpg', 'Black', 2, 0, 'b3e9b578-1638-404a-bbe6-395c43db2176', 'df430e5d-c729-4415-a9e5-84a7b497e277'),
('70aab270-839a-4eef-bfd3-a80cc861e8d1', 'be quiet! Dark Base Pro 900', 'be quiet!', 249.90, 'https://gzhls.at/i/37/79/1453779-l0.jpg', 'Black', 2, 0, 'c5032095-a4f7-400d-a583-6ca0566db052', '3cda042e-c222-46f2-a23e-580ac7ffc13f'),
('be2afebd-6b25-4b1a-9cde-8e3b89fb8de4', 'Fractal Design Define 7 XL', 'Fractal Design', 199.00, 'https://gzhls.at/i/98/47/2239847-l0.jpg', 'Black', 2, 0, '487a3ee6-a3b9-4e47-88b0-70a72a5158fa', '061c7d31-71f1-4b81-9f51-b098c9d1f324');



INSERT INTO CPUMemory (id, memoryType, maxCapacity, maxSpeed) VALUES
('5e1d1f89-2b6b-48cd-9d98-23a6f7e5e111', 0, 192, 5600.0),
('6e2d3f9a-7c5b-49cd-9b98-45a7f8e6f222', 0, 192, 6400.0),
('b1ec3a47-012f-4c24-9ce9-78d24660b930', 1, 128, 3200.0),
('27b2d51c-6a2e-472d-a0a1-898b9f75feb7', 1, 128, 3600.0),
('f380fbaa-7c0c-47ab-9b81-b639755b1eb5', 1, 128, 3600.0),
('6c624e90-888f-4da0-9291-7b4c4b5c0fa5', 0, 128, 5200.0),
('93339899-61e1-48d2-b43e-af958ca8c341', 0, 128, 5600.0),
('a06f2c55-bc3a-4d5f-b98a-8e0f5f6e7da7', 0, 128, 6000.0),
('9afd31c2-b6c2-4e84-b580-9f561f9e42c2', 0, 128, 4800.0),
('aed09f01-6687-407d-9e30-9e698b90323d', 0, 128, 5200.0),
('de8fc720-5b53-4d93-b3ff-91c147d47b53', 0, 128, 5600.0),
('0dc1186c-2b82-4c34-845c-418428947d30', 0, 192, 5600.0);

-- Einfügen der CPU-Spezifikationen
INSERT INTO CPUSpecification (id, power, l2Cache, l3Cache, maxTemp, threads, core, baseClock, boostClock, socket, cpuMemoryId) VALUES
('f2b3c59a-6d2a-4e7d-892d-1a6f5d3f1c56', 250, 28, 33, 100, 28, 20, 3.40, 5.60, 2, '5e1d1f89-2b6b-48cd-9d98-23a6f7e5e111'),
('c3d4e69b-5f7a-48cd-8c78-12a3d9f7e567', 253, 36, 36, 105, 32, 24, 3.70, 5.70, 2, '6e2d3f9a-7c5b-49cd-9b98-45a7f8e6f222'),
('b49f5693-15d7-4c28-ba2a-cb38cd50d16c', 65, 3, 32, 95, 12, 6, 3.50, 4.40, 1, 'b1ec3a47-012f-4c24-9ce9-78d24660b930'),
('1b689e3c-d918-49c1-bb62-aac149ae5ee3', 105, 4, 32, 90, 16, 8, 3.80, 4.70, 1, '27b2d51c-6a2e-472d-a0a1-898b9f75feb7'),
('cc39a23e-17f6-4055-a1f2-ec6650d50728', 105, 6, 64, 90, 24, 12, 3.70, 4.80, 1, 'f380fbaa-7c0c-47ab-9b81-b639755b1eb5'),
('92178a81-2eaf-4f88-bdf2-5844828058d6', 65, 6, 32, 95, 12, 6, 3.80, 5.10, 0, '6c624e90-888f-4da0-9291-7b4c4b5c0fa5'),
('956141ce-b5c4-44fc-b73f-cdc31bcd5207', 105, 8, 32, 95, 16, 8, 4.50, 5.40, 0, '93339899-61e1-48d2-b43e-af958ca8c341'),
('086e3cf1-53c0-4d2c-abf4-7b8608cda97f', 170, 16, 64, 95, 32, 16, 4.50, 5.70, 0, 'a06f2c55-bc3a-4d5f-b98a-8e0f5f6e7da7'),
('fa2dbb6b-0db1-4a68-8f4f-093cd4b84b14', 125, 9, 20, 100, 16, 10, 3.70, 4.90, 2, '9afd31c2-b6c2-4e84-b580-9f561f9e42c2'),
('0462aecd-4d2c-425e-ae6c-9313dc1991e0', 125, 14, 30, 100, 24, 16, 3.20, 5.20, 2, 'aed09f01-6687-407d-9e30-9e698b90323d'),
('b04af56d-554e-4d86-9c52-4bbb8df90cdf', 125, 20, 24, 100, 20, 14, 3.50, 5.10, 2, 'de8fc720-5b53-4d93-b3ff-91c147d47b53'),
('f91b9a26-5c5a-4e84-8f98-ceda0b79e48f', 125, 32, 36, 100, 32, 24, 3.00, 5.80, 2, '0dc1186c-2b82-4c34-845c-418428947d30');


-- Einfügen der CPU-Daten
INSERT INTO Cpus(id, name, manufacturer, price, image, cpuSpecificationId) VALUES
('a8d2e3f4-6b9c-4e0d-99a6-7c1f2d8e3b4a', 'Intel Core i7-14700K, 8P+12E/28T, 3.40-5.60GHz, boxed ohne Kühler', 'Intel', 399.99, 'https://gzhls.at/i/31/51/3043151-n0.jpg', 'f2b3c59a-6d2a-4e7d-892d-1a6f5d3f1c56'),
('b9e3d4c5-7a8b-48cd-99f8-23c5d7e6f678', 'Intel Core Ultra 9 285K, 8P+16E/24C => 32T, 3.70-5.70GHz, boxed ohne Kühler', 'Intel', 671.90, 'https://gzhls.at/i/94/02/3329402-n0.jpg', 'c3d4e69b-5f7a-48cd-8c78-12a3d9f7e567'),
('e3ae57dd-07e4-4b73-97e7-d4a4b5d474a8', 'AMD Ryzen 5 5600, 6C/12T, 3.50-4.40GHz', 'AMD', 139.99, 'https://gzhls.at/i/91/14/2709114-l0.jpg', 'b49f5693-15d7-4c28-ba2a-cb38cd50d16c'),
('a78eabf2-5f8c-4bdf-a69f-6301edf17afa', 'AMD Ryzen 7 5800X, 8C/16T, 3.80-4.70GHz', 'AMD', 209.99, 'https://gzhls.at/i/25/25/2392525-l0.jpg', '1b689e3c-d918-49c1-bb62-aac149ae5ee3'),
('047ff6ce-56b9-4c55-bbb7-c721fb54288d', 'AMD Ryzen 9 5900X, 12C/24T, 3.70-4.80GHz', 'AMD', 329.99, 'https://gzhls.at/i/25/26/2392526-l0.jpg', 'cc39a23e-17f6-4055-a1f2-ec6650d50728'),
('5e94c749-2c61-4c3e-8714-ecf46e81065c', 'AMD Ryzen 5 7600, 6C/12T, 3.80-5.10GHz', 'AMD', 229.00, 'https://gzhls.at/i/11/74/2871174-l0.jpg', '92178a81-2eaf-4f88-bdf2-5844828058d6'),
('ef4c23da-9e0f-44ab-a549-ecd8e6bbee5a', 'AMD Ryzen 7 7700X, 8C/16T, 4.50-5.40GHz', 'AMD', 339.00, 'https://gzhls.at/i/12/29/2801229-l0.jpg', '956141ce-b5c4-44fc-b73f-cdc31bcd5207'),
('1c4dab8e-7c94-4faa-9aa6-6fa62201fd71', 'AMD Ryzen 9 7950X, 16C/32T, 4.50-5.70GHz', 'AMD', 549.00, 'https://gzhls.at/i/19/76/2871976-l0.jpg', '086e3cf1-53c0-4d2c-abf4-7b8608cda97f'),
('9dde94c9-2406-4f02-86d1-cce0a286a08f', 'Intel Core i5-12600K, 10C/16T, 3.70-4.90GHz', 'Intel', 219.99, 'https://gzhls.at/i/35/72/2613572-l0.jpg', 'fa2dbb6b-0db1-4a68-8f4f-093cd4b84b14'),
('f2bb6b11-1a7e-44c8-89e9-7e5cb7424c6c', 'Intel Core i9-12900K, 16C/24T, 3.20-5.20GHz', 'Intel', 389.99, 'https://gzhls.at/i/34/75/2613475-l0.jpg', '0462aecd-4d2c-425e-ae6c-9313dc1991e0'),
('a077a240-df22-4c1b-a7c4-b07792e7ec07', 'Intel Core i5-13600K, 14C/20T, 3.50-5.10GHz', 'Intel', 329.90, 'https://gzhls.at/i/01/86/2810186-l0.jpg', 'b04af56d-554e-4d86-9c52-4bbb8df90cdf'),
('8f2362aa-1576-4cc8-9baf-f98fa5c21cc4', 'Intel Core i9-13900K, 24C/32T, 3.00-5.80GHz', 'Intel', 559.00, 'https://gzhls.at/i/00/39/2810039-l0.jpg', 'f91b9a26-5c5a-4e84-8f98-ceda0b79e48f');




INSERT INTO Dimensions (id, width, height, depth)
VALUES 
('e1c9a3b4-1234-4f6b-8c9d-9f8e7d6a5b2c', 30.5, 24.4, NULL), 
('f2d8b4c5-5678-427d-9e8c-8a7b6c5d4e3f', 30.5, 24.4, NULL), 
('a3e7d6c8-9012-528e-0f9d-7b6a5c4d3e2f', 30.5, 24.4, NULL), 
('b4f8e9d7-3456-639f-1f0e-6c5a4d3e2b1f', 30.5, 24.4, NULL),
('ca25976b-9700-4dac-b2ed-4e361da62d7a', 24.4, 24.4, 3.0),
('51ee4569-9938-4d2e-9f7c-bbb19002c116', 24.4, 24.4, 2.0),
('4324fdba-ec89-4568-b5c1-30b6c29bf372', 24.4, 24.4, 3.2),
('b29b945d-c7cb-4cc3-aa01-f81a22507966', 24.4, 24.4, 3.5),
('8565f2eb-5cae-4d7e-9c33-0989f9b37e39', 24.4, 24.4, 2.5),
('d76581ca-041e-4092-bf0d-dc34ba529677', 24.4, 24.4, 2.0),
('560f0601-1834-4c7c-949c-549c5551db6c', 24.4, 24.4, 3.0),
('dc2851d8-5ea9-4bbf-8e69-65188c4acb3e', 24.4, 24.4, 3.5),
('0cda0f5c-cef2-4291-8d78-80d8cfc4f049', 24.4, 24.4, 2.0),
('c213946d-a245-49f5-b948-e883d07f9fdc', 24.4, 24.4, 3.2);

INSERT INTO MainboardSpecifications (id, socket, chipset, m2Slot, sataPorts,power ,formFactor, memoryType)
VALUES 
('c5a9d3e7-7890-7d8e-9f0a-1b2c3d4e5f6a', 1, 'B650E', 3, 4,30 ,1, 1),
('d6b8c4e7-8901-8f9a-0a1b-2c3d4e5f6b7a', 1, 'B650', 3, 4,30 ,1, 1),
('e7c9d5b3-9012-9a0b-1b2c-3d4e5f6c7d8a', 1, 'X870E', 4, 4,30 ,1, 1),
('f8d7e9c6-2345-0b1c-2c3d-4e5f6d7e8f9a', 1, 'X870', 4, 4,30, 1, 1),
('6b39cbb1-8846-4b73-bcca-f8f589dcef65', 0, 'B650', 2, 4, 30, 0, 0),
('dcd3417c-a1b6-40c6-bc76-5ee9c9975ba0', 0, 'B650E', 3, 4, 30, 0, 0),
('db73f071-5ef4-4f73-bc0a-2a442991c9f0', 0, 'X670', 3, 4, 30, 0, 0),
('758f8249-5334-49b0-9eec-05feff6898ea', 0, 'X670E', 4, 4, 30, 0, 0),
('8d621978-66bf-46c5-9928-c0662c785d9c', 1, 'B550', 2, 4, 30, 0, 1),
('2e629734-5871-456b-9f92-8e967efa3bcf', 2, 'Z690', 2, 4, 30, 0, 0),
('1dd55d79-cac2-4476-b357-3bbf21013b30', 2, 'Z790', 3, 6, 30, 0, 0),
('cc79e718-e38f-426c-a076-716fe0016353', 2, 'B660', 2, 4, 30, 1, 1),
('ec36276b-91a1-4c28-9dc9-251984c4a027', 3, 'H570', 2, 4, 30, 1, 1),
('46434c26-f8b4-401e-a5c6-89f1fe6bad18', 5, 'X299', 2, 8, 30, 0, 0);

INSERT INTO Mainboards (id, name, manufacturer, price, image, mainboardSpecificationsId, dimensionsId)
VALUES 
('a9c3d5e7-5678-7a8b-9c0d-e1f2a3b4c5d6a', 'ASUS ROG Strix B650E-F Gaming WIFI', 'ASUS', 220.84, 'https://gzhls.at/i/43/07/2824307-n0.jpg', 'c5a9d3e7-7890-7d8e-9f0a-1b2c3d4e5f6a', 'e1c9a3b4-1234-4f6b-8c9d-9f8e7d6a5b2c'),
('b8d4e7c6-6789-8b9c-0d1e-2f3a4b5c6d7a', 'ASUS TUF Gaming B650-E WIFI', 'ASUS', 152.88, 'https://gzhls.at/i/07/86/3120786-n0.webp', 'd6b8c4e7-8901-8f9a-0a1b-2c3d4e5f6b7a', 'f2d8b4c5-5678-427d-9e8c-8a7b6c5d4e3f'),
('c7e9d5b3-7890-9c0d-1e2f-3a4b5c6d7e8a', 'GIGABYTE X870E AORUS Elite WIFI7', 'GIGABYTE', 317.00, 'https://gzhls.at/i/65/89/3286589-n0.webp', 'e7c9d5b3-9012-9a0b-1b2c-3d4e5f6c7d8a', 'a3e7d6c8-9012-528e-0f9d-7b6a5c4d3e2f'),
('d8f7e9c6-8901-0d1e-2f3a-4b5c6d7e8f9a', 'MSI MAG X870 Tomahawk WIFI', 'MSI', 314.62, 'https://gzhls.at/i/51/82/3295182-n0.webp', 'f8d7e9c6-2345-0b1c-2c3d-4e5f6d7e8f9a', 'b4f8e9d7-3456-639f-1f0e-6c5a4d3e2b1f'),
('75d3a8bc-274e-4f9e-88ac-c3e807b13b06', 'MSI MAG B650 TOMAHAWK WIFI', 'MSI', 199.90, 'https://gzhls.at/i/43/00/2824300-l0.webp', '6b39cbb1-8846-4b73-bcca-f8f589dcef65', 'ca25976b-9700-4dac-b2ed-4e361da62d7a'),
('e94aebf3-bb51-4c5d-9f06-85ba0cb328bd', 'ASUS ROG Strix B650E-F Gaming', 'ASUS', 249.90, 'https://gzhls.at/i/43/07/2824307-l0.jpg', 'dcd3417c-a1b6-40c6-bc76-5ee9c9975ba0', '51ee4569-9938-4d2e-9f7c-bbb19002c116'),
('0adbe418-b7da-49e6-bb50-776fbecc6fbd', 'GIGABYTE X670 AORUS ELITE AX', 'GIGABYTE', 279.90, 'https://gzhls.at/i/13/45/2791345-l0.jpg', 'db73f071-5ef4-4f73-bc0a-2a442991c9f0', '4324fdba-ec89-4568-b5c1-30b6c29bf372'),
('ecc7c2a4-540f-449c-bac7-a2b03dd7560f', 'ASRock X670E Taichi', 'ASRock', 389.90, 'https://gzhls.at/i/17/23/2791723-l0.jpg', '758f8249-5334-49b0-9eec-05feff6898ea', 'b29b945d-c7cb-4cc3-aa01-f81a22507966'),
('d8bd9edf-8c36-4dde-99c9-4036dc9ac5c1', 'MSI MAG B550 TOMAHAWK', 'MSI', 129.90, 'https://gzhls.at/i/49/74/2774974-l0.jpg', '8d621978-66bf-46c5-9928-c0662c785d9c', '8565f2eb-5cae-4d7e-9c33-0989f9b37e39'),
('a745ca34-260f-4be6-83d5-b2741c3429a7', 'ASUS PRIME Z690-P', 'ASUS', 189.90, 'https://gzhls.at/i/55/74/2625574-l0.jpg', '2e629734-5871-456b-9f92-8e967efa3bcf', 'd76581ca-041e-4092-bf0d-dc34ba529677'),
('ab9bd46f-24ec-495a-bce5-a3b96adee559', 'GIGABYTE Z790 AORUS MASTER', 'GIGABYTE', 399.90, 'https://gzhls.at/i/98/86/2819886-l0.jpg', '1dd55d79-cac2-4476-b357-3bbf21013b30', '560f0601-1834-4c7c-949c-549c5551db6c'),
('69d29876-72fb-4e2b-b23c-83b37b3f6028', 'ASRock B660M Pro RS', 'ASRock', 99.90, 'https://gzhls.at/i/10/37/2661037-l0.jpg', 'cc79e718-e38f-426c-a076-716fe0016353', 'dc2851d8-5ea9-4bbf-8e69-65188c4acb3e'),
('4164cf3b-1a82-43ce-b090-5d0bd92a3798', 'MSI H570M PRO', 'MSI', 89.90, 'https://gzhls.at/i/98/66/2479866-l0.jpg', 'ec36276b-91a1-4c28-9dc9-251984c4a027', '0cda0f5c-cef2-4291-8d78-80d8cfc4f049'),
('eb35b78b-a726-47fa-a214-39266d147ea2', 'ASUS PRIME X299-A II', 'ASUS', 449.90, 'https://gzhls.at/i/58/15/2155815-l0.jpg', '46434c26-f8b4-401e-a5c6-89f1fe6bad18', 'c213946d-a245-49f5-b948-e883d07f9fdc');



-- Einfügen von Dimensions
INSERT INTO Dimensions (id, width, height, depth)
VALUES 
('ecb20d96-3a6f-4596-8fbf-1d37ba0f587e', 125, 155, 135),  -- Thermalright Peerless Assassin 120 SE
('fff26ebf-f754-4fb4-bae4-e3d815b467a5', 136, 168, 145),  -- be quiet! Dark Rock Pro 5
('c6f9b1e7-30ae-4a73-b4d7-112877c7613b', 126, 159, 104),  -- Arctic Freezer 36 Black
('d37346b0-2150-4047-a3eb-014f8b6adfae', 150, 168, 152);  -- Noctua NH-D15 G2

-- Einfügen von CpuFanSpecifications
INSERT INTO CpuFanSpecifications (id, socket, connector, heatpipes)
VALUES 
('bab42c66-b206-468b-a834-d03c18c36b79', 1, '4-Pin PWM', '6 Heatpipes (6mm)'),  -- Thermalright Peerless Assassin 120 SE
('1e8d6c55-07a2-462d-9557-3750d121b9bb', 2, '4-Pin PWM', '7 Heatpipes (6mm)'),  -- be quiet! Dark Rock Pro 5
('e2fad52b-24d1-472d-a13c-607bc1786fc4', 3, '4-Pin PWM', '4 Heatpipes (6mm)'),  -- Arctic Freezer 36 Black
('ab75bfaa-52be-4ea6-8e65-6199b9e86992', 4, '4-Pin PWM', '8 Heatpipes');        -- Noctua NH-D15 G2

-- Einfügen von CPUFan
INSERT INTO CPUFans (id, name, manufacturer, price, image, cpufanSpecificationsId, dimensionsId)
VALUES 
('49b711b0-fa6c-4a0b-ae7e-e50b57b60674', 'Thermalright Peerless Assassin 120 SE', 'Thermalright', 36.90, 'https://gzhls.at/i/71/75/2647175-n0.jpg', 'bab42c66-b206-468b-a834-d03c18c36b79', 'ecb20d96-3a6f-4596-8fbf-1d37ba0f587e'),
('5f176fc2-fa6c-4b40-9844-77785b319435', 'be quiet! Dark Rock Pro 5', 'be quiet!', 86.62, 'https://gzhls.at/i/87/18/3038718-n0.jpg', '1e8d6c55-07a2-462d-9557-3750d121b9bb', 'fff26ebf-f754-4fb4-bae4-e3d815b467a5'),
('035dd0cf-6e9b-4276-b193-0cd0ee762a8b', 'Arctic Freezer 36 Black', 'Arctic', 26.00, 'https://gzhls.at/i/41/76/3144176-n0.webp', 'e2fad52b-24d1-472d-a13c-607bc1786fc4', 'c6f9b1e7-30ae-4a73-b4d7-112877c7613b'),
('12962ade-224d-4bb8-915f-24b45887116a', 'Noctua NH-D15 G2', 'Noctua', 149.86, 'https://gzhls.at/i/16/74/3221674-n0.jpg', 'ab75bfaa-52be-4ea6-8e65-6199b9e86992', 'd37346b0-2150-4047-a3eb-014f8b6adfae');




-- Einfügen von RAMSpecifications
INSERT INTO RAMSpecifications (id, MemoryType, speed, capacity, voltage,power)
VALUES 
('ca69c915-3665-45e1-86eb-af32d2b51c06', 1, 6000, 32, 1.4,5),  -- Kingston FURY Beast DDR5-6000
('ceecb009-ead0-4209-b237-fed8b01b1797', 1, 6000, 64, 1.4,5),  -- Kingston FURY Beast 64GB DDR5-6000
('bbfa7fb4-9845-4d5d-84f9-a91fcde51643', 1, 6000, 32, 1.35,5), -- G.Skill Trident Z5 NEO DDR5-6000
('3c6b504e-678e-471b-b553-eede006101e7', 2, 3200, 32, 1.35,5), -- G.Skill Aegis DDR4-3200
('f37f3c32-bd8c-4056-91ec-5a8692ab745b', 2, 3200, 16, 1.2,5);  -- Crucial SO-DIMM DDR4-3200

-- Einfügen von RAM
INSERT INTO RAMs (id, name, manufacturer, price, image, ramSpecificationsId)
VALUES 
('dc45f7af-10fe-4161-8583-dcc899456fff', 'Kingston FURY Beast DDR5-6000', 'Kingston', 109.80, 'https://gzhls.at/i/49/11/3164911-n0.jpg', 'ca69c915-3665-45e1-86eb-af32d2b51c06'),
('bb713cfb-31fd-49ac-a71c-70f025c9dcc1', 'Kingston FURY Beast 64GB DDR5-6000', 'Kingston', 203.70, 'https://gzhls.at/i/49/13/3164913-n0.jpg', 'ceecb009-ead0-4209-b237-fed8b01b1797'),
('b11dc339-d7fb-4cc9-9465-efdc03602687', 'G.Skill Trident Z5 NEO DDR5-6000', 'G.Skill', 120.91, 'https://gzhls.at/i/58/24/2815824-n0.jpg', 'bbfa7fb4-9845-4d5d-84f9-a91fcde51643'),
('7be2e978-c8b9-401d-84e7-34553664e950', 'G.Skill Aegis DDR4-3200', 'G.Skill', 48.90, 'https://gzhls.at/i/16/24/2151624-n0.jpg', '3c6b504e-678e-471b-b553-eede006101e7'),
('83646994-4ba8-4c70-b9cc-1cb8659b6af5', 'Crucial SO-DIMM DDR4-3200', 'Crucial', 26.85, 'https://gzhls.at/i/65/74/2326574-n0.jpg', 'f37f3c32-bd8c-4056-91ec-5a8692ab745b');




-- Einfügen von Dimensions
INSERT INTO Dimensions (id, width, height, depth)
VALUES 
('1d5e8c3b-4a6f-49d2-9c1a-7e37b6a8d5c2', 150.0, 70.4, 331.9),  -- Palit GeForce RTX 5080 GameRock
('2e6a9d4b-3c5f-41b7-8c6d-2f19e5a7b4c1', 137.0, 40.0, 304.0),  -- NVIDIA GeForce RTX 5090 Founders Edition
('3f7c5b6d-2a4e-49d1-9c5a-1e37b4c8a6d2', 145.6, 69.9, 331.9),  -- Gainward GeForce RTX 5080 Phantom
('4a8e9d3c-5b6f-41d2-8c1a-5c37e4a8b6d2', 158.2, 72.6, 352.9),  -- ASUS TUF Gaming Radeon RX 7900 XTX OC
('5b9d6e3c-4a7f-49d1-8c2a-7e37b6a8d5c2', 136.0, 58.0, 330.0),  -- GIGABYTE GeForce RTX 4080 SUPER Windforce V2
('6c8e5d4b-3a7f-49d2-9c1a-7e37b6a8d5c2', 126.0, 50.0, 261.0);  -- GIGABYTE GeForce RTX 4070 Ti SUPER Windforce OC

-- Einfügen von GPUSpecifications
INSERT INTO GPUSpecifications (id, memory, speed, boostclock, coreclock, power)
VALUES 
('e4a2b42c-8f23-4d8e-9756-991ac5d6aeb1', 16, 30, 2617, 2295, 360),  -- Palit GeForce RTX 5080
('f18d6eb7-d1a5-4c34-b81c-08fd3e59eebb', 32, 28, 2407, 2017, 575),  -- NVIDIA GeForce RTX 5090 Founders Edition
('a3df5b68-2b47-49dc-a4c3-4e6c8d073fa3', 16, 30, 2617, 2295, 360),  -- Gainward GeForce RTX 5080 Phantom
('ba4c6f91-1e37-4f3b-9c95-2e9d1fced3a4', 24, 20, 2565, 2395, 355),  -- ASUS TUF Gaming Radeon RX 7900 XTX OC
('c2b8d4e6-5f31-49a1-98fa-4d23e7c9a8b2', 16, 23, 2550, 2295, 320),  -- GIGABYTE GeForce RTX 4080 SUPER Windforce V2
('d1e59f8a-62c7-4891-85f6-3b29d7e8a4c1', 16, 21, 2625, 2340, 285);  -- GIGABYTE GeForce RTX 4070 Ti SUPER Windforce OC

-- Einfügen von GPU
INSERT INTO GPUs (id, name, manufacturer, price, image, gpuSpecificationsId, dimensionsId)
VALUES 
('3b5a4e92-7f68-45d3-a7c8-3d19f7a6e5b1', 'Palit GeForce RTX 5080 GameRock', 'Palit', 1389.00, 'https://gzhls.at/i/25/03/3382503-n0.webp', 'e4a2b42c-8f23-4d8e-9756-991ac5d6aeb1', '1d5e8c3b-4a6f-49d2-9c1a-7e37b6a8d5c2'),
('4e8c7a5b-9d2f-41b3-8c6d-2f19e5a7b4c1', 'NVIDIA GeForce RTX 5090 Founders Edition', 'NVIDIA', 4999.99, 'https://gzhls.at/i/16/01/3381601-n0.jpg', 'f18d6eb7-d1a5-4c34-b81c-08fd3e59eebb', '2e6a9d4b-3c5f-41b7-8c6d-2f19e5a7b4c1'),
('5c3d4e92-8f7a-4b6d-9c5a-1e37b4c8a6d2', 'Gainward GeForce RTX 5080 Phantom', 'Gainward', 1399.00, 'https://gzhls.at/i/26/23/3382623-n0.webp', 'a3df5b68-2b47-49dc-a4c3-4e6c8d073fa3', '3f7c5b6d-2a4e-49d1-9c5a-1e37b4c8a6d2'),
('6d2e7c5b-3a4f-4b9d-8f1a-5c37e4a8b6d2', 'ASUS TUF Gaming Radeon RX 7900 XTX OC', 'ASUS', 968.02, 'https://gzhls.at/i/17/83/2841783-n0.jpg', 'ba4c6f91-1e37-4f3b-9c95-2e9d1fced3a4', '4a8e9d3c-5b6f-41d2-8c1a-5c37e4a8b6d2'),
('7f6a8b5c-3d4e-49b1-92c7-5a19e7b4d6a2', 'GIGABYTE GeForce RTX 4080 SUPER Windforce V2', 'GIGABYTE', 1326.20, 'https://gzhls.at/i/72/20/3097220-n0.webp', 'c2b8d4e6-5f31-49a1-98fa-4d23e7c9a8b2', '5b9d6e3c-4a7f-49d1-8c2a-7e37b6a8d5c2'),
('8b5c3d7e-4a6f-49d2-9c1a-7e37b6a8d5c2', 'GIGABYTE GeForce RTX 4070 Ti SUPER Windforce OC', 'GIGABYTE', 1030.10, 'https://gzhls.at/i/73/18/3097318-n0.webp', 'd1e59f8a-62c7-4891-85f6-3b29d7e8a4c1', '6c8e5d4b-3a7f-49d2-9c1a-7e37b6a8d5c2');




-- Einfügen von StorageSpecifications mit zufälligen GUIDs
INSERT INTO StorageSpecifications (id, capacity, schnittstelle, readSpeeed, writeSpeeed,power)
VALUES 
('e3b1c9f7-4d6b-43e7-b65d-2e68a59e7c01', 2000, 'M.2/​M-Key (PCIe 4.0 x4)', 7450, 6900,9),  -- Samsung SSD 990 PRO 2TB
('bd8b2cf8-94c2-49bb-8f84-7f7a869d3e02', 2000, 'M.2/​M-Key (PCIe 4.0 x4) oder (PCIe 5.0 x2)', 7250, 6300,8),  -- Samsung SSD 990 EVO Plus 2TB
('ff57a3a1-2c49-42f7-bc57-d3d923cfa103', 4000, 'M.2/​M-Key (PCIe 4.0 x4)', 7450, 6900,7),  -- Samsung SSD 990 PRO 4TB
('c48e2e74-8df5-4d6b-ae7a-d8a3a576f504', 2000, 'M.2/​M-Key (PCIe 4.0 x4)', 5000, 4200,9),  -- Crucial P3 Plus SSD 2TB
('a672bf14-f2c3-41d1-bc6e-dcba759c2105', 2048, 'M.2/​M-Key (PCIe 4.0 x4)', 7000, 7000,8),  -- Kingston KC3000 PCIe 4.0 NVMe SSD 2TB
('e89d5db9-69ac-45bf-80c4-f7b832d5c806', 2000, 'M.2/​M-Key (PCIe 4.0 x4)', 7300, 6600,8),  -- WD_BLACK SN850X NVMe SSD 2TB
('b5399ad6-4bb7-4c64-9f95-2171bcba7707', 1000, 'M.2/​M-Key (PCIe 4.0 x4)', 6000, 4000,7),  -- Kingston NV3 NVMe PCIe 4.0 SSD 1TB
('df4a7e16-36bf-4a4d-ae2c-59b37d189908', 2000, 'M.2/​M-Key (PCIe 4.0 x4)', 7400, 6500,9),  -- Lexar NM790 2TB
('f2d8197d-68ba-419c-9b1c-2f0c8cfbfa09', 4000, 'M.2/​M-Key (PCIe 4.0 x4)', 7400, 6500,8),  -- Lexar NM790 4TB
('adc16e83-81b1-4cd6-8b97-b4bfc314cc10', 1000, 'M.2/​M-Key (PCIe 4.0 x4)', 3500, 2200,9);  -- ADATA XPG Gammix S50 Core 1TB

-- Einfügen von Storage mit zufälligen GUIDs und Referenz auf StorageSpecifications
INSERT INTO Storages (id, name, manufacturer, price, image, storageSpecificationsId)
VALUES 
('b8e27a01-3dbf-4425-b8c7-9a5e8f507d11', 'Samsung SSD 990 PRO 2TB', 'Samsung', 171.15, 'https://gzhls.at/i/59/58/2795958-n0.webp', 'e3b1c9f7-4d6b-43e7-b65d-2e68a59e7c01'),
('d146f0bb-695d-498f-a03e-b2bde279fe12', 'Samsung SSD 990 EVO Plus 2TB', 'Samsung', 136.19, 'https://gzhls.at/i/68/43/3316843-n0.webp', 'bd8b2cf8-94c2-49bb-8f84-7f7a869d3e02'),
('c751df9a-40c6-4f7d-8601-c7e68b502313', 'Samsung SSD 990 PRO 4TB', 'Samsung', 306.12, 'https://gzhls.at/i/81/24/2798124-n0.webp', 'ff57a3a1-2c49-42f7-bc57-d3d923cfa103'),
('e8b5f764-5a97-480f-b4b9-7851f56e3014', 'Crucial P3 Plus SSD 2TB', 'Crucial', 105.87, 'https://gzhls.at/i/18/34/2761834-n0.jpg', 'c48e2e74-8df5-4d6b-ae7a-d8a3a576f504'),
('f4329c85-7d1f-4d4c-8d13-cb9a06f32e15', 'Kingston KC3000 PCIe 4.0 NVMe SSD 2TB', 'Kingston', 137.47, 'https://gzhls.at/i/14/57/2621457-n0.jpg', 'a672bf14-f2c3-41d1-bc6e-dcba759c2105'),
('a1e4b217-2635-4bf3-8dc7-3c19e5c40f16', 'WD_BLACK SN850X NVMe SSD 2TB', 'Western Digital', 148.90, 'https://gzhls.at/i/01/77/2770177-n0.jpg', 'e89d5db9-69ac-45bf-80c4-f7b832d5c806'),
('d3f2a1b9-5db3-46bb-b72d-1e3c50ea9517', 'Kingston NV3 NVMe PCIe 4.0 SSD 1TB', 'Kingston', 55.31, 'https://gzhls.at/i/85/79/3248579-n0.webp', 'b5399ad6-4bb7-4c64-9f95-2171bcba7707'),
('b46dc85e-924b-4038-8461-37a8fdc91e18', 'Lexar NM790 2TB', 'Lexar', 125.28, 'https://gzhls.at/i/65/95/2956595-n0.webp', 'df4a7e16-36bf-4a4d-ae2c-59b37d189908'),
('c2fd67e1-0b46-48d8-97f6-9649a6b1b919', 'Lexar NM790 4TB', 'Lexar', 243.14, 'https://gzhls.at/i/07/05/2980705-n0.webp', 'f2d8197d-68ba-419c-9b1c-2f0c8cfbfa09'),
('a938f4b9-58f1-4e9b-8d94-7413db2eeb20', 'ADATA XPG Gammix S50 Core 1TB', 'ADATA', 54.90, 'https://gzhls.at/i/94/89/3209489-n0.webp', 'adc16e83-81b1-4cd6-8b97-b4bfc314cc10');



-- Einfügen von FanSpecifications mit zufälligen GUIDs
INSERT INTO FanSpecifications (id, rpm, power, noiseLevel, besonderheit)
VALUES 
('f1a3b8c2-6e74-4b5a-b8f1-8f6d1e9c2c01', 2100, 5, '32dB(A)', 'Vibrationsdämpfer, reversierter Rotor'),  -- Lian Li Uni Fan SL-Infinity
('c0e1d9b3-5a28-4c8e-9d83-f1a5c3b5d002', 2100, 3, '30.9dB(A)', 'schwarz (Rahmen), schwarz (Rotor)'),  -- be quiet! Pure Wings 3 PWM High-Speed
('b9e7f4d6-81d3-49b7-afe3-c9a2e0d7f203', 1200, 3, '21.9dB(A)', 'schwarz (Rahmen), schwarz (Rotor)'),  -- be quiet! Pure Wings 3 PWM 140mm
('e3f8d5c9-6b24-4a1c-8e4d-b6f2c3d8a304', 2000, 2, '22.6dB(A)', 'magnetisch hydrodynamisches Gleitlager'),  -- Noctua NF-A12x25 PWM
('d5b4c2e1-7a6d-4e2f-b3a9-f8c9e0d5b405', 2000, 2, '0.3 Sone', 'RGB (12 LEDs)'),  -- Arctic P12 PWM PST A-RGB
('c6a9e1b7-5d3f-4c8b-9e2d-f0b7c5d6a506', 2400, 6, '37dB(A)', 'Magnetschwebelager'),  -- Corsair iCUE LINK QX120
('f7d8c9b4-6a3e-4e2b-8c1d-b5f2e3d7c607', 2600, 6, '33dB(A)', 'RGB (26 LEDs)'),  -- Lian Li Uni Fan TL 120 RGB
('b8e4f1d9-72c5-4d3b-afe6-c9a2d7c5b708', 1500, 2, '24.8dB(A)', 'Noctua NF-A14x25 G2 PWM');  -- Noctua NF-A14x25 G2 PWM

-- Einfügen von Dimensions mit zufälligen GUIDs
INSERT INTO Dimensions (id, width, height, depth)
VALUES 
('d3e7f4c8-6a2d-4b9f-8c1e-b5a2d7c5e901', 120, 122.1, 25),  -- Lian Li Uni Fan SL-Infinity
('f1b9e4d7-62c8-4a3d-b9e5-c2a7d5c8e902', 120, 120, 25),  -- be quiet! Pure Wings 3 PWM High-Speed
('c6d5e9f1-7a4b-4c8d-8b2e-f7a3c9e4d903', 140, 140, 25),  -- be quiet! Pure Wings 3 PWM 140mm
('e3b7d9c5-8a6d-4f2b-9c1e-f5a8c2e7d904', 120, 120, 25),  -- Noctua NF-A12x25 PWM
('d5f4b2c6-9a3e-4d8c-8b1e-f7a9d3c5e905', 120, 120, 25),  -- Arctic P12 PWM PST A-RGB
('c9a7e5f1-62b4-4c3d-8d2e-f8a3d5c7e906', 120, 120, 25),  -- Corsair iCUE LINK QX120
('f8b6e1d9-7a3d-4c9b-8d2e-f5a3d7c4e907', 120, 124, 28),  -- Lian Li Uni Fan TL 120 RGB
('b7f4c9d8-6a2e-4b3d-8c1e-f5a9d2e7c908', 140, 140, 25);  -- Noctua NF-A14x25 G2 PWM

-- Einfügen von Fan mit zufälligen GUIDs und Referenzen auf FanSpecifications und Dimensions
INSERT INTO Fans (id, name, manufacturer, price, image, fanSpecificationsId, dimensionsId)
VALUES 
('f8b9e1d7-62c3-4a2d-b9e5-c7a5d4c9e909', 'Lian Li Uni Fan SL-Infinity', 'Lian Li', 30.79, 'https://gzhls.at/i/63/91/2976391-n0.jpg', 'f1a3b8c2-6e74-4b5a-b8f1-8f6d1e9c2c01', 'd3e7f4c8-6a2d-4b9f-8c1e-b5a2d7c5e901'),
('d6a7e9b5-4c3d-4b2e-8f1c-f8a9d2c7e910', 'be quiet! Pure Wings 3 PWM High-Speed', 'be quiet!', 9.68, 'https://gzhls.at/i/99/66/3049966-n0.jpg', 'c0e1d9b3-5a28-4c8e-9d83-f1a5c3b5d002', 'f1b9e4d7-62c8-4a3d-b9e5-c2a7d5c8e902'),
('c5e7f1d8-9a2d-4b3c-8f1e-b7a9d4c6e911', 'be quiet! Pure Wings 3 PWM 140mm', 'be quiet!', 10.98, 'https://gzhls.at/i/98/95/3049895-n0.jpg', 'b9e7f4d6-81d3-49b7-afe3-c9a2e0d7f203', 'c6d5e9f1-7a4b-4c8d-8b2e-f7a3c9e4d903'),
('e3b9d7f1-8a6d-4c2e-8b1e-f5a4c9d2e912', 'Noctua NF-A12x25 PWM', 'Noctua', 32.21, 'https://gzhls.at/i/29/85/2612985-n0.jpg', 'e3f8d5c9-6b24-4a1c-8e4d-b6f2c3d8a304', 'e3b7d9c5-8a6d-4f2b-9c1e-f5a8c2e7d904'),
('d5a4c7e9-8b3d-4f2e-8c1e-f7a9d2c5e913', 'Arctic P12 PWM PST A-RGB', 'Arctic', 32.37, 'https://gzhls.at/i/89/78/2508978-n0.jpg', 'd5b4c2e1-7a6d-4e2f-b3a9-f8c9e0d5b405', 'd5f4b2c6-9a3e-4d8c-8b1e-f7a9d3c5e905'),
('c9f7e5d1-4a2d-4b3c-8f1e-b8a9d2c7e914', 'Corsair iCUE LINK QX120', 'Corsair', 150.29, 'https://gzhls.at/i/62/73/2976273-n0.webp', 'c6a9e1b7-5d3f-4c8b-9e2d-f0b7c5d6a506', 'c9a7e5f1-62b4-4c3d-8d2e-f8a3d5c7e906'),
('f8b4d1e7-6a2d-4c3b-8f1e-b5a9d2c7e915', 'Lian Li Uni Fan TL 120 RGB', 'Lian Li', 109.90, 'https://gzhls.at/i/04/69/3090469-n0.webp', 'f7d8c9b4-6a3e-4e2b-8c1d-b5f2e3d7c607', 'f8b6e1d9-7a3d-4c9b-8d2e-f5a3d7c4e907'),
('b7f9e1d8-6a2d-4b3c-8f1e-f5a9d2c7e916', 'Noctua NF-A14x25 G2 PWM', 'Noctua', 36.20, 'https://gzhls.at/i/78/58/3317858-n0.jpg', 'b8e4f1d9-72c5-4d3b-afe6-c9a2d7c5b708', 'b7f4c9d8-6a2e-4b3d-8c1e-f5a9d2e7c908');




-- Einfügen von PSU-Dimensions mit neuen GUIDs
INSERT INTO Dimensions (id, width, height, depth)
VALUES 
('e3c7b4f8-9d2a-4b3c-8f1e-5a7d9c6e2b01', 150, 86, 160),  -- be quiet! Pure Power 12 M 850W
('f8e7d6c5-4a3b-49d2-9c1a-7e37b6a8d5c2', 150, 86, 160),  -- be quiet! Pure Power 12 M 750W
('a4d8c3e7-5b6f-49d1-8c2a-7e37b6a8d5c2', 150, 86, 160),  -- be quiet! Pure Power 12 M 1000W
('b6e9d4f7-3c5a-41b7-8c6d-2f19e5a7b4c1', 150, 86, 160),  -- be quiet! Pure Power 12 M 550W
('d8f2a6c9-48b7-42d1-8c1e-3a5f9b7d6e01', 150, 86, 200);  -- ASUS ROG Thor Titanium III 1600W (NEUE GUID)

-- Einfügen von PSU-Spezifikationen mit neuen GUIDs
INSERT INTO PSUSpecification (id, rpm, power, noiseLevel, certifications, connectors)
VALUES 
('f2b3e7d6-4a9d-49c5-8c2a-7e37b6a8d5c2', 2000, 850, '25.7 dB(A)', '80 PLUS Gold, ETA-Platinum', '1x 16-Pin PCIe 5.1, 4x 6/8-Pin PCIe, 6x SATA, 2x IDE'),
('e3a9c7d5-4b8f-41d2-9c1a-7e37b6a8d5c2', 1800, 750, '24 dB(A)', '80 PLUS Gold', '1x 16-Pin PCIe 5.1, 2x 6/8-Pin PCIe, 5x SATA, 2x IDE'),
('b4e9d7c5-3a6f-49d1-8c2a-7e37b6a8d5c2', 2000, 1000, '30.91 dB(A)', '80 PLUS Gold, ETA-Platinum', '1x 16-Pin PCIe 5.1, 4x 6/8-Pin PCIe, 6x SATA, 2x IDE'),
('c9d7e5a1-62b4-4c3d-8d2e-f8a3d5c7e906', 1800, 550, '17.1 dB(A)', '80 PLUS Gold', '1x 20/24-Pin, 1x 4/8-Pin ATX12V, 2x 6/8-Pin PCIe, 5x SATA, 2x IDE'),
('a8f7c9e4-5b6d-4a3f-8c2e-f5a3d7c4e907', 1350, 1600, '31.72 dB(A)', '80 PLUS Titanium, ETA-Platinum', '2x 16-Pin PCIe 5.1, 4x 6/8-Pin PCIe, 10x SATA, 9x IDE');

-- Einfügen von PSU-Daten mit neuen GUIDs
INSERT INTO PSUs (id, name, manufacturer, price, image, psuSpecificationId, dimensionsId)
VALUES 
('b3e9d5a7-6c2f-49d1-8c1a-7e37b6a8d5c2', 'be quiet! Pure Power 12 M 850W ATX 3.1', 'be quiet!', 124.93, 'https://gzhls.at/i/40/20/2884020-n0.jpg', 'f2b3e7d6-4a9d-49c5-8c2a-7e37b6a8d5c2', 'e3c7b4f8-9d2a-4b3c-8f1e-5a7d9c6e2b01'),
('c8e7d6a5-4b3f-49d2-9c1a-7e37b6a8d5c2', 'be quiet! Pure Power 12 M 750W ATX 3.1', 'be quiet!', 109.93, 'https://gzhls.at/i/40/48/2884048-n0.jpg', 'e3a9c7d5-4b8f-41d2-9c1a-7e37b6a8d5c2', 'f8e7d6c5-4a3b-49d2-9c1a-7e37b6a8d5c2'),
('d4e9c7b5-3a6f-49d1-8c2a-7e37b6a8d5c2', 'be quiet! Pure Power 12 M 1000W ATX 3.1', 'be quiet!', 154.99, 'https://gzhls.at/i/40/16/2884016-n0.jpg', 'b4e9d7c5-3a6f-49d1-8c2a-7e37b6a8d5c2', 'a4d8c3e7-5b6f-49d1-8c2a-7e37b6a8d5c2'),
('e5c9d7a1-62b4-4c3d-8d2e-f8a3d5c7e906', 'be quiet! Pure Power 12 M 550W ATX 3.1', 'be quiet!', 85.88, 'https://gzhls.at/i/40/50/2884050-n0.jpg', 'c9d7e5a1-62b4-4c3d-8d2e-f8a3d5c7e906', 'b6e9d4f7-3c5a-41b7-8c6d-2f19e5a7b4c1'),
('f7b8c9e4-6a3d-4c2b-8f1e-b5a9d2c7e915', 'ASUS ROG Thor Titanium III 1600W ATX 3.1', 'ASUS', 775.46, 'https://gzhls.at/i/62/02/3336202-n0.webp', 'a8f7c9e4-5b6d-4a3f-8c2e-f5a3d7c4e907', 'd8f2a6c9-48b7-42d1-8c1e-3a5f9b7d6e01');  -- NEUE GUID für Dimensions

");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

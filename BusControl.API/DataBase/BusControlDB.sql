-- Tabela Bus:
INSERT INTO Buses (Number, Plate, Line, Routes)
VALUES ('1001', 'ABC-1234', 'Linha 100', '1,2,3');

INSERT INTO Buses (Number, Plate, Line, Routes)
VALUES ('1002', 'DEF-5678', 'Linha 200', '4,5,6');

INSERT INTO Buses (Number, Plate, Line, Routes)
VALUES ('1003', 'GHI-9012', 'Linha 300', '7,8,9');


-- Tabela Route:
INSERT INTO Routes (Name, Origin, Destination)
VALUES ('Rota 1', 'Barra da Tijuca', 'Centro do Rio');

INSERT INTO Routes (Name, Origin, Destination)
VALUES ('Rota 2', 'Ilha do Governador', 'Barra da Tijuca');

INSERT INTO Routes (Name, Origin, Destination)
VALUES ('Rota 3', 'Copacabana', 'Ipanema');


-- Tabela Passenger:
INSERT INTO Passengers (Name, Cpf, Email, Phone)
VALUES ('João da Silva', '12345678900', 'joao@email.com', '(21) 98765-4321');

INSERT INTO Passengers (Name, Cpf, Email, Phone)
VALUES ('Maria Santos', '98765432100', 'maria@email.com', '(21) 12345-6789');

INSERT INTO Passengers (Name, Cpf, Email, Phone)
VALUES ('Pedro Oliveira', '09876543210', 'pedro@email.com', '(21) 55555-5555');


-- Tabela Driver:
INSERT INTO Drivers (Login, Name, Cpf, Email)
VALUES ('jose', 'José da Silva', '11111111111', 'jose@email.com');

INSERT INTO Drivers (Login, Name, Cpf, Email)
VALUES ('ana', 'Ana Maria', '22222222222', 'ana@email.com');

INSERT INTO Drivers (Login, Name, Cpf, Email)
VALUES ('carlos', 'Carlos Alberto', '33333333333', 'carlos@email.com');



-- Tabela TripsPassengers:

-- Supondo que os IDs reais na tabela Trips são 10, 11, 12, 15, 16, 17

-- Inserir passageiros para a viagem com ID 10
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (10, 1);
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (10, 2);

-- Inserir passageiros para a viagem com ID 11
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (11, 1);
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (11, 3);

-- Inserir passageiros para a viagem com ID 12
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (12, 2);

-- Inserir passageiros para a viagem com ID 15
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (15, 1);
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (15, 2);
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (15, 3);

-- Inserir passageiros para a viagem com ID 16
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (16, 1);

-- Inserir passageiros para a viagem com ID 17
INSERT INTO TripsPassengers (TripId, PassengerId) VALUES (17, 2);

-- Desativar triggers temporariamente
DISABLE TRIGGER tgr_Trips_BusId ON Trips;
DISABLE TRIGGER tgr_Trips_DepartureTime ON Trips;
DISABLE TRIGGER tgr_Trips_Duration ON Trips;

-- Tabela Trip:
INSERT INTO Trips (BusId, DepartureTime, ArrivalTime, Duration, LimitPassengers, Passengers, DriverId)
VALUES (1, '2024-01-21T08:00:00', '2024-01-21T09:00:00', 60, 40, NULL, '1');

INSERT INTO Trips (BusId, DepartureTime, ArrivalTime, Duration, LimitPassengers, Passengers, DriverId)
VALUES (2, '2024-01-21T10:00:00', '2024-01-21T11:00:00', 60, 50, NULL, '2');

INSERT INTO Trips (BusId, DepartureTime, ArrivalTime, Duration, LimitPassengers, Passengers, DriverId)
VALUES (3, '2024-01-21T12:00:00', '2024-01-21T13:00:00', 60, 30, NULL, '3');

-- Ativar triggers um a um
ENABLE TRIGGER tgr_Trips_BusId ON Trips;
ENABLE TRIGGER tgr_Trips_DepartureTime ON Trips;
ENABLE TRIGGER tgr_Trips_Duration ON Trips;

-- Ativar todas as triggers
ENABLE TRIGGER ALL ON Trips;

-- Para verificar se as trigegrs estão desativadas
SELECT name, is_disabled
FROM sys.triggers
WHERE parent_id = OBJECT_ID('Trips');

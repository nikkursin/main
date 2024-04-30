-- Create CountriesDB database
CREATE DATABASE IF NOT EXISTS CountriesDB;

-- Switch to CountriesDB database
USE CountriesDB;

-- Create Continents table
CREATE TABLE IF NOT EXISTS Continents (
    ID INTEGER PRIMARY KEY,
    name TEXT
);

-- Insert sample data into Continents table
INSERT INTO Continents (name) VALUES 
    ('Asia'),
    ('Europe'),
    ('North America'),
    ('South America'),
    ('Africa'),
    ('Oceania');

-- Create Countries table
CREATE TABLE IF NOT EXISTS Countries (
    ID INTEGER PRIMARY KEY,
    name TEXT,
    continentID INTEGER,
    area REAL,
    population INTEGER,
    description TEXT,
    FOREIGN KEY (continentID) REFERENCES Continents(ID)
);

-- Insert sample data into Countries table
INSERT INTO Countries (name, continentID, area, population, description) VALUES 
    ('China', 1, 9706961, 1403500365, 'The most populous country in the world.'),
    ('Germany', 2, 357022, 83783942, 'Known for its rich history, culture, and technological advancements.'),
    ('United States', 3, 9833520, 331002651, 'A diverse country known for its economic and cultural influence.'),
    ('Brazil', 4, 8515767, 212559417, 'The largest country in South America and known for its biodiversity.'),
    ('Nigeria', 5, 923768, 206139587, 'The most populous country in Africa and known for its cultural diversity.'),
    ('Australia', 6, 7692024, 25499884, 'A country and continent known for its unique wildlife and natural beauty.'),
    ('India', 1, 3287263, 1380004385, 'The second most populous country in the world and known for its rich history and culture.');

-- Create Cities table
CREATE TABLE IF NOT EXISTS Cities (
    ID INTEGER PRIMARY KEY,
    name TEXT,
    countryID INTEGER,
    isCapital BOOLEAN,
    description TEXT,
    FOREIGN KEY (countryID) REFERENCES Countries(ID)
);

-- Insert sample data into Cities table
INSERT INTO Cities (name, countryID, isCapital, description) VALUES 
    ('Beijing', 1, 1, 'Capital city of China.'),
    ('Shanghai', 1, 0, 'China''s largest city and a global financial hub.'),
    ('Guangzhou', 1, 0, 'A major port city and commercial hub in southeastern China.'),
    ('Berlin', 2, 1, 'Capital city of Germany and a cultural center.'),
    ('Munich', 2, 0, 'Known for its Oktoberfest and as a center of art and culture.'),
    ('Hamburg', 2, 0, 'A major port city and a hub for trade and commerce.'),
    ('Washington D.C.', 3, 1, 'Capital city of the United States.'),
    ('New York City', 3, 0, 'The largest city in the United States and a global financial hub.'),
    ('Los Angeles', 3, 0, 'Known for its entertainment industry and cultural diversity.'),
    ('Brasilia', 4, 1, 'Capital city of Brazil.'),
    ('Rio de Janeiro', 4, 0, 'Known for its beaches, music, and annual carnival.'),
    ('Sao Paulo', 4, 0, 'The largest city in Brazil and a major financial center.'),
    ('Abuja', 5, 1, 'Capital city of Nigeria.'),
    ('Lagos', 5, 0, 'The largest city in Nigeria and a major economic center.'),
    ('Sydney', 6, 1, 'Capital city of Australia and known for its iconic opera house.'),
    ('Melbourne', 6, 0, 'Known for its cultural events, sports, and vibrant arts scene.'),
    ('New Delhi', 7, 1, 'Capital city of India and a major cultural and political center.'),
    ('Mumbai', 7, 0, 'The largest city in India and a major financial and entertainment hub.');

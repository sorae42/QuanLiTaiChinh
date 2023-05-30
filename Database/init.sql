CREATE DATABASE KinsenDB;

USE KinsenDB;

CREATE TABLE Profiles (
	profileId INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	profileName NVARCHAR(50) UNIQUE NOT NULL,
	profilePassword VARCHAR(50),

	-- for the settings tab
	profilePrefDefaultName NVARCHAR(420) DEFAULT 'Mua hàng',
	profilePrefSpendingLimit INT NOT NULL DEFAULT 0,
	profilePrefStartupTab TINYINT NOT NULL DEFAULT 1, -- default to add new transaction
);

CREATE TABLE Spendings (
	spendId INT IDENTITY(1, 1) PRIMARY KEY NOT NULL,
	spendName NVARCHAR(420) NOT NULL,
	spendDate DATE NOT NULL DEFAULT CURRENT_TIMESTAMP,
	spendAmount INT NOT NULL,
	spendUser INT NOT NULL,

	FOREIGN KEY (spendUser) REFERENCES Profiles (profileId)
);

-- Demo profiles (You can make a new profile in the Kinsen app)
INSERT INTO Profiles (profileName, profilePassword) VALUES ('Sora', 'DangLeAnh');

-- Demo transaction
INSERT INTO Spendings (spendName, spendAmount, spendUser) VALUES ('Mua thức ăn', 100000, 1);
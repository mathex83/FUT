USE MNFUT
GO

CREATE TABLE tbGoals
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    goalId INT NOT NULL,
    playGroupId INT NOT NULL,
    numSolved INT DEFAULT 0,
    toBeSolved INT DEFAULT 1,
    isDone INT DEFAULT 0,
    myDescr NVARCHAR(100) DEFAULT 'do something',
    endDate DATE DEFAULT GETDATE()
)
GO

CREATE TRIGGER trg_tbGoals ON tbGoals AFTER INSERT AS
	UPDATE tbGoals SET isDone=1 WHERE numSolved>=toBeSolved
GO

CREATE TABLE tbGoalName
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    gName NVARCHAR(100) DEFAULT 'unknown',
);

CREATE TABLE tbGoalGroup
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    gGName NVARCHAR(100) DEFAULT 'unknown',
);

CREATE TABLE tbPlayGroup
(
    id INT IDENTITY(1,1) PRIMARY KEY,
    pGName NVARCHAR(100) DEFAULT 'all',
)
GO
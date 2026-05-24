CREATE DATABASE BookStoreDB;
GO

USE BookStoreDB;
GO

-- Tạo bảng Categories (Chủ đề)
CREATE TABLE Categories (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL
);
GO

-- Tạo bảng Books (Sách)
CREATE TABLE Books (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(200) NOT NULL,
    Author NVARCHAR(100) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Price DECIMAL(18,2) NOT NULL,
    ImageUrl NVARCHAR(MAX) NULL,
    CategoryId INT NOT NULL,
    CONSTRAINT FK_Books_Categories FOREIGN KEY (CategoryId) REFERENCES Categories(Id) ON DELETE CASCADE
);
GO

-- Chèn dữ liệu mẫu cho bảng Categories
INSERT INTO Categories (Name) VALUES 
(N'Cuộc sống'),
(N'Lập trình'),
(N'Sức Khỏe');
GO

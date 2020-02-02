CREATE TABLE [dbo].[Attraction] (
    [attractionId]        INT             IDENTITY (1, 1) NOT NULL,
    [attractionName]      VARCHAR (50)    NOT NULL,
    [attractionPrice]     MONEY           NOT NULL,
    [dateTime]            VARCHAR (50)    NULL,
    [attractionDesc]      VARCHAR (MAX)   NOT NULL,
    [attractionLocation]  VARCHAR (50)    NOT NULL,
    [attractionLatitude]  DECIMAL (18, 8) NULL,
    [attractionLongitude] DECIMAL (18, 8) NULL,
    [attractionInterest]  VARCHAR (50)    NOT NULL,
    [attractionType]      VARCHAR (50)    NOT NULL, 
    CONSTRAINT [PK_Attraction] PRIMARY KEY ([attractionId])
);


CREATE TABLE [dbo].[Ticket] (
    [ticketId]       INT             IDENTITY (1, 1) NOT NULL,
    [attractionName] VARCHAR (50)    NOT NULL,
    [attractionDesc] VARCHAR (50)    NOT NULL,
    [price]          NUMERIC (18, 2) NOT NULL,
    [dateExpire]     DATE            NOT NULL,
    [ticketCode]     VARCHAR (50)    NOT NULL,
    [paid]           VARCHAR (50)    NOT NULL,
    [user_id]        NCHAR (10)      NULL,
    PRIMARY KEY CLUSTERED ([ticketId] ASC)
);


CREATE TABLE [dbo].[Interest] (
    [InterestName] VARCHAR (50) NOT NULL,
    [user_id]      INT          NOT NULL
);


CREATE TABLE [dbo].[Cart] (
    [cartId]          INT             NOT NULL IDENTITY,
    [productName]     VARCHAR (50)    NOT NULL,
    [productPrice]    DECIMAL (18, 2) NOT NULL,
    [productQuantity] INT             NOT NULL,
    [user_id]         INT             NULL,
    [productDesc]     VARCHAR (50)    NULL,
    [active]          VARCHAR (50)    NULL,
    PRIMARY KEY CLUSTERED ([cartId] ASC)
);



CREATE TABLE [dbo].[Users] (
    [user_id]  INT           IDENTITY (1, 1) NOT NULL,
    [password] VARCHAR (255) NOT NULL,
    [name]     VARCHAR (255) NOT NULL,
    [email]    VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);


CREATE TABLE [dbo].[Tourists] (
    [tourist_id]  INT          IDENTITY (1, 1) NOT NULL,
    [nationality] VARCHAR (50) NULL,
    [user_id]     INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([tourist_id] ASC),
    CONSTRAINT [FK_Tourist_ToUser] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Users] ([user_id])
);


CREATE TABLE [dbo].[TourGuides] (
    [tourguide_id] INT           IDENTITY (1, 1) NOT NULL,
    [user_id]      INT           NOT NULL,
    [tours]        VARCHAR (255) NULL,
    [description]  VARCHAR (50)  NULL,
    [languages]    VARCHAR (50)  NULL,
    [credentials]  VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([tourguide_id] ASC),
    CONSTRAINT [FK_TourGuides_ToUsers] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Users] ([user_id])
);


CREATE TABLE [dbo].[Directions] (
    [Id]            INT IDENTITY (1, 1) NOT NULL,
    [attraction_id] INT NOT NULL,
    [tourist_id]    INT NOT NULL,
    CONSTRAINT [PK_Directions] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Directions_ToTourists] FOREIGN KEY ([tourist_id]) REFERENCES [dbo].[Tourists] ([tourist_id]),
    CONSTRAINT [FK_Directions_ToAttractions] FOREIGN KEY ([attraction_id]) REFERENCES [dbo].[Attraction] ([attractionId])
);


CREATE TABLE [dbo].[Reward] (
    [user_id]         INT          NOT NULL,
    [loginCount]      INT          DEFAULT ((0)) NOT NULL,
    [loginStreak]     INT          DEFAULT ((0)) NOT NULL,
    [loyaltyTier]     VARCHAR (50) NOT NULL,
    [totalDiscount]   INT          NOT NULL,
    [bonusCredits]    INT          NOT NULL,
    [membershipTier]  VARCHAR (50) NOT NULL,
    [creditBalance]   INT          NOT NULL,
    [remainBonusDays] INT          NOT NULL,
    CONSTRAINT [PK_Reward] PRIMARY KEY CLUSTERED ([user_id] ASC)
);


CREATE TABLE [dbo].[Transaction] (
    [voucherGen_id]    INT          NOT NULL,
    [voucherStats]     VARCHAR (50) NOT NULL,
    [voucherExpiry]    DATETIME     NULL,
    [confirmCode]      INT          NOT NULL,
    [user_id]          INT          NOT NULL,
    [voucherDate]      DATETIME     NOT NULL,
    [voucherTotalCost] INT          NOT NULL,
    [voucherQuantity]  INT          NOT NULL,
    [voucherName]      VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Transaction] PRIMARY KEY CLUSTERED ([voucherGen_id] ASC),
    CONSTRAINT [FK_Transaction_ToUser] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Reward] ([user_id])
);



CREATE TABLE [dbo].[ShopVoucher] (
    [voucher_id]         INT           NOT NULL,
    [user_id]            INT           NOT NULL,
    [voucherQty]         INT           NOT NULL,
    [voucherType]        VARCHAR (50)  NOT NULL,
    [voucherStatus]      VARCHAR (50)  NOT NULL,
    [membershipCategory] BIT           NOT NULL,
    [foodCategory]       BIT           NOT NULL,
    [categoryFilter]     BIT           NOT NULL,
    [nameFilter]         VARCHAR (50)  NULL,
    [voucherCost]        INT           NOT NULL,
    [shopImage]          NVARCHAR (50) NULL,
    [shopDesc]           NVARCHAR (50) NULL,
    [voucherName]        NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([voucher_id] ASC),
    CONSTRAINT [FK_ShopVoucher_ToUser] FOREIGN KEY ([user_id]) REFERENCES [dbo].[Reward] ([user_id])
);



CREATE TABLE [dbo].[HotelBook] (
    [hotelId]        INT             NOT NULL,
    [hotelPrice]     DECIMAL (18, 2) NOT NULL,
    [hotelImage]     NVARCHAR (50)   NULL,
    [regionFilter]   BIT             NULL,
    [minPriceFilter] INT             NULL,
    [maxPriceFilter] INT             NULL,
    [hotelName]      NVARCHAR (50)   NULL,
    PRIMARY KEY CLUSTERED ([hotelId] ASC)
);



CREATE TABLE [dbo].[ReservationHotel] (
    [hotelGen_Id]  INT             NOT NULL,
    [totalCost]    DECIMAL (18, 2) NOT NULL,
    [roomQty]      INT             NOT NULL,
    [stayDuration] DATETIME        NOT NULL,
    [user_id]      INT             NOT NULL,
    [hotelName]    NVARCHAR (50)   NOT NULL,
    [verifyHotel]  INT             NOT NULL,
    [hotelPaid]    BIT             NOT NULL,
    PRIMARY KEY CLUSTERED ([hotelGen_Id] ASC)
);


CREATE TABLE [dbo].[TouristBooking] (
    [tourist_id] INT           NOT NULL,
    [bookings]   VARCHAR (50) NULL, 
    [id] INT NOT NULL IDENtity(1,1), 
    CONSTRAINT [PK_TouristBooking] PRIMARY KEY ([id]), 
    CONSTRAINT [FK_TouristBooking_ToTourists] FOREIGN KEY ([tourist_id]) REFERENCES [Tourists]([tourist_id])
);


CREATE TABLE [dbo].[ReservationFood] (
    [reservationId]   INT          IDENTITY (1, 1) NOT NULL,
    [reservationName] VARCHAR (50) NOT NULL,
    [reservationTime] VARCHAR (50) NOT NULL,
    [reservationPax]  INT          NOT NULL,
    [userId]          INT          NOT NULL
);

CREATE TABLE [dbo].[Tours]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [tourguide_id] INT NOT NULL, 
    [title] VARCHAR(50) NULL, 
    [description] VARCHAR(50) NULL, 
    [details] VARCHAR(50) NULL, 
    [price] DECIMAL(18, 5) NULL, 
    CONSTRAINT [FK_Tours_ToTourGuides] FOREIGN KEY ([tourguide_id]) REFERENCES [TourGuides]([tourguide_id])
);
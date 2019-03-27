/****** Object:  Table [rkadivar].[ssmspectrumrequest]    Script Date: 3/5/2019 12:56:04 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [rkadivar].[ssmspectrumrequest](
	[requestid] [int] IDENTITY(1,1) NOT NULL,
	[requestorid] [int] NOT NULL,
	[requestType] [nvarchar](50) NULL,
	[antennaHeight] [int] NULL,
	[renewal] [nvarchar](50) NULL,
	[startFrequency] [decimal](7, 3) NULL,
	[endFrequency] [decimal](7, 3) NULL,
	[bandwidth] [decimal](7, 3) NULL,
	[aclLevel] [decimal](7, 3) NULL,
	[tpower] [decimal](7, 3) NULL,
	[receiverSens] [decimal](7, 3) NULL,
	[coChannelReceiver] [decimal](7, 3) NULL,
	[adjacentChannel] [decimal](7, 3) NULL,
	[latitude] [decimal](7, 3) NULL,
	[longitude] [decimal](7, 3) NULL,
	[radius] [decimal](7, 3) NULL,
	[requestDateTime] [datetime] NULL,
	[startDateTime] [datetime] NULL,
	[duration] [int] NULL,
	[dutyCycle] [int] NULL,
	[repeatCount] [int] NULL,
	[repeatInterval] [int] NULL,
	[trafficModel] [nvarchar](50) NULL,
	[qosLevelRequired] [int] NULL,
	[radioFlags] [int] NULL,
	[requestStatus] [nvarchar](50) NULL,
 CONSTRAINT [PK_ssmspectrumrequest] PRIMARY KEY CLUSTERED 
(
	[requestid] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


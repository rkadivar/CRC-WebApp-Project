/****** Object:  StoredProcedure [rkadivar].[Sp_Request_Add]    Script Date: 3/5/2019 12:56:40 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [rkadivar].[Sp_Request_Add]
(
    -- Add the parameters for the stored procedure here
@requestorid int,
@requestType nvarchar(50),
@antennaHeight int,
@renewal  nvarchar(50),
@startFrequency decimal,
@endFrequency decimal,
@bandwidth decimal,
@aclLevel decimal,
@tpower decimal,
@receiverSens decimal,
@coChannelReceiver decimal,
@adjacentChannel decimal,
@latitude decimal,
@longitude decimal,
@radius decimal,
@requestDateTime datetime,
@startDateTime datetime,
@duration int,
@dutyCycle int,
@repeatCount int,
@repeatInterval int,
@trafficModel nvarchar(50),
@qosLevelRequired int,
@radioFlags int,
@requestStatus nvarchar(50)
)
AS
Begin
Insert into rkadivar.ssmspectrumrequest values (
@requestorid,
@requestType,
@antennaHeight,
@renewal,
@startFrequency,
@endFrequency,
@bandwidth,
@aclLevel,
@tpower,
@receiverSens,
@coChannelReceiver,
@adjacentChannel,
@latitude,
@longitude,
@radius,
@requestDateTime,
@startDateTime,
@duration,
@dutyCycle,
@repeatCount,
@repeatInterval,
@trafficModel,
@qosLevelRequired,
@radioFlags,
@requestStatus
)
end

GO


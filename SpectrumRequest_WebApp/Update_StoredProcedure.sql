/****** Object:  StoredProcedure [rkadivar].[Sp_Request_Update]    Script Date: 3/5/2019 12:57:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [rkadivar].[Sp_Request_Update]
(
    -- Add the parameters for the stored procedure here
@requestid int,
@requestorid int,
@requestType nvarchar(50),
@antennaHeight decimal,
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
@trafficModel nvarchar(100),
@qosLevelRequired int,
@radioFlags int,
@requestStatus nvarchar(50)
)
AS
Begin
update rkadivar.ssmspectrumrequest set
requestorid = @requestorid,
requestType= @requestType,
antennaHeight= @antennaHeight,
renewal = @renewal,
startFrequency = @startFrequency,
endFrequency = @endFrequency,
bandwidth =@bandwidth,
aclLevel = @aclLevel,
tpower= @tpower,
receiverSens = @receiverSens,
coChannelReceiver =@coChannelReceiver,
adjacentChannel =@adjacentChannel,
latitude = @latitude,
longitude = @longitude,
radius = @radius,
requestDateTime = @requestDateTime,
startDateTime = @startDateTime,
duration = @duration,
dutyCycle = @dutyCycle,
repeatCount = @repeatCount,
repeatInterval = @repeatInterval,
trafficModel = @trafficModel,
qosLevelRequired = @qosLevelRequired,
radioFlags = @radioFlags,
requestStatus = @requestStatus

WHERE requestid = @requestid
end

GO


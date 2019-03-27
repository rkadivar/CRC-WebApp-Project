/****** Object:  StoredProcedure [rkadivar].[spectrumrequest_get_byid]    Script Date: 2/28/2019 3:02:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [rkadivar].[spectrumrequest_get_byid]
@requestid int
AS
begin
	SELECT * FROM rkadivar.ssmspectrumrequest 
		where requestid = @requestid
end
GO


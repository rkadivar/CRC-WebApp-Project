/****** Object:  StoredProcedure [rkadivar].[spectrumrequest_delete_sp]    Script Date: 2/28/2019 3:01:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [rkadivar].[spectrumrequest_delete_sp]
	@requestid int
AS
begin
	delete from rkadivar.ssmspectrumrequest where requestid = @requestid
end
GO


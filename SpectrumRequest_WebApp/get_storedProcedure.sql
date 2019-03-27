/****** Object:  StoredProcedure [rkadivar].[spectrumrequest_get_sp]    Script Date: 2/28/2019 3:02:46 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [rkadivar].[spectrumrequest_get_sp]
as
begin
	select * from rkadivar.ssmspectrumrequest
end
GO


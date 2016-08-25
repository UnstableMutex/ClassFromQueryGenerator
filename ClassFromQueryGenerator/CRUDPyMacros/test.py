result="SET ANSI_NULLS ON\n"
result+="GO\n"
result+="SET QUOTED_IDENTIFIER ON\n"
result+="GO\n"
result+="CREATE PROCEDURE t_Insert\n"
for val in Model.Columns:
	result+="@"
	result+=val.Name
	result+=" "
	result+=val.SQLType
	result+=",\n@"
result+="AS\n"
result+="BEGIN\n"
result+="SET NOCOUNT ON;\n"
result+="INSERT INTO [dbo].[t]\n"
result+="("
for val in Model.Columns:
	result+="["
	result+=val.Name
	result+="],"
result+=")\n"
result+="VALUES\n"
result+="("
for val in Model.Columns:
	result+="@"
	result+=val.Name
	result+=",\n"
result+=")\n"
result+="END\n"
result+="GO\n"

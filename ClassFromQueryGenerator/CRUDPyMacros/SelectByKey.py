result="SET ANSI_NULLS ON\n"
result+="GO\n"
result+="SET QUOTED_IDENTIFIER ON\n"
result+="GO\n"
result+="CREATE PROCEDURE "+Model.TableName+"_SelectAll\n"
result+="@"+Model.PK.Name+" "+Model.PK.SQLType
result+="\nAS\n"
result+="BEGIN\n"
result+="SET NOCOUNT ON;\n"
result+="select * FROM [dbo].["+Model.TableName+"]\n WHERE "+Model.PK.Name
result+="=@"+Model.PK.Name+"\n"
result+="END\n"
result+="GO\n"

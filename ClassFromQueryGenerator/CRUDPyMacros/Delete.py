
def sqf(col):
	return "["+col.Name+"]"
def dogf(col):
	return "@"+col.Name
def pars(col):
	return "@"+col.Name+" "+col.SQLType+"\n"
comma=","
def mapcols(f):
	return comma.join(map(f,Model.Columns))
result="SET ANSI_NULLS ON\n"
result+="GO\n"
result+="SET QUOTED_IDENTIFIER ON\n"
result+="GO\n"
result+="CREATE PROCEDURE t_Delete\n"
result+="@"+Model.PK.Name+" "+Model.PK.SQLType+"\n\n"
result+="AS\n"
result+="BEGIN\n"
result+="SET NOCOUNT ON;\n"
result+="DELETE FROM [dbo].["+Model.TableName+"]\n"
result+="WHERE "+Model.PK.Name+"=@"+Model.PK.Name+"\n"

result+="END\n"
result+="GO\n"

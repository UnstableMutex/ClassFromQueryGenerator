
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
result+="CREATE PROCEDURE "+Model.TableName+"_Insert\n"
result+=mapcols(pars)
result+="AS\n"
result+="BEGIN\n"
result+="SET NOCOUNT ON;\n"
result+="INSERT INTO [dbo].["+Model.TableName+"]\n"
result+="("
result+=mapcols(sqf)
result+=")\n"
result+="VALUES\n"
result+="("
dogitems=comma.join(map(dogf,Model.Columns))
result+=dogitems
result+=")\n"
result+="END\n"
result+="GO\n"

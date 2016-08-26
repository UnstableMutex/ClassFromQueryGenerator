
def sqf(col):
	return "["+col.Name+"] = @"+col.Name
def pars(col):
	return "@"+col.Name+" "+col.SQLType+"\n"
comma=","
def mapcols(f):
	return comma.join(map(f,Model.Columns))
def mapusual(f):
	return comma.join(map(f,Model.UsualColumns))
result="SET ANSI_NULLS ON\n"
result+="GO\n"
result+="SET QUOTED_IDENTIFIER ON\n"
result+="GO\n"
result+="CREATE PROCEDURE "+Model.TableName+"_Update\n"
result+=mapcols(pars)
result+="AS\n"
result+="BEGIN\n"
result+="SET NOCOUNT ON;\n"
result+="update [dbo].["+Model.TableName+"]\n"
result+=" set ("
result+=mapusual(sqf)
result+=")\n"
result+="WHERE " +Model.PK.Name+"=@"+Model.PK.Name+"\n"
result+="END\n"
result+="GO\n"

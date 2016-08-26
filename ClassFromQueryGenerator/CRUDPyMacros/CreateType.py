
def sqf(col):
	return "["+col.Name+"] = @"+col.Name
def pars(col):
	return "["+col.Name+"] "+col.SQLType+"\n"
comma=","
def mapcols(f):
	return comma.join(map(f,Model.Columns))
def mapusual(f):
	return comma.join(map(f,Model.UsualColumns))

result="CREATE TYPE "+Model.TableName+" as TABLE\n"
result+=mapcols(pars)

result+=",PRIMARY KEY CLUSTERED\n(["+Model.PK.Name+"] ASC)\n"

result+=" WITH IGNORE_DUP_KEY = OFF))"

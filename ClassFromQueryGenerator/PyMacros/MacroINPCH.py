def getFieldName(pr):
    return "_"+pr[0].lower()+pr[1:]
result="using System;\n"
result+="namespace test\n{\n"
result+="\tclass "
result+=Model.Name+"\n\t{\n"

for val in Model.Fields:
	pf=getFieldName(val.Name)
	result+="\t\t"
	result+="private "+val.Type.Name+" "+pf+";\n"
	result+="\t\t"
	result+="public "
	result+=val.Type.Name
	result+=" "
   	result+=val.Name
   	result+=" \n\t\t{\n\t\t\tget { return "+pf+"; }\n\t\t\tset\n\t\t\t{\n\t\t\t\t"+pf+"=value;\n\t\t\t\tRaisePropertyChanged();\n\t\t\t}\n\t\t}\n"
result+="\t}\n"
result+="}"
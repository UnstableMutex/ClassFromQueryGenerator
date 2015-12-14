def getPropName(pr):
    return pr.replace("_","")
result="using System;\n"

result+="namespace test\n{\n"
result+="\tclass "
result+=Model.Name+"\n\t{\n"

for val in Model.Fields:
	result+="\t\t"
	result+="public "
	result+=val.Type.Name
	result+=" "
   	result+=getPropName(val.Name)
   	result+=" { get; set; }\n"

result+="\t}\n"
result+="}"
```
curl 'http://fsdn.azurewebsites.net/api/search?

query=string+-%3E+int&
exclusion=Argu%2BNewtonsoft.Json%2BFAKE.Lib%2BFParsec%2BFSharp.Compiler.Service%2BFSharp.Collections.ParallelSeq%2BFSharp.Control.AsyncSeq%2BFSharp.Control.Reactive%2BFSharp.Data%2BFSharp.ViewModule.Core%2BFsPickler%2BFsUnit%2BSuave%2BSuave.Experimental%2BSystem.Reactive.Core%2BSystem.Reactive.Interfaces%2BSystem.Reactive.Linq%2BSystem.ValueTuple&
respect_name_difference=enabled&
greedy_matching=disabled&
ignore_parameter_style=enabled&
ignore_case=enabled&
swap_order=enabled&
complement=enabled&
limit=500' \

-XGET \
-H 'Accept: application/json, text/plain, */*' \
-H 'Referer: http://fsdn.azurewebsites.net/' \
-H 'User-Agent: Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_5) AppleWebKit/603.2.4 (KHTML, like Gecko) Version/10.1.1 Safari/603.2.4'
```

```json
{
    "values": [{
        "api": {
            "assembly": "FSharp.Core",
            "kind": "module value",
            "link": "https:\/\/msdn.microsoft.com\/visualfsharpdocs\/conceptual\/string.length-function-%5bfsharp%5d",
            "name": {
                "class_name": "String",
                "id": "length",
                "namespace": "Microsoft.FSharp.Core"
            },
            "signature": "str:string -> int",
            "type_constraints": "",
            "xml_doc": "Returns the length of the string."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.convert.toint32.aspx",
            "name": {
                "class_name": "Convert",
                "id": "ToInt32",
                "namespace": "System"
            },
            "signature": "value:string -> int",
            "type_constraints": "",
            "xml_doc": "Converts the specified string representation of a number to an equivalent 32-bit signed integer."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.int32.parse.aspx",
            "name": {
                "class_name": "Int32",
                "id": "Parse",
                "namespace": "System"
            },
            "signature": "s:string -> int",
            "type_constraints": "",
            "xml_doc": "Converts the string representation of a number to its 32-bit signed integer equivalent."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.httpworkerrequest.getknownrequestheaderindex.aspx",
            "name": {
                "class_name": "HttpWorkerRequest",
                "id": "GetKnownRequestHeaderIndex",
                "namespace": "System.Web"
            },
            "signature": "header:string -> int",
            "type_constraints": "",
            "xml_doc": "Returns the index number of the specified HTTP request header."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.string.compare.aspx",
            "name": {
                "class_name": "String",
                "id": "Compare",
                "namespace": "System"
            },
            "signature": "strA:string * strB:string * ignoreCase:bool -> int",
            "type_constraints": "",
            "xml_doc": "Compares two specified  objects, ignoring or honoring their case, and returns an integer that indicates their relative position in the sort order."
        },
        "distance": 3
    }]
}
```
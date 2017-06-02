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
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.httpworkerrequest.getknownresponseheaderindex.aspx",
            "name": {
                "class_name": "HttpWorkerRequest",
                "id": "GetKnownResponseHeaderIndex",
                "namespace": "System.Web"
            },
            "signature": "header:string -> int",
            "type_constraints": "",
            "xml_doc": "Returns the index number of the specified HTTP response header."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.security.passportidentity.cryptputhost.aspx",
            "name": {
                "class_name": "PassportIdentity",
                "id": "CryptPutHost",
                "namespace": "System.Web.Security"
            },
            "signature": "strHost:string -> int",
            "type_constraints": "",
            "xml_doc": "Sets the key being used for Passport encryption and decryption. This class is deprecated."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.security.passportidentity.cryptputsite.aspx",
            "name": {
                "class_name": "PassportIdentity",
                "id": "CryptPutSite",
                "namespace": "System.Web.Security"
            },
            "signature": "strSite:string -> int",
            "type_constraints": "",
            "xml_doc": "Sets the key being used for Passport encryption and decryption by referring to the site-name label assigned to that key when the key was first installed. This class is deprecated."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.getcountofuserstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "GetCountOfUserState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "usernameToMatch:string -> int",
            "type_constraints": "",
            "xml_doc": "Returns a count of the personalization state items in the underlying data store that exist for the specified user."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.resetuserstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "ResetUserState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "path:string -> int",
            "type_constraints": "",
            "xml_doc": "Resets all per-user state in the underlying data store for the specified path."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "System.Xml",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.xml.xmlconvert.toint32.aspx",
            "name": {
                "class_name": "XmlConvert",
                "id": "ToInt32",
                "namespace": "System.Xml"
            },
            "signature": "s:string -> int",
            "type_constraints": "",
            "xml_doc": "Converts the  to a  equivalent."
        },
        "distance": 0
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "instance property with get",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.string.length.aspx",
            "name": {
                "class_name": "String",
                "id": "Length",
                "namespace": "System"
            },
            "signature": "int",
            "type_constraints": "",
            "xml_doc": "Gets the number of characters in the current  object."
        },
        "distance": 1
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.char.converttoutf32.aspx",
            "name": {
                "class_name": "Char",
                "id": "ConvertToUtf32",
                "namespace": "System"
            },
            "signature": "s:string * index:int -> int",
            "type_constraints": "",
            "xml_doc": "Converts the value of a UTF-16 encoded character or surrogate pair at a specified position in a string into a Unicode code point."
        },
        "distance": 2
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
            "signature": "value:string * provider:IFormatProvider -> int",
            "type_constraints": "",
            "xml_doc": "Converts the specified string representation of a number to an equivalent 32-bit signed integer, using the specified culture-specific formatting information."
        },
        "distance": 2
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
            "signature": "value:string * fromBase:int -> int",
            "type_constraints": "",
            "xml_doc": "Converts the string representation of a number in a specified base to an equivalent 32-bit signed integer."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.globalization.charunicodeinfo.getdecimaldigitvalue.aspx",
            "name": {
                "class_name": "CharUnicodeInfo",
                "id": "GetDecimalDigitValue",
                "namespace": "System.Globalization"
            },
            "signature": "s:string * index:int -> int",
            "type_constraints": "",
            "xml_doc": "Gets the decimal digit value of the numeric character at the specified index of the specified string."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.globalization.charunicodeinfo.getdigitvalue.aspx",
            "name": {
                "class_name": "CharUnicodeInfo",
                "id": "GetDigitValue",
                "namespace": "System.Globalization"
            },
            "signature": "s:string * index:int -> int",
            "type_constraints": "",
            "xml_doc": "Gets the digit value of the numeric character at the specified index of the specified string."
        },
        "distance": 2
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
            "signature": "s:string * provider:IFormatProvider -> int",
            "type_constraints": "",
            "xml_doc": "Converts the string representation of a number in a specified culture-specific format to its 32-bit signed integer equivalent."
        },
        "distance": 2
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
            "signature": "s:string * style:NumberStyles -> int",
            "type_constraints": "",
            "xml_doc": "Converts the string representation of a number in a specified style to its 32-bit signed integer equivalent."
        },
        "distance": 2
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
            "signature": "strA:string * strB:string -> int",
            "type_constraints": "",
            "xml_doc": "Compares two specified  objects and returns an integer that indicates their relative position in the sort order."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "mscorlib",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.string.compareordinal.aspx",
            "name": {
                "class_name": "String",
                "id": "CompareOrdinal",
                "namespace": "System"
            },
            "signature": "strA:string * strB:string -> int",
            "type_constraints": "",
            "xml_doc": "Compares two specified  objects by evaluating the numeric values of the corresponding  objects in each string."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.getcountofinactiveuserstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "GetCountOfInactiveUserState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "pathToMatch:string * userInactiveSinceDate:DateTime -> int",
            "type_constraints": "",
            "xml_doc": "Returns a count of the per-user personalization items in the underlying data store for inactive users, based on the specified parameters."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.getcountofstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "GetCountOfState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "scope:PersonalizationScope * pathToMatch:string -> int",
            "type_constraints": "",
            "xml_doc": "Returns a count of the personalization state items in the underlying data store that exist for the specified parameters."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.resetinactiveuserstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "ResetInactiveUserState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "path:string * userInactiveSinceDate:DateTime -> int",
            "type_constraints": "",
            "xml_doc": "Resets all per-user state information in the underlying data store for inactive users, based on the specified parameters."
        },
        "distance": 2
    }, {
        "api": {
            "assembly": "System.Web",
            "kind": "static method",
            "link": "https:\/\/msdn.microsoft.com\/en-us\/library\/system.web.ui.webcontrols.webparts.personalizationadministration.resetuserstate.aspx",
            "name": {
                "class_name": "PersonalizationAdministration",
                "id": "ResetUserState",
                "namespace": "System.Web.UI.WebControls.WebParts"
            },
            "signature": "path:string * usernames:string[] -> int",
            "type_constraints": "",
            "xml_doc": "Resets per-user state in the underlying data store for the page and users specified."
        },
        "distance": 2
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
            "signature": "s:string * style:NumberStyles * provider:IFormatProvider -> int",
            "type_constraints": "",
            "xml_doc": "Converts the string representation of a number in a specified style and culture-specific format to its 32-bit signed integer equivalent."
        },
        "distance": 3
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
            "signature": "strA:string * strB:string * comparisonType:StringComparison -> int",
            "type_constraints": "",
            "xml_doc": "Compares two specified  objects using the specified rules, and returns an integer that indicates their relative position in the sort order."
        },
        "distance": 3
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
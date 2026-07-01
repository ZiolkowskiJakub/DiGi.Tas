## DiGi\.Tas\.TBD\.Classes Namespace
### Classes

<a name='DiGi.Tas.TBD.Classes.Document'></a>

## Document Class

Provides functionality for managing TBD documents, including loading, saving, and closing operations\.

```csharp
public class Document : DiGi.Tas.Core.Classes.Document<TBD.TBDDocument>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject') → [DiGi\.Tas\.Core\.Classes\.Document&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.classes.document-1 'DiGi\.Tas\.Core\.Classes\.Document\`1')[TBD\.TBDDocument](https://learn.microsoft.com/en-us/dotnet/api/tbd.tbddocument 'TBD\.TBDDocument')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.classes.document-1 'DiGi\.Tas\.Core\.Classes\.Document\`1') → Document
### Constructors

<a name='DiGi.Tas.TBD.Classes.Document.Document()'></a>

## Document\(\) Constructor

Initializes a new instance of the [Document](DiGi.Tas.TBD.Classes.md#DiGi.Tas.TBD.Classes.Document 'DiGi\.Tas\.TBD\.Classes\.Document') class\.

```csharp
public Document();
```

<a name='DiGi.Tas.TBD.Classes.Document.Document(string,bool)'></a>

## Document\(string, bool\) Constructor

Initializes a new instance of the [Document](DiGi.Tas.TBD.Classes.md#DiGi.Tas.TBD.Classes.Document 'DiGi\.Tas\.TBD\.Classes\.Document') class with a specified file path and read\-only status\.

```csharp
public Document(string path, bool readOnly=false);
```
#### Parameters

<a name='DiGi.Tas.TBD.Classes.Document.Document(string,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the document\.

<a name='DiGi.Tas.TBD.Classes.Document.Document(string,bool).readOnly'></a>

`readOnly` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

Indicates whether the document should be opened in read\-only mode\.
### Methods

<a name='DiGi.Tas.TBD.Classes.Document.Close()'></a>

## Document\.Close\(\) Method

Closes the underlying TBD document instance\.

```csharp
public override void Close();
```

<a name='DiGi.Tas.TBD.Classes.Document.Load(string)'></a>

## Document\.Load\(string\) Method

Loads a TBD document from the specified path or creates a new one if it does not exist\.

```csharp
protected override bool Load(string? path=null);
```
#### Parameters

<a name='DiGi.Tas.TBD.Classes.Document.Load(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional file system path to load\. If null or empty, no loading is performed\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the operation was successful or skipped; otherwise, `false`\.

<a name='DiGi.Tas.TBD.Classes.Document.Save()'></a>

## Document\.Save\(\) Method

Saves the current state of the TBD document to disk\.

```csharp
public override bool Save();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the document was saved successfully; otherwise, `false`\.
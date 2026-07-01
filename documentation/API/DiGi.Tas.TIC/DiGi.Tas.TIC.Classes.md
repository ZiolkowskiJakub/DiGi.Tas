#### [DiGi\.Tas\.TIC](index.md 'index')

## DiGi\.Tas\.TIC\.Classes Namespace
### Classes

<a name='DiGi.Tas.TIC.Classes.Document'></a>

## Document Class

Represents a document wrapper for TIC documents, providing functionality to load, save, and close the underlying document resource\.

```csharp
public class Document : DiGi.Tas.Core.Classes.Document<TIC.Document>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Tas\.Core\.Classes\.Document&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.classes.document-1 'DiGi\.Tas\.Core\.Classes\.Document\`1')[TIC\.Document](https://learn.microsoft.com/en-us/dotnet/api/tic.document 'TIC\.Document')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.classes.document-1 'DiGi\.Tas\.Core\.Classes\.Document\`1') → Document
### Constructors

<a name='DiGi.Tas.TIC.Classes.Document.Document()'></a>

## Document\(\) Constructor

Initializes a new instance of the [Document](DiGi.Tas.TIC.Classes.md#DiGi.Tas.TIC.Classes.Document 'DiGi\.Tas\.TIC\.Classes\.Document') class\.

```csharp
public Document();
```

<a name='DiGi.Tas.TIC.Classes.Document.Document(string,bool)'></a>

## Document\(string, bool\) Constructor

Initializes a new instance of the [Document](DiGi.Tas.TIC.Classes.md#DiGi.Tas.TIC.Classes.Document 'DiGi\.Tas\.TIC\.Classes\.Document') class with a specified file path and read\-only status\.

```csharp
public Document(string path, bool readOnly=false);
```
#### Parameters

<a name='DiGi.Tas.TIC.Classes.Document.Document(string,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The physical path to the document file\.

<a name='DiGi.Tas.TIC.Classes.Document.Document(string,bool).readOnly'></a>

`readOnly` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the document should be opened in read\-only mode\.
### Methods

<a name='DiGi.Tas.TIC.Classes.Document.Close()'></a>

## Document\.Close\(\) Method

Closes the underlying TIC document resource\.

```csharp
public override void Close();
```

<a name='DiGi.Tas.TIC.Classes.Document.Load(string)'></a>

## Document\.Load\(string\) Method

Loads the document from the specified path or creates a new one if the file does not exist\.

```csharp
protected override bool Load(string? path=null);
```
#### Parameters

<a name='DiGi.Tas.TIC.Classes.Document.Load(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The optional path to the document file to be loaded\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the load operation was successful; otherwise, `false`\.

<a name='DiGi.Tas.TIC.Classes.Document.Save()'></a>

## Document\.Save\(\) Method

Saves the current state of the document to the disk if it is not read\-only and exists\.

```csharp
public override bool Save();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the document was saved successfully; otherwise, `false`\.
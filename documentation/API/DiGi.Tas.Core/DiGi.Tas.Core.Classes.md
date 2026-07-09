#### [DiGi\.Tas\.Core](DiGi.Tas.Core.Overview.md 'DiGi\.Tas\.Core\.Overview')

## DiGi\.Tas\.Core\.Classes Namespace
### Classes

<a name='DiGi.Tas.Core.Classes.Document_T_'></a>

## Document\<T\> Class

Provides a base abstract class for document handling with support for loading, saving, and disposal of resources\.

```csharp
public abstract class Document<T> : DiGi.Tas.Core.Interfaces.IDocument, DiGi.Tas.Core.Interfaces.ITasObject, DiGi.Core.Interfaces.IObject, System.IDisposable
```
#### Type parameters

<a name='DiGi.Tas.Core.Classes.Document_T_.T'></a>

`T`

The type of the value contained within the document\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Document\<T\>

Implements [DiGi\.Tas\.Core\.Interfaces\.IDocument](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.interfaces.idocument 'DiGi\.Tas\.Core\.Interfaces\.IDocument'), [DiGi\.Tas\.Core\.Interfaces\.ITasObject](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.interfaces.itasobject 'DiGi\.Tas\.Core\.Interfaces\.ITasObject'), [DiGi\.Core\.Interfaces\.IObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iobject 'DiGi\.Core\.Interfaces\.IObject'), [System\.IDisposable](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable 'System\.IDisposable')
### Constructors

<a name='DiGi.Tas.Core.Classes.Document_T_.Document()'></a>

## Document\(\) Constructor

Initializes a new instance of the [Document&lt;T&gt;](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_ 'DiGi\.Tas\.Core\.Classes\.Document\<T\>') class with default settings\.

```csharp
public Document();
```

<a name='DiGi.Tas.Core.Classes.Document_T_.Document(string,bool)'></a>

## Document\(string, bool\) Constructor

Initializes a new instance of the [Document&lt;T&gt;](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_ 'DiGi\.Tas\.Core\.Classes\.Document\<T\>') class using the specified path and read\-only status\.

```csharp
public Document(string? path, bool readOnly);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.Document_T_.Document(string,bool).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to load the document from\. Can be null\.

<a name='DiGi.Tas.Core.Classes.Document_T_.Document(string,bool).readOnly'></a>

`readOnly` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A value indicating whether the document is opened in read\-only mode\.
### Properties

<a name='DiGi.Tas.Core.Classes.Document_T_.ReadOnly'></a>

## Document\<T\>\.ReadOnly Property

Gets a value indicating whether the document is read\-only\.

```csharp
public bool ReadOnly { get; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

<a name='DiGi.Tas.Core.Classes.Document_T_.Value'></a>

## Document\<T\>\.Value Property

Gets the underlying value of the document\.

```csharp
public virtual T? Value { get; }
```

#### Property Value
[T](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_.T 'DiGi\.Tas\.Core\.Classes\.Document\<T\>\.T')
### Methods

<a name='DiGi.Tas.Core.Classes.Document_T_.Close()'></a>

## Document\<T\>\.Close\(\) Method

Closes the document and releases associated resources\.

```csharp
public abstract void Close();
```

<a name='DiGi.Tas.Core.Classes.Document_T_.Dispose()'></a>

## Document\<T\>\.Dispose\(\) Method

Performs application\-defined tasks associated with freeing, releasing, or resetting unmanaged resources\.

```csharp
public void Dispose();
```

Implements [Dispose\(\)](https://learn.microsoft.com/en-us/dotnet/api/system.idisposable.dispose 'System\.IDisposable\.Dispose')

<a name='DiGi.Tas.Core.Classes.Document_T_.Save()'></a>

## Document\<T\>\.Save\(\) Method

Saves the current state of the document to its source\.

```csharp
public abstract bool Save();
```

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the save operation was successful; otherwise, false\.
### Operators

<a name='DiGi.Tas.Core.Classes.Document_T_.op_ImplicitT(DiGi.Tas.Core.Classes.Document_T_)'></a>

## Document\<T\>\.implicit operator T\(Document\<T\>\) Operator

Implicitly converts a [Document&lt;T&gt;](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_ 'DiGi\.Tas\.Core\.Classes\.Document\<T\>') instance to its underlying value\.

```csharp
public static T? implicit operator T?(DiGi.Tas.Core.Classes.Document<T>? document);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.Document_T_.op_ImplicitT(DiGi.Tas.Core.Classes.Document_T_).document'></a>

`document` [DiGi\.Tas\.Core\.Classes\.Document&lt;](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_ 'DiGi\.Tas\.Core\.Classes\.Document\<T\>')[T](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_.T 'DiGi\.Tas\.Core\.Classes\.Document\<T\>\.T')[&gt;](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_ 'DiGi\.Tas\.Core\.Classes\.Document\<T\>')

The document instance to convert\.

#### Returns
[T](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_.T 'DiGi\.Tas\.Core\.Classes\.Document\<T\>\.T')  
The value of the document, or the default value of type [T](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.Document_T_.T 'DiGi\.Tas\.Core\.Classes\.Document\<T\>\.T') if the document is null\.

<a name='DiGi.Tas.Core.Classes.FolderPath'></a>

## FolderPath Class

Represents a path to a folder within the object hierarchy\.

```csharp
public class FolderPath : DiGi.Core.Classes.ObjectPath<DiGi.Tas.Core.Classes.FolderPath>
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.ObjectPath&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.objectpath-1 'DiGi\.Core\.Classes\.ObjectPath\`1')[FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.objectpath-1 'DiGi\.Core\.Classes\.ObjectPath\`1') → FolderPath
### Constructors

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(string)'></a>

## FolderPath\(string\) Constructor

Initializes a new instance of the [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath') class with a single segment name\.

```csharp
public FolderPath(string name);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the path segment\.

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(string,DiGi.Tas.Core.Classes.FolderPath)'></a>

## FolderPath\(string, FolderPath\) Constructor

Initializes a new instance of the [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath') class by appending a name to an existing folder path\.

```csharp
public FolderPath(string name, DiGi.Tas.Core.Classes.FolderPath folderPath);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(string,DiGi.Tas.Core.Classes.FolderPath).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment to append\.

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(string,DiGi.Tas.Core.Classes.FolderPath).folderPath'></a>

`folderPath` [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath')

The existing folder path to which the name is appended\.

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(System.Collections.Generic.IEnumerable_string_)'></a>

## FolderPath\(IEnumerable\<string\>\) Constructor

Initializes a new instance of the [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath') class using a collection of segment names\.

```csharp
public FolderPath(System.Collections.Generic.IEnumerable<string> names);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(System.Collections.Generic.IEnumerable_string_).names'></a>

`names` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The collection of segment names to include in the path\.

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(System.Text.Json.Nodes.JsonObject)'></a>

## FolderPath\(JsonObject\) Constructor

Initializes a new instance of the [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath') class from a JSON object\.

```csharp
public FolderPath(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.FolderPath.FolderPath(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The JSON object used to initialize the path\.
### Methods

<a name='DiGi.Tas.Core.Classes.FolderPath.Create(string)'></a>

## FolderPath\.Create\(string\) Method

Creates a new instance of the [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath') class\.

```csharp
protected override DiGi.Tas.Core.Classes.FolderPath Create(string name);
```
#### Parameters

<a name='DiGi.Tas.Core.Classes.FolderPath.Create(string).name'></a>

`name` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the segment\.

#### Returns
[FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath')  
A new instance of [FolderPath](DiGi.Tas.Core.Classes.md#DiGi.Tas.Core.Classes.FolderPath 'DiGi\.Tas\.Core\.Classes\.FolderPath')\.
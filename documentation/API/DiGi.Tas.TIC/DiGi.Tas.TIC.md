#### [DiGi\.Tas\.TIC](DiGi.Tas.TIC.Overview.md 'DiGi\.Tas\.TIC\.Overview')

## DiGi\.Tas\.TIC Namespace
### Classes

<a name='DiGi.Tas.TIC.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IInternalCondition)'></a>

## Convert\.ToDiGi\(this IInternalCondition\) Method

Converts a TIC internal condition to its corresponding DiGi analytical building representation\.

```csharp
public static DiGi.Analytical.Building.Classes.InternalCondition? ToDiGi(this TIC.IInternalCondition? internalCondition);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IInternalCondition).internalCondition'></a>

`internalCondition` [TIC\.IInternalCondition](https://learn.microsoft.com/en-us/dotnet/api/tic.iinternalcondition 'TIC\.IInternalCondition')

The source TIC internal condition instance\.

#### Returns
[DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')  
The converted [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') object, or `null` if the input is null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IInternalGain)'></a>

## Convert\.ToDiGi\(this IInternalGain\) Method

Converts a TIC internal gain object to its corresponding DiGi analytical building HVAC representation\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.InternalGain? ToDiGi(this TIC.IInternalGain? internalGain);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IInternalGain).internalGain'></a>

`internalGain` [TIC\.IInternalGain](https://learn.microsoft.com/en-us/dotnet/api/tic.iinternalgain 'TIC\.IInternalGain')

The source internal gain instance from the TIC namespace\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.internalgain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain')  
A converted [DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.internalgain 'DiGi\.Analytical\.Building\.HVAC\.Classes\.InternalGain') instance, or `null` if the input is null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IProfile)'></a>

## Convert\.ToDiGi\(this IProfile\) Method

Converts a TIC profile instance to its corresponding Analytical Building Profile representation\.

```csharp
public static DiGi.Analytical.Building.Classes.Profile? ToDiGi(this TIC.IProfile? profile);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IProfile).profile'></a>

`profile` [TIC\.IProfile](https://learn.microsoft.com/en-us/dotnet/api/tic.iprofile 'TIC\.IProfile')

The source TIC profile to convert\.

#### Returns
[DiGi\.Analytical\.Building\.Classes\.Profile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.profile 'DiGi\.Analytical\.Building\.Classes\.Profile')  
A new [DiGi\.Analytical\.Building\.Classes\.Profile](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.profile 'DiGi\.Analytical\.Building\.Classes\.Profile') object if the input is not null; otherwise, null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IThermostat)'></a>

## Convert\.ToDiGi\(this IThermostat\) Method

Converts a TIC thermostat instance to its corresponding DiGi analytical building HVAC thermostat representation\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.Thermostat? ToDiGi(this TIC.IThermostat? thermostat);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IThermostat).thermostat'></a>

`thermostat` [TIC\.IThermostat](https://learn.microsoft.com/en-us/dotnet/api/tic.ithermostat 'TIC\.IThermostat')

The source TIC thermostat instance to be converted\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat')  
A converted [DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.thermostat 'DiGi\.Analytical\.Building\.HVAC\.Classes\.Thermostat') instance, or `null` if the provided [thermostat](DiGi.Tas.TIC.md#DiGi.Tas.TIC.Convert.ToDiGi(thisTIC.IThermostat).thermostat 'DiGi\.Tas\.TIC\.Convert\.ToDiGi\(this TIC\.IThermostat\)\.thermostat') is null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi_InternalGainProfileType(thisSystem.Nullable_TIC.Profiles_)'></a>

## Convert\.ToDiGi\_InternalGainProfileType\(this Nullable\<Profiles\>\) Method

Converts a TIC profile type to the corresponding DiGi internal gain profile type\.

```csharp
public static DiGi.Analytical.Building.HVAC.Enums.InternalGainProfileType ToDiGi_InternalGainProfileType(this System.Nullable<TIC.Profiles> profiles);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi_InternalGainProfileType(thisSystem.Nullable_TIC.Profiles_).profiles'></a>

`profiles` [System\.Nullable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')[TIC\.Profiles](https://learn.microsoft.com/en-us/dotnet/api/tic.profiles 'TIC\.Profiles')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.nullable-1 'System\.Nullable\`1')

The TIC profiles enumeration value to convert\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.internalgainprofiletype 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType')  
The mapped [DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.internalgainprofiletype 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType'), or [DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.internalgainprofiletype.undefined 'DiGi\.Analytical\.Building\.HVAC\.Enums\.InternalGainProfileType\.Undefined') if no mapping is found or the input is null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi_SystemProperties(thisTIC.IInternalGain)'></a>

## Convert\.ToDiGi\_SystemProperties\(this IInternalGain\) Method

Converts a [TIC\.IInternalGain](https://learn.microsoft.com/en-us/dotnet/api/tic.iinternalgain 'TIC\.IInternalGain') instance to an [DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.systemproperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') instance\.

```csharp
public static DiGi.Analytical.Building.HVAC.Classes.SystemProperties? ToDiGi_SystemProperties(this TIC.IInternalGain internalGain);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi_SystemProperties(thisTIC.IInternalGain).internalGain'></a>

`internalGain` [TIC\.IInternalGain](https://learn.microsoft.com/en-us/dotnet/api/tic.iinternalgain 'TIC\.IInternalGain')

The internal gain source object to convert\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.systemproperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties')  
A mapped [DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.classes.systemproperties 'DiGi\.Analytical\.Building\.HVAC\.Classes\.SystemProperties') object, or `null` if the provided [internalGain](DiGi.Tas.TIC.md#DiGi.Tas.TIC.Convert.ToDiGi_SystemProperties(thisTIC.IInternalGain).internalGain 'DiGi\.Tas\.TIC\.Convert\.ToDiGi\_SystemProperties\(this TIC\.IInternalGain\)\.internalGain') is null\.

<a name='DiGi.Tas.TIC.Convert.ToDiGi_ThermostatProfileType(thisTIC.Profiles)'></a>

## Convert\.ToDiGi\_ThermostatProfileType\(this Profiles\) Method

Converts a TIC profile type to the corresponding DiGi thermostat profile type\.

```csharp
public static DiGi.Analytical.Building.HVAC.Enums.ThermostatProfileType ToDiGi_ThermostatProfileType(this TIC.Profiles profiles);
```
#### Parameters

<a name='DiGi.Tas.TIC.Convert.ToDiGi_ThermostatProfileType(thisTIC.Profiles).profiles'></a>

`profiles` [TIC\.Profiles](https://learn.microsoft.com/en-us/dotnet/api/tic.profiles 'TIC\.Profiles')

The TIC profiles enumeration value to convert\.

#### Returns
[DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.thermostatprofiletype 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType')  
The equivalent [DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.thermostatprofiletype 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType') value, or [DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType\.Undefined](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.hvac.enums.thermostatprofiletype.undefined 'DiGi\.Analytical\.Building\.HVAC\.Enums\.ThermostatProfileType\.Undefined') if no mapping is found\.

<a name='DiGi.Tas.TIC.Create'></a>

## Create Class

```csharp
public static class Create
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Create
### Methods

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisDiGi.Tas.TIC.Classes.Document)'></a>

## Create\.InternalConditions\(this Document\) Method

Retrieves a list of internal conditions from the specified document\.

```csharp
public static System.Collections.Generic.List<DiGi.Analytical.Building.Classes.InternalCondition>? InternalConditions(this DiGi.Tas.TIC.Classes.Document? document);
```
#### Parameters

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisDiGi.Tas.TIC.Classes.Document).document'></a>

`document` [Document](DiGi.Tas.TIC.Classes.md#DiGi.Tas.TIC.Classes.Document 'DiGi\.Tas\.TIC\.Classes\.Document')

The document to extract internal conditions from\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') objects, or `null` if the document is null\.

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisTIC.InternalConditionFolder,bool,DiGi.Tas.Core.Classes.FolderPath)'></a>

## Create\.InternalConditions\(this InternalConditionFolder, bool, FolderPath\) Method

Retrieves a list of internal conditions from the specified folder, optionally including those in nested child folders\.

```csharp
public static System.Collections.Generic.List<DiGi.Analytical.Building.Classes.InternalCondition>? InternalConditions(this TIC.InternalConditionFolder? internalConditionFolder, bool includeNested=true, DiGi.Tas.Core.Classes.FolderPath? folderPath=null);
```
#### Parameters

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisTIC.InternalConditionFolder,bool,DiGi.Tas.Core.Classes.FolderPath).internalConditionFolder'></a>

`internalConditionFolder` [TIC\.InternalConditionFolder](https://learn.microsoft.com/en-us/dotnet/api/tic.internalconditionfolder 'TIC\.InternalConditionFolder')

The folder to extract internal conditions from\.

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisTIC.InternalConditionFolder,bool,DiGi.Tas.Core.Classes.FolderPath).includeNested'></a>

`includeNested` [System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')

A boolean value indicating whether to recursively include conditions from child folders\.

<a name='DiGi.Tas.TIC.Create.InternalConditions(thisTIC.InternalConditionFolder,bool,DiGi.Tas.Core.Classes.FolderPath).folderPath'></a>

`folderPath` [DiGi\.Tas\.Core\.Classes\.FolderPath](https://learn.microsoft.com/en-us/dotnet/api/digi.tas.core.classes.folderpath 'DiGi\.Tas\.Core\.Classes\.FolderPath')

The current path context for the folder hierarchy\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of [DiGi\.Analytical\.Building\.Classes\.InternalCondition](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.internalcondition 'DiGi\.Analytical\.Building\.Classes\.InternalCondition') objects, or `null` if the folder is null\.
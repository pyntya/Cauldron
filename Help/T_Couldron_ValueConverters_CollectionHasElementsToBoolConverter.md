# CollectionHasElementsToBoolConverter Class
 _**\[This is preliminary documentation and is subject to change.\]**_

Checks a collection if it has child elements and return true or false depending on the converter parameters 

 Default is return false if the collection has no elements


## Inheritance Hierarchy
System.Object<br />&nbsp;&nbsp;<a href="T_Couldron_ValueConverters_ValueConverterBase_2">Couldron.ValueConverters.ValueConverterBase</a>(IEnumerable, Boolean)<br />&nbsp;&nbsp;&nbsp;&nbsp;Couldron.ValueConverters.CollectionHasElementsToBoolConverter<br />
**Namespace:**&nbsp;<a href="N_Couldron_ValueConverters">Couldron.ValueConverters</a><br />**Assembly:**&nbsp;Couldron (in Couldron.dll) Version: 1.0.0.0 (1.0.0.0)

## Syntax

**C#**<br />
``` C#
public class CollectionHasElementsToBoolConverter : ValueConverterBase<IEnumerable, bool>
```

The CollectionHasElementsToBoolConverter type exposes the following members.


## Constructors
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Couldron_ValueConverters_CollectionHasElementsToBoolConverter__ctor">CollectionHasElementsToBoolConverter</a></td><td /></tr></table>&nbsp;
<a href="#collectionhaselementstoboolconverter-class">Back to Top</a>

## Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Couldron_ValueConverters_ValueConverterBase_2_Convert">Convert</a></td><td>
Converts a value.
 (Inherited from <a href="T_Couldron_ValueConverters_ValueConverterBase_2">ValueConverterBase(TInput, TOutput)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td><a href="M_Couldron_ValueConverters_ValueConverterBase_2_ConvertBack">ConvertBack</a></td><td>
Converts a value.
 (Inherited from <a href="T_Couldron_ValueConverters_ValueConverterBase_2">ValueConverterBase(TInput, TOutput)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>Equals</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>Finalize</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetHashCode</td><td> (Inherited from Object.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>GetType</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td>MemberwiseClone</td><td> (Inherited from Object.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Couldron_ValueConverters_CollectionHasElementsToBoolConverter_OnConvert">OnConvert</a></td><td>
Converts a value
 (Overrides <a href="M_Couldron_ValueConverters_ValueConverterBase_2_OnConvert">ValueConverterBase(TInput, TOutput).OnConvert(TInput, Object, CultureInfo)</a>.)</td></tr><tr><td>![Protected method](media/protmethod.gif "Protected method")</td><td><a href="M_Couldron_ValueConverters_CollectionHasElementsToBoolConverter_OnConvertBack">OnConvertBack</a></td><td>
Converts a value
 (Overrides <a href="M_Couldron_ValueConverters_ValueConverterBase_2_OnConvertBack">ValueConverterBase(TInput, TOutput).OnConvertBack(TOutput, Object, CultureInfo)</a>.)</td></tr><tr><td>![Public method](media/pubmethod.gif "Public method")</td><td>ToString</td><td> (Inherited from Object.)</td></tr></table>&nbsp;
<a href="#collectionhaselementstoboolconverter-class">Back to Top</a>

## Extension Methods
&nbsp;<table><tr><th></th><th>Name</th><th>Description</th></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_Extensions_CastTo__1">CastTo(T)</a></td><td>
Performs certain types of conversions between compatible reference types or nullable types 

 Returns null if convertion was not successfull
 (Defined by <a href="T_Couldron_Extensions">Extensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_Extensions_DisposeAll">DisposeAll</a></td><td>
Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources. 

 This will dispose an object if it implements the IDisposable interface. 

 If the object is a FrameworkElement it will try to find known diposable attached properties. 

 It will also dispose the the DataContext content.
 (Defined by <a href="T_Couldron_Extensions">Extensions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_ExtensionConvertions_ToBool">ToBool</a></td><td>
Tries to convert an Object to a Boolean
 (Defined by <a href="T_Couldron_ExtensionConvertions">ExtensionConvertions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_ExtensionConvertions_ToDouble">ToDouble</a></td><td>
Tries to convert a Object to an Double
 (Defined by <a href="T_Couldron_ExtensionConvertions">ExtensionConvertions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_ExtensionConvertions_ToInteger">ToInteger</a></td><td>
Tries to convert a Object to an Int32
 (Defined by <a href="T_Couldron_ExtensionConvertions">ExtensionConvertions</a>.)</td></tr><tr><td>![Public Extension Method](media/pubextension.gif "Public Extension Method")</td><td><a href="M_Couldron_ExtensionConvertions_ToString2">ToString2</a></td><td>
Returns a string that represents the current object. 

 If the object is null a Empty will be returned
 (Defined by <a href="T_Couldron_ExtensionConvertions">ExtensionConvertions</a>.)</td></tr></table>&nbsp;
<a href="#collectionhaselementstoboolconverter-class">Back to Top</a>

## See Also


#### Reference
<a href="N_Couldron_ValueConverters">Couldron.ValueConverters Namespace</a><br />
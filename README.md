# UnitySpriteSheetResourceManager
This singleton script will hold all your sprites from your sprite sheets that you need to load from the resources folder for whatever reason. It loads them all and adds them to a dictionary for quick lookup and prevents having to load the resources from every script you can simply call one of the prebuilt functions, or expand it for yourself!

Note
Please ensure that this script is executing before any scripts that would need access to the corresponding resource files you can do so by following the information provided here: https://docs.unity3d.com/6000.2/Documentation/Manual/class-MonoManager.html

To use you should only have to call the function as you would normally use the resources.load method so instead of 

Resources.Load<Sprite>("Coin");

you would use

IconLibrary.GetIcon("Coin");

also while this script is primarily for sprites you could easily change the Sprite Types in the file to any other Object Type and it should work so long as Resources.Load has compatibility.

# Once Data Manager

Once Data Manager is temporary data management utility kit for Unity.

## Concept

Unity developer who develop the application which has multiple scenes will facing the challenge when they have to pass data between scene. So what does they do ?

### [PlayerPref](https://docs.unity3d.com/ScriptReference/PlayerPrefs.html)

Most of Unity developer prefer to use `PlayerPrefs` to passing data between scene. However, there are a lot of limitation of `PlayerPrefs` such as the following:

- Only `string`, `float` and `int` can store in `PlayerPrefs`
- When data are saved in `PlayerPrefs`, the system writes `preference file` and save it to your storage ! (But you just only want to pass the data between scene???)

### Once Data Manager

Yeah! we want to break those limitations. So we create this utility for you. `Once Data Manager` will allow you to pass the data between scene with the power of `DontDestroyOnload`. We create the temporary storage which you can save kind of Object on it without saving any file on your local storage!

| | PlayerPrefs | Once Data Manager |
|---|---|---|
| Supported Data types | 3 | All |
| Passing Data without saving file | No | Yes |
| Number of storage | 1 | As much as you create it! |

## Implementation

### Installation

1. Download our [Unity Package](https://github.com/ReiiYuki/once-data-manager/releases/tag/v1.0.0)
2. Import our package by `Assets` -> `Import Package` -> `Custom Package...`
3. Select `odm.unitypackage`
3. `ODM` directory will appear on your project.

### Usage

1. Drag `ODM Manager` in `ODM/Prefabs/ODM Manager.prefab` to your scene.
2. So now you can call `Once Data Manager Storage` to manage your data
3. To access `Once Data Manager` call the following code:
	```cs
	GameObject.Find("ODM Manager").GetComponent<DataManager>().Put("Key", data); // To Add
	(DataTypeOfData) GameObject.Find("ODM Manager").GetComponent<DataManager>().Get("Key"); // To Get your data
	GameObject.Find("ODM Manager").GetComponent<DataManager>().Has("Key"); // To Check if key is existed
	GameObject.Find("ODM Manager").GetComponent<DataManager>().Delete("Key"); // To Delete data from Key
	```

Note: You don't have to drag `ODM Manager` to all of your scene. Just put it on the gateway scene or first scene.

## Reference

### Data Manager

#### void Put(string key, object data)

Put your data to the ODM storage

| Param | Data Type | Description |
|---|---|---|
| key | string | Key for reference to data |
| data | any | Data to be store |

#### object Get(string key)

Get your data from the ODM storage.

Note: Please always do type casting when using this method.

| Param | Data Type | Description |
|---|---|---|
| key | string | Key for reference to data |

#### bool Has(string key)

Return true if key is existed in the ODM storage.

| Param | Data Type | Description |
|---|---|---|
| key | string | Key for reference to data |

#### void Delete(string key)

Delete data from the ODM storage.

| Param | Data Type | Description |
|---|---|---|
| key | string | Key for reference to data |

## Limitation

The original purpose of this package is to saving data without writing file on user's local storage, so with ODM you can store permanent data on your local storage which can be restored when you open the application on next time like `PlayerPrefs`.

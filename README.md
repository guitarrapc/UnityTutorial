Reference https://github.com/unity3d-jp/FirstTutorial/wiki for Unity Project tutorial.

Done
-----

- [x] Use Unity 5.3.x Pro (latest as possible)
    - [x] Open with different version of Unity
- [x] Commit with GitHub
    - [x] Add .gitignore for Unity
        - [Unity Manual - Using External Version Control Systems with Unity](http://docs.unity3d.com/Manual/ExternalVersionControlSystemSupport.html)
        - [GitHub - Unity .gitignore](https://github.com/github/gitignore/blob/master/Unity.gitignore)
    - [x] Understand how it should set for ```Edit > Project Settings > Editor```.
        - Version Control : Mode -> ```Visible Meta Files```
        - Asset Serialization : Mode -> ```Force Text```
        - [How to use Git for Unity source control?](http://stackoverflow.com/questions/18225126/how-to-use-git-for-unity-source-control)
- [x] Understand Unity Project
    - [Tutorial 0](https://github.com/unity3d-jp/FirstTutorial/wiki/0.%E3%83%95%E3%82%9A%E3%83%AD%E3%82%B7%E3%82%99%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E4%BD%9C%E6%88%90)
    - New Project
    - Add Existing Project
- [x] Understand what Unity Scene
    - [Tutorial 0](https://github.com/unity3d-jp/FirstTutorial/wiki/0.%E3%83%95%E3%82%9A%E3%83%AD%E3%82%B7%E3%82%99%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E4%BD%9C%E6%88%90)
    - [x] Save
    - [x] Move
    - [x] Reopen
- [x] Editor Layout
    - [Tutorial 0](https://github.com/unity3d-jp/FirstTutorial/wiki/0.%E3%83%95%E3%82%9A%E3%83%AD%E3%82%B7%E3%82%99%E3%82%A7%E3%82%AF%E3%83%88%E3%81%AE%E4%BD%9C%E6%88%90) 
    - [x] Understand what each layout section name is
        - Scene View
        - Game View
        - Inspector View
        - Hierarchy View
        - Project Browser
    - [x] Modify Project Browser for Single column
    - [x] Understand how to move Scene View
        - Understand each icon meaning
        - Understand Mouse short cut
    - [x] Understand template
    - [x] Change and save preference
    - [x] Override existing
    - [x] Temporary define Prefered style of Layout for Hierarchy and Inspector
    - [x] Check others layout
        - neuecc
    - [x] Unity Scene cannot share with others.
- [x] GameObject
    - [Tutorial 1](https://github.com/unity3d-jp/FirstTutorial/wiki/1.%E3%82%B9%E3%83%86%E3%83%BC%E3%82%B8%E3%82%92%E4%BD%9C%E6%88%90)
    - [x] Add Item to Hierarchy
    - [x] Copy Item
    - [x] Move Item in Scene view
        - [x] Understand Position
    - [x] Adjust position in Scene view by mouse 
    - [x] Adjust position in Scene view by Inspector
    - [x] Add Material to GameObject by Project Browser to Hierarchy
        - [x] Change Material Aldibo Text
        - [x] Change Material Aldibo Colour
    - [x] Scale GameObject
        - [x] Understand Scale
    - [x] Rotate GameObject
    - [x] Sort GameObjects
        - [x] Create Folder
        - [x] Move GameObject and add it to Folder at Hierarchy
    - [x] Set Stage as Static Object
        - Improve Performance
        - Apply to Child Items
    - [Tutorial 2](https://github.com/unity3d-jp/FirstTutorial/wiki/2.%E3%83%95%E3%82%9A%E3%83%AC%E3%82%A4%E3%83%A4%E3%83%BC%E3%81%AE%E7%A7%BB%E5%8B%95) 
    - [x] Add cube
    - [x] Add Compornent
    - [x] Add RigidBody
        - [x] What RigidBody is
        - [x] What change if RigidBody is added to GameObject
        - [x] How to check Unity API
- [x] Play
    - [Tutorial 2](https://github.com/unity3d-jp/FirstTutorial/wiki/2.%E3%83%95%E3%82%9A%E3%83%AC%E3%82%A4%E3%83%A4%E3%83%BC%E3%81%AE%E7%A7%BB%E5%8B%95)
    - [x] Understand Play
    - [x] Change Editor Colour when Playing
        - ```Edit > Preference > Colors > Playmode tint```
    - [x] How to 
- [x] Script
    - [Tutorial 2](https://github.com/unity3d-jp/FirstTutorial/wiki/2.%E3%83%95%E3%82%9A%E3%83%AC%E3%82%A4%E3%83%A4%E3%83%BC%E3%81%AE%E7%A7%BB%E5%8B%95)
    - [x] How to Add Script
        - ```Project Browser > Add Script > Csharp```
    - [x] Use Script Editor as Visual Studio 2015 Enterprise.
        - [x] Switch with Mono Develop
        - [x] Understand VSTU integration check by ```Edit > Preference > External Tools``` and ```Help > About Unity```.
        - [x] Install VSTU 2.2 as it were latest.
    - [x] Add Script to Compornent
    - [x] What FixedUpdate() Method is
    - [x] What Update() Method is
    - [x] How to expose parameter to Inspector
        - [x] What Public Field
        - [x] Why Property couldn't expose paramter to Inspector
        - [x] How to use Property as Field 
        - [x] Pass paremter from Inspector to Script
- [x] Script Methods
    - [Tutorial 2](https://github.com/unity3d-jp/FirstTutorial/wiki/2.%E3%83%95%E3%82%9A%E3%83%AC%E3%82%A4%E3%83%A4%E3%83%BC%E3%81%AE%E7%A7%BB%E5%8B%95)
    - [x] What is Input
    - [x] Where to handle Input Key, Mouse and JoyStick Binding
        - Need to input when Game Schene is active,
    - [x] What GetAxis() is. Why string constructor is fixed. (.... Why Unity doesn't use Enum to pass...?)
- [x] Camera
    - [Tutorial 3](https://github.com/unity3d-jp/FirstTutorial/wiki/3.%E3%82%AB%E3%83%A1%E3%83%A9%E3%82%92%E5%8B%95%E3%81%8B%E3%81%99)
    - Add Camera to GameObject
        - Won't be controllable:)
    - Create component, Script, to trace Player position
        - as FPS
        - as TPS
- [ ] Prefab
    - [Tutorial 4](https://github.com/unity3d-jp/FirstTutorial/wiki/4.%E3%82%A2%E3%82%A4%E3%83%86%E3%83%A0%E5%9B%9E%E5%8F%8E%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [ ] What Prefab is.
        - 
    - [ ] Why Prefab?
        - 
    - [ ] Why Prefab make it easy to dup GameObejcts?
        - 
    - [ ] Create Prefab

Todo
----

- [ ] Understand Unity GameObject LifeCycle
    - When Update() is call?
    - When FixedUpdate() is call?
- [ ] How to determine method name for event
- [ ] Understand Attribute for Script


Disclaimer
---- 

- Visual Studio Tools for Unity 2.2 couldn't work with Unity 5.4.
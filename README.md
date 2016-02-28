Reference https://github.com/unity3d-jp/FirstTutorial/wiki for Unity Project tutorial.

Done
====

Roll-a-Ball
----

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
- [x] Prefab
    - [Tutorial 4](https://github.com/unity3d-jp/FirstTutorial/wiki/4.%E3%82%A2%E3%82%A4%E3%83%86%E3%83%A0%E5%9B%9E%E5%8F%8E%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [x] What Prefab is.
        - [Unity - Prefab](http://docs.unity3d.com/ja/current/Manual/Prefabs.html)
        - Instance of Asset?
        - All GameObject created from Prefab can be handle as Class Instance.
        - It means if you add some material to a Prefab, not to GameObject, then all clone items created from a Prefab will be apply same change.
        - After you create instance of Prefab, you can set each instance of GameObject position, rotation and others.
    - [x] Why Prefab?
        - Because as Object-Oriented Programing have Class-Instance, Prefab is samething in Unity GameObject. 
    - [x] Prefab rule
        - [x] Should Position / Rotation set to be 0?
            - This is because Prefab is template of GameObject and copy will create based on Prefab. 
    - [x] Create Prefab
        - Create Folder in Projet Browser -> then drag Hierarchy item to ProjectBrowser Folder
    - [x] Position Prefab instance GameObject
    - [x] Add Colision detection by Trigger
        - [x] Change Project Item Collider to ```Is Trigger``` enabled.
        - [x] Check Collider Tag where target have expected tag or not.
            - Collider.CompareTag() : http://docs.unity3d.com/ja/current/ScriptReference/Component.CompareTag.html
            - Component.Tag : http://docs.unity3d.com/ja/current/ScriptReference/Component-tag.html
            - Tag and Layers Manager : http://docs.unity3d.com/ja/current/Manual/class-TagManager.html
            - Set Tag to Target GameObject to use Collider.CompareTag().
                - ```Inspector > Tag```, set Player.
        - [x] Destroy Self GameObject
            - Destroy(This.gameObject);
- [x] Canvas
    - [Tutorial 5](https://github.com/unity3d-jp/FirstTutorial/wiki/5.%E3%82%B1%E3%82%99%E3%83%BC%E3%83%A0%E3%81%AEui%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B)
    - [x] Create Canvas
        - Now Canvas can contains UI item to draw item inside
        - Automatically create ```EventSystem``` GameObject
    - [x] UI Scale mode to be ```Scale with Screen Size```
    - Should be better move Scene view from GAmeView like to near the Canvas. This is because GameView will draw by Canvas + SceneView Item.
- [x] Text
    - [Tutorial 5](https://github.com/unity3d-jp/FirstTutorial/wiki/5.%E3%82%B1%E3%82%99%E3%83%BC%E3%83%A0%E3%81%AEui%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B)
    - [x] Create Text object inside Canvas
    - [x] Rocate Text by Scaling position of Canvas
    - [x] Change Scale
    - [x] Change Font Size
    - [x] Change Label
- [x] GameController
    - [Tutorial 5](https://github.com/unity3d-jp/FirstTutorial/wiki/5.%E3%82%B1%E3%82%99%E3%83%BC%E3%83%A0%E3%81%AEui%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B)
    - Message Dispatcher from Event to the Text
    - [x] Create Empty
    - [x] Taging with ```GameController```
    - [x] Apply ```Item``` Tag to Prefab item ```Item```.
        - This apply tag change to all instantiate items.
    - [x] Create GameController Script 
        - [x] Count up Taged items and apply change to Label.
            - ```GameObject.FindGameObjectsWithTag (<string>tagName).Length```
        - [x] Create public field to accept Label GameObject binding with Script.
        - [x] Apply count change to label.text.
    - [x] Bind Script to GameController
    - [x] Bind Lebel to GameController Script Public Field by drag and drop Label in Hieralchy -> GameController Inspector > GameController public Field.
- [x] Tag and Layer
    - [Tutorial 5](https://github.com/unity3d-jp/FirstTutorial/wiki/5.%E3%82%B1%E3%82%99%E3%83%BC%E3%83%A0%E3%81%AEui%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B)
    - [x] Add Tag by ```Menu bar > Edit > Tags and Layer``` add Tags by + and set name.
    - Add ```Item``` Tag.
- [x] Position fix
    - If you had set GameObject inside Empty, then Empty is Parent and items inside will be children.
    - All Children position is based on Parent position.
        - This means if Parent position is 10, 10, 10 then even if you sat children position 0,0,0 world position will be calculated from parent position 10,10,10.
    - Would be better always set parent as 0, 0, 0?
- [x] Active
    - [Tutorial 6](https://github.com/unity3d-jp/FirstTutorial/wiki/6.%E3%82%B1%E3%82%99%E3%83%BC%E3%83%A0%E3%81%AE%E3%82%AF%E3%83%AA%E3%82%A2%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B)
    - All GameObject have property ```Active```
        - If you set this as InActive, then GameObject will not be show in GameView.
        - So it can be use for timing when to show GameObject.
    - [x] Create ```Lable``` for Finish -> FinishLabel.
        - [x] Set position and default text
        - [x] Set Item as InActive at Inspector (means default)
    - [x] create public field to GameController to accept ```GameObject``` of FinishLabel
        - [x] Bind FinishLabel to the Script from Inspector
    - [x] Add Condition when count == 0, WinnerLabel is Active.       
- [x] Bright Materia
    - [Tutorial 7](https://github.com/unity3d-jp/FirstTutorial/wiki/7.%E9%9A%9C%E5%AE%B3%E7%89%A9%E3%81%A8%E3%83%AA%E3%82%B9%E3%82%BF%E3%83%BC%E3%83%88%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [x] Create material at Project Browser
    - [x] Name it as DangerWallMaterial
    - [x] Set Albedo colour as Red
    - [x] Set Emission colour as Red
- [x] Create GameObject for Trap
    - [Tutorial 7](https://github.com/unity3d-jp/FirstTutorial/wiki/7.%E9%9A%9C%E5%AE%B3%E7%89%A9%E3%81%A8%E3%83%AA%E3%82%B9%E3%82%BF%E3%83%BC%E3%83%88%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [x] Create Cube Object as DangerWall
    - [x] Attach DangerWAllMaterial to DangerWall GameObject
    - [x] Set it as Prefab
    - [x] Instantiate items from prefab
    - [x] Create Empty GameObject as Traps, and set scale as 1,1,1. position as 0,0,0
    - [x] Attach all DangerWall gameobjects inside Traps
    - [x] Set Traps as Static, as it were never move. 
- [x] Light
    - [Tutorial 7](https://github.com/unity3d-jp/FirstTutorial/wiki/7.%E9%9A%9C%E5%AE%B3%E7%89%A9%E3%81%A8%E3%83%AA%E3%82%B9%E3%82%BF%E3%83%BC%E3%83%88%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [x] Change Brightness
        - Select DirectionalLight and set Intensity from 1.0 to 0.7 (Can be make 0, looks like night effect!) 
- [x] SceneManager
    - [Tutorial 7](https://github.com/unity3d-jp/FirstTutorial/wiki/7.%E9%9A%9C%E5%AE%B3%E7%89%A9%E3%81%A8%E3%83%AA%E3%82%B9%E3%82%BF%E3%83%BC%E3%83%88%E3%81%AE%E8%BF%BD%E5%8A%A0)
    - [x] Create DangerWallRestartScene Script to restart scene when player collision danger wall.
    - [x] Detect Collision by ```void OnCollisionEnter(Collision hit)```
    - [x] Change Application as it were depricated. ```Application.LoadLevel(Application.loadedLevel);```
        - [x] Replace with SceneManager ```SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name)```
        - Ref : http://qiita.com/kyubuns/items/d7f8c26250a6744c508e
- [x] Build for Standalone
    - Windows
- [x] Run Build Game

### Additional

- [x] Add TimeLimit
    - Timer.deltaTime
- [x] Add GameOver
    - Label + TimeLimit 
- [x] Add Mouse Move X/Y


2D Shooting
----

- [x] Player Settings
    - [Before started](https://github.com/unity3d-jp-tutorials/2d-shooting-game/wiki/%E3%81%93%E3%81%AE%E3%83%81%E3%83%A5%E3%83%BC%E3%83%88%E3%83%AA%E3%82%A2%E3%83%AB%E3%82%92%E5%A7%8B%E3%82%81%E3%82%8B%E5%89%8D%E3%81%AB)
    - Modify Player Resolution Settings
    - ```Edit > Project Preference > PlayerSettings > Resolution and Presentation```
    - 600 x 400
- [x] Game View Resolution
    - [Before started](https://github.com/unity3d-jp-tutorials/2d-shooting-game/wiki/%E3%81%93%E3%81%AE%E3%83%81%E3%83%A5%E3%83%BC%E3%83%88%E3%83%AA%E3%82%A2%E3%83%AB%E3%82%92%E5%A7%8B%E3%82%81%E3%82%8B%E5%89%8D%E3%81%AB)
    - [x] Modify to 600x400
- [x] Sprite
    - [Tutorial 1](https://github.com/unity3d-jp-tutorials/2d-shooting-game/wiki/%E7%AC%AC01%E5%9B%9E-%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%81%A8%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%82%A2%E3%83%8B%E3%83%A1%E3%83%BC%E3%82%B7%E3%83%A7%E3%83%B3%E3%81%AE%E4%BD%9C%E6%88%90)
    - What is Sprite : http://docs.unity3d.com/ja/current/ScriptReference/Sprite.html
        - Spirite Object in 2D Game Play
    - [x] Texture Type
        - Should set as Sprite
    - [x] Sprite Mode
        - Multiple : If Texture contains more than one sprite
        - Single :  If Texture contains only one sprite
    - [x] Pixcels per Units
        - Unity of measure in Unity == ```Unit```
        - 1 Unit == 1m
        - Pixcels per units express relationship with Pixcel and Unit.
        - Pixcels Per Unit == 1
            - 1 Pixcel size = 1 Unit Size
        - Pixcels Per Unit == 100
            - 100 Pixcel = 1 Unity
- [x] Sprite Editor
    - [Tutorial 1](https://github.com/unity3d-jp-tutorials/2d-shooting-game/wiki/%E7%AC%AC01%E5%9B%9E-%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%81%A8%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%82%A2%E3%83%8B%E3%83%A1%E3%83%BC%E3%82%B7%E3%83%A7%E3%83%B3%E3%81%AE%E4%BD%9C%E6%88%90)
    - 1 Texture would be contains more than 1 Sprite because of it's efficiecy.
         - Problem is "How to devide sprite for each GameObject from 1 Texture."
         - Resolution is set Sprite area in Texture when import texture. 
    - [x] Open ```Sprite Editor``` from Inspector View
    - [x] Select ```Slice``` on left top.
        - [x] Type == ```Automatic``` means automatically slice Sprite.
        - [x] Change Type to ```Grid by cell Size```
        - [x] Set Slice size in ```Pixcel size``` than run slice.
        - [x] Apply to chang takes effects.
- [x] Animation
    - [Tutorial 1](https://github.com/unity3d-jp-tutorials/2d-shooting-game/wiki/%E7%AC%AC01%E5%9B%9E-%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%81%A8%E3%82%B9%E3%83%97%E3%83%A9%E3%82%A4%E3%83%88%E3%82%A2%E3%83%8B%E3%83%A1%E3%83%BC%E3%82%B7%E3%83%A7%E3%83%B3%E3%81%AE%E4%BD%9C%E6%88%90)
    - [x] Create Animation
        - Drag and Drop > Select Folder name to be created.
    - Change Hierarchy GameObject Name to ```Player```, change Animation name to ```Normal```, ```Player```.
    - [x] Create Animations
        - [x] Create Player
        - [x] Create Enemy
        - [x] Create Bullet (Only Sprite)
        - [x] Create Explode
    - Create Prefab.
        
    

Todo
====

- [ ] Understand Unity GameObject LifeCycle
    - When Update() is call?
    - When FixedUpdate() is call?
- [ ] How to determine method name for event
- [ ] Understand Attribute for Script


Disclaimer
==== 

- Visual Studio Tools for Unity 2.2 couldn't work with Unity 5.4.

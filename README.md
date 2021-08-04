# unityevent-reordering

A simple editor extension to enable unityevent reordering (draggable) feature. I don't know why it is not a default setting.

Tested with Unity 2020.3.5f1

Just put the code inside an Editor folder

```c#
using UnityEditor;
using UnityEditorInternal;
using UnityEngine.Events;

[CustomPropertyDrawer(typeof(UnityEventBase), true)]
public class ReorderingUnityEventDrawer : UnityEventDrawer
{
    protected override void SetupReorderableList(ReorderableList list)
    {
        base.SetupReorderableList(list);

        list.draggable = true;
    }
}
```

## [/Assets/Editor/**ReorderingUnityEventDrawer.cs**](https://github.com/vlab22/unityevent-reordering/blob/main/Assets/Editor/ReorderingUnityEventDrawer.cs)

![](https://user-images.githubusercontent.com/1412924/124610283-aa4fec00-de70-11eb-9b50-c588fb548b8a.gif)

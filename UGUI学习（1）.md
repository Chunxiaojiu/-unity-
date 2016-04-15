## unity 3d--UGUI第一节
#### 作者：TheSeed
---
初步认识画布`Canvas`，了解`button`，`text`，`image`，`slider`，`togger`，`Scrollbar`的简单使用。
button在监听onclick事件时</br>
![button onclick](https://raw.githubusercontent.com/Chunxiaojiu/-unity-/master/pic/buttononclick.png)</br>
可以直接在上面的OnClick窗口中创建一个事件，调用对应的OnClick方法传递参数（下面是用于场景切换两种方法）

方法一：
``` c#
public void OnStartGame(string sceneName) {
    Application.LoadLevel(sceneName);
}
```

 方法二：
``` c#
 public void OnStartGame(int Sceneindex) {
        Application.LoadLevel(Sceneindex);
    }
```
注意当存在两个场景是要先进行`buildsetting`将两个场景都放进去；
`text`，`image`的使用很简单的直接进行修改即可，当然也有代码重载，暂时不提；
`slider`和`scrollbar`这两个的运用场景根据名字是不一样的，slider常用于简单的音量数值调节，在这举个例子</br>
![slider](https://raw.githubusercontent.com/Chunxiaojiu/-unity-/master/pic/clipboard.png)</br>
通过移动可以获得当前的精度条数值，直接进行传递</br>
```c#
void Update () {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * speed);//Vector3.up
    }
    public void changspeed(float newspeed) {
        this.speed = newspeed;
    }
}
```
上面的`Upate()`每帧调用，时间使用 `Time.deltaTime`，在进行绕轴旋转时使用Rotate</br>
[`public void Rotate(Vector3 eulerAngles, Space relativeTo = Space.Self);`](http://docs.unity3d.com/ScriptReference/Transform.Rotate.html)</br>
官方文档说明当第二个参数不说明时即代表自身，可以使用`speed.up`代表绕Y轴旋转或者`new Vector(0,1,0)`;

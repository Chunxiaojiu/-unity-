## unity 3d--UGUI第二节
##### 作者：TheSeed *版权所有，要用要给原版链接哦，么么哒(づ￣ 3￣)づ*
---
好的，上次我们第一次接触unity5.0及以上系统的UGUI系统，接下来我们将以一个好玩的实用性范例来加强UGUI的学习。</br>
那首先我们来认识UI`image`组件,在unity4.7版本前，我们对于图片的使用一直是使用GUI来进行处理，而5.0版本以上unity采用了自己的UGUI系统，当然有不同的地方，第一点我们就要引入`Sprite`精灵的概念</br>
我们在使用image组件前，要把对应的图片先设置为精灵，在`Texture Type`中设置为`Sprite(2D and UI)`,并apply。</br>
我们可以创建一个`Image`，在Inspector属性中有一个`Rect Transform`属性，那在unity中UGUI里image是以一个矩形GameObjct来表示的，在没有UGUI时个人常用3d object中的`Quad`组件来放置图（`Quad`组件原本被定义为一个没有厚度的3D立方体，所以当我们为其加上图片后，我们只能从一个面上看到图片）</br>
在`Anchors`属性中（我们点击对应的图，如下）在其中我们可以选择对应不同位置的锚点</br>
图片将会以对应的锚点作为原点坐标中心，这样做的意义在于，当我们的屏幕进行收缩时，图片将会相对于锚点进行坐标变换，如果我们没有设置好锚点，如一个图片相对于屏幕较为靠右，但锚点设置为屏幕中心点，那屏幕左右收缩时，我们会发现图片在屏幕中显示不全。当我们在该模式下按住`ALT`键时，会出现下面窗口</br>
![anchors](https://raw.githubusercontent.com/Chunxiaojiu/-unity-/master/pic/anchors.png)</br>
该窗口代表的是图片填充的模式，你可以自己动手试试，常用的是最后一个和中间那个，一个用于填充整个`image`组件，另一个用于居中。</br>
说了那么多，我们应该自己动手制作一下一些有趣的东西了，我们这次制作一个技能冷却按钮，首先我们先创建一个技能图标，然后创建一个灰色的图片同样的大小覆盖在技能图标上，并且将它的透明度加大，保证它能看到技能正在CD，然后我们在技能图标上添加`Button`属性。这时我们运行下，发现我们的技能按钮无论何时都处于CD状态，那怎么让它CD起来呢？</br>
我们可以看到在image属性中有一个`image type`属性，在这个属性中有`Simple`、`Sliced`、`Tiled`、`Filed`四个属性，我们来讲解下：</br>
- Simple:普通模式，没有什么特殊的，就是普通图片。
- Sliced：如果你有学习过移动端开发，在Android中有一种nineold属性的图片，它和我们unity中的图片该模式下的是一样的，我们可以通过设置拉伸区域，来控制边界不失真，这种做法常见于`button`的制作中
- Tiled:这个模式即平铺模式，它将以原本图片的原始大小进行无限重复平铺
- Filed：（没错这就是我们今天的主角！开心脸）在该模式下，我们可以把图片想象成一个进度条，它可以以自己中心为坐标原点，然后使用取定角度区间的图片，当然他也可以以某条边的中点（那就180度），或者某个顶点（那就90度），还可以把自己的x轴方向的长度当做1，来进行取一部分（没错,利用这个我们可以自定义Slider！骄傲脸）</br>

好的，在这里我们选择`Radial 360`模式，试着改变下`fill amount`这个属性，成功了有没有！，发现新大陆了（你再装逼我就打死你！TUT）好吧，我们可以看到我们有了一个cd的模型了，但是怎么去控制它的变化呢？</br>
废话不多说，我们直接上代码：
```c#
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class skillitem : MonoBehaviour {
    public float coldtime = 2;
    private float time = 0;
    private Image fillimage;
    private bool isStarttime = false;
	void Start () {
        fillimage = transform.Find("fillimage").GetComponent<Image>();
	}
	void Update () {
        if (isStarttime) {
            time += Time.deltaTime;
            fillimage.fillAmount = (coldtime - time) / coldtime;
            if (time >= coldtime) {
                isStarttime = false;
                time = 0;
                fillimage.fillAmount = 0;
            }
        }
	}
    public void Onclick() {
        isStarttime = true;
    }
}
```
代码解释下，我们在前面设置了一个冷却时间2秒，然后我们在update中去判断我们的是否开始计时CD，如果可以，那我们就计时，不然我们就要等待CD完成，我们在这里调用了组件UI中的`image`组件，所以不要忘了把`using UnityEngine.UI;`加上去，好了今天的技能制作搞定了，我们下次再见，我去CD去了，不废话啦！

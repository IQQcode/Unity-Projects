
# 摘要

> 游戏，作为大众化娱乐的方式之一，已经越来越受到各年龄段的人们的欢迎。而其中3D游戏也是技术含量比较高的一种。Unity 3D作为一种2D/3D游戏开发引擎，凭借其在音频，图像，物理等各种引擎上的强大功能，深受游戏开发者和爱好者的喜爱。

本文以 Unity3D 2019.2.10 为开发环境，设计并开发了一款单人射击类3D游戏——“健康保卫战”。本文旨在介绍Unity3D的开发流程和步骤，并逐步介绍3D游戏从前期策划，素材制作，到创建场景，编写脚本，调试代码，不断试验等，再到最后通过Unity3D平台生成一个可执行文件，完成一个完整的3D类游戏制作的全过程。

# 第1章 项目分析

## 1.1 游戏背景

人类健康深受病毒的威胁，一位勇士临危受命，带上胶囊手枪，不惧各种奇形怪状的病毒的阻挠，用勇气去对对抗敌人，用智慧去探索前方的道路。当然，也要时刻注意沿路的补给包。拿上枪，你就是人类最后的希望！

 在未来，人们都生活在网络科技搭建的虚拟世界里，长期的不运动，全世界的人都是依靠各种药物维持自己的身体机能，每个人依靠生物药物改变身材改变相貌改变性格，忽然爆发了有史以来的最大的生化危机，生物专家斥巨资研究针对此次病毒的药物，可是这类药物无法口服无法注射，因为这类病毒在人类每个部位衍生楚各种各样不同的细菌，所以需要一位研究该病毒的生物学家服下缩小身体的药物进入病人身体，根据细菌衍生速度以及当前生长状态来实施处理。

在这危难之际，给所有的生物学家检查身体是否符合进入人体的体质，可是竟然无一人符合，因为生活在虚拟世界的人们身体机能已完全滞留，自身无法分泌促进生长的代谢的激素，这时有一位虽然生活在虚拟世界可是却从未放弃按时进食按时锻炼身体的一名医学生迪西勇敢站出来，愿意服下缩小药进入病人体内解决此次危机。

那么你们是否愿意进入虚拟世界同迪西一起，临危受命，带上胶囊手枪，不惧各种奇形怪状的病毒的阻挠，用勇气去对对抗敌人，用智慧去探索前方的道路，请加入我们，你就是人类最后的希望！

## 1.2 游戏开发平台介绍

本游戏开发环境为Unity3D，Unity 是一款跨平台的专业游戏引擎，可以使用它轻松的开发各种 2D 和 3D 游戏， 然后 部署到各种游戏平台上。 当然也包括这些主流游戏平台： Windows、 iOS 、 Android 、 Xbox 360 、 PS3。 

# 第2章 需求分析

### 2.1 游戏性能分析

为了能流畅运行本射击游戏，需要您的个人计算机上至少有如下配置……

 适用于各种PC端。（64位计算机和32位计算机）

### 2.2 功能分析

本游戏是3D射击类游戏，主要是由玩家的第一视角为主，配以地图辅助，射击游戏中出现的各种病毒形状的敌人，收集积分和钥匙道具，完成地图中所有路径的探索，即为通关。

本游戏是3D类游戏，主要是玩家的通过消灭病菌拿到钥匙，然后根据游戏提示或者尝试性分析找到每个门的钥匙，但此过程需要合理分析，稍有不慎可能又要重新返回，当开启最后一扇门进入场景后即为胜利。

该游戏利用 Unity3D 跨平台功能的突出、兼容性强的特点，结合 C# 开发一款坦克大战的游戏系统，画面好看，游戏方式简单，玩家易上手。

### 2.3 用户需求分析

本游戏简单上手，适合于不同年龄段的人群，但游戏菜单为英文模式，所以需要玩家有一定的英语阅读能力，英语四级及以上为佳。

本游戏简单上手，也易于操作，适合于不同年龄段的人群，画面充满活力，场景选择为人体的器官（如心脏，牙齿）以及动脉血管、毛细血管。更适用于有益智闯关游戏需求的朋友。

### 2.4 游戏道具分析

玩家：控制游戏中的射机枪，向游戏中的病毒发出攻击

病毒：不会攻击玩家，主要起到在被“射杀”后提供游戏的钥匙道具

钥匙：作为开启游戏路径中“门”的道具

胶囊：“枪药”的“子弹”

1.玩家：使用 “WASD”键分别控制游戏中人物，使用space键跳跃，鼠标左键发射子弹，鼠标滚轮控制武器的切换

2.血条生命值：场景内部有红色的血细胞可以增加人物血量 

3.子弹：使用 R 键填装子弹

### 2.5 玩家步骤分析-游戏流程以及流程图 

![在这里插入图片描述](https://img-blog.csdnimg.cn/2019111021083780.png)

 

# 第3章 游戏开发步骤

## 3.1 Unity编辑器快速概述

Unity编辑器的基本熟练

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvZmM4M2NlNjAtMGZkZi00ZGFmLWFjZGYtNjg4MjAyMjBmZDU0XzEuM19Vbml0eUVkaXRvci5wbmc?x-oss-process=image/format,png)

 Unity编辑器有四个主要部分：

**1.场景视图** 在这里，您可以通过在3D空间中选择和移动游戏对象来编辑当前场景。在此套件中，游戏级别包含在一个场景中。 

**2.层次结构窗口** 这是场景中所有GameObjects的列表。GameObjects包含将用于填充游戏的角色，道具和风景。这些可以放置在父子层次结构中，这使您可以对对象进行分组-这意味着当父GameObject移动时，其所有子对象将同时移动。 

**3.检查器窗口** 这将显示与当前所选GameObject相关的所有设置。在演练期间，您将更多地探索此窗口。 

**4.项目窗口** 在这里，您可以管理项目**资产**。资产就是我们在项目中使用的所有媒体文件（例如，图像，3D模型和声音文件）。“项目”窗口的作用类似于文件浏览器，可用于在计算机上浏览和创建文件夹。当演练提示您在给定的文件路径中找到**资产**时，请使用此窗口。

 **提示：**如果您的编辑器布局与上面的图像不匹配，请使用工具栏右上方的布局下拉菜单选择**默认**。

**5.工具栏简介**

工具栏包含一系列有用的工具按钮，可帮助您设计和测试游戏。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvMWVmNzZiMzktM2MxZi00YjY3LWJhZmYtMzNlNmRkODA5Y2I1XzEuNF8xX0Z1bGxUb29sYmFyLnBuZw?x-oss-process=image/format,png)

### 3.1.1 工具栏介绍

**播放按钮**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvYmVhZDU2ODUtNzAyOC00NmM1LWIwNjQtOTY5NGUxYTFhODA5XzEuNF8yX1BsYXlCdXR0b25zLnBuZw?x-oss-process=image/format,png)

**玩** 

“播放”用于测试当前在“层次结构”窗口中加载的“场景”，并允许您在编辑器中实时尝试游戏。

**暂停** 

您可能已经猜到了，暂停可以让您暂停游戏窗口中的游戏。这可以帮助您发现在其他情况下不会看到的视觉问题或游戏性问题。

**下一步**

步骤用于逐帧浏览暂停的场景。当您在游戏世界中寻找实时变化时，这非常有用，这对于实时查看很有帮助。



#### I. 操作对象

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvNjc1NTM5MTAtMzAzNi00MDQxLTgyOTItNWU1OWU4ZTg3ZGNmXzEuNF8zX1Rvb2xiYXIucG5n?x-oss-process=image/format,png)

这些工具可在“场景”视图中移动和操纵GameObject。您可以单击按钮将其激活，也可以使用快捷键。

**手工具**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvMDg5YTc5NjctMTk4My00ZmZlLTgzZGItYjdlMTQ0MmJlN2VlXzEuNF80X0hhbmRUb29sLnBuZw?x-oss-process=image/format,png)

快捷键：Q

您可以使用此工具在窗口中四处移动场景。您也可以使用鼠标中键单击来访问该工具。

**移动工具**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvOGY1MjZhMjctMjYzNy00MjcxLWExNTEtM2YzYzgwMzRkMDFmXzEuNF80X01vdmVUb29sLnBuZw?x-oss-process=image/format,png)

快捷方式：W

该工具使您可以选择项目并分别移动它们。  

**旋转工具**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvOWViMjQ5MGMtMjJlMi00NzAxLWI4MzQtOTRkOThmMjNmNzhlXzEuNF80X1JvdGF0ZVRvb2wucG5n?x-oss-process=image/format,png)

快捷键：E

选择项目并使用此工具旋转它们。  

**比例工具**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvZmQ3NjAxZjYtZjE5OC00MGEwLTgyNWQtMDUwYTVkMTQzNmIzXzEuNF80X1NjYWxlVG9vbC5wbmc?x-oss-process=image/format,png)

快捷键：R

您猜对了–这是用于缩放游戏对象的工具。 

**矩形转换工具**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvYTVmYjljNjctOGE3Yy00Y2VhLTkzMmItYWFiNjNmYzA2ZGYxXzEuNF80X1JlY3RUcmFuc2Zvcm0ucG5n?x-oss-process=image/format,png)

捷径：T

这个工具可以做很多事情。从本质上讲，它将移动，缩放和旋转组合为一个专用于2D和UI的工具。 

**旋转，移动或缩放**

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvODZkN2ExZmUtYzU5Yy00OWNmLTg2YTEtOWRkM2I2OWRkZDFhXzEuNF80X1JNU1Rvb2wucG5n?x-oss-process=image/format,png)

捷径：Y

同样，该工具可以完成很多事情。它还使您能够移动，旋转或缩放GameObject，但是它更适合3D。



#### II. 用鼠标导航

在“场景”视图中时，还可以：

- 左键单击以在场景中选择您的GameObject。
- 单击鼠标中键并拖动以使用手动工具移动“场景”视图的相机。
- 右键单击并拖动以使用“飞越”模式（手动工具的一种）来旋转“场景”视图的相机。在执行此操作时，您还可以使用A和D左右移动相机，使用W和S前后移动相机，使用Q和E上下移动相机。

### 3.1.2 场景模型导入

首先，导入素材场景：

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110174801888.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)



**1.**   在“ **Windows”窗口中**，导航到**“ Asset Store”** 选项

<img src = "https://img-blog.csdnimg.cn/20191110174907235.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70 " width = " 40%">

**2.**   寻找合适的素材并导入

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110175341606.png)

打开场景后，就可以看到模型了。选择工具栏中的“ **播放”** 按钮开始。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvM2JlMTFkZTktZTg4Ni00YzIzLTg0YzktYTkwZDZmNzQ2MmIwXzEuNS4yXzJfUGxheUJ1dHRvbnMucG5n?x-oss-process=image/format,png)

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110175515279.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)



此时，仅仅是一个空场景，而我们最终想要实现的目标是、

#### I. 游戏角色动作目标

> **游戏能够**
>
> - 按下键盘上的**WASD** 键移动
> - 按下空格键即可跳转
> - 按住Shift键运行
> - 用鼠标瞄准武器
> - 瞄准后，通过单击鼠标按钮用药消灭细菌
> - 消灭细菌会给你点药，并消耗药弹。您可以在屏幕的左上角看到您的得分，并在右下角看到武器的剩余药量
> - 当你完成游戏测试员，按**逃逸**键盘上，让您的鼠标光标回来。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYxNy9sZWFybi9pbWFnZXMvODlkY2VhZDItNTY3Mi00MmZhLTlhMDgtYjZkZWQyZGEwZjFlXzEuNS4yXzNfRXhhbXBsZVNjZW5lU2NyZWVuc2hvdC5wbmc?x-oss-process=image/format,png)





## 3.2 Scene中添加细菌

### 3.2.1 为游戏创建关卡

在游戏模型中创建了一个模板，其中包含一个房间，制作自己的副本：

 **1.**   从顶部菜单栏中，转到 **FPSKIT -> 创建新场景**

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110190807917.png)

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110190937890.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)

 **2.**  为新的场景指定唯一的名称，然后单击“ **保存”** 。这将在**Assets -> MyScenes中** 创建新的Scene ，并打开它



### 3.2.2 添加更多目标

从向房间添加目标开始： 

**1.**   在“ **项目”窗口中**，转到“ *资产/创建者套件-FPS / Prefabs / Targets”* 。选择**GermSlimeTarget** 预制件。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMGUzNjczNTEtMmM1MS00ODk2LTlkYTItZmI5Y2RmMTgwZDE3XzIuMy4xX0dlcm1TbGltZVRhcmdldC5wbmc?x-oss-process=image/format,png)

 **2.**   将**GermSlimeTarget** 预制件从“项目”窗口拖动到“场景”视图中。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYmM3MTFiOWYtYTNmYi00YjJjLTg3YWItYWEyOTQzMGFmMTdhXzIuMy4yX0RyYWdHZXJtU2xpbWVUYXJnZXRfTFEuZ2lm)

现在，在左侧的“层次结构”窗口中看到GermSlime。已成功在场景中放置了一个新的GameObject。 

**3.**   现在，将GermSlime移到新位置。首先，在工具栏中选择“ **移动工具**”。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYjhkYjU5YzgtZTMzNi00OGY5LWFjNTQtNzRjZDgwNDk4YzRiXzIuMy4zXzFfTW92ZVRvb2wucG5n?x-oss-process=image/format,png)

能够看到覆盖在新目标上的三个箭头（蓝色，绿色和红色）。 

 **4.**   首先**，**单击**绿色箭头**并向上拖动以更改GermSlimeTarget的垂直位置。这会将其抬离房间的地板。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZTY3NmQyOTYtYmVmMy00MWM5LWI5NTEtZGRjZjcwZTZlYzFhXzIuMy40X0RyYWdWZXJ0aWNhbC5naWY)

**5.**   单击并拖动**红色和蓝色箭头**以更改GermSlimeTarget的水平位置。将其放在房间中的任何位置。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMzY4MTQzNGMtY2NiYi00MDg0LWIzNjAtYzc1ZjVkNDhiZjVjXzIuMy41X0RyYWdIb3Jpem9udGFsLmdpZg)

还可以选择三个移动箭头中间的立方体，以一次在多个方向上移动GameObject。

 **6.**   将GermSlimeTarget放置在所需位置后，按**Ctrl + S** 保存场景。  

**7.**   选择“ **玩”** 以再次测试游戏，然后尝试销毁新细菌。您可以根据需要向游戏添加尽可能多的新目标。

### 3.2.3 更改目标统计

该游戏中的Prefab靶标具有简单的统计信息，可用来衡量它们的**健康状况**以及被药击中时获得的**积分值**。可以更改这些统计信息，使细菌更容易或更难以治愈。

调整目标的统计信息：

**1.**   在“场景”视图中，单击GermSlimeTarget。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvODhmZjdmOWQtZjUyMy00MGYyLWFjZDUtZDM0MzRhNjk4OGI3XzIuNC4xXzFfR2VybUluc3BlY3Rvci5wbmc?x-oss-process=image/format,png)

 “ **检查器”** **窗口**现在将显示目标的设置。  “检查器”窗口显示了连接到GameObject的所有**组件**。组件用于在Unity中向GameObjects添加不同的功能。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvNzNiNGE2OTUtMWI2OS00ZGFhLWE2ODEtZWEzMGI4MGRkNDE0XzIuNC4xXzJfR2VybVNsaW1lVHJhbnNmb3JtLnBuZw?x-oss-process=image/format,png)



 **2.**   更改目标的健康状况和积分值。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvNmM2ZWNjNWItY2I3MC00MjA0LTlmZmUtMDliMjVlNzY1YzQ1XzIuNC4yX1RhcmdldFNjcmlwdC5wbmc?x-oss-process=image/format,png)

增加其**健康状况**将使细菌更难被破坏，而减少其**健康状况**将使其变得更容易。销毁细菌时，设置的**点值**将显示在“场景”视图的左上角。  

**3.**   按**Ctrl + S** 保存游戏。现在播放以测试更改。

游戏中已经存在的红细胞也可以被医生的药物作为目标。可以选择一个红细胞，并以完全相同的方式找出其“健康”和“点值”。

已经为游戏准备好了GermSlimes，现在就可以从头开始创建新目标了！ 



### 3.2.4 创建一个新目标

为您的游戏创建一个新的细菌目标：

**1.**   在**Project窗口中**，转到*Assets / Creator Kit-FPS / Art / Models / Characters，*然后选择**GermSpike** 资产。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDcxMC9sZWFybi9pbWFnZXMvZTg3OGFiYjQtNzQxNS00NDU3LWIwMmMtODJkOTZjZGEwODI5X2dlcm1zcGlrZS5QTkc?x-oss-process=image/format,png)

 **2.**   将模型拖放到“ **场景”视图中**。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYTc5YWNlYjMtNWFiMi00ODg0LTg0MjMtOGQzMzUzY2NhYWQ2XzIuNC42XzJfR2VybVNwaGVyZS5wbmc?x-oss-process=image/format,png)

 **3.**   确保已选择对象，然后查看“检查器”窗口。您现在应该只看到一个**Transform** 组件。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUyMC9sZWFybi9pbWFnZXMvOWMzNDAxOTQtMzEyOC00ZWYzLTgyNGItODYwYzI0MDg2NDJiX0ZQU19HZXJtU3Bpa2VfSW5zcGVjdG9yX1VwZGF0ZS5wbmc?x-oss-process=image/format,png)

 **4.**   单击**添加组件**按钮，然后开始在搜索栏中输入“ **Rigidbody”** 。



![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYjk0ZjQ2ZTYtOWViNC00NGMzLWFlYzctMzU0Y2Y5NDE1NjI3XzIuNS40X1JpZ2lkYm9keUNvbXBvbmVudC5wbmc?x-oss-process=image/format,png)

 

单击Rigidbody组件将其添加到GermSpike **。**

 **5.**   在“检查器”窗口中找到“刚体”组件，然后：

- 禁用**使用重力**复选框
- 启用**是运动学**复选框

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvOWYwNjk5NDgtYTBhZC00YmJiLTg2YTctNGI0NGQ0ZDg1MzMxXzIuNS41X1JpZ2lkYm9keUNoZWNrYm94LnBuZw?x-oss-process=image/format,png)

 

这将使新细菌成为游戏中的物理对象。禁用“ **使用重力”** 会使细菌漂浮，而启用“ **Is Kinematic”** 将阻止子弹（或其他任何东西）移动。

 **6.**   再次单击**添加组件**，然后搜索**Sphere Collider** 。

添加组件。



![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZDAwYjA3MmUtOGZmMi00OGY2LTlmN2MtMmJlODc2YjkyZDUxXzIuNS42XzFfU3BoZXJlQ29sbGlkZXJDb21wb25lbnQucG5n?x-oss-process=image/format,png)

 

一**球撞机**将确保胚芽可击; 有时称为“ hitbox”。在“场景”视图中，对撞机将作为细菌周围的绿色球体。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMjBkYzNiNDYtMmMwMy00OThiLThhZjQtYWMyOTdkMDllYmI0XzIuNS42XzJfU2hlcmVDb2xsaWRlclNjZW5lLnBuZw?x-oss-process=image/format,png)

 **7.**   在**中心**字段中，将**Y** 设置为**0.95** 。这将确保对撞机位于细菌的中心，而不是在细菌的下方。 

**8.**   更改对撞机的尺寸：



- 将鼠标悬停在“检查器”窗口中的“半径”一词上。

  

- 单击并向右或向左拖动鼠标以增加或减小点击框的大小。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMmVhNGFhYzQtOTllZS00NzcyLWFkMDgtN2Q0ZjRlYjU5MjdiXzIuNS42XzNfUmFkaXVzUHJvcGVydHkucG5n?x-oss-process=image/format,png)

 增大对撞机将使细菌更容易被击中，减小对撞机将使其更具挑战性。

 **9.**   单击**添加组件**，然后搜索并添加**目标**组件。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMTM4ZDA2ZTMtZDFmMC00NWU5LTgyZmYtNzNkN2NmNmJmNWFmXzIuNS43X1RhcmdldENvbXBvbmVudC5wbmc?x-oss-process=image/format,png)

 该组件添加了一个自定义脚本，使脚本成为目标。添加完成后，更改目标的“生命值”和“点值”，然后再次测试游戏。完成后，请确保保存更改。



### 3.2.5 添加目标动画和声音

为确保在击打细菌时播放正确的音频，需要将GameObjects添加到Target组件：  

**1.**   在“层次结构”中，单击**GermSpike GameObject** 左侧的灰色箭头。这将显示其子**GameObjects** ：**HitPlayer** 和**IdlePlayer** 。 

**2.** 将HitPlayer GameObject从“层次结构”拖到检查器“目标”组件中的“ **命中播放器”** 字段（在“音频”标题下）。  

**3.** 将IdlePlayer GameObject从“层次结构”拖动到“检查**器”** 中“目标”组件中的“ **空闲播放器”** 字段（在“音频”标题下）。 

**4.**   保存您的更改。  现在您已经添加了正确的声音，有一种简单的方法可以复制GermSpike目标：创建自己的**Prefab** 。



### 3.2.6 将目标变成预制件

**预制件**是标准化游戏中不同对象的好方法：链接场景中预制件模板的所有副本。这意味着，如果您更改胚芽预制件的对象值，则场景中该胚芽的每个副本都会更改以匹配它。

要将新的细菌目标转化为预制件：

**1.**   在“ **项目”窗口中**，转到“ *资产/创建者套件-FPS / Prefabs / Targets”* 。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvNzQ3MjNlNjgtYWVlYi00ODkxLThhMDEtZmJiM2Y4Mjk5MTdmXzIuNi4xX1ByZWZhYkZvbGRlci5wbmc?x-oss-process=image/format,png)

 **2.**   将**GermSpike GameObject** 从“层次结构”窗口拖放到“项目”窗口。

 **3.**   将出现一个对话框，询问您是否要保存原始预制件或预制件变体-选择**原始预制件。**

 Project文件夹中有一个新的Prefab，您可以使用它将细菌的多个副本添加到场景中。



## 3.3 关卡设计

### 3.3.1 设计自己的关卡

现在可以向场景中添加更多目标，这个一室一厅的世界变得非常拥挤是时候扩展游戏的空间了。

- 为游戏设计一个完整的关卡
- 添加锁定的门和钥匙以打开它们

### 3.3.2 关闭音频小控件

该Creator Kit包含一个简单的关卡编辑器，可以使用该编辑器将通过门连接的房间“捕捉”在一起。为了使此操作简单易行，需要关闭两个在“场景”视图中可见的Gizmos（图形叠加层）。

要关闭Gizmos，请执行以下操作： 

**1.**   在“场景”视图中，进行缩小，可以看到当前正在工作的房间被默认的灰色空间包围。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvZWQyM2NmMWYtNWE0Yy00NjRiLWFkZTgtZTNiY2ViZmZmYzFhX0ZQU19CUkFJTi5wbmc?x-oss-process=image/format,png)

**2.**   在“层次结构”窗口中，选择“ **LevelLayout GameObject”** 。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvZDVkNjczOTYtYmE4My00NTY3LThhOTktMWFjYjY5M2RkNTgzXzMuMi4yX0xldmVsTGF5b3V0R2FtZU9iamVjdC5wbmc?x-oss-process=image/format,png)

执行此操作时，默认的大脑空间周围将出现蓝色球体：

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvZTA2NTA0M2MtNmU2ZC00YzY0LWE0ZDMtYWFmNWFjMmQyYjgzX0ZQU19CbHVlU3BoZXJlc0ZpbmFsLnBuZw?x-oss-process=image/format,png)

 这些球体代表“音频混响区”和“音频源”，它们是默认情况下附加到所有房间的组件。球体会妨碍编辑关卡布局，因此您将禁用它们。

**3.**   在“场景”视图的右上角，单击**Gizmos按钮旁边的向下箭头**。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvYjM1NWQ4MTItNGJiNS00YTNkLTkzMGUtMjRkNWNlYTIzYTcxX0ZQU19HaXptb0Fycm93LnBuZw?x-oss-process=image/format,png)

**注意：**单击Gizmos按钮本身将禁用所有Gizmo图标，这不是您需要在此Creator Kit中执行的操作。

**4.**   在菜单中，向下滚动列表并禁用以下两个内置组件复选框：

- AudioReverbZone
- 音源

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvN2U2MTYxYjktZThlYS00OGJlLTliNWYtZDlkZjVmMGI2Zjk3X0ZQU19SZWRHaXptb3MucG5n?x-oss-process=image/format,png)

 就是这样–现在，在“场景”视图中为关卡放置房间和走廊将变得更加容易。  

**提示：**关闭所有音频混响区域和音频源的Gizmos。需要随时查看其范围，可以通过再次启用其复选框来打开Gizmos。



### 3.3.3 添加新房间和走廊

关闭了Gizmos，则可以使用关卡布局编辑器来设计自己的游戏关卡：

**1.**   在层次结构中，检查是否仍选择了**LevelLayout GameObject** 。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYzhhNmQ4MWYtYTFkYi00ZjZjLWFiNzQtMzMwYjQ3NjBmOGU1XzMuMi4yX0xldmVsTGF5b3V0R2FtZU9iamVjdC5wbmc?x-oss-process=image/format,png)

 **2.**   在“检查器”窗口中，找到“ **关卡布局”** 组件。点击**添加**。然后单击“ **走廊组”** 以添加走廊，或**单击“** 室**组”** 以添加“房间”。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvOTE4YjljOTUtNWMyYy00MWFmLTg4MzktY2RlMDQ0ZmQ4ZTg0XzMuMi4zXzFfRWRpdGluZ0xheW91dEJ1dHRvbi5wbmc?x-oss-process=image/format,png)

这将显示可选走廊或房间的缩略图：

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvYmFmZTNiY2QtYTFjMi00NDVjLThlMmQtOTY4ZjJhNWRmNjA1X0ZQU19MTF9Db3JyaWRvckdyb3VwLnBuZw?x-oss-process=image/format,png)

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDYwNi9sZWFybi9pbWFnZXMvNzA4NjhkZWMtYWJiYi00ZDc0LWI5ZTMtNTI4YjAxOTdmODM1X0ZQU19MTF9Sb29tR3JvdXAucG5n?x-oss-process=image/format,png)



 **3.**   单击一个可选房间，将：

- 将鼠标移到“场景”视图上时，将出现在场景中
- 在编辑器中自动捕捉到网格系统

- 按键盘上的**R** 来旋转房间并更改它要锁定到的门



**地图预览**

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110193249748.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110193312886.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)

 **4.**   如果输入错误或要删除房间，请单击组件中的“ **删除”** 按钮。完成此操作后，将光标移至“场景”视图中的房间和走廊上方将突出显示它们。单击一个房间将其删除。  

**5.**   完成关卡设计的**编辑后**，再次单击“检查器”窗口中的“ **编辑布局”** 按钮以禁用关卡编辑器工具。 

**6.**   保存更改，然后再次玩游戏以测试新关卡设计。







### 3.3.4 添加上锁的门

此刻，医生可以在身体上随处奔跑。为了使他们的任务更具挑战性，您可以锁定房间的门，直到玩家找到特定的"钥匙"为止，来继续通过场景来消灭细菌

首先，向房间添加一扇锁着的门：

**1.** 在Project窗口中，转到*Assets / Creator Kit-FPS / Prefabs / Door and Key* 。

 **2.**   选择**FatBlob** 预制件。这将充当游戏门的锁。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMGFhMTkxN2MtZWIzYy00MGNiLWI0NjAtYzc5NzFlMjc3ZjA2XzMuMy4yX0ZhdEJsb2JQcmVmYWIucG5n?x-oss-process=image/format,png)

 **3.** 将FatBlog预制件从“项目”窗口拖动到“场景”视图中，将其放置为挡住门口。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMTM0NTZkNTQtMzY4My00MmUzLTliNzEtMzYyZmMyMzZlN2M1XzMuMy4zXzFfUGxhY2VGYXRCbG9iLmdpZg)

锁的正面标有钥匙名称。

锁尚未分配钥匙： 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYTRjNWE1MTQtNTkwYS00MGIwLWE4YzMtZDkwMTYwMzkyZTMwXzMuMy4zXzJfTm9LZXlBc3NpZ25lZC5wbmc?x-oss-process=image/format,png)

 **4.**   保存对游戏的更改。



### 3.3.5 将钥匙与锁关联

现在，玩家将需要解锁门才能进入关卡。要将钥匙与锁关联起来：

**1.**   在“项目”窗口中，选择“ **Key** Prefab”。 

**2.**   将**Key** 拖动到FatBlob门锁所在房间的“场景”视图中。 

**3.**   在检查器中，找到“ **关键”** 组件。在“ **密钥类型”** 字段中，为您的密钥指定一个唯一的名称。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZGNhOTNkZjktNjJlMi00NTVlLWEzZTEtZWFmNjc4NDg1MGY0XzMuNC4zX0tleVR5cGUucG5n?x-oss-process=image/format,png)

 **4.**   在层次结构中，选择**FatBlob GameObject** 。 

**5.**   在检查器中，找到其“ **锁定”** 组件。使用下拉菜单将“ **密钥类型”** 值设置为您选择的密钥名称。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvNmM3N2YxMTctMWE0MC00Y2Y0LTg4MDctZTkxMmJiYmY3MjQwXzMuNC41X1NldEtleVR5cGUucG5n?x-oss-process=image/format,png)

 **6.**   保存游戏，然后在“播放模式”下进行测试。当医生离锁足够近时，将显示其关联钥匙的名称：

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZTJkMDdmODQtYTdmYi00ODU5LWFjYzctMDVmNTlkMTcxOTUwXzMuNC42X0xvY2tHYW1lcGxheS5wbmc?x-oss-process=image/format,png)

领取钥匙后，他们就可以穿过门了。 

现在，医生可以在关卡中定位目标和上锁的门，从而使游戏更具挑战性



## 3.4 武器修改

### 3.4.1 创建新武器

现在，医生必须面对更具挑战性的目标，所以要增强他们的细菌破坏工具了。

在本部分中，将修改游戏中可用的武器，以便为玩家提供更多选择。

要创建新的武器预制件：

**1.**   在“项目”窗口中，转到“ *资产/创建者套件-FPS / Prefabs /武器”*  

**2.**   选择**GermOBlaster** 预制件。通过按**Ctrl + D** 进行复制以进行复制

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvM2U2YjNkMGUtMTE1OS00ZDdiLWI5MzItM2JhZDdlMzhjZmQwXzQuMi4yX0R1cGxpY2F0ZWRXZWFwb24ucG5n?x-oss-process=image/format,png)

 **3.**   单击副本名称，或选择它，然后按**F2** 。给新武器起一个不同的名字。 

**4.**   保存您的更改。

### 3.4.2 调整新武器预制件

原始的GermOBlaster具有自动高速发射功能，带有大量药弹。  让我们每次触发按下一次就可以使新武器弹药更少，但伤害更高：

**1.**   双击新武器，或在选择副本后单击“检查器”窗口中的“ **打开预制”** 按钮。Unity Editor现在处于“预制模式”，并将在“场景”视图中显示武器

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMGEyZWZhY2UtOThlZC00MTM0LWI3ODAtMjBmNDQ0MzUzYzk2XzQuMi40X1ByZWZhYk1vZGUucG5n?x-oss-process=image/format,png)

 **2.**   在检查器中，找到“ **武器”** 组件。这是为此Creator Kit编写的自定义脚本，具有许多不同的可配置值

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwOS9sZWFybi9pbWFnZXMvYmZjNjlmYTEtYjMwMy00NzhhLTgxZGMtMTkzZmVmYjQ5M2FmXzQuMy4yX1dlYXBvbkhpZ2hsaWdodGVkRmllbGRzLnBuZw?x-oss-process=image/format,png)

 **3.**   使用下拉菜单将**触发器类型**更改为**手动**。现在，仅在按下扳机时，武器才会发射一次，而不是尽可能快地发射。 

**4.**   将**剪辑大小**值从30 更改为8，以减少单个重新加载剪辑中的弹药量

**5.**   将**伤害**值从0.5 更改为5。这意味着，与GermOBlaster相比，使用此武器的每次命中对细菌的伤害更大

**6.**   现在，您已经创建了一种新型武器，请使用键盘快捷键保存“预制”，或单击“场景”视图右上角的“保存”按钮

**7.**   通过单击“ **场景**”视图左上角的“场景” 退出“预制模式”

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvNTZlNDBhYmQtNzI5NS00MTc0LWE0ODAtNzQ2OGFjZDg3MzM4XzQuMy43X1NjZW5lc0J1dHRvbi5wbmc?x-oss-process=image/format,png)





### 3.4.3 使玩家可以使用武器

现在已经成功创建了另一种消灭细菌的武器，将其提供给玩家：

**1.**   在层次结构中，选择**角色**GameObject。

**2.**   在“检查器”窗口中，找到**控制器**组件

这是另一个自定义脚本，可处理所有玩家输入  

**3.**   选择名称左侧的小箭头，展开“ **开始武器”** 条目

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMmExZmZiNTAtY2NhOS00YzFiLThmMDQtMmJkOTA4ZDdhMjE3XzQuNC4zX1N0YXJ0aW5nV2VhcG9ucy5wbmc?x-oss-process=image/format,png)

 **4.**   将**大小**从3 更改为4。这将在级别开始时为玩家提供四个武器 

**5.**   将新武器Prefab从“项目”窗口拖动到“检查器”中已出现的“ **元素3”** 字段。

**6.**   保存更改 



## 3.5 游戏终点及整体逻辑

### 3.5.1 创建一个LevelEnd

首先，创建一个LevelEnd GameObject：

**1.**   在“层次结构”窗口中的空白处单击鼠标右键，然后选择“ **创建空白”** 。

<img src = "https://img-blog.csdnimg.cn/20191110200410771.png " width = " 25%">

 **2.**   选中GameObject，然后转到“ **检查器”窗口。**使用标题中的文本字段将其重命名为“ **LevelEnd** ”。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvODUxYzY3ZWMtNTU3ZC00Y2QyLThjZTEtMzg5MThiNTBjZTkzXzUuMi4yX0xldmVsRW5kLnBuZw?x-oss-process=image/format,png)

 **3.**   接下来，您需要确保LevelEnd在关卡的中间。单击“ **变换”** 组件左上方的小齿轮图标。选择**重置**。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvY2E4NTFiNTUtMGI1YS00Y2RmLWE5YjgtYWYwNmRjY2FmY2ExXzUuMi4zX1Jlc2V0LnBuZw?x-oss-process=image/format,png)

 **4.**   将光标移到“场景”视图上，然后按键盘上的**F** 以将焦点对准LevelEnd GameObject。  

**5.**   在**检查器中**，单击“ **添加组件”** 按钮。搜索“ **Box Collider** ”，然后将此组件添加到LevelEnd。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvM2FjZTEyZjUtNzVhNy00MGNlLTk4MjUtNDliODdlNGQyNWJiXzUuMi41X0FkZEJveENvbGxpZGVyLnBuZw?x-oss-process=image/format,png)

 **6.**   一个绿色的线框框将出现在“场景”视图中，表明LevelEnd具有对撞机。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZWEyNzAzNGYtNDM1My00YzJhLWE0MTktM2E2N2RlNzJmMjM3XzUuMi42X0xldmVsRW5kQ29sbGlkZXJTY2VuZVYucG5n?x-oss-process=image/format,png)



使用**变换工具**将对象放置在您希望关卡结束的位置。

房间或走廊的尽头是执行此操作的好地方。



**7.**   可以使用Box Collider组件中的**Size** 参数来调整Collider的**大小**。一次将鼠标悬停在一个轴上，然后单击并向右或向左拖动以增加或减小Collider的大小。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMWRiZTdmYjctOTRjMi00NjhjLWI2N2YtYWM0NjcxNjBmZjU5XzUuMi43XzFfU2l6ZVByb3BlcnR5LnBuZw?x-oss-process=image/format,png)

LevelEnd GameObject已移动到房间的尽头。对撞机已调整大小，以填充大部分可用空间。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvYmQ4NzU2NjAtNTE0OS00NzE3LWFhY2MtZTY2M2I2MTZiNjFkXzUuMi43XzJfU2NlbmVDb2xsaWRlci5wbmc?x-oss-process=image/format,png)

 **8.**   保存您的更改。



### 3.5.2 添加触发器

现在，需要添加一个游戏结束的触发器。

触发器是游戏的基本构建块，可用于执行许多不同的操作。例如，当玩家到达某个点，播放声音或加载新游戏级别时，触发器可以启动过场动画。关卡设计的重要部分是放置碰撞器，该碰撞器将在玩家到达特定位置时触发游戏事件。

为了使玩家能够完成关卡，需要将LevelEnd Box Collider设置为游戏最终屏幕的触发器： 

**1.**   在检查器中，转到**Box Collider** 组件**。**启用**是触发器**复选框。 

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvMTA1MWQ4ZDktM2VjYi00NjZlLTg5NTQtMjI4NDMwZWI0MDM0XzUuMy4xX0lzVHJpZ2dlci5wbmc?x-oss-process=image/format,png)

 **2.**   单击**添加组件**按钮。搜索“ **End Checkpoint** ”，然后将此组件添加到LevelEnd。

![img](https://imgconvert.csdnimg.cn/aHR0cHM6Ly9jb25uZWN0LWNkbi1wcmQtY24udW5pdHljaGluYS5jbi8yMDE5MDUwMi9sZWFybi9pbWFnZXMvZmI3ZGQ3YWQtMWExNS00M2U0LTgwYzItNGU3ZWU1YmU5MjBjXzUuMy4yX0VuZENoZWNrcG9pbnQucG5n?x-oss-process=image/format,png)

 **3.**   保存更改。现在，按“ **播放”** 并通过移动到放置在关卡中的Box Collider中来测试触发器。当进入该空间时，游戏将结束并显示结果屏幕



## 3.6 开始UI界面及发布游戏

### 3.6.1 开始UI界面

> 现在，游戏场景已经搭建完成，**开始**，**结束**，**细菌放置及设置*，*****玩家移动**，**开启关卡**，**钥匙藏放**，**开门逻辑**，**模型碰撞检测** 等等步骤全部测试完毕. 
>
> 
>
> **到此共计测试32次，感谢每一位小组成员的合作和付出**



- 现在，要将这个封面作为游戏开始的UI界面

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110201001757.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)



#### I. 创建 Button

<img src="https://img-blog.csdnimg.cn/20191110203509296.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70" alt="在这里插入图片描述" style="zoom:80%;" />



**点击Button 下的 Text**，在右侧**Inspector**面板中，添加**Start**按钮内容，修改文字大小

<img src="https://img-blog.csdnimg.cn/20191110203644253.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70" alt="在这里插入图片描述" style="zoom:67%;" />

**选中Button**，修改Button颜色，点击时颜色及选择时颜色

<img src="C:\Users\j2726\AppData\Roaming\Typora\typora-user-images\image-20191110203938271.png" alt="image-20191110203938271" style="zoom:67%;" />



并且为游戏添加名字， 我们的游戏名为**FPS Germ Hit**

![在这里插入图片描述](https://img-blog.csdnimg.cn/20191110204039206.png?x-oss-process=image/watermark,type_ZmFuZ3poZW5naGVpdGk,shadow_10,text_aHR0cHM6Ly9ibG9nLmNzZG4ubmV0L3dlaXhpbl80MzIzMjk1NQ==,size_16,color_FFFFFF,t_70)



#### II. 点击时场景切换

从UI界面切换到游戏中，在Button上挂载点击事件，此代码为`SceneManage`

[外链图片转存失败,源站可能有防盗链机制,建议将图片保存下来直接上传(img-d06DzvMj-1573576742172)(C:\Users\j2726\AppData\Roaming\Typora\typora-user-images\image-20191110204329112.png)]

- 调整图片大小，按钮大小，文本文字大小

- 测试点击之后场景是否跳转



> **再次测试，游戏整体完成**







# 第4章 UI界面设计

## 4.1 登录界面设计

 

## 4.2 通关机制设计

 

# 第5章 问题及心得

## 5.1 问题及解决方案

### 5.1.1问题

- 素材的收集以及无法导入
- 素材导入之后无法在场景中加载
- 物理组件各种碰撞器的使用
- 碰撞检测以及穿模问题
- 子弹穿模，穿过细菌（无法碰撞检测）
- 地图场景的搭建
- 门和钥匙 `Key - Value`的对应
- 开始`Start`场景的无法跳转到`Game`场景

### 5.1.2 解决方案

- 素材的收集以及无法导入
- 素材导入之后无法在场景中加载
- 物理组件各种碰撞器的使用
- 碰撞检测以及穿模问题
- 子弹穿模，穿过细菌（无法碰撞检测）
- 地图场景的搭建
- 门和钥匙 `Key - Value`的对应
- 开始`Start`场景的无法跳转到`Game`场景

## 5.2 游戏开发心得

通过本次3D游戏的开发，我们熟练地使用了Unity3D开发工具，并且较为深入地了解了3D游戏的开发过程，学会了在游戏中使用刚体，碰撞，角色控制器等物理引擎，学会对自己游戏场景进行美感上的设计，并且会使用C#脚本语言对游戏进行操控。

更重要的是我们以小组的形式进行开发和创作，在互助中学会了分工合作，各显其长。也在开发3D游戏的过程中了解到了现今3D游戏的发展前景和我国目前在该市场上的优势与不足。

通过本次3D游戏的开发，我们熟练地使用了Unity3D开发工具，并且较为深入地了解了3D游戏的开发过程，学会了在游戏中使用刚体，碰撞，角色控制器等物理引擎，学会对自己游戏场景进行美感上的设计，并且会使用C#脚本语言对游戏进行操控。更重要的是我们以小组的形式进行开发和创作，在互助中学会了分工合作，各显其长。也在开发3D游戏的过程中了解到了现今3D游戏的发展前景和我国目前在该市场上的优势与不足。

本报告从游戏的开始界面、游戏界面、游戏对象几面等几个模块来介绍利用 Unity3D 引擎并结合 C# 来开发一款简单的坦克游戏。游戏中包含了几个常用的重点技术，如射线检测、碰撞检测、敌人的 AI 等。它基本实现了一般的游戏功能，同时它的可扩展性还很高，可以再此基础上另外添加一些比较有创意的设计使该游戏更加的完整。

本系统主要是用 Unity3D 进行系统整体框架的搭建，但 Unity3D 对于我来说是比较陌生的，再接触前根本没有听说过，在网上有大量的资料可供查阅，从中提取有用信息的同时也让我对这款软件有了进一步的认识和了解。编程的过程对于我们本身也是一个学习进步的过程，我们自己在编程的水平十分有限，经常在一些简单的地方出错误，因为我只能去网上或者老师来指导我，给了我很大的帮助，最后我可以独立的完成功能的实现。

这款游戏有不足之处，可拓展性还有很多，包括关卡的设置以及细菌的伤害，场景的进一步的优化等等问题，先将其部署在Github上，方便后续进一步的优化和开发。

通过本次3D游戏的开发和对Unity3D软件的熟悉，对于我们今后对于3D游戏的进一步开发起着非常大的促进作用。

 


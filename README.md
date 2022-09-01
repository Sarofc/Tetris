# 现代俄罗斯方块

[MGF](https://github.com/Sarofc/com.saro.mgf) demo项目，资源框架使用[MoonAsset](https://github.com/Sarofc/com.saro.moonasset)，Gameplay使用[ecslite](https://github.com/Sarofc/ecslite)，接入[HybridCLR](https://github.com/focus-creative-games/hybridclr)代码热更新。
</br>
unity资源全异步加载，包体最小化（main场景+单manifest即可），可边玩边下。

## 快速开始

- Unity 2021.3.0f1
- .Net Standard 2.1

查看 [startup.md](https://github.com/Sarofc/TetrisGame-Unity/blob/main/doc/Startup.md)

## 游戏界面

<img src="https://github.com/Sarofc/TetrisGame-Unity/blob/main/doc/game.jpg">

## 超级旋转系统(Super Rotation System, SRS)

- 7种方块。

    T,I,L,J,S,Z,O

- 旋转。

    每个方块都有自己的旋转点，其 O 可以看作是没有旋转。按照旋转点，可以进行左旋和右旋，左旋和右旋结果不同。

- 踢墙(WallKick)。

    当方块被墙壁等障碍卡住不能旋转的时候，进行一组WallKick数据测试，若其中一项测试成功，则方块会旋转并移动到指定位置，若全部测试失败，则旋转失败，方块没有任何旋转和位移。

## Hold操作

可以将一个现有方块存起来备用，打出高收益。

## 7-bag方块生成器

一个包装7种方块，在这7个方块中进行随机。这样一来，每一轮（7次），都会获取到这7种方块，只是顺序不同罢了。

## Twist操作

有了SRS系统为支撑，可以有很多新奇的玩法。

通过踢墙，可以将方块旋进一些意想不到的地方。

为了提高Spin操作的成功率，落地仍可以操作一段时间（大概0.5s左右）。

- T-Spin
- I-Spin
- L-Spin
- J-Spin
- S-Spin
- Z-Spin

## Scoring

根据每个操作/消除动作，来打分。

## 参考

- [SRS](http://harddrop.com/wiki/SRS)
- [Random Generator](http://harddrop.com/wiki/Random_Generator)
- [Twist](http://harddrop.com/wiki/List_of_twists)
- [TSpin](http://harddrop.com/wiki/T-Spin)
- [Scoring](http://harddrop.com/wiki/Scoring)

## ！音乐/音效仅供学习使用

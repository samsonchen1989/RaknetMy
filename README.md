# RaknetMy
Modified raknet for unity.

[Raknet版本4.081](https://github.com/facebookarchive/RakNet)，编译环境VS2017社区版

- VS2010以上版本编译，需要合并[PR#105](https://github.com/facebookarchive/RakNet/pull/105)。
- 用Swig生成C#版本前，需要合并[PR#93](https://github.com/facebookarchive/RakNet/pull/93)，提前生成Swig输出文件的目录。
- 用Swig 3.0.10生成C#版本, DLL项目在目录RaknetMy\RakNet\DependentExtensions\Swig\DLL_Swig中，编译前记得把Swig路径添加到系统路径中。
- 编译C#用dll文件时，记得导入RakNet_wrap.cxx文件。
- 编译C#用dll文件时，会提示"CSharp_OpPlus\__SWIG_1"无法引用RakWString的+号重载，临时解决方法是把CSharp_OpPlus\__SWIG_1函数注释。
- 编译C#用dll文件时，如果提示**raknet_wrap.cxx(15441): error C2558: class 'RakNet::ReliabilityLayer' : no copy constructor available or copy constructor is declared 'explicit'**，可以自己添加拷贝构造函数或者参考[这里的解决方案](https://stackoverflow.com/questions/28679859/building-raknet-c-sharp-wrapper-with-swig-get-an-annoying-error-at-build)。
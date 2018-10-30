node {
checkout scm
bat '"C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\MSBuild\\15.0\\Bin\\MSBuild.exe" "JENKIS.sln"'
bat ' "C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" jenkins/testJenkis/bin/Debug/testJenkis.dll
cleanWs()
}
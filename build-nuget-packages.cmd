@echo off
echo *** Make sure you have updated the assembly and nuspec to match the release version! ***

call "%VS100COMNTOOLS%vsvars32.bat"
mkdir log\
mkdir lib\net40\

msbuild.exe /ToolsVersion:4.0 "src\swxben.Windows.Forms\swxben.Windows.Forms.csproj" /p:configuration=Release
utilities\nuget.exe pack swxben.Windows.Forms.nuspec
pause